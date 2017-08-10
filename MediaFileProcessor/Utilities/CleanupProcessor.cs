using MediaFileProcessor.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaFileProcessor.Utilities
{
    class CleanupProcessor
    {
        private string parentPath = "";
        private IEnumerable<string> folders;
        private IEnumerable<string> files;

        public string info = "";

        public void runCleanup(string selectedFolderPath)
        {
            parentPath = selectedFolderPath;
            getFolders();
            getFiles();

            processFolders();
            processFiles();            
        }
        
        private void getFolders()
        {
            folders = Directory.EnumerateDirectories(parentPath);
        }

        private void getFiles()
        {
            files = Directory.EnumerateFiles(parentPath);
        } 
      
        private void processFolders()
        {
            if (folders != null && folders.ToList().Count > 0)
            {
                foreach (string folder in folders)
                {
                    var tempFiles = Directory.EnumerateFiles(folder);
                    foreach (string file in tempFiles)
                    {
                        MediaFile mediaFile = new MediaFile(file, "");
                        mediaFile.fileName = mediaFile.processTempName();
                        mediaFile.cleanMetaData();
                        info += "Cleaned File: " + mediaFile.fileName + "\r\n";
                    }
                }
            }
        }
        
        private void processFiles()
        {
            if (files != null && files.ToList().Count > 0)
            {
                foreach (string file in files)
                {
                    MediaFile mediaFile = new MediaFile(file, "");
                    mediaFile.fileName = mediaFile.processTempName();
                    mediaFile.parentFolderNameCustom = mediaFile.fileName;
                    mediaFile.setPreData();
                    mediaFile.movePath = mediaFile.parentFolderPath + "\\" + mediaFile.parentFolderNameCustom;
                    mediaFile.moveFile(false);
                    info += "Cleaned and Moved File: " + mediaFile.fileName + "\r\n";
                }
            }
        }    
    }
}
