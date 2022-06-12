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
    /// Логика взаимодействия для sellerListPage.xaml
    /// </summary>
    public partial class sellerListPage : Page
    {
        public sellerListPage()
        {
            InitializeComponent();
           
        }

        private void storeSeller_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new sellerStorePage(null));
        }

        private void showProduct_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new sellerPage((sender as Button).DataContext as sellersDB));
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
                appDVDsEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            DGrid.ItemsSource = appDVDsEntities.GetContext().sellersDBs.ToList();
        }
    }
}
