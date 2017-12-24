using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace WPF
{
    public class ImageConverter : IValueConverter
    {
        /// <summary>
        /// Classe qui permet la convertion d'une image quelconque en une image reconnu en XAML
        /// </summary>
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            {
                try
                {
                    return new BitmapImage(new Uri(String.Format("/Classes;component{0}", value as string), UriKind.RelativeOrAbsolute));
                }
                catch
                {
                    return new BitmapImage();
                }
            }

        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
