using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagerTwo
{
    /// <summary>
    /// This is a representation of a drive - disk, cd-rom, flash etc. It can have only one active directory at a time.
    /// Idea is to load only one directory at a time and not load whole drive.
    /// TO DO: Should DriveInfo object be private and expose info with properties or leave it as it is - public property ??
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

        #region CONSTRUCTORS

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

        // not used right now. Everything is in view model. DirectioryItemViewModel updates directoryItem model or fires file.
        #region METHODS
        /*
         

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileItem"></param>
        public void ExecuteItem(FileItem fileItem)
        {
            if (fileItem.Type == FileItemType.File)
                OpenFile(fileItem.FullPath);
            else
                OpenDirectory(fileItem.FullPath);
        }

        /// <summary>
        /// Opens file with default application.
        /// </summary>
        /// <param name="path"></param>
        private void OpenFile(string path)
        {
            Process p = new Process();
            ProcessStartInfo pi = new ProcessStartInfo();
            pi.UseShellExecute = true;
            pi.FileName = path;
            p.StartInfo = pi;
            try
            {
                p.Start();
            }
            catch
            {


            }
        }

        /// <summary>
        /// Changes directory in selected drive
        /// </summary>
        /// <param name="path"></param>
        private void OpenDirectory(string path)
        {
            ActiveDirectory = new DirectoryItem(new DirectoryInfo(path));
        }

        */
        #endregion 


    }
}
