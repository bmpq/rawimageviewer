using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rawimageviewer
{
    internal static class Utils
    {
        public static string FormatFileSize(long bytes)
        {
            var unit = 1024;
            if (bytes < unit) { return $"{bytes} B"; }

            var exp = (int)(Math.Log(bytes) / Math.Log(unit));
            return $"{bytes / Math.Pow(unit, exp):F2} {("KMGTPE")[exp - 1]}B";
        }
    }
}
