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
    /// Логика взаимодействия для productStorePage.xaml
    /// </summary>
    public partial class productStorePage : Page
    {
        private DVDsDB _currentProduct = new DVDsDB();
        public productStorePage(DVDsDB selectProduct)
        {
            InitializeComponent();

            if (selectProduct != null)
                _currentProduct = selectProduct;

            DataContext = _currentProduct;
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }

        private void storeProduct_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentProduct.title))
                errors.AppendLine("Нименование товара не может быть пустым");
            if (string.IsNullOrWhiteSpace(_currentProduct.category))
                errors.AppendLine("категория не может быть пустой");
            if (string.IsNullOrWhiteSpace(_currentProduct.description))
                errors.AppendLine("Описание не может быть пустым");
            if (string.IsNullOrWhiteSpace(_currentProduct.price))
                errors.AppendLine("Цена не может быть пустой");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_currentProduct.C_id == 0)
                appDVDsEntities.GetContext().DVDsDBs.Add(_currentProduct);
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
    }
}

//b64->QGRpc29vbG9v