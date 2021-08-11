using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace VisualTreeCollapseIssue001.ValueConverters
{
    public class VisibilityToBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (value is Visibility visibilityValue) && visibilityValue == Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (value is bool boolValue && boolValue) ? Visibility.Visible : Visibility.Collapsed;
        }
    }
}
