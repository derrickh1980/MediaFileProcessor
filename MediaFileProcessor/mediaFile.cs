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
        public string parentFolderName { get; set; }
        public string parentFolderPath { get; set; }
        public string year { get; set; }

        public string processTempName()
        {
            string[] filePathNodes = this.filePath.Split('\\');

            // set the file name
            string tempFileName = filePathNodes[filePathNodes.Length - 1];

            string[] nameParts = this.fileName.Split('.');
            string tempExt = '.' + nameParts[nameParts.Length - 1];
            tempFileName = tempFileName.Replace(tempExt, "");

            int index = this.filePath.IndexOf('\\' + tempFileName + this.ext);
            return _processName(tempFileName);            
        }
        public void setFileData(bool initial)
        {
            // first check for read only            
            _processPath(initial);
            _getMovieData();
            //_setMetaData();
        }
        public void moveFile()
        {
            _moveFileLocation();
            _deleteOldFile();
        }

        private void _deleteOldFile()
        {
            File.Delete(this.filePath);
            try
            {
                Directory.Delete(this.parentFolderPath);
            }
            catch (Exception ex)
            {
                //if (ex.Message.Contains("not empty"))
                //{
                //    _processOtherFiles();
                //}
            }
        }

        private void _doParent()
        {

        }

        private void _doFile()
        {

        }

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

        private void _moveFileLocation()
        {
            if (this.movePath != null && this.movePath != "")
            {
                string modifiedPath = this.movePath + "\\" + this.parentFolderName + "\\" + this.fileName + this.ext;
                Directory.CreateDirectory(this.movePath + "\\" + this.parentFolderName);
                File.Move(this.filePath, modifiedPath);
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
                    if (this.delimiter != null)
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
            // need to check for subs
            // if subs are found, change the name of the file and move it to the parent folder

            // need to delete all other files

        }

        private void _processPath(bool initial)
        {            
            if (initial)
            {
                string[] filePathNodes = this.filePath.Split('\\');

                // set the file name
                string tempFileName = filePathNodes[filePathNodes.Length - 1];

                string[] nameParts = tempFileName.Split('.');
                this.ext = '.' + nameParts[nameParts.Length - 1];
                tempFileName = tempFileName.Replace(this.ext, "");

                // set the parent path
                int index = this.filePath.IndexOf('\\' + tempFileName + this.ext);
                this.parentFolderPath = (index < 0) ? "" : this.filePath.Remove(index, tempFileName.Length + 5);
                string fileName = this.fileName;

                // set the new parent folder name
                filePathNodes = this.parentFolderPath.Split('\\');
                this.parentFolderName = filePathNodes[filePathNodes.Length - 1];
                string modifiedFolderPath = this.parentFolderPath.Replace(this.parentFolderName, fileName);
                this.filePath = modifiedFolderPath + '\\' + this.fileName + this.ext;
                this.parentFolderName = fileName;
                if (this.parentFolderPath != modifiedFolderPath)
                {
                    // windows rename work around
                    Directory.Move(this.parentFolderPath, modifiedFolderPath);
                }
                this.parentFolderPath = modifiedFolderPath;
                if ((File.GetAttributes(this.parentFolderPath) & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                {
                    File.SetAttributes(this.parentFolderPath, FileAttributes.ReadOnly);
                }
                string modifiedFilePath = modifiedFolderPath + '\\' + fileName + this.ext;
                File.Move(this.filePath, modifiedFilePath);
                this.filePath = modifiedFilePath;

                if ((File.GetAttributes(this.filePath) & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                {
                    File.SetAttributes(this.filePath, FileAttributes.ReadOnly);
                }
            }
            else
            {
                string modifiedFolderPath = this.parentFolderPath.Replace(this.parentFolderName, fileName);
                this.filePath = modifiedFolderPath + '\\' + this.fileName + this.ext;
                this.parentFolderName = fileName;
                if (this.parentFolderPath != modifiedFolderPath)
                {
                    // windows rename work around
                    Directory.Move(this.parentFolderPath, modifiedFolderPath);
                }
                this.parentFolderPath = modifiedFolderPath;
                if ((File.GetAttributes(this.parentFolderPath) & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                {
                    File.SetAttributes(this.parentFolderPath, FileAttributes.ReadOnly);
                }
                string modifiedFilePath = modifiedFolderPath + '\\' + fileName + this.ext;
                File.Move(this.filePath, modifiedFilePath);
                this.filePath = modifiedFilePath;

                if ((File.GetAttributes(this.filePath) & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                {
                    File.SetAttributes(this.filePath, FileAttributes.ReadOnly);
                }
            }
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
