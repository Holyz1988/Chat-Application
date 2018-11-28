using System;
using System.Globalization;
using System.Windows;
using System.Windows.Media;

namespace Fasseto.Word
{
    /// <summary>
    /// a converter that takes in a bollean and returns a <see cref="Visibility"/>
    /// </summary>
    class StringRBGToBrushConverter : BaseValueConverter<StringRBGToBrushConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (SolidColorBrush)(new BrushConverter().ConvertFrom($"#" + value));
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
