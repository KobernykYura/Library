using System;
using System.Windows.Forms;

namespace Client
{
    public partial class AdminForm : Form
    {
        Service.WebServiceSoapClient serv;

        public AdminForm()
        {
            InitializeComponent();
        }

        private void loginclient_Click(object sender, EventArgs e)
        {
            Hide();
            Login form = new Login();
            form.Show();
        }

        private void viewworkers_Click(object sender, EventArgs e)
        {
            label2.Text = "Workers";
            personsdataGrid.DataSource = serv.LoadWorkers();
        }

        private void viewreders_Click(object sender, EventArgs e)
        {
            label2.Text = "Readers";
            personsdataGrid.DataSource = serv.LoadReaders();
        }
    }
}
