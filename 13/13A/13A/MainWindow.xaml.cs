using System;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Data;

namespace _13A
{
    public class DateMultiValueConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values.Contains(string.Empty)) return Binding.DoNothing;

            try
            {
                int day = System.Convert.ToInt32(values[0]);
                int month = System.Convert.ToInt32(values[1]);
                int year = System.Convert.ToInt32(values[2]);

                if (day == 29 && month == 2 && !DateTime.IsLeapYear(year)) MessageBox.Show("29 февраля существует только в високосном году.",
                        "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);

                DateTime dateTime = new DateTime(year, month, day);
                return dateTime;
            }
            catch
            {
                return Binding.DoNothing;
            }
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            DateTime dateTime = (DateTime)value;
            object[] values = new object[] { dateTime.Day.ToString(), dateTime.Month.ToString(), dateTime.Year.ToString() };
            return values;
        }
    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}