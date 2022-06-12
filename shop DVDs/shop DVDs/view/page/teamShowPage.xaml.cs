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
    /// Логика взаимодействия для teamShowPage.xaml
    /// </summary>
    public partial class teamShowPage : Page
    {
        private teamDB _currentTeam = new teamDB();
        public teamShowPage(teamDB selectTeam)
        {
            InitializeComponent();

            if (selectTeam != null)
                _currentTeam = selectTeam;

            DataContext = _currentTeam;
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }

        private void remove_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("remove on development");
        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new teamStorePage((sender as Button).DataContext as teamDB));
        }
    }
}
