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
    /// Логика взаимодействия для teamStorePage.xaml
    /// </summary>
    public partial class teamStorePage : Page
    {
        private teamDB _correntTeam = new teamDB();

        public teamStorePage(teamDB selectTeam)
        {
            InitializeComponent();

            if (selectTeam != null)
                _correntTeam = selectTeam;

            DataContext = _correntTeam;
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }

        private void storeTeam_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_correntTeam.name))
                errors.AppendLine("Имя не может быть пустым");
            if (string.IsNullOrWhiteSpace(_correntTeam.surname))
                errors.AppendLine("Фамилия не может быть пустой");
            if (string.IsNullOrWhiteSpace(_correntTeam.department))
                errors.AppendLine("Отдел не может быть пустым");
            if (string.IsNullOrWhiteSpace(_correntTeam.post))
                errors.AppendLine("Должность не может быть пустой");
            if (string.IsNullOrWhiteSpace(_correntTeam.login))
                errors.AppendLine("Логин не может быть пустом");
            if (string.IsNullOrWhiteSpace(_correntTeam.password))
                errors.AppendLine("Пароль не может быть пустом");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_correntTeam.C_id == 0)
                appDVDsEntities.GetContext().teamDBs.Add(_correntTeam);
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