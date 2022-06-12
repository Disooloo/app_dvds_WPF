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
    /// Логика взаимодействия для sellerStorePage.xaml
    /// </summary>
    public partial class sellerStorePage : Page
    {

        private sellersDB _currentSeller = new sellersDB();
        public sellerStorePage(sellersDB selectSeller)
        {
            InitializeComponent();

            if (selectSeller != null)
                _currentSeller = selectSeller;

            DataContext = _currentSeller;
        }

        private void storeSeller_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentSeller.name))
                errors.AppendLine("Имя не может быть пустым");
            if (string.IsNullOrWhiteSpace(_currentSeller.surname))
                errors.AppendLine("Фамилия не может быть пустой");
            if (string.IsNullOrWhiteSpace(_currentSeller.phone))
                errors.AppendLine("Телефон не может быть пустым");
            if (string.IsNullOrWhiteSpace(_currentSeller.mail))
                errors.AppendLine("Email не может быть пустой");
            if (string.IsNullOrWhiteSpace(_currentSeller.company))
                errors.AppendLine("Компания не может быть пустой");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_currentSeller.C_id == 0)
                appDVDsEntities.GetContext().sellersDBs.Add(_currentSeller);
            try
            {
                appDVDsEntities.GetContext().SaveChanges();
                MessageBox.Show("Данные сохранены");
                Manager.MainFrame.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка -> " + ex.Message.ToString());
            }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }
    }
}

//b64->QGRpc29vbG9v