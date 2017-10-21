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

        public UserForm()
        {
            InitializeComponent();
            dbm = new DBManager();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            UpdateLsbUsers();
        }

        private void UpdateLsbUsers()
        {
            lsbUsers.Items.Clear();
            List<User> users = dbm.GetUsers();
            foreach (var user in users)
            {
                lsbUsers.Items.Add(user);
            }
            lsbUsers.DisplayMember = "Username";
            lsbUsers.ValueMember = "ID";

        }

        private void lsbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(lsbUsers.SelectedValue);
            User user = dbm.GetUserByID(userID);
            Console.WriteLine($"changed! {user.Username}");//dbm.GetUserByID((int)lsbUsers.SelectedValue).ToString());
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            string name = txbName.Text;
            string surname = txbSurname.Text;
            string pass1 = txbPass1.Text;
            string pass2 = txbPass2.Text;
            int typeID = Convert.ToInt32(cmbUserType.SelectedValue);
            
            UserType type = dbm.GetUserTypeById(typeID);

            Console.WriteLine(type.ToString());

            if(!name.Equals("") && !surname.Equals("") && !pass1.Equals("") && !pass2.Equals(""))
            {
                if (pass1.Equals(pass2))
                {
                    User user = new User(name+surname,pass1,type,name,surname);
                    dbm.AddUser(ref user);
                    UpdateLsbUsers();
                }
                else
                {
                    MessageBox.Show("Passwords do not match.");
                }
            } else
            {
                MessageBox.Show("Complete all fields.");
            }

        }
    }
}
