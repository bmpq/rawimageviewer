using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rawimageviewer
{
    public partial class FormBrowser : Form
    {
        private Form1 mainForm; // is this the right way to do this??

        private const int PAGE_SIZE = 1000;
        private int page;

        private class FileData
        {
            public string ID { get; set; }
            public string FilePath { get; set; }
            public DateTime CreationDate { get; set; }
            public long Size { get; set; }

            public string CreationDateString
            {
                get
                {
                    return CreationDate.ToString("dd-MMM hh:mm:ss.fff");
                }
            }

            public string TimeSinceCreation
            {
                get
                {
                    TimeSpan elapsed = DateTime.Now - CreationDate;

                    string text;
                    int n = 1;

                    if (elapsed.TotalDays >= 1)
                    {
                        n = (int)elapsed.TotalDays;
                        text = n + " day";
                    }
                    else if (elapsed.TotalHours >= 1)
                    {
                        n = (int)elapsed.TotalHours;
                        text = n + " hour";
                    }
                    else if (elapsed.TotalMinutes >= 1)
                    {
                        n = (int)elapsed.TotalMinutes;
                        text = n + " minute";
                    }
                    else
                    {
                        n = (int)elapsed.TotalSeconds;
                        text = n + " second";
                    }

                    // plural
                    if (n > 1)
                        text += "s";

                    text += " ago";

                    return text;
                }
            }

            public string SizeString
            {
                get
                {
                    return Utils.FormatFileSize(Size);
                }
            }
        }

        List<FileData> files;

        public FormBrowser(Form1 mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        public void OpenMostRecent()
        {
            LoadAllCache(Configuration.DiskCachePath);

            if (files == null || files.Count == 0)
            {
                Close();
                return;
            }

            mainForm.LoadFile(files[0].FilePath);
            mainForm.ReadMetadata();

            DisplayList(files[0]);
        }

        public void OpenCacheFolderFromImage(string pathImg)
        {
            var dir = Directory.GetParent(pathImg);

            if (dir == null || dir.Parent == null)
            {
                Close();
                return;
            }

            if (Configuration.DiskCachePath != dir.Parent.FullName)
            {
                Configuration.DiskCachePath = dir.Parent.FullName;
                Configuration.Save();
            }

            if (files == null || files.Count == 0)
            {
                LoadAllCache(Configuration.DiskCachePath);
                DisplayList(pathImg);
            }
        }

        void DisplayList(string pathOpenedFile)
        {
            if (files == null || files.Count == 0)
                LoadAllCache(Configuration.DiskCachePath);

            FileData fileData = files.FirstOrDefault(x => x.FilePath == pathOpenedFile, null);

            DisplayList(fileData);
        }

        void DisplayList(FileData openedFile)
        {
            if (files == null)
                LoadAllCache(Configuration.DiskCachePath);

            int desiredPage = 1;

            if (openedFile == null)
            {
                desiredPage = page;
            }
            else
            {
                int selectedFileIndex = files.IndexOf(openedFile);
                desiredPage = (selectedFileIndex / PAGE_SIZE) + 1;
            }
            
            DisplayList(page, openedFile);
        }

        void DisplayList(int page, FileData openedFile)
        {
            page = Math.Clamp(page, 1, GetTotalPages());
            this.page = page;

            // Calculate the start and end indices for the current page
            int startIndex = (page - 1) * PAGE_SIZE;
            int endIndex = Math.Min(startIndex + PAGE_SIZE, files.Count);

            // Get the files for the current page
            List<FileData> filesForPage = files.GetRange(startIndex, endIndex - startIndex);

            listView1.BeginUpdate();
            listView1.Items.Clear();

            foreach (var file in filesForPage)
            {
                ListViewItem item = new ListViewItem(file.ID);
                item.SubItems.Add(file.CreationDateString + "  (" + file.TimeSinceCreation + ")");
                item.SubItems.Add(file.SizeString);

                item.Tag = file;

                item.Selected = (file == openedFile);

                listView1.Items.Add(item);
            }

            listView1.EndUpdate();

            inputPage.Text = page.ToString();
            int totalPages = GetTotalPages();
            textPagesTotal.Text = "/ " + totalPages.ToString();

            btnPageNext.Enabled = page < totalPages;
            btnPagePrev.Enabled = page > 1;
        }

        private int GetTotalPages()
        {
            int totalPages = files.Count / PAGE_SIZE;
            if (files.Count % PAGE_SIZE > 0)
            {
                totalPages++;
            }
            return totalPages;
        }

        private void FormBrowser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    DeleteSelectedFrames();
                }
            }
        }

        private void DeleteSelectedFrames()
        {
            string message = "Are you sure you want to permanently delete " + listView1.SelectedItems.Count + " file(s)?";
            string title = "Confirm Delete";

            DialogResult dialogResult = MessageBox.Show(
                message, 
                title, 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question, 
                MessageBoxDefaultButton.Button2);

            if (dialogResult == DialogResult.Yes)
            {
                for (int i = 0; i < listView1.SelectedItems.Count; i++)
                {
                    FileData fileData = (FileData)listView1.SelectedItems[i].Tag;

                    System.IO.File.Delete(fileData.FilePath);
                }

                ScanFolderAndDisplay();
                mainForm.LoadFile("");
            }
        }

        private void LoadAllCache(string dir)
        {
            try
            {
                files = GetFilesRecursively(dir);
                files.Sort((f2, f1) => f1.CreationDate.CompareTo(f2.CreationDate));
            }
            catch
            {
                MessageBox.Show("Error scanning path:\n" + dir);
                return;
            }

            textFramesAmount.Text = "Frames: " + files.Count;
            textPath.Text = dir;
        }

        private List<FileData> GetFilesRecursively(string path)
        {
            List<FileData> Files = new List<FileData>();
            try
            {
                foreach (string d in Directory.GetDirectories(path))
                {
                    foreach (FileInfo f in new DirectoryInfo(d).GetFiles())
                    {
                        if (f.Extension != ".aecache")
                            continue;

                        Files.Add(
                            new FileData 
                            {
                                ID = f.Name.Substring(0, f.Name.Length - f.Extension.Length),
                                FilePath = f.FullName, 
                                CreationDate = f.CreationTime,
                                Size = f.Length
                            });
                    }
                    Files.AddRange(GetFilesRecursively(d));
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Files;
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            ScanFolderAndDisplay();
        }

        private void ScanFolderAndDisplay()
        {
            textFramesAmount.Text = "";
            listView1.SelectedItems.Clear();
            listView1.Items.Clear();
            LoadAllCache(Configuration.DiskCachePath);
            DisplayList(mainForm.loadedFilePath);
        }

        private void textPath_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Configuration.DiskCachePath))
            {
                Process.Start(new ProcessStartInfo()
                {
                    FileName = Configuration.DiskCachePath + Path.DirectorySeparatorChar,
                    UseShellExecute = true,
                    Verb = "open"
                });
            };
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;

            FileData selectedFile = (FileData)listView1.SelectedItems[0].Tag;
            if (selectedFile.FilePath == mainForm.loadedFilePath)
                return;

            bool loaded = mainForm.LoadFile(selectedFile.FilePath);
            if (loaded)
                mainForm.ReadMetadata();
        }

        private void btnPageNext_Click(object sender, EventArgs e)
        {
            DisplayList(page + 1, null);
        }

        private void btnPagePrev_Click(object sender, EventArgs e)
        {
            DisplayList(page - 1, null);
        }

        private void inputPage_TextChanged(object sender, EventArgs e)
        {
            int p = page;
            int.TryParse(inputPage.Text, out p);

            if (p == page)
                return;

            DisplayList(p, null);
        }
    }
}
