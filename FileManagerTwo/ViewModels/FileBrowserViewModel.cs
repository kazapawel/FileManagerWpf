
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;

namespace FileManagerTwo
{
    /// <summary>
    /// File browser single module view model class.
    /// TO DO: Dependency Injection or this.create new model ??
    /// </summary>
    public class FileBrowserViewModel : BaseViewModel
    {
        #region PRIVATE MEMBERS

        /// <summary>
        /// Model
        /// </summary>
        private FileBrowser model;

        /// <summary>
        /// 
        /// </summary>
        private DriveItemViewModel selectedDrive;

        #endregion

        #region PUBLIC PROPERTIES

        /// <summary>
        /// Observable collections of all drives view models.
        /// </summary>
        public ObservableCollection<DriveItemViewModel> DrivesListObservable { get; set; }

        /// <summary>
        /// Currently active/selected drive.
        /// </summary>
        public DriveItemViewModel SelectedDrive
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

        #region CONSTRUCTORS

        /// <summary>
        /// Default  constructor
        /// </summary>
        public FileBrowserViewModel()
        {
            model = new FileBrowser();
            DrivesListObservable = new ObservableCollection<DriveItemViewModel>();
            LoadDrives();

            if(DrivesListObservable.Count>0)
                SelectedDrive = DrivesListObservable[0];

            DoubleClickItemCommand = new RelayCommand(DoubleClickAction);
        }

        #endregion

        #region METHODS

        /// <summary>
        /// Creates content of observable collection, based on model drives list.
        /// </summary>
        private void LoadDrives()
        {
            foreach (var drive in model.DrivesList)
                DrivesListObservable.Add(new DriveItemViewModel(drive));
        }

        /// <summary>
        /// Method for double click on item command.
        /// </summary>
        /// <param name="o"></param>
        private void DoubleClickAction(object o)
        {
            if (SelectedDrive.DirectoryActiveViewModel.SelectedItem.Type == FileItemType.File)
                OpenFile(SelectedDrive.DirectoryActiveViewModel.SelectedItem.FullPath);
            else
                OpenDirectory();
        }


        /// <summary>
        /// Opens file in default application.
        /// </summary>
        /// <param name="path"></param>
        private void OpenFile(string path)
        {
            Process p = new Process();
            ProcessStartInfo pi = new ProcessStartInfo();
            pi.UseShellExecute = true;
            pi.FileName = path;
            p.StartInfo = pi;
            p.Start();
        }

        /// <summary>
        /// 
        /// </summary>
        private void OpenDirectory()
        {
            SelectedDrive.DirectoryActiveViewModel = new DirectoryItemViewModel(new DirectoryItem(new DirectoryInfo(SelectedDrive.DirectoryActiveViewModel.SelectedItem.FullPath)));
        }

        #endregion
    }
}
