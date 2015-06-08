using System;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;
using Container.Properties;

namespace Container
{
    public class MyContainer
    {
        public string Path;

        /// <summary>
        ///     Constructor initializes class instance and creates container-file with name in parametr.
        /// </summary>
        /// <param name="name">Name of creating container</param>
        public MyContainer(string name)
        {
            try
            {
                var folder = new FolderBrowserDialog();
                if (folder.ShowDialog() == DialogResult.OK)
                {
                    Path = folder.SelectedPath;
                }
                Path += @"\" + name + ".cnt";
                if (File.Exists(Path)) return;
                using (ZipFile.Open(Path, ZipArchiveMode.Create))
                {
                }
            }
            catch (Exception)
            {
                throw new Exception("Error while attempts to create container");
            }
        }

        /// <summary>
        ///     Default constructor. It doesn't create new container-file, but it
        ///     initializes class instance. It is useful in work with
        ///     existing container.
        /// </summary>
        public MyContainer()
        {
            try
            {
                var fileDialogContainer = new OpenFileDialog {Filter = Resources.FilterForSearch};
                if (fileDialogContainer.ShowDialog() != DialogResult.OK) return;
                Path = fileDialogContainer.FileName;
            }
            catch (Exception)
            {
                throw new Exception("Error in container while attempts to select exsiting container");
            }
        }

        /// <summary>
        ///     Method for adding file to container. It open container and create entry,
        ///     will add entry's name to combobox with all entries' names.
        /// </summary>
        /// <param name="filePath"> path to file that should be added</param>
        /// <param name="files">combobox with all entries' names</param>
        /// <returns>true if success</returns>
        public bool AddFile(string filePath, ComboBox files)
        {
            try
            {
                using (ZipArchive archive = ZipFile.Open(Path, ZipArchiveMode.Update))
                {
                    if (filePath == null) return false;

                    string name = GetEntryName(filePath);
                    archive.CreateEntryFromFile(filePath, name);
                    files.Items.Add(name);
                }
                return true;
            }
            catch (Exception)
            {
                throw new Exception("Error in container while attempts to add file to existing container");
            }
        }

        /// <summary>
        ///     Get name of entry by cutting entry's full name
        /// </summary>
        /// <param name="fullName">Entry's full name, that should be cut</param>
        /// <returns>Entry's name</returns>
        private string GetEntryName(string fullName)
        {
            int indexFile = fullName.LastIndexOf(@"\", StringComparison.Ordinal) + 1;
                // add one to keep "\" in string name;
            string name = fullName.Substring(indexFile, fullName.Length - indexFile);
            return name;
        }

        /// <summary>
        ///     Function for adding selected folder. It calls recursively itself to add every file in
        ///     selected folder and subfolders.
        ///     All files' names will be in combobox.
        /// </summary>
        /// <param name="folderPath">Path to selected folder</param>
        /// <param name="indexMainFolder">
        ///     a number that indicates the beginning
        ///     of the folder name in the full directory path (used in work with subfolders)
        /// </param>
        /// <param name="files">comboBox with all entries' names</param>
        /// <returns>true if success</returns>
        public bool AddFileToFolder(string folderPath, int indexMainFolder, ComboBox files)
        {
            try
            {
                string folder = folderPath.Substring(indexMainFolder, folderPath.Length - indexMainFolder);

                // walk all subfolders as tree. 
                string[] directories = Directory.GetDirectories(folderPath);
                foreach (string directoryPath in directories)
                {
                    AddFileToFolder(directoryPath, indexMainFolder, files);
                }

                string[] filePaths = Directory.GetFiles(folderPath);

                foreach (string fileName in filePaths)
                {
                    if (fileName == null) continue;

                    string name = GetEntryName(fileName);
                    name = folder + @"\" + name;
                    using (ZipArchive archive = ZipFile.Open(Path, ZipArchiveMode.Update))
                    {
                        archive.CreateEntryFromFile(fileName, name);
                        files.Items.Add(name);
                    }
                }
                return true;
            }
            catch (Exception)
            {
                throw new Exception("Error in container while attempts to add folder to existing container");
            }
        }

        /// <summary>
        ///     Function for extracting selected file. It checks existing file with same name in
        ///     selected folder for extracting, if it exsist, function tries to add "(1)" to
        ///     the name of file. if file with this name exists too func add "(2)", "(3)" and ect.
        ///     while finds index, that is not exist.
        /// </summary>
        /// <param name="fileName">Name of file that should be extracted</param>
        /// <param name="extractingPath">Folder path, that was selected for extracting</param>
        /// <returns>true if success</returns>
        public bool ExtractFile(string fileName, string extractingPath)
        {
            try
            {
                using (ZipArchive archive = ZipFile.Open(Path, ZipArchiveMode.Read))
                {
                    foreach (ZipArchiveEntry entry in archive.Entries)
                    {
                        string exctractPath = extractingPath + @"\" + entry.FullName;

                        if (entry.FullName != fileName) continue;

                        if (File.Exists(exctractPath))
                        {
                            int index = 1;
                            while (File.Exists(exctractPath))
                            {
                                string name = entry.FullName;
                                int cut = name.LastIndexOf(".", StringComparison.Ordinal);
                                string extention = name.Substring(cut, name.Length - cut);
                                name = name.Substring(0, cut);
                                exctractPath = extractingPath + @"\" + name + "(" + index + ")" + extention;
                                index ++;
                            }
                        }
                        if (entry.FullName.Contains(@"\"))
                        {
                            string directoryPath = extractingPath + @"\" +
                                                   entry.FullName.Substring(0, entry.FullName.Length - entry.Name.Length);
                            Directory.CreateDirectory(directoryPath);
                        }
                        entry.ExtractToFile(exctractPath);
                    }
                }
                return true;
            }
            catch (Exception)
            {
                throw new Exception("Error in container while attempts to extract file from container");
            }
        }

        /// <summary>
        ///     Func for extracting all filsed from container.
        /// </summary>
        /// <param name="extractingPath">Folder path for extracting files</param>
        /// <returns>true if success</returns>
        public bool ExtractAllFiles(string extractingPath)
        {
            try
            {
                using (ZipArchive archive = ZipFile.Open(Path, ZipArchiveMode.Read))
                {
                    foreach (ZipArchiveEntry entry in archive.Entries)
                    {
                        ExtractFile(entry.FullName, extractingPath);
                    }
                }
                return true;
            }
            catch (Exception)
            {
                throw new Exception("Error in container while attempts to extract all files from container");
            }
        }

        /// <summary>
        ///     Func for adding entries' names to comboBox
        /// </summary>
        /// <param name="files">comboBox for adding items</param>
        public void AddAllFilesToComboBox(ComboBox files)
        {
            using (ZipArchive archive = ZipFile.Open(Path, ZipArchiveMode.Read))
            {
                foreach (ZipArchiveEntry entry in archive.Entries)
                {
                    files.Items.Add(entry);
                }
            }
        }
    }
}