using System;
using System.Globalization;
using Xamarin.Forms;

namespace LineIndicator
{
    public class DoubleToGridLengthConverter : IValueConverter
    {
        public object Convert (object value, Type targetType, object parameter, CultureInfo culture)
        {
            var it = (double)value;

            if (it < 0.01)
                return new GridLength (0, GridUnitType.Absolute);

            return new GridLength (it, GridUnitType.Star);
        }

        public object ConvertBack (object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException ();
        }
    }
}
