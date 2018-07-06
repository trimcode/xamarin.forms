using System;
using System.Globalization;
using Xamarin.Forms;

namespace XamarinSample.Converters
{
    public class ItemTappedEventArgsConverter : IValueConverter
    {
        public ItemTappedEventArgsConverter()
        {
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var eventArgs = value as ItemTappedEventArgs;

            if (eventArgs == null)
                throw new ArgumentException("Excepted TappedEventArgs as value");

            return eventArgs.Item;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
