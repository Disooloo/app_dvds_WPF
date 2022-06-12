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
    /// Логика взаимодействия для ManagerWindow.xaml
    /// </summary>
    public partial class ManagerWindow : Window
    {
        public ManagerWindow()
        {
            InitializeComponent();
            ManagerFrame.Navigate(new ManagerPage());
            FManager.ManagerFrame = ManagerFrame;
        }

        private void dasbord_Click(object sender, RoutedEventArgs e)
        {
            FManager.ManagerFrame.Navigate(new ManagerPage());
        }

        private void seller_Click(object sender, RoutedEventArgs e)
        {
            FManager.ManagerFrame.Navigate(new ManagerSellerPage());
        }

        private void exitLogin_Click(object sender, RoutedEventArgs e)
        {
            loginWindow loginWindow = new loginWindow();
            loginWindow.Show();
            this.Close();
        }
    }
}

// b64->QGRpc29vbG9v