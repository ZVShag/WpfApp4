using System;
using System.Collections.Generic;
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

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void Button_click1(object sender,RoutedEventArgs e)
        {
            MessageBox.Show("ZTE");
        }
        public void Button_click2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("IPhone");
        }
    }
    public class Tshirt
    {
        public string name { get; set; }    
        public float price { get; set; }
        public override string ToString()
        {
            return $"Наименование {name}, Цена {price}";
        }

    }
}
