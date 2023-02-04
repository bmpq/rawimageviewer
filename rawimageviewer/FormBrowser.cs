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

        public void SetPath(string imgPath)
        {
            var dir = Directory.GetParent(imgPath);

            if (dir == null || dir.Parent == null)
            {
                Close();
                return;
            }

            LoadFolder(dir.Parent.FullName);
        }

        private void LoadFolder(string folderPathDiskCache)
        {
            string directory = folderPathDiskCache;
            List<FileData> Files = GetFilesRecursively(directory);
            Files.Sort((f2, f1) => f1.CreationDate.CompareTo(f2.CreationDate));

            int count = 0;
            List<FileData> filteredFiles = new List<FileData>();
            foreach (FileData file in Files)
            {
                if (count >= MAX_ITEMS) break;
                filteredFiles.Add(file);
                count++;
            }

            listView1.BeginUpdate();
            listView1.Items.Clear();
            listView1.Columns.Clear();

            listView1.Columns.Add("Creation Date", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("Time Since Creation", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("Size", 100, HorizontalAlignment.Left);
            foreach (FileData file in filteredFiles)
            {
                ListViewItem item = new ListViewItem(file.CreationDateString);
                item.SubItems.Add(file.TimeSinceCreation);
                item.SubItems.Add(file.SizeString);

                item.Tag = file;
                listView1.Items.Add(item);
            }
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
