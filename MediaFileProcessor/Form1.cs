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
            }

            addInfoFile("Move Complete...");
            addInfoFile(Environment.NewLine);
            addInfoFile("-------------------------------------");
            addInfoFile(Environment.NewLine);
        }

        private void add_Click(object sender, EventArgs e)
        {
            // this adds the from file and the to location to the info list            
            Cursor cursor = Cursor.Current;
            cursor = Cursors.WaitCursor;
            var newFile = new MediaFile(fromPath.Text, toPath.Text);
            newFile.setFileData();
            addInfoFile(newFile.fileName);
            files.Add(newFile);
            cursor = Cursors.Arrow;
        }
    }
}
