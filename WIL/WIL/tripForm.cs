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
    public partial class TripForm : Form
    {
        public TripForm()
        {
            InitializeComponent();
        }

        private void addTripButton_Click(object sender, EventArgs e)
        {
            //Show add bookings form once add trip button is clicked
            BookingsForm bf = new BookingsForm();
            bf.ShowDialog();
            //this.Close(); 
            UpdateDGVTrips();     
        }

        private void exitButton_Click(object sender, EventArgs e)
        { 
            //close form to get back to main form
            this.Close();
        }

        private void TripForm_Load(object sender, EventArgs e)
        {
            UpdateDGVTrips();
            cmbViewType.SelectedIndex = 0;
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            pnlReportView.Visible = true;
            viewPlannedTripsBtn.Visible = false;
            viewCompletedTripsBtn.Visible = false;
            //clear cols
            dgvTrips.Columns.Clear();
            //add column headingname and text 
            dgvTrips.Columns.Add("ID", "Truck ID");
            dgvTrips.Columns.Add("Username", "Driver");
            dgvTrips.Columns.Add("Kms", "Kiliometers Travelled");
            dgvTrips.Columns.Add("Destination", "Destination");

            //resize rows


            // dataGridView1.AutoResizeColumns();// = DataGridViewAutoSizeColumnsMode.None;
            // dataGridView1.AllowUserToResizeRows = false;
            dgvTrips.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            //clear rows
            dgvTrips.Rows.Clear();
            List<Trip> trips = new DBManager().GetTrips();
            foreach (var item in trips)
            {

                dgvTrips.Rows.Add(item.Truck.ID, item.Driver.Username, item.Route.Kms, item.Route.Destination);
               
               
            }
        
        }

        private void btnCloseReportView_Click(object sender, EventArgs e)
        {

            UpdateDGVTrips();
            
            pnlReportView.Visible = false;
            viewPlannedTripsBtn.Visible = true;
            viewCompletedTripsBtn.Visible = true;
        }

        private void dtpTrips_ValueChanged(object sender, EventArgs e)
        {
            UpdateDGVTrips();
        }

        private void UpdateDGVTrips()
        {
            dgvTrips.Rows.Clear();
            dgvTrips.Columns.Add("ID", "Truck ID");
            dgvTrips.Columns.Add("Username", "Driver");
            dgvTrips.Columns.Add("Kms", "Kiliometers Travelled");
            dgvTrips.Columns.Add("Destination", "Destination");

            DateTime start = dtpTrips.Value; ;
            DateTime end = start;

            if (cmbViewType.SelectedItem != null)
            {

                switch (cmbViewType.SelectedItem.ToString())
                {
                    case "Daily":
                        end = start.AddDays(1);
                        break;
                    case "Weekly":
                        end.AddDays(7);
                        break;
                    case "Monthly":
                        end.AddMonths(1);
                        break;
                }

                List<Trip> trips = new DBManager().GetTrips();//start,end);
                foreach (var item in trips)
                {
                    dgvTrips.Rows.Add(item.Truck.ID, item.Customer.ID, item.Start, item.End, item.Route.Departure, item.Route.Destination);
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDGVTrips();
        }
    }
}
