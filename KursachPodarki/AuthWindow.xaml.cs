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
using System.Windows.Shapes;

namespace KursachPodarki
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Old_Tb.Visibility = Visibility.Visible;
            FIO_Tb.Visibility=Visibility.Visible;   
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            Old_Tb.Visibility = Visibility.Collapsed;
            FIO_Tb.Visibility = Visibility.Collapsed;
        }

        private void Login_Btn_Click(object sender, RoutedEventArgs e)
        {
            Window window = new MainWindow();
            window.Show();
            this.Close();
        }
    }
}
