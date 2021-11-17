using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace FileManagerTwo
{
    /// <summary>
    /// This is a single file browser module. It contains list of all drives.
    /// TO DO: methods for manipulating files etc.
    /// </summary>
    public class FileBrowser
    {
        #region PUBLIC PROPERTIES

        /// <summary>
        /// List of all drives.
        /// </summary>
        public List<DriveItem> DrivesList { get; set; }

        #endregion

        #region CONSTRUCTOR

        /// <summary>
        /// Default constructor.
        /// </summary>
        public FileBrowser()
        {
            DrivesList = LoadDrives();
        }

        #endregion

        #region METHODS

        /// <summary>
        /// Creates a list of all drives on a computer.
        /// Returns DriveItem list created based on DriveInfo.GetDrives.
        /// </summary>
        /// <returns></returns>
        private List<DriveItem> LoadDrives()
        {
            var drives = new List<DriveItem>();

            // TO DO: Create logic for handling not ready drive in driveitem constructor!!
            foreach(var drive in DriveInfo.GetDrives())
            {
                if(drive.IsReady)
                    drives.Add(new DriveItem(drive));
            }
            return drives;
        }

        #endregion

    }
}
