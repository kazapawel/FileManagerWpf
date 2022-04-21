using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FileBrowserData
{
    /// <summary>
    /// This is a representation of a single directory.
    /// 
    /// TO DO: return no orderd list of item and let view model handle preparing for display.
    /// TO DO: check if directoryinfo.Root is enough to set parent directory path.
    /// </summary>
    public class DirectoryItem
    {
        #region PUBLIC PROPERTIES

        /// <summary>
        /// Directory's display name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Directory's path.
        /// </summary>
        public string FullPath { get; set; }

        /// <summary>
        /// Parent directory file item.
        /// </summary>
        public FileItem Parent { get; set; }

        /// <summary>
        /// Collection of all FileSystemInfo items in directory ordered by type.
        /// </summary>
        public IEnumerable<FileItem> Items { get; set; }

        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// Default constructor that takes directoryinfo object as argument.
        /// </summary>
        /// <param name="path"></param>
        public DirectoryItem(DirectoryInfo directoryInfo)
        {
            Name = directoryInfo.Name;
            FullPath = directoryInfo.FullName;

            //TO DO: WHAT TO DO WITH THIS EXCEPTION, HOW TO INFORM USER ABOUT ACCESS DENIED
            try
            {
                Items = directoryInfo.GetFileSystemInfos().Select(item => new FileItem(item));
            }
            catch (UnauthorizedAccessException ex)
            {              
            }

            //If there is no parent directory, sets this directory as parent
            Parent = directoryInfo.Parent != null ? new FileItem(directoryInfo.Parent) : new FileItem(directoryInfo);

            //Sets parent item display name
            Parent.Name = "..";
        }

        #endregion
    }
}
