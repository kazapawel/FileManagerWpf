using FileBrowserData;
using System.IO;

namespace FileManagerTwo
{
    /// <summary>
    /// View model for system file item.
    /// </summary>
    public class FileItemVM: BaseViewModel
    {
        #region PRIVATE MEMBERS

        /// <summary>
        /// Model
        /// </summary>
        private FileItem model;

        #endregion

        #region PUBLIC PROPERTIES

        /// <summary>
        /// Returns item's display name
        /// </summary>
        public string Name
        {
            get
            {
                return model.Type == FileItemType.File ? model.Name : model.Name;//.ToUpper();
            }
            set
            {
                if(model.Name!=value)
                {
                    model.Name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        /// <summary>
        /// Item's full path
        /// </summary>
        public string FullPath => model.FullPath;

        /// <summary>
        /// Returns item's size in string.
        /// </summary>
        /// 
        public string Size => model.Size > 0 ? HelperMethods.ConvertSize(model.Size) : "DIR";

        /// <summary>
        /// 
        /// </summary>
        public FileItemType Type => model.Type;

        /// <summary>
        /// 
        /// </summary>
        public string CreationTime => model.CreationTime.ToString();

        /// <summary>
        /// 
        /// </summary>
        public bool IsHidden => model.Attributes.HasFlag(FileAttributes.Hidden);


        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="file"></param>
        public FileItemVM(FileItem file)
        {
            model = file;
        }

        #endregion

    }
}
