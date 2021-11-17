using System;
using System.Globalization;
using System.IO;
using System.Windows.Data;

namespace FileManagerTwo
{
    /// <summary>
    /// Converts DriveType value to string image path.
    /// </summary>
    public class DrivetypeToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch((DriveType)value)
            {
                case DriveType.Removable: return "pack://application:,,,/Icons/metroUSB1.png";
                default: return "pack://application:,,,/Icons/metroHDD3.png";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
