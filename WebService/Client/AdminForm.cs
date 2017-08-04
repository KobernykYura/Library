using System;
using System.Windows.Forms;

namespace Client
{
    public partial class AdminForm : Form
    {
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
    }
}
