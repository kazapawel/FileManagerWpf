using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FileManagerTwo
{
    /// <summary>
    /// This is a representation of a single directory which content is going to be displayed.
    /// 
    /// TO DO: return no orderd list of item and let view model handle preparing for display.
    /// TO DO: set parent directory display name in view model.
    /// TO DO: check if directoryinfo.Root is enough to set parent direcotry path.
    /// 
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
        /// List of all FileSystemInfo items in directory ordered by type.
        /// </summary>
        public List<FileItem> Items { get; set; }

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
            Items = new List<FileItem>();

            //TO DO: WHAT TO DO WITH THIS EXCEPTION, HOW TO INFORM USER ABOUT ACCESS DENIED
            try
            {
                foreach (var item in directoryInfo.GetFileSystemInfos())
                    Items.Add(new FileItem(item));
            }
            catch (UnauthorizedAccessException ex)
            {
               
            }
            //Sets item list content
            

            //If there is no parent directory, sets this directory as parent
            Parent = directoryInfo.Parent != null ? new FileItem(directoryInfo.Parent) : new FileItem(directoryInfo);

            //Sets parent item display name
            Parent.Name = "..";
        }

        #endregion
    }
}
