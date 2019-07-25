using System;
using System.Globalization;
using System.Windows.Data;

namespace Wpf_Stopwatch.ViewModel {
    class BooleanNotConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            if ((value is bool) && ((bool)value) == false)
                return true;
            else
                return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}
