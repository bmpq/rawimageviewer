using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace rawimageviewer
{
    public static class Configuration
    {
        private static string AppPath => Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        private static string ConfigFile => Path.Combine(AppPath, "config.ini");

        public static string DiskCachePath { get; set; } = string.Empty;

        public static void Save()
        {
            File.WriteAllText(ConfigFile, 
                "[section1]\nDiskCachePath=" + DiskCachePath.ToString() +
                "\n");
        }

        public static void Load()
        {
            if (!File.Exists(ConfigFile)) return;

            string configContents = File.ReadAllText(ConfigFile);
            string[] configLines = configContents.Split('\n');

            DiskCachePath = configLines[1].Split('=')[1];
        }
    }
}
