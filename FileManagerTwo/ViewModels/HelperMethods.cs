using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagerTwo
{
    /// <summary>
    /// Misc. helper methods for converting data for display.
    /// </summary>
    public static class HelperMethods
    {
        /// <summary>
        /// Converts bytes into larger units.
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public static string ConvertSize(long size)
        {
            var names = new string[]
            {
                "B",
                "kB",
                "MB",
                "GB",
                "TB"
            };
            var index = (int)Math.Log(size, 1024);
            var name = names[index];
            var newSize = size / Math.Pow(1024, index);
            return $"{string.Format("{0:0.00}", newSize)} {name}";
        }
    }
}
