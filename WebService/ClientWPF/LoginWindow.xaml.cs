using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientWPF.ClientWindows;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ClientWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        LibServiceReference.WebServiceSoapClient serv;
        Window form;

        public LoginWindow()
        {
            InitializeComponent();
            serv = new LibServiceReference.WebServiceSoapClient();
        }

        private void btnAcceptLogin_Click(object sender, RoutedEventArgs e)
        {
            string login = txtLogin.Text;
            string password = passwordBox.Password;
            //DialogResult res;

            var condition = serv.CheckLogin(login, password);
            if (condition.mean)
            {
                Hide();
                if (condition.MeanID == 1) form = new AdminWindow();
                else form = new ClientWindow();
                form.Show();
            }
            else DialogWindow();
        }
        private void DialogWindow()
        {
            var res = MessageBox.Show("Incorrect password or login. Try once again!", "Invalid login", MessageBoxButton.OK, MessageBoxImage.Information);
            if (res == MessageBoxResult.OK) { txtLogin.Text = null; passwordBox.Password = null; }
        }
    }
}
