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
    public partial class Form1 : Form
    {
        public Form1()
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

        private void addFile(string name)
        {
            fileList.Items.Add(name);
        }

        private void clearFileList()
        {
            fileList.Items.Clear();
        }
        
        private void clear_Click(object sender, EventArgs e)
        {
            clearFileList();
        }

        private void process_Click(object sender, EventArgs e)
        {
            Cursor cursor = Cursor.Current;
            cursor = Cursors.WaitCursor;
            var newFile = new MediaFile(fromPath.Text, toPath.Text);
            newFile.setFileData();
            addFile(newFile.fileName);
            cursor = Cursors.Arrow;
        }
    }
}
