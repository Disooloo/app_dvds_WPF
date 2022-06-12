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
using System.Windows.Shapes;
using shop_DVDs.db;




namespace shop_DVDs.view.window
{
    /// <summary>
    /// Логика взаимодействия для loginWindow.xaml
    /// </summary>
    public partial class loginWindow : Window
    {
        public loginWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                try
                {
                    this.DragMove();
                }
                catch (Exception)
                {

                }
            }
               
        }

        private void close_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void enter_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            ManagerWindow managerWindow = new ManagerWindow();

            string login = loginbox.Text,
                pass = passBox.Password;
            int admin = 1;

            teamDB authUser = null;

            using (appDVDsEntities db = new appDVDsEntities())
            {
                authUser = db.teamDBs.Where(b => b.login == login && b.password == pass).FirstOrDefault();
            }

            if (authUser != null && authUser.role == admin)
            {
                MessageBox.Show(authUser.surname.ToString() + " " + authUser.name.ToString() + "| Вы авторизовались под админкой 1 уровня");
                mainWindow.Show();
                this.Close();
            } 
            else if (authUser != null && authUser.role != admin)
            {
                MessageBox.Show("Добро пожаловать: "  + authUser.surname.ToString() + " " + authUser.name.ToString() );
                managerWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }

        }
    }
}

//b64->QGRpc29vbG9v