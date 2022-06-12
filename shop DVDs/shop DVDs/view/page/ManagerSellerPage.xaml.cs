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
    /// Логика взаимодействия для ManagerSellerPage.xaml
    /// </summary>
    public partial class ManagerSellerPage : Page
    {
        public ManagerSellerPage()
        {
            InitializeComponent();
        }

        private void showProduct_Click(object sender, RoutedEventArgs e)
        {
            FManager.ManagerFrame.Navigate(new ManagerSellerShowPage((sender as Button).DataContext as sellersDB));
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
                appDVDsEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            DGrid.ItemsSource = appDVDsEntities.GetContext().sellersDBs.ToList();
        }
    }
}

// b64->QGRpc29vbG9v