using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaFileProcessor
{
    public partial class main : Form
    {
        public List<MediaFile> files = new List<MediaFile>();
        public MediaFile currentFile = null;
        public MediaFile oldFile = null;

        public main()
        {
            InitializeComponent();
        }

        private void from_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog.FileName;
                try
                {
                    fromPath.Text = file;
                    checkAddEnabled();
                }
                catch (IOException ex)
                {
                    error.Text = ex.Message;
                }
            }
        }

        private void to_Click(object sender, EventArgs e)
        {
            DialogResult result = openFolderDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string folder = openFolderDialog.SelectedPath;
                try
                {
                    toPath.Text = folder;
                    checkAddEnabled();
                }
                catch (IOException ex)
                {
                    error.Text = ex.Message;
                }
            }
        }

        private void addInfoFile(string name)
        {
            infoList.Items.Add(name);
        }

        private void removeInfoFile(string name)
        {
            infoList.Items.Remove(name);
        }
        private void addFinishedFile(string name)
        {
            infoList.Items.Add(name);
        }

        private void clearFileList()
        {
            fileList.Items.Clear();
            infoList.Items.Clear();
            files = new List<MediaFile>();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            clearFileList();
        }

        private void process_Click(object sender, EventArgs e)
        {
            // this needs to process each file from the list of files
            addInfoFile("Moving Files...");

            foreach (MediaFile file in files)
            {
                file.moveFile();
                addFinishedFile(file.fileName);
            }

            addInfoFile("Move Complete...");
            addInfoFile(Environment.NewLine);
            addInfoFile("-------------------------------------");
            addInfoFile(Environment.NewLine);
        }

        private void add_Click(object sender, EventArgs e)
        {
            // this adds the from file and the to location to the info list    
            if (!files.Contains(currentFile))
            {
                currentFile.fileName = processedName.Text;
                currentFile.setFileData(true);
            }
            else
            {
                // this file has already been added before
                files.RemoveAll(file => file.filePath == oldFile.filePath);
                removeInfoFile(oldFile.fileName);
                currentFile.setFileData(false);
            }
            addInfoFile(currentFile.fileName);
            files.Add(currentFile);
            fromPath.Text = "";
        }

        private void processName_Click(object sender, EventArgs e)
        {
            if (currentFile != null)
            {
                oldFile = new MediaFile(currentFile.filePath, currentFile.movePath);
            }
            else
            {
                int count = 0;

                // add "Custom" as the first delimiter
                ComboboxItem item = new ComboboxItem();
                item.Text = "Custom";
                item.Value = count;
                count++;

                // add the rest of the options
                foreach (string delimiter in currentFile.delimiterOptions)
                {
                    item = new ComboboxItem();
                    item.Text = delimiter;
                    item.Value = count;
                    delimiterOptions.Items.Add(item);
                    if (delimiter == currentFile.delimiter)
                    {
                        delimiterOptions.SelectedIndex = count;
                    }
                    count++;
                }
            }
            currentFile = new MediaFile(fromPath.Text, toPath.Text);
            processName.Text = currentFile.processTempName();
        }

        private void checkAddEnabled()
        {
            // check to see if the add button should be enabled or not
            if (fromPath.Text != "" && toPath.Text != "" && processedName.Text != "")
            {
                add.Enabled = true;
            }
            else
            {
                add.Enabled = false;
            }
        }
    }

    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
