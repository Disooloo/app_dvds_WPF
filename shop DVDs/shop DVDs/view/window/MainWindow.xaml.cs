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
using shop_DVDs.view.page;

namespace shop_DVDs.view.window
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new productPage());
            Manager.MainFrame = MainFrame;
        }

        private void dasbord_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void seller_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void exitLogin_Click(object sender, RoutedEventArgs e)
        {
            loginWindow loginWindow = new loginWindow();
            loginWindow.Show();
            this.Close();
        }

        private void dasbord_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new productPage());
        }

        private void seller_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new sellerListPage());
        }

        private void team_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new teamPage());
        }
    }
}

// b64->QGRpc29vbG9v