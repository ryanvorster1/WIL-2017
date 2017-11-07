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
    public partial class MainForm : Form
    {
        private User LoggedIn { get; set; }

        public MainForm(User loggedIn)
        {
            InitializeComponent();
            LoggedIn = loggedIn;
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            new UserForm().ShowDialog();
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            new ServiceForm().ShowDialog();
        }

        private void btnTrips_Click(object sender, EventArgs e)
        {
            new TripForm().ShowDialog();
        }

        private void btnTrucks_Click(object sender, EventArgs e)
        {
            new TruckForm().ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblUser.Text = LoggedIn.Fname;
        }

        private void routeBtn_Click(object sender, EventArgs e)
        {
            RouteForm rf = new RouteForm();
            rf.ShowDialog();
        }
    }
}
