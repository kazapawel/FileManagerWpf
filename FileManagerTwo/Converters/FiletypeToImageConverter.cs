using FileBrowserData;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace FileManagerTwo
{
    public class FiletypeToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((FileItemType)value)
            {
                case FileItemType.Directory : return "pack://application:,,,/Icons/folder2.png";
                default: return "pack://application:,,,/Icons/file1.png";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
