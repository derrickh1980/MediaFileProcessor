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
            this.importPanel = new System.Windows.Forms.Panel();
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
            this.processorTabs = new System.Windows.Forms.TabControl();
            this.importTabPanel = new System.Windows.Forms.TabPage();
            this.cleanupTabPanel = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.cleanupInfo = new System.Windows.Forms.ListBox();
            this.processCleanupButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.selectedFolder = new System.Windows.Forms.TextBox();
            this.folderSelectButton = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.smcList = new System.Windows.Forms.ListBox();
            this.smcProcessButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.smcPath = new System.Windows.Forms.TextBox();
            this.smcFolderSelect = new System.Windows.Forms.Button();
            this.suffixLabel = new System.Windows.Forms.Label();
            this.suffixEntry = new System.Windows.Forms.TextBox();
            this.importPanel.SuspendLayout();
            this.processorTabs.SuspendLayout();
            this.importTabPanel.SuspendLayout();
            this.cleanupTabPanel.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // importPanel
            // 
            this.importPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            this.importPanel.Controls.Add(this.title);
            this.importPanel.Controls.Add(this.clear);
            this.importPanel.Controls.Add(this.label1);
            this.importPanel.Controls.Add(this.infoList);
            this.importPanel.Controls.Add(this.label2);
            this.importPanel.Controls.Add(this.fromDescrition);
            this.importPanel.Controls.Add(this.customerParentName);
            this.importPanel.Controls.Add(this.toDescription);
            this.importPanel.Controls.Add(this.fromPath);
            this.importPanel.Controls.Add(this.fileList);
            this.importPanel.Controls.Add(this.toPath);
            this.importPanel.Controls.Add(this.customFolderName);
            this.importPanel.Controls.Add(this.from);
            this.importPanel.Controls.Add(this.folderName);
            this.importPanel.Controls.Add(this.to);
            this.importPanel.Controls.Add(this.label3);
            this.importPanel.Controls.Add(this.process);
            this.importPanel.Controls.Add(this.delimiter);
            this.importPanel.Controls.Add(this.fileName);
            this.importPanel.Controls.Add(this.processName);
            this.importPanel.Controls.Add(this.processedName);
            this.importPanel.Controls.Add(this.add);
            this.importPanel.Controls.Add(this.delimiterOptions);
            this.importPanel.Location = new System.Drawing.Point(0, 0);
            this.importPanel.Name = "importPanel";
            this.importPanel.Size = new System.Drawing.Size(834, 649);
            this.importPanel.TabIndex = 0;
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial Unicode MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(133)))), ((int)(((byte)(239)))));
            this.title.Location = new System.Drawing.Point(265, 3);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(320, 26);
            this.title.TabIndex = 0;
            this.title.Text = "Media Center Import Processor";
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
            // processorTabs
            // 
            this.processorTabs.Controls.Add(this.importTabPanel);
            this.processorTabs.Controls.Add(this.cleanupTabPanel);
            this.processorTabs.Controls.Add(this.tabPage1);
            this.processorTabs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.processorTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processorTabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processorTabs.Location = new System.Drawing.Point(0, 0);
            this.processorTabs.Margin = new System.Windows.Forms.Padding(0);
            this.processorTabs.Name = "processorTabs";
            this.processorTabs.Padding = new System.Drawing.Point(25, 3);
            this.processorTabs.SelectedIndex = 0;
            this.processorTabs.Size = new System.Drawing.Size(850, 679);
            this.processorTabs.TabIndex = 1;
            // 
            // importTabPanel
            // 
            this.importTabPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            this.importTabPanel.Controls.Add(this.importPanel);
            this.importTabPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importTabPanel.Location = new System.Drawing.Point(4, 25);
            this.importTabPanel.Name = "importTabPanel";
            this.importTabPanel.Padding = new System.Windows.Forms.Padding(3);
            this.importTabPanel.Size = new System.Drawing.Size(842, 650);
            this.importTabPanel.TabIndex = 0;
            this.importTabPanel.Text = "Import";
            // 
            // cleanupTabPanel
            // 
            this.cleanupTabPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            this.cleanupTabPanel.Controls.Add(this.label5);
            this.cleanupTabPanel.Controls.Add(this.cleanupInfo);
            this.cleanupTabPanel.Controls.Add(this.processCleanupButton);
            this.cleanupTabPanel.Controls.Add(this.label4);
            this.cleanupTabPanel.Controls.Add(this.selectedFolder);
            this.cleanupTabPanel.Controls.Add(this.folderSelectButton);
            this.cleanupTabPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cleanupTabPanel.Location = new System.Drawing.Point(4, 25);
            this.cleanupTabPanel.Name = "cleanupTabPanel";
            this.cleanupTabPanel.Padding = new System.Windows.Forms.Padding(3);
            this.cleanupTabPanel.Size = new System.Drawing.Size(842, 650);
            this.cleanupTabPanel.TabIndex = 1;
            this.cleanupTabPanel.Text = "Cleanup";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Unicode MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(133)))), ((int)(((byte)(239)))));
            this.label5.Location = new System.Drawing.Point(236, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(379, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "Media Center File Cleanup Processor";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cleanupInfo
            // 
            this.cleanupInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            this.cleanupInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cleanupInfo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.cleanupInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(114)))), ((int)(((byte)(206)))));
            this.cleanupInfo.FormattingEnabled = true;
            this.cleanupInfo.ItemHeight = 17;
            this.cleanupInfo.Location = new System.Drawing.Point(11, 81);
            this.cleanupInfo.Name = "cleanupInfo";
            this.cleanupInfo.Size = new System.Drawing.Size(823, 478);
            this.cleanupInfo.TabIndex = 10;
            // 
            // processCleanupButton
            // 
            this.processCleanupButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.processCleanupButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.processCleanupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.processCleanupButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.processCleanupButton.FlatAppearance.BorderSize = 0;
            this.processCleanupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.processCleanupButton.Font = new System.Drawing.Font("Arial", 9F);
            this.processCleanupButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            this.processCleanupButton.Location = new System.Drawing.Point(11, 582);
            this.processCleanupButton.Name = "processCleanupButton";
            this.processCleanupButton.Size = new System.Drawing.Size(823, 60);
            this.processCleanupButton.TabIndex = 9;
            this.processCleanupButton.Text = "Process";
            this.processCleanupButton.UseVisualStyleBackColor = false;
            this.processCleanupButton.Click += new System.EventHandler(this.processCleanupButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            this.label4.Location = new System.Drawing.Point(11, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Selected Folder:";
            // 
            // selectedFolder
            // 
            this.selectedFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            this.selectedFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectedFolder.Font = new System.Drawing.Font("Arial", 10F);
            this.selectedFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(114)))), ((int)(((byte)(206)))));
            this.selectedFolder.Location = new System.Drawing.Point(129, 43);
            this.selectedFolder.Name = "selectedFolder";
            this.selectedFolder.Size = new System.Drawing.Size(576, 23);
            this.selectedFolder.TabIndex = 6;
            // 
            // folderSelectButton
            // 
            this.folderSelectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.folderSelectButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.folderSelectButton.FlatAppearance.BorderSize = 0;
            this.folderSelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.folderSelectButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderSelectButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            this.folderSelectButton.Location = new System.Drawing.Point(711, 40);
            this.folderSelectButton.Name = "folderSelectButton";
            this.folderSelectButton.Size = new System.Drawing.Size(121, 27);
            this.folderSelectButton.TabIndex = 7;
            this.folderSelectButton.Text = "Select Folder";
            this.folderSelectButton.UseVisualStyleBackColor = false;
            this.folderSelectButton.Click += new System.EventHandler(this.folderSelectButton_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.suffixLabel);
            this.tabPage1.Controls.Add(this.suffixEntry);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.smcList);
            this.tabPage1.Controls.Add(this.smcProcessButton);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.smcPath);
            this.tabPage1.Controls.Add(this.smcFolderSelect);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(842, 650);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Add Suffix";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Unicode MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(133)))), ((int)(((byte)(239)))));
            this.label6.Location = new System.Drawing.Point(235, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(294, 26);
            this.label6.TabIndex = 17;
            this.label6.Text = "Media Center File Add Suffix";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // smcList
            // 
            this.smcList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            this.smcList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smcList.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.smcList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(114)))), ((int)(((byte)(206)))));
            this.smcList.FormattingEnabled = true;
            this.smcList.ItemHeight = 17;
            this.smcList.Location = new System.Drawing.Point(10, 135);
            this.smcList.Name = "smcList";
            this.smcList.Size = new System.Drawing.Size(823, 427);
            this.smcList.TabIndex = 16;
            this.smcList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // smcProcessButton
            // 
            this.smcProcessButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.smcProcessButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.smcProcessButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.smcProcessButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.smcProcessButton.FlatAppearance.BorderSize = 0;
            this.smcProcessButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smcProcessButton.Font = new System.Drawing.Font("Arial", 9F);
            this.smcProcessButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            this.smcProcessButton.Location = new System.Drawing.Point(10, 585);
            this.smcProcessButton.Name = "smcProcessButton";
            this.smcProcessButton.Size = new System.Drawing.Size(823, 60);
            this.smcProcessButton.TabIndex = 15;
            this.smcProcessButton.Text = "Process";
            this.smcProcessButton.UseVisualStyleBackColor = false;
            this.smcProcessButton.Click += new System.EventHandler(this.smcProcessButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            this.label7.Location = new System.Drawing.Point(10, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Selected Folder:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // smcPath
            // 
            this.smcPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            this.smcPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smcPath.Font = new System.Drawing.Font("Arial", 10F);
            this.smcPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(114)))), ((int)(((byte)(206)))));
            this.smcPath.Location = new System.Drawing.Point(128, 46);
            this.smcPath.Name = "smcPath";
            this.smcPath.Size = new System.Drawing.Size(576, 23);
            this.smcPath.TabIndex = 12;
            this.smcPath.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // smcFolderSelect
            // 
            this.smcFolderSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.smcFolderSelect.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.smcFolderSelect.FlatAppearance.BorderSize = 0;
            this.smcFolderSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smcFolderSelect.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smcFolderSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            this.smcFolderSelect.Location = new System.Drawing.Point(710, 43);
            this.smcFolderSelect.Name = "smcFolderSelect";
            this.smcFolderSelect.Size = new System.Drawing.Size(121, 27);
            this.smcFolderSelect.TabIndex = 13;
            this.smcFolderSelect.Text = "Select Folder";
            this.smcFolderSelect.UseVisualStyleBackColor = false;
            this.smcFolderSelect.Click += new System.EventHandler(this.smcFolderSelect_Click);
            // 
            // suffixLabel
            // 
            this.suffixLabel.AutoSize = true;
            this.suffixLabel.Font = new System.Drawing.Font("Arial", 10F);
            this.suffixLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            this.suffixLabel.Location = new System.Drawing.Point(10, 91);
            this.suffixLabel.Name = "suffixLabel";
            this.suffixLabel.Size = new System.Drawing.Size(46, 16);
            this.suffixLabel.TabIndex = 19;
            this.suffixLabel.Text = "Suffix:";
            // 
            // suffixEntry
            // 
            this.suffixEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            this.suffixEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.suffixEntry.Font = new System.Drawing.Font("Arial", 10F);
            this.suffixEntry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(114)))), ((int)(((byte)(206)))));
            this.suffixEntry.Location = new System.Drawing.Point(128, 89);
            this.suffixEntry.Name = "suffixEntry";
            this.suffixEntry.Size = new System.Drawing.Size(576, 23);
            this.suffixEntry.TabIndex = 18;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(850, 679);
            this.Controls.Add(this.processorTabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.Text = "Media Center File Processor";
            this.importPanel.ResumeLayout(false);
            this.importPanel.PerformLayout();
            this.processorTabs.ResumeLayout(false);
            this.importTabPanel.ResumeLayout(false);
            this.cleanupTabPanel.ResumeLayout(false);
            this.cleanupTabPanel.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel importPanel;
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
        private System.Windows.Forms.TabControl processorTabs;
        private System.Windows.Forms.TabPage importTabPanel;
        private System.Windows.Forms.TabPage cleanupTabPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox selectedFolder;
        private System.Windows.Forms.Button folderSelectButton;
        private System.Windows.Forms.Button processCleanupButton;
        private System.Windows.Forms.ListBox cleanupInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox smcList;
        private System.Windows.Forms.Button smcProcessButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox smcPath;
        private System.Windows.Forms.Button smcFolderSelect;
        private System.Windows.Forms.Label suffixLabel;
        private System.Windows.Forms.TextBox suffixEntry;
    }
}

