using System.Collections.ObjectModel;
using System.Linq;
using FileBrowserData;

namespace FileManagerTwo
{
    public class DirectoryItemViewModel : BaseViewModel
    {
        #region PRIVATE MEMBERS

        /// <summary>
        /// Model
        /// </summary>
        private DirectoryItem model;

        /// <summary>
        /// SelectedItem
        /// </summary>
        private FileItemViewModel selectedItem;

        #endregion

        #region PUBLIC PROPERTIES

        /// <summary>
        /// Changing name will be available via command.
        /// </summary>
        public string Name
        {
            get
            {
                return model.Name;
            }
            set
            {
                if(model.FullPath!=value)
                {
                    model.FullPath = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        /// <summary>
        /// Moving and deleting directory etc
        /// </summary>
        public string FullPath
        {
            get
            {
                return model.FullPath;
            }
            set
            {
                if(model.FullPath!=value)
                {
                    model.FullPath = value;
                    OnPropertyChanged(nameof(FullPath));
                }
            }
        }

        /// <summary>
        /// Number of items in this directory
        /// </summary>
        public string ItemsCount => model.Items.Count().ToString();

        /// <summary>
        /// Items for display.
        /// </summary>
        public ObservableCollection<FileItemViewModel> ItemsObservable { get; set; }

        /// <summary>
        /// Represents currently selected item in items display.
        /// </summary>
        public FileItemViewModel SelectedItem
        {
            get
            {
                return selectedItem;
            }
            set
            {
                if(selectedItem!=value)
                {
                    selectedItem = value;
                    OnPropertyChanged(nameof(SelectedItem));
}
            }
        }

        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="directoryItem"></param>
        public DirectoryItemViewModel(DirectoryItem directoryItem)
        {
            model = directoryItem;
            ItemsObservable = new ObservableCollection<FileItemViewModel>();
            LoadItemsViewModels();
        }

        #endregion

        #region METHODS

        /// <summary>
        /// Loads items from model to observable collection.
        /// </summary>
        private void LoadItemsViewModels()
        {
            //Adds parent view model to the list
            ItemsObservable.Add(new FileItemViewModel(model.Parent));

            //model.Items.OrderBy(x => x.Type).ToList();
            foreach (var file in model.Items.OrderBy(x => x.Type))
                ItemsObservable.Add(new FileItemViewModel(file));

            SelectedItem = ItemsObservable[0];
        }
      
        #endregion
    }
}
