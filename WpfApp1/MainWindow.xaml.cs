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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            lbl1.Content = "1";
            textbox1.Clear();
            MessageBox.Show("olmadiki", "sef error", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            lbl1.Content = "2";
            textbox1.Clear();
            
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            lbl1.Content = "3";
            textbox1.Clear();
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            lbl1.Content = "4";
            textbox1.Clear();
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            lbl1.Content = "5";
            textbox1.Clear();
        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            lbl1.Content = "6";
            textbox1.Clear();
        }
    }
}
