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
    /// Логика взаимодействия для productPage.xaml
    /// </summary>
    public partial class productPage : Page
    {
        public productPage()
        {
            InitializeComponent();
            DGrid.ItemsSource = appDVDsEntities.GetContext().DVDsDBs.ToList();

        }

        private void showProduct_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new productShowPage((sender as Button).DataContext as DVDsDB));
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
                appDVDsEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            DGrid.ItemsSource = appDVDsEntities.GetContext().DVDsDBs.ToList();
            var countI = appDVDsEntities.GetContext().DVDsDBs.Count();
           
            countItem.Text = countI.ToString();

        }

        private void storeProduct_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new productStorePage(null));
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

//b64->QGRpc29vbG9v