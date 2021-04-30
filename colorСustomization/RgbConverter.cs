using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace colorСustomization
{
    internal sealed class RgbConverter : IMultiValueConverter
    {
        #region IMultiValueConverter Members

        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var a = System.Convert.ToByte(values[0]);
            var r = System.Convert.ToByte(values[1]);
            var g = System.Convert.ToByte(values[2]);
            var b = System.Convert.ToByte(values[3]);

            return Color.FromArgb(a,r, g, b);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
