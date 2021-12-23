using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Data;
using System.Globalization;

namespace FFDraftAssist
{
    class NumberEvenOddConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            try
            {

                double val = System.Convert.ToDouble(value);

                if (val % 2 == 0)
                {

                    return "Even";

                }
                else
                {

                    return "Odd";

                }

            }
            catch
            {

                return Binding.DoNothing;

            }

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {

            return Binding.DoNothing;

        }

    }
}
