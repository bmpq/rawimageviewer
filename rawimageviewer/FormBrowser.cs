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
using static System.Net.WebRequestMethods;

namespace rawimageviewer
{
    public partial class FormBrowser : Form
    {
        private Form1 mainForm; // is this the right way to do this??

        private const int MAX_ITEMS = 100;

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

        public FormBrowser(Form1 mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
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

            OpenCacheFolder(dir.Parent.FullName, pathImg);
        }

        public void OpenCacheFolder(string folderPathDiskCache, string currentlyOpen)
        {
            string directory = folderPathDiskCache;
            List<FileData> Files = GetFilesRecursively(directory);
            Files.Sort((f2, f1) => f1.CreationDate.CompareTo(f2.CreationDate));

            int count = 0;
            List<FileData> filteredFiles = new List<FileData>();

            int indexOpened = -1;
            foreach (FileData file in Files)
            {
                if (count >= MAX_ITEMS) break;

                // looking for the currently open file
                if (file.FilePath == currentlyOpen)
                    indexOpened = count;

                if (indexOpened == -1)
                    continue;

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
            if (indexOpened != -1)
                listView1.Items[indexOpened].Selected = true;
            listView1.EndUpdate();
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

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            FileData selectedFile = (FileData)listView1.SelectedItems[0].Tag;
            mainForm.LoadFile(selectedFile.FilePath);
            mainForm.ReadMetadata();
        }
    }
}
