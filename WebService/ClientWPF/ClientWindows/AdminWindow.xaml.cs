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

namespace ClientWPF
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEditBook_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDeleteBook_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnChooseCategory_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAddReader_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDeleteReader_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEditReader_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnChooseReader_Click(object sender, RoutedEventArgs e)
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
