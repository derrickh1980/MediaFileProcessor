namespace MediaFileProcessor
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {            
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.title = new System.Windows.Forms.Label();
            this.delimiter = new System.Windows.Forms.Label();
            this.delimiterOptions = new System.Windows.Forms.ComboBox();
            this.processName = new System.Windows.Forms.Button();
            this.processedName = new System.Windows.Forms.TextBox();
            this.fileName = new System.Windows.Forms.Label();
            this.process = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.fileList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.infoList = new System.Windows.Forms.ListBox();
            this.error = new System.Windows.Forms.Label();
            this.to = new System.Windows.Forms.Button();
            this.from = new System.Windows.Forms.Button();
            this.toPath = new System.Windows.Forms.TextBox();
            this.fromPath = new System.Windows.Forms.TextBox();
            this.toDescription = new System.Windows.Forms.Label();
            this.fromDescrition = new System.Windows.Forms.Label();
            this.openFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 576);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.title);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.delimiter);
            this.splitContainer1.Panel2.Controls.Add(this.processName);
            this.splitContainer1.Panel2.Controls.Add(this.add);
            this.splitContainer1.Panel2.Controls.Add(this.delimiterOptions);
            this.splitContainer1.Panel2.Controls.Add(this.processedName);
            this.splitContainer1.Panel2.Controls.Add(this.fileName);
            this.splitContainer1.Panel2.Controls.Add(this.process);
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Controls.Add(this.error);
            this.splitContainer1.Panel2.Controls.Add(this.to);
            this.splitContainer1.Panel2.Controls.Add(this.from);
            this.splitContainer1.Panel2.Controls.Add(this.toPath);
            this.splitContainer1.Panel2.Controls.Add(this.fromPath);
            this.splitContainer1.Panel2.Controls.Add(this.toDescription);
            this.splitContainer1.Panel2.Controls.Add(this.fromDescrition);
            this.splitContainer1.Size = new System.Drawing.Size(802, 608);
            this.splitContainer1.SplitterDistance = 59;
            this.splitContainer1.TabIndex = 0;
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(284, 14);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(235, 20);
            this.title.TabIndex = 0;
            this.title.Text = "Media Center File Processor";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // delimiter
            // 
            this.delimiter.AutoSize = true;
            this.delimiter.Location = new System.Drawing.Point(675, 80);
            this.delimiter.Name = "delimiter";
            this.delimiter.Size = new System.Drawing.Size(47, 13);
            this.delimiter.TabIndex = 14;
            this.delimiter.Text = "Delimiter";
            // 
            // delimiterOptions
            // 
            this.delimiterOptions.FormattingEnabled = true;
            this.delimiterOptions.Location = new System.Drawing.Point(678, 96);
            this.delimiterOptions.Name = "delimiterOptions";
            this.delimiterOptions.Size = new System.Drawing.Size(121, 21);
            this.delimiterOptions.TabIndex = 13;
            // 
            // processName
            // 
            this.processName.BackColor = System.Drawing.Color.Black;
            this.processName.BackgroundImage = global::MediaFileProcessor.Properties.Resources.refresh_arrow_icon;
            this.processName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.processName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.processName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.processName.Location = new System.Drawing.Point(678, 123);
            this.processName.Name = "processName";
            this.processName.Size = new System.Drawing.Size(121, 32);
            this.processName.TabIndex = 12;
            this.processName.UseVisualStyleBackColor = false;
            this.processName.Click += new System.EventHandler(this.processName_Click);
            // 
            // processedName
            // 
            this.processedName.Location = new System.Drawing.Point(60, 96);
            this.processedName.Name = "processedName";
            this.processedName.Size = new System.Drawing.Size(612, 20);
            this.processedName.TabIndex = 11;
            // 
            // fileName
            // 
            this.fileName.AutoSize = true;
            this.fileName.Location = new System.Drawing.Point(-3, 99);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(57, 13);
            this.fileName.TabIndex = 10;
            this.fileName.Text = "File Name:";
            // 
            // process
            // 
            this.process.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.process.Location = new System.Drawing.Point(3, 445);
            this.process.Name = "process";
            this.process.Size = new System.Drawing.Size(796, 60);
            this.process.TabIndex = 8;
            this.process.Text = "Process";
            this.process.UseVisualStyleBackColor = true;
            this.process.Click += new System.EventHandler(this.process_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(60, 123);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(612, 32);
            this.add.TabIndex = 9;
            this.add.Text = "Add To Queue";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(0, 154);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.clear);
            this.splitContainer2.Panel1.Controls.Add(this.fileList);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.infoList);
            this.splitContainer2.Size = new System.Drawing.Size(802, 285);
            this.splitContainer2.SplitterDistance = 327;
            this.splitContainer2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Completed Files";
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(3, 231);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(311, 46);
            this.clear.TabIndex = 1;
            this.clear.Text = "Clear Files List";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // fileList
            // 
            this.fileList.FormattingEnabled = true;
            this.fileList.Location = new System.Drawing.Point(3, 26);
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(311, 199);
            this.fileList.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Queue";
            // 
            // infoList
            // 
            this.infoList.FormattingEnabled = true;
            this.infoList.Location = new System.Drawing.Point(14, 26);
            this.infoList.Name = "infoList";
            this.infoList.Size = new System.Drawing.Size(454, 251);
            this.infoList.TabIndex = 0;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.DarkRed;
            this.error.Location = new System.Drawing.Point(0, 528);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 17);
            this.error.TabIndex = 6;
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(678, 44);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(121, 27);
            this.to.TabIndex = 3;
            this.to.Text = "Choose To";
            this.to.UseVisualStyleBackColor = true;
            this.to.Click += new System.EventHandler(this.to_Click);
            // 
            // from
            // 
            this.from.Location = new System.Drawing.Point(678, 13);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(121, 27);
            this.from.TabIndex = 2;
            this.from.Text = "Choose From";
            this.from.UseVisualStyleBackColor = true;
            this.from.Click += new System.EventHandler(this.from_Click);
            // 
            // toPath
            // 
            this.toPath.Location = new System.Drawing.Point(60, 48);
            this.toPath.Name = "toPath";
            this.toPath.Size = new System.Drawing.Size(612, 20);
            this.toPath.TabIndex = 1;
            // 
            // fromPath
            // 
            this.fromPath.Location = new System.Drawing.Point(60, 17);
            this.fromPath.Name = "fromPath";
            this.fromPath.Size = new System.Drawing.Size(612, 20);
            this.fromPath.TabIndex = 0;
            // 
            // toDescription
            // 
            this.toDescription.AutoSize = true;
            this.toDescription.Location = new System.Drawing.Point(-3, 51);
            this.toDescription.Name = "toDescription";
            this.toDescription.Size = new System.Drawing.Size(55, 13);
            this.toDescription.TabIndex = 5;
            this.toDescription.Text = "To Folder:";
            // 
            // fromDescrition
            // 
            this.fromDescrition.AutoSize = true;
            this.fromDescrition.Location = new System.Drawing.Point(-3, 20);
            this.fromDescrition.Name = "fromDescrition";
            this.fromDescrition.Size = new System.Drawing.Size(52, 13);
            this.fromDescrition.TabIndex = 4;
            this.fromDescrition.Text = "From File:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Processed Name";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(827, 601);
            this.Controls.Add(this.panel1);
            this.Name = "main";
            this.Text = "Media Center File Processor";
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button to;
        private System.Windows.Forms.Button from;
        private System.Windows.Forms.TextBox toPath;
        private System.Windows.Forms.TextBox fromPath;
        private System.Windows.Forms.Label toDescription;
        private System.Windows.Forms.Label fromDescrition;
        private System.Windows.Forms.FolderBrowserDialog openFolderDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListBox fileList;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button process;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox infoList;
        private System.Windows.Forms.ComboBox delimiterOptions;
        private System.Windows.Forms.Button processName;
        private System.Windows.Forms.TextBox processedName;
        private System.Windows.Forms.Label fileName;
        private System.Windows.Forms.Label delimiter;
        private System.Windows.Forms.Label label3;
    }
}

