using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace BigGreenButton.Converters
{
    class WidthToRadiusConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var result = 0;
            if(int.TryParse(value.ToString(), out int intValue)){
                result = intValue / 2;
            }
            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
            // Optional: throw new NotSupportedException();
        }
    }
}
