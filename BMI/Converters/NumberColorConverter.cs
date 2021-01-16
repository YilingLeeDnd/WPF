using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace BmiViewModel.Converters
{
    // 注意此 attribute, 可寫可不寫
    [ValueConversion(typeof(double), typeof(Brush))]
    public class NumberColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is null) return new SolidColorBrush(Colors.Blue);
            var v = (double)value;
            if (v < 18.5)
            { return new SolidColorBrush(Colors.Blue); }
            else if (v > 24)
            { return new SolidColorBrush(Colors.Coral); }
            else
            { return new SolidColorBrush(Colors.Green); }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}