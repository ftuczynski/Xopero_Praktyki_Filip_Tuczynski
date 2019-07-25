using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows;

namespace Wpf_Stopwatch.ViewModel {
    class BooleanVisibilityConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            if ((value is bool) && ((bool)value) == true)
                return Visibility.Visible;
            else
                return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}
