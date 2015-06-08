using System;
using System.Windows.Forms;
using Container.Properties;

namespace Container
{
    public partial class ContainerForm : Form
    {
        private MyContainer _currentContainer;
        private string _extractingPath = Resources.DefaultPath;
        private string _selectedFile;

        public ContainerForm()
        {
            InitializeComponent();
        }

        private void CreateContainer_Click(object sender, EventArgs e)
        {
            string containerName = name.Text;
            _currentContainer = new MyContainer(containerName);

            var myFileDialog = new OpenFileDialog {Multiselect = true};
            if (myFileDialog.ShowDialog() != DialogResult.OK)
                return;

            status.Text = Resources.Please_wait;
            bool success = false;
            foreach (string file in myFileDialog.FileNames)
            {
                if (_currentContainer.Path != myFileDialog.FileName)
                {
                    success = _currentContainer.AddFile(file, Files);
                }
            }
            ChangeLabel(success, status);
            name.Text = "";
        }

        private void AddFile_Click(object sender, EventArgs e)
        {
            var myFileDialog = new OpenFileDialog {Multiselect = true};

            if (myFileDialog.ShowDialog() != DialogResult.OK) return;
            statusAdd.Text = Resources.Please_wait;
            bool success = false;
            foreach (string file in myFileDialog.FileNames)
            {
                success = _currentContainer.AddFile(file, Files);
            }
            ChangeLabel(success, statusAdd);
        }

        private void AddFolder_Click(object sender, EventArgs e)
        {
            var myFolderDialog = new FolderBrowserDialog();
            if (myFolderDialog.ShowDialog() != DialogResult.OK) return;

            statusAdd.Text = Resources.Please_wait;
            Cursor = Cursors.WaitCursor;
            Application.DoEvents();
            string folderPath = myFolderDialog.SelectedPath;
            //variable to contain index of start name of main folder in path
            int indexFolder = folderPath.LastIndexOf(@"\", StringComparison.Ordinal) + 1;
                // add one to keep symbol "\" in string
            bool success = _currentContainer.AddFileToFolder(myFolderDialog.SelectedPath, indexFolder, Files);
            ChangeLabel(success, statusAdd);

            Cursor = Cursors.Default;
        }

        private void ExtractAllFiles_Click(object sender, EventArgs e)
        {
            statusExtract.Text = Resources.Please_wait;
            bool success = _currentContainer.ExtractAllFiles(_extractingPath);
            ChangeLabel(success, statusExtract);
        }

        private void Files_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedFile = Files.SelectedItem.ToString();
        }

        private void ExtractFile_Click(object sender, EventArgs e)
        {
            statusExtract.Text = Resources.Please_wait;
            bool success = _currentContainer.ExtractFile(_selectedFile, _extractingPath);
            ChangeLabel(success, statusExtract);
        }

        private void SelectContainer_Click(object sender, EventArgs e)
        {
            Files.Items.Clear();
            _currentContainer = new MyContainer();
            if (_currentContainer.Path == null)
                return;

            selectContainerAdd.Text = Resources.Select_container + _currentContainer.Path;
            selectContainerExtract.Text = selectContainerAdd.Text;
            _currentContainer.AddAllFilesToComboBox(Files);

            SelectFolderToExtract.Enabled = true;
            AddFile.Enabled = true;
            AddFolder.Enabled = true;
        }

        private void SelectFolderToExtract_Click(object sender, EventArgs e)
        {
            var folder = new FolderBrowserDialog();
            if (folder.ShowDialog() != DialogResult.OK)
                return;
            _extractingPath = folder.SelectedPath;

            ExtractAllFiles.Enabled = true;
            ExtractFile.Enabled = true;
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            CreateContainer.Enabled = ! string.IsNullOrEmpty(name.Text);
        }

        private void Tabs_selectedIndexChanged(object sender, EventArgs e)
        {
            switch (Tabs.SelectedIndex)
            {
                case 0:
                    SelectContainer.Enabled = false;
                    Files.Enabled = false;
                    break;
                case 1:
                    SelectContainer.Enabled = true;
                    Files.Enabled = false;
                    break;
                case 2:
                    SelectContainer.Enabled = true;
                    Files.Enabled = true;
                    break;
            }
        }

        private void ChangeLabel(bool success, Label label)
        {
            if (!success)
                return;
            switch (label.Name)
            {
                case "statusExtract":
                    statusExtract.Text = Resources.File_has_been_extracted;
                    break;
                case "status":
                    status.Text = Resources.Status_container_has_been_created + "\n" + _currentContainer.Path;
                    break;
                case "statusAdd":
                    statusAdd.Text = Resources.Files_have_been_added_to_container;
                    break;
            }
        }
    }
}