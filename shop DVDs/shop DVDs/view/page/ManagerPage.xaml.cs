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
    /// Логика взаимодействия для ManagerPage.xaml
    /// </summary>
    public partial class ManagerPage : Page
    {
        public ManagerPage()
        {
            InitializeComponent();
        }

        private void storeProduct_Click(object sender, RoutedEventArgs e)
        {
            FManager.ManagerFrame.Navigate(new ManagerStorePage());
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
                appDVDsEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            DGrid.ItemsSource = appDVDsEntities.GetContext().DVDsDBs.ToList();
            countItem.Text = appDVDsEntities.GetContext().DVDsDBs.Count().ToString();

        }

        private void showProduct_Click(object sender, RoutedEventArgs e)
        {
            FManager.ManagerFrame.Navigate(new ManagerShowPage((sender as Button).DataContext as DVDsDB));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("test 200");
            Manager.MainFrame.Navigate(new ManagerShowPage((sender as Button).DataContext as DVDsDB));
        }
    }
}
// b64->QGRpc29vbG9v