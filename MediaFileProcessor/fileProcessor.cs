using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaFileProcessor
{
    class FileProcessor
    {
        public void preProcessor(MediaFile file) {
            // this needs to set file values no moving here...
            // this gets called when the user clicks 'Add to Queue'

            // process the file path down to it's parts
            string[] filePathNodes = file.filePath.Split('\\');

            // get the original name from the path nodes
            file.o = filePathNodes[filePathNodes.Length - 1];
        }

        public void postProcessor(MediaFile file)
        {
            // the file has already been setup for the move
            // this does the file moving

        }
    }
}
