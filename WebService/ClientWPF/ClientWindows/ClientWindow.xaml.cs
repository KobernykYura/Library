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

namespace ClientWPF.ClientWindows
{
    /// <summary>
    /// Логика взаимодействия для ClientWindow.xaml
    /// </summary>
    public partial class ClientWindow : Window
    {
        public ClientWindow()
        {
            InitializeComponent();
        }

        private void btnShowBooks_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnChooseCategory_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnShowReaders_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAddBook_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void miReLogin_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            LoginWindow lw = new LoginWindow();
            lw.Show();
        }

        private void miClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
