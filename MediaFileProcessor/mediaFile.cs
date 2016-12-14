using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Web;

namespace MediaFileProcessor
{
    public class MediaFile
    {
        public MediaFile(string path, string movePath)
        {
            this.filePath = path;
            this.movePath = movePath;
        }

        public string delimiter { get; set; }
        public string[] delimiterOptions { get; set; }
        public string ext { get; set; }
        public string fileName { get; set; }
        public string filePath { get; set; }
        public Movie movieData { get; set; }
        public string movePath { get; set; }
        public string originalFileName { get; set; }
        public string originalParentFolderName { get; set; }
        public string parentFolderName { get; set; }
        public string parentFolderNameCustom { get; set; }
        public string parentFolderPath { get; set; }
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
            _processor.preProcessor(this);
        }

        public void moveFile()
        {
            _getMovieData();
            _processor.postProcessor(this);
        }

        private FileProcessor _processor = new FileProcessor();               

        private void _getMovieData()
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"http://www.omdbapi.com?" + HttpUtility.ParseQueryString("t=" + this.fileName));
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                string content = new StreamReader(response.GetResponseStream()).ReadToEnd();
                this.movieData = new Movie(content);
            }
            catch (Exception ex)
            {
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
                foreach (string part in this.delimiterOptions)
                {
                    count++;
                    if (this.delimiter == null)
                    {
                        // this is the first run so do the default processing
                        int yr = 0;
                        if ((int.TryParse(part, out yr) && yr >= 1930 && yr <= 2060) || (part == "1080p"))
                        {
                            this.delimiter = part;

                            // this is the year (probably), get out
                            this.year = part;
                            break;
                        }
                        else
                        {
                            remasteredName += part + " ";
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
                            remasteredName += part + " ";
                        }
                    }

                }

                if (count == this.delimiterOptions.Length)
                {
                    this.delimiter = this.delimiterOptions[0];
                }
                return remasteredName.Trim();
            }
            else
            {
                //TODO: may end up here when changing a name                
                return this.delimiterOptions[0];
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

        private void _setMetaData()
        {
            //TODO
            //this doesn't work... there has to be a better way
            try
            {
                TagLib.File file = TagLib.File.Create(this.filePath);
                file.Tag.Title = this.movieData.Title;
                TagLib.Riff.MovieIdTag tag = (TagLib.Riff.MovieIdTag)file.GetTag(TagLib.TagTypes.MovieId);
                tag.SetValue("Id", this.movieData.imdbID);
                tag.SetValue("Title", this.movieData.Title);
                tag.SetValue("Year", this.movieData.Year);
                tag.SetValue("Genre", this.movieData.Genre);
                tag.SetValue("Parental rating", this.movieData.Rated);
            }
            catch (Exception ex)
            {
                var a = ex;
            }
        }
    };
}
