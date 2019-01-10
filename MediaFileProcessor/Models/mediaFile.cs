using MediaFileProcessor.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Web;
using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace MediaFileProcessor.Models
{
    public class MediaFile
    {
        private string apiKey = "0d665b6e7609d157c003ca8999f6c9b2";
        private Uri baseAddress = new Uri("https://api.themoviedb.org/3/");
        private int loadCounter = 4;

        public MediaFile(string path, string movePath)
        {
            this.filePath = path;
            this.movePath = movePath;
        }

        public string delimiter { get; set; }
        public string[] delimiterOptions { get; set; }
        public string[] directors { get; set; }
        public string ext { get; set; }
        public string fileName { get; set; }
        public string filePath { get; set; }
        public string[] genres { get; set; }
        public Movie movieData { get; set; }
        public string movePath { get; set; }
        public string originalFileName { get; set; }
        public string originalParentFolderName { get; set; }
        public string parentFolderName { get; set; }
        public string parentFolderNameCustom { get; set; }
        public string parentFolderPath { get; set; }
        public string[] producers { get; set; }
        public string rating { get; set; }
        public string[] writers { get; set; }
        public string year { get; set; }

        public string processTempName()
        {
            string[] filePathNodes = this.filePath.Split('\\');

            // set the file name
            string tempFileName = filePathNodes[filePathNodes.Length - 1];

            string[] nameParts = tempFileName.Split('.');
            string tempExt = '.' + nameParts[nameParts.Length - 1];
            tempFileName = tempFileName.Replace(tempExt, "");

            return _processName(tempFileName);
        }

        public void setPreData()
        {
            _importProcessor.preProcessor(this);
        }

        public void moveFile(bool renameFile = true, bool doDelete = true)
        {
            _setMetaData();
            _importProcessor.postProcessor(this, renameFile, doDelete);
        }

        public void cleanMetaData()
        {
            _setMetaData();
        }

        private FileProcessor _importProcessor = new FileProcessor();
        private CleanupProcessor _cleanupProcessor = new CleanupProcessor();

        private void _getMovieData(string name, MediaFile me)
        {
            try
            {
                // Query by the movie name to get best matches.
                NameQueryResponse nameQueryResponse = queryName(name);

                if (nameQueryResponse != null)
                {
                    // Process down to the best match.
                    NameQueryMovie[] movieResponses = new NameQueryMovie[nameQueryResponse.total_results];
                    var index = 0;
                    var nodes = JArray.Parse(nameQueryResponse.results.ToString());
                    foreach (JToken node in nodes)
                    {
                        if (node != null)
                        {
                            movieResponses[index] = new NameQueryMovie(node.ToString());
                        }
                        ++index;
                    }

                    this.movieData = queryId(movieResponses.Where(x => x != null).ToArray().OrderByDescending(x => x.vote_count).First().id);

                    if (this.movieData != null)
                    {
                        getGenreNames(this.movieData.genres);

                        queryRating();

                        queryCrew();

                    }
                    else
                    {
                        this.loadCounter = 0;
                    }
                }
                else
                {
                    this.loadCounter = 0;
                }
            }
            catch (Exception ex)
            {
                this.loadCounter = 0;
                // do nothing here...
            }
        }

        private string _processName(string name)
        {
            // need to determine if the name is not in proper form
            this.delimiterOptions = name.Split('.');
            if (this.delimiterOptions.Length > 2)
            {
                // now to strip down the name
                var remasteredName = "";
                int count = 1;
                int yr = 0;
                foreach (string part in this.delimiterOptions)
                {
                    count++;
                    if (this.delimiter == null)
                    {
                        // this is the first run so do the default processing
                        if ((int.TryParse(part, out yr) && yr >= 1930 && yr <= 2060) || part == "1080p" || part == "720p" || part == "WEBRiP" || part == "HDTV")
                        {
                            this.delimiter = part;
                            break;
                        }
                        else
                        {
                            var seriesId = _seriesId(part);
                            if (seriesId.Contains("- "))
                            {
                                remasteredName += seriesId + " ";
                            }
                            else
                            {
                                remasteredName += _uppercaseFirst(part) + " ";
                            }                            
                        }
                    }
                    else
                    {
                        if (part == this.delimiter)
                        {
                            break;
                        }
                        else
                        {
                            var seriesId = _seriesId(part);
                            if (seriesId.Contains("- "))
                            {
                                remasteredName += seriesId + " ";
                            }
                            else
                            {
                                remasteredName += _uppercaseFirst(part) + " ";
                            }
                        }
                    }

                }

                if (count == this.delimiterOptions.Length)
                {
                    this.delimiter = this.delimiterOptions[0];
                }

                // If the year has been set add it to the end of the file name.
                if (yr > 0)
                {
                    remasteredName = remasteredName + "(" + yr.ToString() + ")";
                }

                return remasteredName.Trim();
            }
            else
            {
                //TODO: may end up here when changing a name                
                return this.delimiterOptions[0];
            }
        }

        private static string _uppercaseFirst(string s)
        {
            // Check for empty string.
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            // Return char and concat substring.
            return char.ToUpper(s[0]) + s.Substring(1);
        }

        private static string _seriesId(string s)
        {
            // Check for empty string.
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }

            if (char.ToLower(s[0]) == 's' && s.Length == 6)
            {                        
                var split = s.ToLower().Split('e');
                if (split.Length == 2 && split[0].Length == 3)
                {
                    var season = split[0];
                    var episode = split[1];
                    int sNumber;
                    int eNumber;
                    if (int.TryParse(season.Substring(1), out sNumber) && int.TryParse(episode.Substring(1), out eNumber))
                    {
                        // Make sure the seasion and episode are in lower case.
                        s = "s" + season.Substring(1) + "e" + episode;
                        return "- " + s;
                    }
                    else
                    {
                        return s;
                    }
                }
                else
                {
                    return s;
                }
            }
            else
            {
                return s;
            }
        }

        private void _processOtherFiles()
        {
            //TODO!!!
            // need to deal with this sometime soon


            // need to check for subs
            // if subs are found, change the name of the file and move it to the parent folder

            // need to delete all other files

        }

        private void getGenreNames(JArray jGenres)
        {
            var tokens = JArray.Parse(jGenres.ToString());
            this.genres = new String[tokens.ToList().Count];
            var index = 0;
            foreach (JToken token in tokens)
            {
                Genre genre = new Genre(token.ToString());
                this.genres[index] = genre.name;
                ++index;
            }

            this.genres = genres;
        }

        private void getProducers(JArray jProducers)
        {
            var tokens = JArray.Parse(jProducers.ToString());
            this.producers = new String[tokens.ToList().Count];
            var index = 0;
            foreach (JToken token in tokens)
            {
                Producer producer = new Producer(token.ToString());
                this.producers[index] = producer.name;
                ++index;
            }
        }

        private void queryCrew()
        {
            try
            {
                CrewQuery initialCrewResponse = null;
                using (var httpClient = new HttpClient { BaseAddress = this.baseAddress })
                {
                    var crewResponse = httpClient.GetAsync(@"movie/" + this.movieData.id + @"/credits?" + HttpUtility.ParseQueryString(@"api_key=" + this.apiKey));
                    if (crewResponse.Result.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        initialCrewResponse = new CrewQuery(crewResponse.Result.Content.ReadAsStringAsync().Result);
                    }
                    else
                    {
                        --this.loadCounter;
                        return;
                    }
                }

                List<string> directorsList = new List<string>();
                List<string> writersList = new List<string>();

                CrewMember[] crew = new CrewMember[initialCrewResponse.crew.ToList().Count];
                var index = 0;
                foreach (var item in initialCrewResponse.crew)
                {
                    var member = new CrewMember(item.ToString());
                    if (member.department == "Directing")
                    {
                        directorsList.Add(member.name);
                    }
                    else if (member.department == "Writing")
                    {
                        writersList.Add(member.name);
                    }
                }

                if (directorsList.Count > 0)
                {
                    this.directors = directorsList.ToArray();
                }

                if (writersList.Count > 0)
                {
                    this.writers = writersList.ToArray();
                }

                --this.loadCounter;
            }
            catch (Exception ex)
            {
                --this.loadCounter;
            }
        }

        private Movie queryId(int id)
        {
            try
            {
                Movie queryResponse = null;
                using (var httpClient = new HttpClient { BaseAddress = baseAddress })
                {
                    var movieResponse = httpClient.GetAsync(@"movie/" + id + @"?" + HttpUtility.ParseQueryString(@"api_key=" + this.apiKey));
                    if (movieResponse.Result.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        queryResponse = new Movie(movieResponse.Result.Content.ReadAsStringAsync().Result);
                        --this.loadCounter;
                    }
                    else
                    {
                        --this.loadCounter;
                        return null;
                    }
                }

                return queryResponse;
            }
            catch (Exception ex)
            {
                --this.loadCounter;
                return null;
            }
        }

        private NameQueryResponse queryName(string name)
        {
            try
            {
                NameQueryResponse initialNameResponse = null;
                using (var httpClient = new HttpClient { BaseAddress = this.baseAddress })
                {
                    var nameResponse = httpClient.GetAsync(@"search/movie?" + HttpUtility.ParseQueryString(@"api_key=" + this.apiKey + @"&query=" + name));
                    if (nameResponse.Result.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        initialNameResponse = new NameQueryResponse(nameResponse.Result.Content.ReadAsStringAsync().Result);
                        --this.loadCounter;
                    }
                    else
                    {
                        --this.loadCounter;
                        return null;
                    }
                }

                return initialNameResponse;
            }
            catch (Exception ex)
            {
                --this.loadCounter;
                return null;
            }
        }

        private void queryRating()
        {
            try
            {
                ReleaseDatesQuery initialRatingResponse = null;
                using (var httpClient = new HttpClient { BaseAddress = this.baseAddress })
                {
                    var ratingResponse = httpClient.GetAsync(@"movie/" + this.movieData.id + @"/release_dates?" + HttpUtility.ParseQueryString(@"api_key=" + this.apiKey));
                    if (ratingResponse.Result.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        initialRatingResponse = new ReleaseDatesQuery(ratingResponse.Result.Content.ReadAsStringAsync().Result);
                    }
                    else
                    {
                        --this.loadCounter;
                        return;
                    }
                }

                ReleaseDateResult[] resultArray = new ReleaseDateResult[initialRatingResponse.results.ToList().Count];
                int index = 0;
                foreach (var result in initialRatingResponse.results)
                {
                    resultArray[index] = new ReleaseDateResult(result.ToString());
                    ++index;
                }

                ReleaseDateResult datesResult = resultArray.First(x => x.iso_3166_1 == "US");

                this.rating = new ReleaseDate(JArray.Parse(datesResult.release_dates.ToString())[0].ToString()).certification;
                --this.loadCounter;
            }
            catch (Exception ex)
            {
                --this.loadCounter;
            }
        }

        private void _setMetaData()
        {
            try
            {

                _getMovieData(this.fileName, this);

                while (this.loadCounter > 0)
                {
                    // we are waiting for the calls to finish here.
                }

                List<string> arrHeaders = new List<string>();

                Shell32.Shell shell = new Shell32.Shell();
                Shell32.Folder objFolder;

                objFolder = shell.NameSpace(this.parentFolderPath);

                for (int i = 0; i < short.MaxValue; i++)
                {
                    string header = objFolder.GetDetailsOf(null, i);
                    if (String.IsNullOrEmpty(header))
                        break;
                    arrHeaders.Add(header);
                }

                // TODO - This could be used to do all the processing... 
                // say there is a folder with subtitles in it, that could be processed here.
                // In the case of TV series this could process all the files all at once instead of 
                // having to pick each one and set it's title the processor could do it for me.
                // Would need a more robust name processor since the names of TV series files are 
                // much harder to deal with on the server.

                // for now just pick off the one that is being processed and set it's meta-data.

                // here we are looping each item inside the parent folder
                foreach (Shell32.FolderItem2 item in objFolder.Items())
                {
                    string filePath = this.parentFolderPath;
                    ShellFile file = null;
                    for (int i = 0; i < arrHeaders.Count; i++)
                    {
                        var propertyName = arrHeaders[i];
                        var propertyDetail = objFolder.GetDetailsOf(item, i);

                        if (i == 0)
                        {
                            if (objFolder.GetDetailsOf(item, i) == this.originalFileName + this.ext)
                            {
                                file = ShellFile.FromFilePath(filePath + "/" + propertyDetail);
                                file.Properties.System.FileName.Value = this.fileName;
                                file.Properties.System.Title.Value = this.fileName;
                                file.Properties.System.Media.Subtitle.Value = null;
                                file.Properties.System.Comment.Value = null;
                                file.Properties.System.Author.Value = null;
                                file.Properties.System.Media.Year.Value = this.movieData != null && this.movieData.release_date != null ? (uint?)int.Parse(this.movieData.release_date.Substring(0, 4)) : null;
                                file.Properties.System.Music.Genre.Value = this.genres != null && this.genres.Length > 0 ? this.genres : null;
                                file.Properties.System.ParentalRating.Value = this.rating != null ? this.rating : null;
                                file.Properties.System.Media.ProviderRating.Value = null;
                                file.Properties.System.Media.DateReleased.Value = this.movieData.release_date != null ? this.movieData.release_date : null;
                                file.Properties.System.Music.Artist.Value = new string[] { };
                                file.Properties.System.Video.Director.Value = this.directors != null && this.directors.Length > 0 ? this.directors : null;
                                file.Properties.System.Media.Writer.Value = this.writers != null && this.writers.Length > 0 ? this.writers : null;
                                break;
                            }
                        }
                    }
                }

                foreach (Shell32.FolderItem2 item in objFolder.Items())
                {
                    for (int i = 0; i < arrHeaders.Count; i++)
                    {
                        Console.WriteLine("{0}\t{1}: {2}", i, arrHeaders[i], objFolder.GetDetailsOf(item, i));
                    }

                    Console.WriteLine("\n\n**************************\n\n");
                }
            }
            catch (Exception ex)
            {
                var a = ex;
            }
        }
    };
}
