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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.infoList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fromDescrition = new System.Windows.Forms.Label();
            this.customerParentName = new System.Windows.Forms.Label();
            this.toDescription = new System.Windows.Forms.Label();
            this.fromPath = new System.Windows.Forms.TextBox();
            this.fileList = new System.Windows.Forms.ListBox();
            this.toPath = new System.Windows.Forms.TextBox();
            this.customFolderName = new System.Windows.Forms.TextBox();
            this.from = new System.Windows.Forms.Button();
            this.folderName = new System.Windows.Forms.Label();
            this.to = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.process = new System.Windows.Forms.Button();
            this.delimiter = new System.Windows.Forms.Label();
            this.fileName = new System.Windows.Forms.Label();
            this.processName = new System.Windows.Forms.Button();
            this.processedName = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.delimiterOptions = new System.Windows.Forms.ComboBox();
            this.error = new System.Windows.Forms.Label();
            this.openFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.clear);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.infoList);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.fromDescrition);
            this.panel1.Controls.Add(this.customerParentName);
            this.panel1.Controls.Add(this.toDescription);
            this.panel1.Controls.Add(this.fromPath);
            this.panel1.Controls.Add(this.fileList);
            this.panel1.Controls.Add(this.toPath);
            this.panel1.Controls.Add(this.customFolderName);
            this.panel1.Controls.Add(this.from);
            this.panel1.Controls.Add(this.folderName);
            this.panel1.Controls.Add(this.to);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.process);
            this.panel1.Controls.Add(this.delimiter);
            this.panel1.Controls.Add(this.fileName);
            this.panel1.Controls.Add(this.processName);
            this.panel1.Controls.Add(this.processedName);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.delimiterOptions);
            this.panel1.Location = new System.Drawing.Point(4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 649);
            this.panel1.TabIndex = 0;
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial Unicode MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(133)))), ((int)(((byte)(239)))));
            this.title.Location = new System.Drawing.Point(271, 7);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(292, 26);
            this.title.TabIndex = 0;
            this.title.Text = "Media Center File Processor";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.clear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Arial", 9F);
            this.clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            this.clear.Location = new System.Drawing.Point(16, 499);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(311, 46);
            this.clear.TabIndex = 1;
            this.clear.Text = "Clear Files List";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            this.label1.Location = new System.Drawing.Point(111, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Completed Files";
            // 
            // infoList
            // 
            this.infoList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            this.infoList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoList.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.infoList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(114)))), ((int)(((byte)(206)))));
            this.infoList.FormattingEnabled = true;
            this.infoList.ItemHeight = 17;
            this.infoList.Location = new System.Drawing.Point(358, 305);
            this.infoList.Name = "infoList";
            this.infoList.Size = new System.Drawing.Size(454, 240);
            this.infoList.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            this.label2.Location = new System.Drawing.Point(560, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Queue";
            // 
            // fromDescrition
            // 
            this.fromDescrition.AutoSize = true;
            this.fromDescrition.Font = new System.Drawing.Font("Arial", 10F);
            this.fromDescrition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            this.fromDescrition.Location = new System.Drawing.Point(34, 53);
            this.fromDescrition.Name = "fromDescrition";
            this.fromDescrition.Size = new System.Drawing.Size(72, 16);
            this.fromDescrition.TabIndex = 4;
            this.fromDescrition.Text = "From File:";
            // 
            // customerParentName
            // 
            this.customerParentName.AutoSize = true;
            this.customerParentName.Font = new System.Drawing.Font("Arial", 10F);
            this.customerParentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            this.customerParentName.Location = new System.Drawing.Point(106, 166);
            this.customerParentName.Name = "customerParentName";
            this.customerParentName.Size = new System.Drawing.Size(204, 16);
            this.customerParentName.TabIndex = 18;
            this.customerParentName.Text = "Customize Parent Folder Name";
            // 
            // toDescription
            // 
            this.toDescription.AutoSize = true;
            this.toDescription.Font = new System.Drawing.Font("Arial", 10F);
            this.toDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            this.toDescription.Location = new System.Drawing.Point(31, 84);
            this.toDescription.Name = "toDescription";
            this.toDescription.Size = new System.Drawing.Size(72, 16);
            this.toDescription.TabIndex = 5;
            this.toDescription.Text = "To Folder:";
            // 
            // fromPath
            // 
            this.fromPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            this.fromPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fromPath.Enabled = false;
            this.fromPath.Font = new System.Drawing.Font("Arial", 10F);
            this.fromPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(114)))), ((int)(((byte)(206)))));
            this.fromPath.Location = new System.Drawing.Point(109, 48);
            this.fromPath.Name = "fromPath";
            this.fromPath.Size = new System.Drawing.Size(576, 23);
            this.fromPath.TabIndex = 0;
            this.fromPath.TextChanged += new System.EventHandler(this.fromPath_TextChanged);
            // 
            // fileList
            // 
            this.fileList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            this.fileList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileList.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.fileList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(114)))), ((int)(((byte)(206)))));
            this.fileList.FormattingEnabled = true;
            this.fileList.ItemHeight = 17;
            this.fileList.Location = new System.Drawing.Point(16, 304);
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(311, 189);
            this.fileList.TabIndex = 0;
            // 
            // toPath
            // 
            this.toPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            this.toPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toPath.Font = new System.Drawing.Font("Arial", 10F);
            this.toPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(114)))), ((int)(((byte)(206)))));
            this.toPath.Location = new System.Drawing.Point(109, 79);
            this.toPath.Name = "toPath";
            this.toPath.Size = new System.Drawing.Size(576, 23);
            this.toPath.TabIndex = 1;
            // 
            // customFolderName
            // 
            this.customFolderName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            this.customFolderName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customFolderName.Font = new System.Drawing.Font("Arial", 10F);
            this.customFolderName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(114)))), ((int)(((byte)(206)))));
            this.customFolderName.Location = new System.Drawing.Point(109, 185);
            this.customFolderName.Name = "customFolderName";
            this.customFolderName.Size = new System.Drawing.Size(576, 23);
            this.customFolderName.TabIndex = 17;
            // 
            // from
            // 
            this.from.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.from.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.from.FlatAppearance.BorderSize = 0;
            this.from.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.from.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            this.from.Location = new System.Drawing.Point(691, 46);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(121, 27);
            this.from.TabIndex = 2;
            this.from.Text = "Choose From";
            this.from.UseVisualStyleBackColor = false;
            this.from.Click += new System.EventHandler(this.from_Click);
            // 
            // folderName
            // 
            this.folderName.AutoSize = true;
            this.folderName.Font = new System.Drawing.Font("Arial", 10F);
            this.folderName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            this.folderName.Location = new System.Drawing.Point(13, 188);
            this.folderName.Name = "folderName";
            this.folderName.Size = new System.Drawing.Size(93, 16);
            this.folderName.TabIndex = 16;
            this.folderName.Text = "Folder Name:";
            // 
            // to
            // 
            this.to.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.to.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.to.FlatAppearance.BorderSize = 0;
            this.to.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.to.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            this.to.Location = new System.Drawing.Point(691, 77);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(121, 27);
            this.to.TabIndex = 3;
            this.to.Text = "Choose To";
            this.to.UseVisualStyleBackColor = false;
            this.to.Click += new System.EventHandler(this.to_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            this.label3.Location = new System.Drawing.Point(106, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Processed Name";
            // 
            // process
            // 
            this.process.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.process.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.process.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.process.FlatAppearance.BorderSize = 0;
            this.process.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.process.Font = new System.Drawing.Font("Arial", 9F);
            this.process.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            this.process.Location = new System.Drawing.Point(16, 565);
            this.process.Name = "process";
            this.process.Size = new System.Drawing.Size(796, 60);
            this.process.TabIndex = 8;
            this.process.Text = "Process";
            this.process.UseVisualStyleBackColor = false;
            this.process.Click += new System.EventHandler(this.process_Click);
            // 
            // delimiter
            // 
            this.delimiter.AutoSize = true;
            this.delimiter.Font = new System.Drawing.Font("Arial", 10F);
            this.delimiter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            this.delimiter.Location = new System.Drawing.Point(511, 115);
            this.delimiter.Name = "delimiter";
            this.delimiter.Size = new System.Drawing.Size(63, 16);
            this.delimiter.TabIndex = 14;
            this.delimiter.Text = "Delimiter";
            // 
            // fileName
            // 
            this.fileName.AutoSize = true;
            this.fileName.Font = new System.Drawing.Font("Arial", 10F);
            this.fileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            this.fileName.Location = new System.Drawing.Point(29, 137);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(75, 16);
            this.fileName.TabIndex = 10;
            this.fileName.Text = "File Name:";
            // 
            // processName
            // 
            this.processName.BackColor = System.Drawing.Color.Transparent;
            this.processName.BackgroundImage = global::MediaFileProcessor.Properties.Resources.icon;
            this.processName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.processName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.processName.FlatAppearance.BorderSize = 0;
            this.processName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.processName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.processName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.processName.Location = new System.Drawing.Point(715, 129);
            this.processName.Name = "processName";
            this.processName.Size = new System.Drawing.Size(79, 79);
            this.processName.TabIndex = 12;
            this.processName.UseVisualStyleBackColor = false;
            this.processName.Click += new System.EventHandler(this.processName_Click);
            // 
            // processedName
            // 
            this.processedName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            this.processedName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.processedName.Font = new System.Drawing.Font("Arial", 10F);
            this.processedName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(114)))), ((int)(((byte)(206)))));
            this.processedName.Location = new System.Drawing.Point(109, 134);
            this.processedName.Name = "processedName";
            this.processedName.Size = new System.Drawing.Size(399, 23);
            this.processedName.TabIndex = 11;
            this.processedName.TextChanged += new System.EventHandler(this.processedName_TextChanged);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.add.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Arial", 9F);
            this.add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            this.add.Location = new System.Drawing.Point(16, 223);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(796, 32);
            this.add.TabIndex = 9;
            this.add.Text = "Add To Queue";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delimiterOptions
            // 
            this.delimiterOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            this.delimiterOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delimiterOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.delimiterOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delimiterOptions.Font = new System.Drawing.Font("Arial", 10F);
            this.delimiterOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(114)))), ((int)(((byte)(206)))));
            this.delimiterOptions.FormattingEnabled = true;
            this.delimiterOptions.Location = new System.Drawing.Point(514, 133);
            this.delimiterOptions.MaxDropDownItems = 15;
            this.delimiterOptions.Name = "delimiterOptions";
            this.delimiterOptions.Size = new System.Drawing.Size(171, 24);
            this.delimiterOptions.TabIndex = 13;
            this.delimiterOptions.SelectedIndexChanged += new System.EventHandler(this.delimiterOptions_SelectedIndexChanged);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.DarkRed;
            this.error.Location = new System.Drawing.Point(0, 546);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 17);
            this.error.TabIndex = 6;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(840, 651);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.Text = "Media Center File Processor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.Label customerParentName;
        private System.Windows.Forms.TextBox customFolderName;
        private System.Windows.Forms.Label folderName;
    }
}

