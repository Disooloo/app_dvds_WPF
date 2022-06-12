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
    /// Логика взаимодействия для ManagerShowPage.xaml
    /// </summary>
    public partial class ManagerShowPage : Page
    {
        private DVDsDB _currentDvd = new DVDsDB();
        public ManagerShowPage(DVDsDB selectDvd)
        {
            InitializeComponent();

            if (selectDvd != null)
                _currentDvd = selectDvd;

            DataContext = _currentDvd;

            DBlist.ItemsSource = appDVDsEntities.GetContext().sellersDBs.ToList();
        }

        private void sellerShow_Click(object sender, RoutedEventArgs e)
        {
            FManager.ManagerFrame.Navigate(new ManagerSellerShowPage((sender as Button).DataContext as sellersDB));
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            FManager.ManagerFrame.GoBack();
        }
    }
}
//b64->QGRpc29vbG9v