namespace Container
{
    partial class ContainerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContainerForm));
            this.CreateContainer = new System.Windows.Forms.Button();
            this.Print_name = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.AddFile = new System.Windows.Forms.Button();
            this.AddFolder = new System.Windows.Forms.Button();
            this.ExtractFile = new System.Windows.Forms.Button();
            this.ExtractAllFiles = new System.Windows.Forms.Button();
            this.Files = new System.Windows.Forms.ComboBox();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.Creating = new System.Windows.Forms.TabPage();
            this.status = new System.Windows.Forms.Label();
            this.Adding = new System.Windows.Forms.TabPage();
            this.statusAdd = new System.Windows.Forms.Label();
            this.selectContainerAdd = new System.Windows.Forms.Label();
            this.Extracton = new System.Windows.Forms.TabPage();
            this.statusExtract = new System.Windows.Forms.Label();
            this.SelectFolderToExtract = new System.Windows.Forms.Button();
            this.selectContainerExtract = new System.Windows.Forms.Label();
            this.SelectContainer = new System.Windows.Forms.Button();
            this.FilesInContainer = new System.Windows.Forms.Label();
            this.Tabs.SuspendLayout();
            this.Creating.SuspendLayout();
            this.Adding.SuspendLayout();
            this.Extracton.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateContainer
            // 
            this.CreateContainer.Enabled = false;
            this.CreateContainer.Location = new System.Drawing.Point(82, 59);
            this.CreateContainer.Name = "CreateContainer";
            this.CreateContainer.Size = new System.Drawing.Size(100, 39);
            this.CreateContainer.TabIndex = 0;
            this.CreateContainer.Text = "Create new container";
            this.CreateContainer.UseVisualStyleBackColor = true;
            this.CreateContainer.Click += new System.EventHandler(this.CreateContainer_Click);
            // 
            // Print_name
            // 
            this.Print_name.AutoSize = true;
            this.Print_name.Location = new System.Drawing.Point(6, 16);
            this.Print_name.Name = "Print_name";
            this.Print_name.Size = new System.Drawing.Size(114, 13);
            this.Print_name.TabIndex = 1;
            this.Print_name.Text = "Print container\'s name:";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(6, 32);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(259, 20);
            this.name.TabIndex = 2;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // AddFile
            // 
            this.AddFile.Enabled = false;
            this.AddFile.Location = new System.Drawing.Point(3, 78);
            this.AddFile.Name = "AddFile";
            this.AddFile.Size = new System.Drawing.Size(100, 33);
            this.AddFile.TabIndex = 3;
            this.AddFile.Text = "Add new file";
            this.AddFile.UseVisualStyleBackColor = true;
            this.AddFile.Click += new System.EventHandler(this.AddFile_Click);
            // 
            // AddFolder
            // 
            this.AddFolder.Enabled = false;
            this.AddFolder.Location = new System.Drawing.Point(168, 78);
            this.AddFolder.Name = "AddFolder";
            this.AddFolder.Size = new System.Drawing.Size(100, 33);
            this.AddFolder.TabIndex = 4;
            this.AddFolder.Text = "Add folder";
            this.AddFolder.UseVisualStyleBackColor = true;
            this.AddFolder.Click += new System.EventHandler(this.AddFolder_Click);
            // 
            // ExtractFile
            // 
            this.ExtractFile.Enabled = false;
            this.ExtractFile.Location = new System.Drawing.Point(3, 78);
            this.ExtractFile.Name = "ExtractFile";
            this.ExtractFile.Size = new System.Drawing.Size(100, 33);
            this.ExtractFile.TabIndex = 5;
            this.ExtractFile.Text = "Extract file";
            this.ExtractFile.UseVisualStyleBackColor = true;
            this.ExtractFile.Click += new System.EventHandler(this.ExtractFile_Click);
            // 
            // ExtractAllFiles
            // 
            this.ExtractAllFiles.Enabled = false;
            this.ExtractAllFiles.Location = new System.Drawing.Point(168, 78);
            this.ExtractAllFiles.Name = "ExtractAllFiles";
            this.ExtractAllFiles.Size = new System.Drawing.Size(100, 33);
            this.ExtractAllFiles.TabIndex = 6;
            this.ExtractAllFiles.Text = "Extract all files";
            this.ExtractAllFiles.UseVisualStyleBackColor = true;
            this.ExtractAllFiles.Click += new System.EventHandler(this.ExtractAllFiles_Click);
            // 
            // Files
            // 
            this.Files.CausesValidation = false;
            this.Files.Enabled = false;
            this.Files.Location = new System.Drawing.Point(147, 208);
            this.Files.Name = "Files";
            this.Files.Size = new System.Drawing.Size(130, 21);
            this.Files.TabIndex = 7;
            this.Files.SelectedIndexChanged += new System.EventHandler(this.Files_SelectedIndexChanged);
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.Creating);
            this.Tabs.Controls.Add(this.Adding);
            this.Tabs.Controls.Add(this.Extracton);
            this.Tabs.Location = new System.Drawing.Point(8, 12);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(279, 167);
            this.Tabs.TabIndex = 8;
            this.Tabs.SelectedIndexChanged += new System.EventHandler(this.Tabs_selectedIndexChanged);
            // 
            // Creating
            // 
            this.Creating.Controls.Add(this.status);
            this.Creating.Controls.Add(this.CreateContainer);
            this.Creating.Controls.Add(this.name);
            this.Creating.Controls.Add(this.Print_name);
            this.Creating.Location = new System.Drawing.Point(4, 22);
            this.Creating.Name = "Creating";
            this.Creating.Padding = new System.Windows.Forms.Padding(3);
            this.Creating.Size = new System.Drawing.Size(271, 141);
            this.Creating.TabIndex = 0;
            this.Creating.Text = "Creating";
            this.Creating.UseVisualStyleBackColor = true;
            // 
            // status
            // 
            this.status.AutoEllipsis = true;
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(4, 118);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(42, 17);
            this.status.TabIndex = 3;
            this.status.Text = "Status: ";
            this.status.UseCompatibleTextRendering = true;
            // 
            // Adding
            // 
            this.Adding.Controls.Add(this.statusAdd);
            this.Adding.Controls.Add(this.selectContainerAdd);
            this.Adding.Controls.Add(this.AddFile);
            this.Adding.Controls.Add(this.AddFolder);
            this.Adding.Location = new System.Drawing.Point(4, 22);
            this.Adding.Name = "Adding";
            this.Adding.Padding = new System.Windows.Forms.Padding(3);
            this.Adding.Size = new System.Drawing.Size(271, 141);
            this.Adding.TabIndex = 1;
            this.Adding.Text = "Adding";
            this.Adding.UseVisualStyleBackColor = true;
            // 
            // statusAdd
            // 
            this.statusAdd.AutoSize = true;
            this.statusAdd.Location = new System.Drawing.Point(4, 118);
            this.statusAdd.Name = "statusAdd";
            this.statusAdd.Size = new System.Drawing.Size(43, 13);
            this.statusAdd.TabIndex = 6;
            this.statusAdd.Text = "Status: ";
            // 
            // selectContainerAdd
            // 
            this.selectContainerAdd.AutoSize = true;
            this.selectContainerAdd.Location = new System.Drawing.Point(0, 21);
            this.selectContainerAdd.Name = "selectContainerAdd";
            this.selectContainerAdd.Size = new System.Drawing.Size(210, 13);
            this.selectContainerAdd.TabIndex = 5;
            this.selectContainerAdd.Text = "Click button \"Select container\" to add data";
            // 
            // Extracton
            // 
            this.Extracton.Controls.Add(this.statusExtract);
            this.Extracton.Controls.Add(this.SelectFolderToExtract);
            this.Extracton.Controls.Add(this.selectContainerExtract);
            this.Extracton.Controls.Add(this.ExtractFile);
            this.Extracton.Controls.Add(this.ExtractAllFiles);
            this.Extracton.Location = new System.Drawing.Point(4, 22);
            this.Extracton.Name = "Extracton";
            this.Extracton.Padding = new System.Windows.Forms.Padding(3);
            this.Extracton.Size = new System.Drawing.Size(271, 141);
            this.Extracton.TabIndex = 2;
            this.Extracton.Text = "Extracting";
            this.Extracton.UseVisualStyleBackColor = true;
            // 
            // statusExtract
            // 
            this.statusExtract.AutoSize = true;
            this.statusExtract.Location = new System.Drawing.Point(4, 118);
            this.statusExtract.Name = "statusExtract";
            this.statusExtract.Size = new System.Drawing.Size(40, 13);
            this.statusExtract.TabIndex = 9;
            this.statusExtract.Text = "Status:";
            // 
            // SelectFolderToExtract
            // 
            this.SelectFolderToExtract.Enabled = false;
            this.SelectFolderToExtract.Location = new System.Drawing.Point(3, 37);
            this.SelectFolderToExtract.Name = "SelectFolderToExtract";
            this.SelectFolderToExtract.Size = new System.Drawing.Size(262, 35);
            this.SelectFolderToExtract.TabIndex = 8;
            this.SelectFolderToExtract.Text = "Select folder to extract";
            this.SelectFolderToExtract.UseVisualStyleBackColor = true;
            this.SelectFolderToExtract.Click += new System.EventHandler(this.SelectFolderToExtract_Click);
            // 
            // selectContainerExtract
            // 
            this.selectContainerExtract.AutoSize = true;
            this.selectContainerExtract.Location = new System.Drawing.Point(3, 3);
            this.selectContainerExtract.Name = "selectContainerExtract";
            this.selectContainerExtract.Size = new System.Drawing.Size(224, 13);
            this.selectContainerExtract.TabIndex = 7;
            this.selectContainerExtract.Text = "Click button \"Select container\" to extract data";
            // 
            // SelectContainer
            // 
            this.SelectContainer.Enabled = false;
            this.SelectContainer.Location = new System.Drawing.Point(21, 191);
            this.SelectContainer.Name = "SelectContainer";
            this.SelectContainer.Size = new System.Drawing.Size(90, 38);
            this.SelectContainer.TabIndex = 9;
            this.SelectContainer.Text = "Select container";
            this.SelectContainer.UseVisualStyleBackColor = true;
            this.SelectContainer.Click += new System.EventHandler(this.SelectContainer_Click);
            // 
            // FilesInContainer
            // 
            this.FilesInContainer.AutoSize = true;
            this.FilesInContainer.Location = new System.Drawing.Point(144, 182);
            this.FilesInContainer.Name = "FilesInContainer";
            this.FilesInContainer.Size = new System.Drawing.Size(86, 13);
            this.FilesInContainer.TabIndex = 10;
            this.FilesInContainer.Text = "Files in container";
            // 
            // ContainerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 241);
            this.Controls.Add(this.FilesInContainer);
            this.Controls.Add(this.SelectContainer);
            this.Controls.Add(this.Tabs);
            this.Controls.Add(this.Files);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ContainerForm";
            this.Text = "Container";
            this.Tabs.ResumeLayout(false);
            this.Creating.ResumeLayout(false);
            this.Creating.PerformLayout();
            this.Adding.ResumeLayout(false);
            this.Adding.PerformLayout();
            this.Extracton.ResumeLayout(false);
            this.Extracton.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateContainer;
        private System.Windows.Forms.Label Print_name;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button AddFile;
        private System.Windows.Forms.Button AddFolder;
        private System.Windows.Forms.Button ExtractFile;
        private System.Windows.Forms.Button ExtractAllFiles;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage Creating;
        private System.Windows.Forms.TabPage Adding;
        private System.Windows.Forms.TabPage Extracton;
        private System.Windows.Forms.Button SelectContainer;
        private System.Windows.Forms.Label FilesInContainer;
        private System.Windows.Forms.Label selectContainerAdd;
        private System.Windows.Forms.Label selectContainerExtract;
        private System.Windows.Forms.Button SelectFolderToExtract;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label statusAdd;
        private System.Windows.Forms.Label statusExtract;
        private System.Windows.Forms.ComboBox Files;
    }
}

