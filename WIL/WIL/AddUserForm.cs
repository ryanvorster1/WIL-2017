﻿using System;
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
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(txbFName.Text.Length > 0 && txbLname.Text.Length > 0 && txbEmail.Text.Length > 0 & txbCell.Text.Length > 0)
            {
                Customer cus = new Customer(txbFName.Text, txbLname.Text, txbEmail.Text, txbCell.Text);
                int cusID = new DBManager().AddCustomer(ref cus);
                MessageBox.Show($"Customer {cusID} has been added sucsessfully.");
                Close();
            } else
            {
                MessageBox.Show("Complete all fields");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
