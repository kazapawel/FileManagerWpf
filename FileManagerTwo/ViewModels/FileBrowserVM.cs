using FileBrowserData;
using FileBrowserServices;
using System.Collections.ObjectModel;
using System.Linq;

namespace FileManagerTwo
{
    /// <summary>
    /// View model of a single file browser module.
    /// </summary>
    public class FileBrowserVM : BaseViewModel
    {
        #region PRIVATE MEMBERS

        private FileService filesService;

        private DriveItemVM selectedDrive;

        #endregion

        #region PUBLIC PROPERTIES

        /// <summary>
        /// Observable collections of all drives view models.
        /// </summary>
        public ObservableCollection<DriveItemVM> Drives { get; set; }

        /// <summary>
        /// Currently active/selected drive.
        /// </summary>
        public DriveItemVM SelectedDrive
        {
            get
            {
                return selectedDrive;
            }
            set
            {
                if(selectedDrive!=value)
                {
                    selectedDrive = value;
                    OnPropertyChanged(nameof(SelectedDrive));
                }
            }
        }

        #endregion

        public RelayCommand DoubleClickItemCommand { get; set; }
        public RelayCommand CopyItemCommand { get; set; }
        public RelayCommand DeleteItemCommand { get; set; }
        public RelayCommand CutItemCommand { get; set; }

        #region CONSTRUCTOR

        /// <summary>
        /// Default  constructor
        /// </summary>
        public FileBrowserVM()
        {
            filesService = new FileService();
            Drives = GetDrives();
            SelectedDrive = Drives.FirstOrDefault();
            DoubleClickItemCommand = new RelayCommand(OpenItem);
            CopyItemCommand = new RelayCommand(CopyItem);
            DeleteItemCommand = new RelayCommand(DeleteItem);
            CutItemCommand = new RelayCommand(CutItem);
        }

        #endregion

        #region METHODS

        /// <summary>
        /// Returns collections of driveitemViewModels.
        /// </summary>
        private ObservableCollection<DriveItemVM> GetDrives() =>
            new(filesService.GetAllDrives().Select(drive => new DriveItemVM(drive)));

        /// <summary>
        /// Method for double click on item command.
        /// </summary>
        /// <param name="o"></param>
        private void OpenItem(object o)
        {
            // Gets path of selected item in current directory
            var path = SelectedDrive.Directory.SelectedItem.FullPath;

            // If item is a file, opens it 
            if (SelectedDrive.Directory.SelectedItem.Type == FileItemType.File)
                filesService.OpenFile(path);
            else
                OpenDirectory(path);
        }

        /// <summary>
        /// 
        /// </summary>
        private void OpenDirectory(string path) =>
            SelectedDrive.Directory = new DirectoryItemVM(filesService.GetDirectory(path));
     
        private void CopyItem(object o)
        {

        }

        private void DeleteItem(object o)
        {

        }

        private void CutItem(object o)
        {

        }

        #endregion
    }
}
