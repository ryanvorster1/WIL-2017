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
    public partial class BookingsForm : Form
    {
        private DBManager db;
        public BookingsForm()
        {
            InitializeComponent();
            db = new DBManager();
        }

        private void slctCustBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            slctCustBox.DataSource = db.GetCustomers();
            slctCustBox.DisplayMember = "Fname";
            slctCustBox.ValueMember = "ID";
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            //Open trip Form when cancel button is clicked
            TripForm tf = new TripForm();

        }

        private void AddCustBtn_Click(object sender, EventArgs e)
        {
            //Open add customer form when add customer button is clicked
            AddCustomerForm acf = new AddCustomerForm();
            acf.ShowDialog();
            this.Close();
        }

        private void bookBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Trip booked");
            this.Close();

        }
    }
}