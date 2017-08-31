using System;
using System.Windows.Forms;

namespace Client
{
    public partial class Login : Form
    {
        LibServiceReference.WebServiceSoapClient serv;
        Form form;

        public Login()
        {
            InitializeComponent();
            serv = new LibServiceReference.WebServiceSoapClient();
        }

        private void LoginIn_Click(object sender, EventArgs e)
        {
            string login = textBoxlogin.Text;
            string password = textBoxpassword.Text;
            //DialogResult res;

            var condition = serv.CheckLogin(login, password);
            if (condition.mean)
            {
                Hide();
                if (condition.MeanID == 1) form = new AdminForm();
                else form = new ClientForm();
                form.Show();
            }
            else DialogWindow();      
        }
            private void DialogWindow()
            {
                var res = MessageBox.Show("Incorrect password or login. Try once again!", "Invalid login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (res == DialogResult.OK) { textBoxlogin.Text = ""; textBoxpassword.Text = ""; }
            }
    }
}
