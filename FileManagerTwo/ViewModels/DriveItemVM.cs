using System.IO;
using FileBrowserData;

namespace FileManagerTwo
{
    /// <summary>
    /// View model for single drive.
    /// </summary>
    public class DriveItemVM : BaseViewModel
    {
        #region PRIVATE MEMBERS

        private DriveItem model;
        private DirectoryItemVM activeDirectory;

        #endregion

        #region PUBLIC PROPERTIES

        #region INFO PROPERTIES

        /// <summary>
        /// TO DO: Changing name will be available via command.
        /// </summary>
        public string Name => model.Info.Name;

        /// <summary>
        /// 
        /// </summary>
        public string VolumeLabel => string.IsNullOrEmpty(model.Info.VolumeLabel) ? "no name" : model.Info.VolumeLabel;

        /// <summary>
        /// String representation if drive is ready.
        /// </summary>
        public bool IsReady => model.Info.IsReady;

        /// <summary>
        /// Name of the file system type, such as NTFS or FAT32
        /// </summary>
        public string DriveFormat => model.Info.DriveFormat;

        /// <summary>
        /// String representation of a drive type, such as CD-ROM, FIXED etc.
        /// </summary>
        public DriveType DriveType => model.Info.DriveType;

        /// <summary>
        /// Drive type for display.
        /// </summary>
        public string DriveTypeName => model.Info.DriveType.ToString();

        /// <summary>
        /// 
        /// </summary>
        public string SizeInfo => $"{HelperMethods.ConvertSize(model.Info.TotalFreeSpace)} / {HelperMethods.ConvertSize(model.Info.TotalSize)}";

        public long FreeSpace => model.Info.AvailableFreeSpace;
        public long TotalSize => model.Info.TotalSize;
        public double Percentage => (double) ((model.Info.TotalSize - model.Info.AvailableFreeSpace) / (model.Info.TotalSize / 100));

        #endregion


        /// <summary>
        /// Active directory view model.
        /// </summary>
        public DirectoryItemVM Directory
        {
            get
            {
                return activeDirectory;
            }
            set
            {
                if(activeDirectory!=value)
                {
                    activeDirectory = value;
                    OnPropertyChanged(nameof(Directory));
                }
            }
        }

        #endregion

        #region COMMANDS 

        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="driveItem"></param>
        public DriveItemVM(DriveItem driveItem)
        {
            model = driveItem;
            Directory = new DirectoryItemVM(model.ActiveDirectory);
        }

        #endregion
    }
}
