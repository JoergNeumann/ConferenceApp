using System;
using Xamarin.Forms;

namespace ConferenceApp
{
    class RatingConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var rating = (int)value;
            if (rating == 1)
                return "Richtig schlecht!";
            if (rating == 2)
                return "Geht so!";
            if (rating == 3)
                return "Ganz OK!";
            if (rating == 4)
                return "Gut!";
            if (rating == 5)
                return "Super!";

            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
