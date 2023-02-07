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
using static System.Net.WebRequestMethods;

namespace rawimageviewer
{
    public partial class FormBrowser : Form
    {
        private Form1 mainForm; // is this the right way to do this??

        private const int MAX_ITEMS = 1000;

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
                    return elapsed.TotalDays >= 1 ? (int)elapsed.TotalDays + " day(s) ago"
                        : elapsed.TotalHours >= 1 ? (int)elapsed.TotalHours + " hour(s) ago"
                        : elapsed.TotalMinutes >= 1 ? (int)elapsed.TotalMinutes + " minute(s) ago"
                        : (int)elapsed.TotalSeconds + " second(s) ago";
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
            DisplayList();

            if (files == null || files.Count == 0)
            {
                Close();
                return;
            }

            mainForm.LoadFile(files[0].FilePath);
            mainForm.ReadMetadata();
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
                DisplayList();
            }
        }

        void DisplayList()
        {
            if (files == null)
                LoadAllCache(Configuration.DiskCachePath);

            int count = 0;
            List<FileData> filteredFiles = new List<FileData>();

            foreach (FileData file in files)
            {
                if (count >= MAX_ITEMS) break;

                filteredFiles.Add(file);
                count++;
            }

            listView1.BeginUpdate();
            listView1.Items.Clear();
            foreach (FileData file in filteredFiles)
            {
                ListViewItem item = new ListViewItem(file.ID);
                item.SubItems.Add(file.CreationDateString);
                item.SubItems.Add(file.TimeSinceCreation);
                item.SubItems.Add(file.SizeString);

                item.Tag = file;
                listView1.Items.Add(item);
            }

            listView1.EndUpdate();
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
            DisplayList();
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
            bool loaded = mainForm.LoadFile(selectedFile.FilePath);
            if (loaded)
                mainForm.ReadMetadata();
        }
    }
}
