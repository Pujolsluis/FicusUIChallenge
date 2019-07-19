using System;
using System.Globalization;
using Xamarin.Forms;

namespace FicusUIChallenge.Converters
{
    public class LeafImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int val;
            val = (int)value;
            if (val % 2 == 0)
                return $"ic_leaf_right.png";
            return $"ic_leaf_left.png";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
