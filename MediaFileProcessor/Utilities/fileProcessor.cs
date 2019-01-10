using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaFileProcessor.Models;

namespace MediaFileProcessor.Utilities
{
    public class FileProcessor
    {
        public void preProcessor(MediaFile file)
        {
            // this needs to set file values no moving here...
            // this gets called when the user clicks 'Add to Queue'

            // FILE PROCESSING
            // process the file path down to it's parts
            string[] filePathNodes = file.filePath.Split('\\');

            // get the original name from the path nodes
            file.originalFileName = filePathNodes[filePathNodes.Length - 1];

            // get the name parts
            string[] nameParts = file.originalFileName.Split('.');

            // get the file extension
            file.ext = '.' + nameParts[nameParts.Length - 1];

            // set the original file name without the extension
            file.originalFileName = file.originalFileName.Replace(file.ext, "");

            // FOLDER PROCESSING
            // get the parent path
            int index = file.filePath.IndexOf('\\' + file.originalFileName + file.ext);
            file.parentFolderPath = (index < 0) ? "" : file.filePath.Remove(index, file.originalFileName.Length + 5);

            // get the original parent folder name
            filePathNodes = file.parentFolderPath.Split('\\');
            file.originalParentFolderName = filePathNodes[filePathNodes.Length - 1];

            // get the new parent folder name if it hasn't been set yet
            if (file.parentFolderName == "" || file.parentFolderName == null)
            {
                file.parentFolderName = file.parentFolderNameCustom;
            }
        }

        public void postProcessor(MediaFile file, bool renaming, bool doDelete)
        {
            // the file has already been setup for the move
            // this does the file moving and renaming

            if (renaming)
            {
                // rename the file
                string modifiedFilePath = file.filePath.Replace(file.originalFileName + file.ext, file.fileName + file.ext);
                try
                {
                    File.Move(file.filePath, modifiedFilePath);
                }
                catch (System.IO.FileNotFoundException error)
                {
                    throw (error);
                }

                // set the file path to reflect the name change
                file.filePath = modifiedFilePath;
                file.originalFileName = null;
            }

            // create the new parent directory
            string newParentPath = file.movePath + "\\" + file.parentFolderName;

            if (!Directory.Exists(newParentPath))
            {
                Directory.CreateDirectory(newParentPath);
            }

            // move the file to the new directory
            string newFilePath = newParentPath + "\\" + file.fileName + file.ext;
            File.Move(file.filePath, newFilePath);

            // delete the old file
            //File.Delete(file.filePath);

            // delete the old folder if no more files reside there
            if (doDelete)
            {
                if (Directory.GetFiles(file.parentFolderPath, "*", SearchOption.TopDirectoryOnly).Length == 0 &&
                    Directory.GetDirectories(file.parentFolderPath, "*", SearchOption.TopDirectoryOnly).Length == 0)
                {
                    Directory.Delete(file.parentFolderPath);
                }
            }

            // set the file's parameters to reflect the move
            file.filePath = newFilePath;
            file.parentFolderPath = newParentPath;
            file.originalParentFolderName = null;
            file.parentFolderNameCustom = null;
        }
    }
}
