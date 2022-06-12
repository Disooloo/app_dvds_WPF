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
using shop_DVDs.db;

namespace shop_DVDs.view.page
{
    /// <summary>
    /// Логика взаимодействия для sellerPage.xaml
    /// </summary>
    public partial class sellerPage : Page
    {
        private sellersDB _currentSeller = new sellersDB();
        public sellerPage(sellersDB selectSeller)
        {
            InitializeComponent();

            if (selectSeller != null)
                _currentSeller = selectSeller;

            DataContext = _currentSeller;
        }

        private void remove_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("remove on development");
        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new sellerStorePage((sender as Button).DataContext as sellersDB));
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }
    }
}
