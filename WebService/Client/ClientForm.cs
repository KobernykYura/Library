using System;
using System.Windows.Forms;

namespace Client
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void loginadmin_Click(object sender, EventArgs e)
        {
            Hide();
            Login form = new Login();
            form.Show();
        }
    }
}
