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
        private bool updating;
        private DBManager dbm;
        private Trip trip;
        public LogIncidentForm(Trip trip)
        {
            InitializeComponent();
            dbm = new DBManager();
            this.trip = trip;
        }

        private void LogIncidentForm_Load(object sender, EventArgs e)
        {
            cnbIncidents.Items.Clear();
            cnbIncidents.Items.Add("Select item here>");
            updating = true;
            cnbIncidents.SelectedIndex = 0;
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            switch (trip.Status.ID)
            {
                case 0:
                    lblTripStatus.Text = "Awaiting Trip: ";
                    btnTripStatus.Text = "Begin Trip";
                    pnlTripDetails.BackColor = Color.Red;
                    break;
                case 1:
                    lblTripStatus.Text = "Current Trip";
                    btnTripStatus.Text = "Complete Trip";
                    pnlTripDetails.BackColor = Color.Yellow;
                    btnLogIncident.Visible = true;
                    break;
                case 2:
                    btnTripStatus.Visible = false;
                    pnlTripDetails.BackColor = Color.Green;
                    lblTripStatus.Text = "Complete Trip: ";
                    break;
            }

            lblDriver.Text = trip.Driver.Fname + " " + trip.Driver.Lname;
            lblTrip.Text = trip.Route.ToString();
            lblTruck.Text = trip.Truck.ToString();

        }

        private void btnLogIncident_Click(object sender, EventArgs e)
        {
            pnlIncident.Visible = true;
        }
       
        private void cancelButton_Click(object sender, EventArgs e)
        {
            pnlIncident.Visible = false;
        }

        private async void sendIncidentReportButton_Click(object sender, EventArgs e)
        {
            int serviceID = await dbm.GetOrCreateLatestServiceID(trip.Truck);
            Console.WriteLine($"im using service id {serviceID}");
            ServiceType type = await dbm.GetServiceTypeById((int)cnbIncidents.SelectedValue);
            Service service = await dbm.GetServiceById(serviceID);
            ServiceItem si = await dbm.AddServiceIem(service,type);
            MessageBox.Show(si.ToString());


            //if(await dbm.AddServiceIem(service, await dbm.GetServiceTypeById((int)cnbIncidents.SelectedValue)) != null)
            //{

            //    MessageBox.Show("Report succesful");
            //pnlIncident.Visible = false;

            //} else
            //{
            //    MessageBox.Show("Couldnt add incident");

            //}
        }

        private async void startbtn_Click(object sender, EventArgs e)
        {
            switch (trip.Status.ID)
            {
                case 0: //awaiting (start trip)
                    btnLogIncident.Visible = false;
                    trip = await dbm.StartTrip(trip);
                    break;
                case 1://on route (complete trip)
                    btnLogIncident.Visible = true;
                    trip = await dbm.CompleteTrip(trip);
                    break;
                case 2:

                    break;
            }
            MessageBox.Show("trip updated " + trip.Status.Status);
            UpdateDisplay();
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

        private async void cnbIncidents_MouseClick(object sender, MouseEventArgs e)
        {
           
                cnbIncidents.DataSource = await dbm.GetServiceTypes();
                cnbIncidents.DisplayMember = "Job";
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
