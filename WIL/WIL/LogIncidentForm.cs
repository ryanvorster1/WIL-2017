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
    public partial class LogIncidentForm : Form
    {
        private User loggedIn;
        private bool updating;
        private DBManager dbm;
        private bool isCurrentTrip;
        public LogIncidentForm(User user)
        {
            loggedIn = user;
            InitializeComponent();
            dbm = new DBManager();
        }

        private async void LogIncidentForm_Load(object sender, EventArgs e)
        {
            cnbIncidents.Items.Clear();
            cnbIncidents.Items.Add("Select item here>");
            updating = true;
            cnbIncidents.SelectedIndex = 0;

            Trip awaitingTrip = await dbm.GetAwaitingTrip(loggedIn);

            if(awaitingTrip != null)
            {//show in trip
                switch (awaitingTrip.Status.ID)//awaiting
                {
                    case 0:
                        MessageBox.Show("Awaiting " + awaitingTrip.ToString());

                        break;
                    case 1: // on way
                        MessageBox.Show("On way " + awaitingTrip.ToString());
                        break;
                    case 2:
                        MessageBox.Show("Complete" + awaitingTrip.ToString());
                        break;
                }
                isCurrentTrip = false;
                startbtn.Text = "Start Trip";
            }else// if() trip on way
            {
                if()
                isCurrentTrip = true;
                startbtn.Text = "Complete Trip";
            }

            lblTrip.Text = awaitingTrip.ToString();
            lblTruck.Text = awaitingTrip.Truck.ToString() + " " + awaitingTrip.Truck.ID;


        }

        private void btnLogIncident_Click(object sender, EventArgs e)
        {
            pnlIncident.Visible = true;
        }
       
        private void cancelButton_Click(object sender, EventArgs e)
        {
            pnlIncident.Visible = false;
        }

        private void sendIncidentReportButton_Click(object sender, EventArgs e)
        {
           dbm.LogIncident((int)cnbIncidents.SelectedValue,loggedIn);

            MessageBox.Show("Report succesful");
            pnlIncident.Visible = false;
        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            btnLogIncident.Visible = true;
        }

        private void cnbIncidents_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (!updating)
            //{
            //    cnbIncidents.DataSource = new DBManager().GetIncidentTypes();
            //    cnbIncidents.DisplayMember = "Description";
            //    cnbIncidents.ValueMember = "ID";
            //}
            //updating = false;
        }

        private void cnbIncidents_MouseClick(object sender, MouseEventArgs e)
        {
           
                cnbIncidents.DataSource = new DBManager().GetIncidentTypes();
                cnbIncidents.DisplayMember = "Description";
                cnbIncidents.ValueMember = "ID";
            
            updating = false;
        }

        private void cnbIncidents_Click(object sender, EventArgs e)
        {

        }

        private void completedTripsbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
