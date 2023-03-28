using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _13C
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Worker> Workers_col { get; set; }
        ObservableCollection<Departments> Departments_col { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Workers_col = new ObservableCollection<Worker>();
            Departments_col = new ObservableCollection<Departments>();
            Worker p1 = new Worker();
            p1.Name = "Mike";
            p1.Surname = "Tyson";
            Workers_col.Add(p1);

            Worker p2 = new Worker();
            p2.Name = "Ann";
            p2.Surname = "Tyson";
            Workers_col.Add(p2);

            Worker p3 = new Worker();
            p3.Name = "Nina";
            p3.Surname = "Tyson";
            Workers_col.Add(p3);

            Worker p5= new Worker();
            p5.Name = "Artem";
            p5.Surname = "Tyson";
            Workers_col.Add(p5);

            //workers.ItemsSource = Workers_col;
            Departments it = new Departments();
            it.Name = "IT";
            it.Workers_col = new ObservableCollection<Worker>();
            it.Workers_col.Add(p1);
            it.Workers_col.Add(p2);
            Departments_col.Add(it);

            Departments buchgalteria = new Departments();
            buchgalteria.Name = "Buchgalteria";
            buchgalteria.Workers_col = new ObservableCollection<Worker>();
            buchgalteria.Workers_col.Add(p3);
            buchgalteria.Workers_col.Add(p5);
            Departments_col.Add(buchgalteria);
            departments.ItemsSource = Departments_col;

           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Worker p4 = new Worker();
            p4.Name = "Vasya";
            p4.Surname = "Tyson";
            Workers_col.Add(p4);
        }
    }
}
