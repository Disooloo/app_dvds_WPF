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
    /// Логика взаимодействия для teamPage.xaml
    /// </summary>
    public partial class teamPage : Page
    {
        public teamPage()
        {
            InitializeComponent();
        }

        private void showTeam_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new teamShowPage((sender as Button).DataContext as teamDB));
        }

        private void storeTeam_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new teamStorePage(null));
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if(Visibility == Visibility.Visible)
                appDVDsEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            DGrid.ItemsSource = appDVDsEntities.GetContext().teamDBs.ToList();
            countItem.Text = appDVDsEntities.GetContext().teamDBs.Count().ToString();
        }
    }
}

//b64->QGRpc29vbG9v