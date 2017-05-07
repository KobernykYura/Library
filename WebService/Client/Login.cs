using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, FormClosingEventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;
            //DialogResult res;

            if (CheckLogin(login, password)) new AdminForm(); 
            else DialogWindow();
        }
        private void DialogWindow()
        {
            var  res = MessageBox.Show("Incorrect password or login. Try once again!", "Invalid login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (res == DialogResult.OK) Close();
        }
    }
}
