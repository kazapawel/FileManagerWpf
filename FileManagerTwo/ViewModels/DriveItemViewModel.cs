
using System.Diagnostics;
using System.IO;

namespace FileManagerTwo
{
    /// <summary>
    /// Drive Item view model class.
    /// </summary>
    public class DriveItemViewModel : BaseViewModel
    {
        #region PRIVATE MEMBERS

        private DriveItem model;
        private DirectoryItemViewModel activeDirectory;

        #endregion

        #region PUBLIC PROPERTIES

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
        public string IsReady => model.Info.IsReady.ToString();

        /// <summary>
        /// Name of the file system type, such as NTFS or FAT32
        /// </summary>
        public string DriveFormat => model.Info.DriveFormat;

        /// <summary>
        /// String representation of a drive type, such as CD-ROM, FIXED etc.
        /// </summary>
        public DriveType DriveType => model.Info.DriveType;

        /// <summary>
        /// Drive type for display
        /// </summary>
        public string DriveTypeName => model.Info.DriveType.ToString();

        /// <summary>
        /// 
        /// </summary>
        public string SizeInfo => $"{HelperMethods.ConvertSize(model.Info.TotalFreeSpace)} / {HelperMethods.ConvertSize(model.Info.TotalSize)}";

        public long FreeSpace => model.Info.AvailableFreeSpace;
        public long TotalSize => model.Info.TotalSize;

        public double Percentage => (double) ((model.Info.TotalSize - model.Info.AvailableFreeSpace) / (model.Info.TotalSize / 100));

        /// <summary>
        /// Active directory view model.
        /// </summary>
        public DirectoryItemViewModel DirectoryActiveViewModel
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
                    OnPropertyChanged(nameof(DirectoryActiveViewModel));
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
        public DriveItemViewModel(DriveItem driveItem)
        {
            model = driveItem;
            DirectoryActiveViewModel = new DirectoryItemViewModel(model.ActiveDirectory);
        }

        #endregion

        #region METHODS

        #endregion
    }
}
