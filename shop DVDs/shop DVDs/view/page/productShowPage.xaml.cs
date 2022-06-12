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
    /// Логика взаимодействия для productShowPage.xaml
    /// </summary>
    public partial class productShowPage : Page
    {
        private DVDsDB _currentDvd = new DVDsDB();
        public productShowPage(DVDsDB selectDvd)
        {
            InitializeComponent();

            if (selectDvd != null)
                _currentDvd = selectDvd;

            DataContext = _currentDvd;

            DBlist.ItemsSource = appDVDsEntities.GetContext().sellersDBs.ToList();

        }

        private void sellerShow_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new sellerPage((sender as Button).DataContext as sellersDB));
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new productStorePage((sender as Button).DataContext as DVDsDB));
        }

        private void remove_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("remove on development");
        }
    }

       
    
}
