using FileBrowserData;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace FileBrowserServices
{
    public class FileService
    {
        public IEnumerable<DriveItem> GetAllDrives() =>
            DriveInfo.GetDrives().Select(drive => new DriveItem(drive));

        public DirectoryItem GetDirectory(string path) => 
            string.IsNullOrEmpty(path) ? throw new Exception() : new DirectoryItem(new DirectoryInfo(path));

        public void OpenFile(string path)
        {
            Process p = new Process();
            ProcessStartInfo pi = new ProcessStartInfo();
            pi.UseShellExecute = true;
            pi.FileName = path;
            p.StartInfo = pi;
            p.Start();
        }
    }
}
