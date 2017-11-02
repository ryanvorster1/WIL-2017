using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemLogic;

namespace WIL
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txbPassword.Text.Length > 0 && txbUsername.Text.Length > 0){
                User loggedIn = new DBManager().LogInUser(txbUsername.Text, txbPassword.Text);
                if(loggedIn != null)
                {
                    new MainForm(loggedIn).Show();
                } else
                {
                    MessageBox.Show("Invalid username or password");
                }

            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txbUsername.Visible = true;
            ActiveControl = txbUsername;

        }
    }
}
