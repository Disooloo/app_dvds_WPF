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
    /// Логика взаимодействия для ManagerSellerShowPage.xaml
    /// </summary>
    public partial class ManagerSellerShowPage : Page
    {

        private sellersDB _currentSeller = new sellersDB();
        public ManagerSellerShowPage(sellersDB selectSeller)
        {
            InitializeComponent();
            if (selectSeller != null)
                _currentSeller = selectSeller;

            DataContext = _currentSeller;
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            FManager.ManagerFrame.GoBack();
        }
    }
}
