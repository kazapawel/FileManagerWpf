using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FileBrowserData
{
    /// <summary>
    /// This is a single file browser module. It contains list of all drives.
    /// </summary>
    public class FileBrowser
    {
        /// <summary>
        /// List of all drives.
        /// </summary>
        public IEnumerable<DriveItem> DrivesList { get; set; }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public FileBrowser()
        {
            DrivesList = LoadDrives();
        }

        /// <summary>
        /// Returns collection of all drives on a computer.
        /// </summary>
        /// <returns></returns>
        private IEnumerable<DriveItem> LoadDrives() => 
            DriveInfo.GetDrives().Select(drive => new DriveItem(drive));
        //{
        //    return 

        //    var drives = new List<DriveItem>();

        //    // TO DO: Create logic for handling not ready drive in driveitem constructor!!
        //    foreach(var drive in DriveInfo.GetDrives())
        //    {
        //        if(drive.IsReady)
        //            drives.Add(new DriveItem(drive));
        //    }
        //    return drives;
        //}


    }
}
