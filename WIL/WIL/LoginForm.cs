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

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (txbPassword.Text.Length > 0 && txbUsername.Text.Length > 0){
                User loggedIn = await new DBManager().LogInUser(txbUsername.Text, txbPassword.Text);
                if(loggedIn != null)
                {
                    switch (loggedIn.Type.Type.ToLower())
                    {
                        //case "driver":
                        //    //show driver form
                        //    new LogIncidentForm(loggedIn).Show();
                        //    break;
                        default:
                            new MainForm(loggedIn).Show();
                            break;
                    }
                  //  Close();
                } else
                {
                    MessageBox.Show("Invalid username or password");
                }

            }
        }

        private async void LoginForm_Load(object sender, EventArgs e)
        {
            txbUsername.Visible = true;
            ActiveControl = txbUsername;
            txbUsername.Text = "Bart";
            txbPassword.Text = "simps";
        }
    }
}
