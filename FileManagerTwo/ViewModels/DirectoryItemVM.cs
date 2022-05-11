using System.Collections.ObjectModel;
using System.Linq;
using FileBrowserData;

namespace FileManagerTwo
{
    public class DirectoryItemVM : BaseViewModel
    {
        #region PRIVATE MEMBERS

        /// <summary>
        /// Model
        /// </summary>
        private DirectoryItem model;

        /// <summary>
        /// SelectedItem
        /// </summary>
        private FileItemVM selectedItem;

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
        /// Moving and deleting  directory etc
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
        public ObservableCollection<FileItemVM> Items { get; set; }

        /// <summary>
        /// Represents currently selected item in items display.
        /// </summary>
        public FileItemVM SelectedItem
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
        public DirectoryItemVM(DirectoryItem directoryItem)
        {
            model = directoryItem;
            Items = GetItems();
            SelectedItem = Items.FirstOrDefault();
        }

        #endregion

        #region METHODS

        /// <summary>
        /// Returns collection of file item view models.
        /// </summary>
        private ObservableCollection<FileItemVM> GetItems() //=> new(model.Items.Select(x => new FileItemVM(x)));
        {
            var items = new ObservableCollection<FileItemVM>();

            //Adds parent view model to the list
            items.Add(new FileItemVM(model.Parent));

            //Adds rest
            foreach (var file in model.Items)
                items.Add(new FileItemVM(file));

            return items;
        }

    #endregion
}
}
