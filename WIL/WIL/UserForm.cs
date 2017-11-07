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
    public partial class UserForm : Form
    {
        private DBManager dbm;
        private bool updating;

        public UserForm()
        {
            InitializeComponent();
            dbm = new DBManager();
            UpdateLsbUsers();

        }

        private void UserForm_Load(object sender, EventArgs e)
        {
        }

        private async void UpdateLsbUsers()
        {
            updating = true;
            lsbUsers.DataSource = await dbm.GetUsers();
            lsbUsers.DisplayMember = "Username";
            lsbUsers.ValueMember = "ID";
            updating = false;
        }

        private async void lsbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!updating)
            {
                pnlAddUser.Visible = false;
                int id = Convert.ToInt32( lsbUsers.SelectedValue.ToString());
                User user = await dbm.GetUserByID(id);
                lblName.Text = user.Fname;
                lblSurname.Text = user.Lname;
                lblHours.Text = user.Hours + " hrs";
                lblType.Text = user.Type.Type;
                pnlDetails.Visible = true;
            }

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            //hide details
            pnlDetails.Visible = false;
            //show controls
            pnlAddUser.Visible = true;
            //update controls
            foreach (var item in dbm.GetUserTypes())
            {
                cmbUserType.Items.Add(item);
            }

            cmbUserType.DisplayMember = "Type";
            cmbUserType.ValueMember = "ID";

            txbName.Text = "";
            txbSurname.Text = "";
            txbPass1.Text = "";
            txbPass2.Text = "";

        }

        private async void btnOK_Click(object sender, EventArgs e)
        {
            string name = txbName.Text;
            string surname = txbSurname.Text;
            string pass1 = txbPass1.Text;
            string pass2 = txbPass2.Text;
            int typeID = Convert.ToInt32(cmbUserType.SelectedValue);

            UserType type = await dbm.GetUserTypeById(typeID);

            if (!name.Equals("") && !surname.Equals("") && !pass1.Equals("") && !pass2.Equals(""))
            {
                if (pass1.Equals(pass2))
                {
                    User user = new User(name + surname, pass1, type, name, surname);
                    try
                    {
                        dbm.AddUser(user);

                        UpdateLsbUsers();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    pnlAddUser.Visible = false;
                }
                else
                {
                    MessageBox.Show("Passwords do not match.");
                }
            }
            else
            {
                MessageBox.Show("Complete all fields.");
            }

        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
