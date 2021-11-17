using System;
using System.IO;

namespace FileManagerTwo
{
    /// <summary>
    /// This class represents basic file system item - file or directory.
    /// TO DO: should this contain FileSystemInfo object as property or do everything in constructor.
    /// </summary>
    public class FileItem
    {
        #region PUBLIC PROPERTIES

        /// <summary>
        /// Item's display name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Item's path.
        /// </summary>
        public string FullPath { get; set; }

        /// <summary>
        /// Item type - file or directory.
        /// </summary>
        public FileItemType Type { get; set; }

        /// <summary>
        /// If item is a file returns size in bytes. If item is a directory returns -1;
        /// </summary>
        public long Size { get; set; }

        /// <summary>
        /// When the item was created
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// When the item was last modified
        /// </summary>
        public DateTime ModificationTime { get; set; }

        /// <summary>
        /// Items attributes
        /// </summary>
        public FileAttributes Attributes { get; set; }

        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// Default constructor with FileSystemInfo injection.
        /// </summary>
        /// <param name="fileSystemInfo"></param>
        public FileItem(FileSystemInfo info)
        {
            this.Name = info.Name;
            this.FullPath = info.FullName;
            this.Attributes = info.Attributes;
            this.CreationTime = info.CreationTime;
            this.ModificationTime = info.LastWriteTime;

            //Sets item's type based on attribute
            this.Type = info.Attributes.HasFlag(FileAttributes.Directory) ? FileItemType.Directory : FileItemType.File;

            //Sets item's size
            Size = this.Type == FileItemType.File ? (info as FileInfo).Length : -1;
        }

        #endregion
    }
}
