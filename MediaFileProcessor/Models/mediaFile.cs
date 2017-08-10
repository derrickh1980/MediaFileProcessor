using MediaFileProcessor.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Web;
using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;

namespace MediaFileProcessor.Models
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
            _importProcessor.preProcessor(this);
        }

        public void moveFile(bool renameFile = true)
        {
            _setMetaData();
            _importProcessor.postProcessor(this, renameFile);
        }

        public void cleanMetaData()
        {
            _setMetaData();
        }

        private FileProcessor _importProcessor = new FileProcessor();
        private CleanupProcessor _cleanupProcessor = new CleanupProcessor();

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
                        if ((int.TryParse(part, out yr) && yr >= 1930 && yr <= 2060) || part == "1080p" || part == "720p" || part == "WEBRiP" || part == "HDTV")
                        {
                            this.delimiter = part;
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
            try
            {

                _getMovieData();

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
                            if (objFolder.GetDetailsOf(item,i) == this.originalFileName + this.ext)
                            {
                                file = ShellFile.FromFilePath(filePath + "/" + propertyDetail);
                                file.Properties.System.FileName.Value = this.fileName;
                                file.Properties.System.Title.Value = this.fileName;
                                file.Properties.System.Media.Subtitle.Value = "";
                                file.Properties.System.Author.Value = new string[] { };
                                file.Properties.System.Media.Year.Value = this.movieData.Year != null ? uint.Parse(this.movieData.Year) : 0;
                                file.Properties.System.Music.Genre.Value = this.movieData.Genre != null ? new string[] { this.movieData.Genre } : new string[] { };
                                file.Properties.System.Media.ProviderRating.Value = this.movieData.Rated != null ? this.movieData.Rated : "";
                                file.Properties.System.Media.DateReleased.Value = this.movieData.Released != null ? this.movieData.Released : "";
                                file.Properties.System.Music.Artist.Value = new string[] { };
                                file.Properties.System.Video.Director.Value = this.movieData.Director != null ? new string[] { this.movieData.Director } : new string[] { };
                                file.Properties.System.Media.Writer.Value = this.movieData.Writer != null ? new string[] { this.movieData.Writer } : new string[] { };
                                break;
                            }
                        } 
                        //Console.WriteLine("{0}\t{1}: {2}", i, arrHeaders[i], objFolder.GetDetailsOf(item, i));
                    }                    

                    //Console.WriteLine("\n\n**************************\n\n");
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
