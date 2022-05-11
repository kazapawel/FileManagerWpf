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
        /// <summary>
        /// Returns IEnumerable of all drives present in this computer. 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DriveItem> GetAllDrives() =>
            DriveInfo.GetDrives().Select(drive => new DriveItem(drive));

        /// <summary>
        /// Returns DirectoryItem object based on given path.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public DirectoryItem GetDirectory(string path) => 
            string.IsNullOrEmpty(path) && Directory.Exists(path) ? throw new Exception() 
                                                                 : new DirectoryItem(new DirectoryInfo(path));

        /// <summary>
        /// Opens file in default application.
        /// </summary>
        /// <param name="path"></param>
        public void OpenFile(string path)
        {
            Process p = new Process();
            ProcessStartInfo pi = new ProcessStartInfo();
            pi.UseShellExecute = true;
            pi.FileName = path;
            p.StartInfo = pi;

            // If there is no default application throws an exception
            try
            {
                p.Start();
            }
            catch(Exception e)
            {

            }
        }
    }
}
