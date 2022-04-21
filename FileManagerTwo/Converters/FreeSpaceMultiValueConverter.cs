using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace FileManagerTwo
{
    public class FreeSpaceMultiValueConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            // totalsize = 100 x 1%
            // 1% = total size /100
            var totalsize = (long)values[0];
            var freespace = (long)values[1];
            var perct = freespace / (totalsize / 100);
            //freespace / (totalsize/100)
            return (double)perct;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
