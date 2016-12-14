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

            // set the custom folder name here - always
            currentFile.parentFolderNameCustom = customFolderName.Text;

            if (!files.Contains(currentFile))
            {
                currentFile.fileName = processedName.Text;
                currentFile.setPreData();
            }
            else
            {            
                //TODO!!!!
                // debug this, not sure what if anything needs to happen here......

                // this file has already been added before
                files.RemoveAll(file => file.filePath == oldFile.filePath);
                removeInfoFile(oldFile.fileName);
                currentFile.setPreData();
            }
            addInfoFile(currentFile.fileName);
            files.Add(currentFile);
            fromPath.Text = "";
        }

        private void processName_Click(object sender, EventArgs e)
        {
            if (delimiterOptions.SelectedIndex != 0 || processedName.Text == "")
            {
                if (currentFile != null)
                {
                    oldFile = new MediaFile(currentFile.filePath, currentFile.movePath);

                    currentFile.delimiter = delimiterOptions.Text;
                    if (delimiterOptions.SelectedIndex == 0 && processedName.Text == "")
                    {
                        currentFile.delimiter = null;
                    }
                    processedName.Text = currentFile.processTempName();
                    delimiterOptions.Text = currentFile.delimiter;

                    files.RemoveAll(file => file.filePath == oldFile.filePath);
                }
                else
                {
                    currentFile = new MediaFile(fromPath.Text, toPath.Text);
                    processedName.Text = currentFile.processTempName();

                    // start at 1 because 0 is added by default
                    int count = 1;
                    int tempIndex = 0;

                    // add "Custom" as the first delimiter
                    ComboboxItem item = new ComboboxItem();

                    // add the rest of the options
                    foreach (string delimiter in currentFile.delimiterOptions)
                    {
                        item = new ComboboxItem();
                        item.Text = delimiter;
                        item.Value = count;
                        delimiterOptions.Items.Add(item);
                        if (delimiter == currentFile.delimiter)
                        {
                            tempIndex = count;
                        }
                        count++;
                    }

                    // add None to the end so the user can just leave the name alone
                    item.Text = "None";
                    item.Value = count;
                    delimiterOptions.Items.Add(item);

                    delimiterOptions.SelectedIndex = tempIndex;
                }
            }
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

        private void processedName_TextChanged(object sender, EventArgs e)
        {
            if (delimiterOptions.SelectedIndex > 0)
            {
                //TODO: maybe throw a message here...
                delimiterOptions.Focus();
            }
        }

        private void delimiterOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (delimiterOptions.SelectedIndex == 0)
            {
                processedName.Enabled = true;
                processedName.Text = "";
            }
            else if (delimiterOptions.SelectedIndex == currentFile.delimiterOptions.Length + 1)
            {
                currentFile.delimiter = "This is some random text that will never happen";
                processedName.Enabled = false;
                processedName.Text = currentFile.processTempName();
            }
            else
            {
                processedName.Enabled = false;
                oldFile = new MediaFile(currentFile.filePath, currentFile.movePath);

                currentFile.delimiter = delimiterOptions.Text;
                processedName.Text = currentFile.processTempName();
            }
        }

        private void fromPath_TextChanged(object sender, EventArgs e)
        {
            processedName.Enabled = true;
            delimiterOptions.Items.Clear();
            ComboboxItem item = new ComboboxItem();
            item.Text = "Custom";
            item.Value = 0;
            delimiterOptions.Items.Add(item);
            delimiterOptions.SelectedIndex = 0;
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
