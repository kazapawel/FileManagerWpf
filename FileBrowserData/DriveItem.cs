using System.IO;

namespace FileBrowserData
{
    /// <summary>
    /// This is a representation of a drive - disk, cd-rom, flash etc. It can have only one active directory at a time.
    /// The idea is to load only one directory at a time and not load whole drive.
    /// </summary>
    public class DriveItem
    {
        #region PUBLIC PROPERTIES

        /// <summary>
        /// Contains all info about drive.
        /// </summary>
        public DriveInfo Info { get; private set; }

        /// <summary>
        /// Represents active directory, that we are currently in.
        /// </summary>
        public DirectoryItem ActiveDirectory { get; set; }

        #endregion

        #region CONSTRUCTOR

        /// <summary>
        /// Default constructor. Creates drive based on injected DriveInfo object.
        /// </summary>
        /// <param name="driveInfo"></param>
        public DriveItem(DriveInfo driveInfo)
        {            
            this.Info = driveInfo;

            //Sets root directory as active directory
            if (driveInfo.IsReady)
                this.ActiveDirectory = new DirectoryItem(driveInfo.RootDirectory);         
        }

        #endregion
    }
}
