using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace _13B
{
    class TrolleyBus
    {
        public static readonly DateTime startWorkingTime;
        public int Num { get; set; }
        public bool Driving { get; private set; }

        static int count;
        public static TrolleyBus[] trolleys;

        public static int Count
        {
            get => count;
            set
            {
                count = value;
                trolleys = new TrolleyBus[count];

                for (int i = 0; i < count; i++)
                {
                    trolleys[i] = new TrolleyBus(i + 1);
                }
            }
        }

        static TrolleyBus() => startWorkingTime = DateTime.Now;

        public TrolleyBus(int num) => Num = num;

        public string Drive()
        {
            Driving = true;

            DateTime time = DateTime.Now;
            int difference = Convert.ToInt32((time - startWorkingTime).TotalSeconds);

            return $"Троллейбус №{Num} выехал в {time} (через {difference} сек.) " +
                $"после начала работы парка в {startWorkingTime}\n";
        }
    }

    public class TrolleyCountRule : ValidationRule
    {
        public int Min { get; set; }
        public int Max { get; set; }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            int count = 0;

            try
            {
                if ((string)value != string.Empty) count = Convert.ToInt32(value);
            }
            catch (Exception e)
            {
                return new ValidationResult(false, $"Только цифры: {e.Message}");
            }

            if ((count < Min) || (count > Max))
            {
                return new ValidationResult(false, $"Введите количество троллейбусов от {Min} до {Max}.");
            }

            return ValidationResult.ValidResult;
        }
    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public int Count { get; set; }

        private void ok_button_Click(object sender, RoutedEventArgs e)
        {
            TrolleyBus.Count = Count;

            start_label.Content = TrolleyBus.startWorkingTime.ToString("dd.MM.yyyy HH:mm:ss");
            trolleys_wrapPanel.Children.Clear();

            for (int i = 0; i < TrolleyBus.Count; i++)
            {
                Button button = new Button();
                button.Tag = i;
                button.Content = '№' + (i + 1).ToString();
                button.Click += trolley_button_Click;

                trolleys_wrapPanel.Children.Add(button);
            }
        }

        private void trolley_button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            int i = Convert.ToInt32(button.Tag);
            if (TrolleyBus.trolleys[i].Driving) return;

            button.Background = Brushes.Red;
            log_textBox.Text += TrolleyBus.trolleys[i].Drive();
        }
    }
}