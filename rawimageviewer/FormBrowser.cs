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

            public override string ToString()
            {
                return CreationDate.ToString("dd MMM | HH:mm:ss.fff");
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

            listBox1.DataSource = filteredFiles;
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

                        Files.Add(new FileData { FilePath = f.FullName, CreationDate = f.CreationTime });
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

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FileData selectedFile = (FileData)listBox1.SelectedItem;
            mainForm.LoadFile(selectedFile.FilePath);
            mainForm.ReadMetadata();
        }
    }
}
