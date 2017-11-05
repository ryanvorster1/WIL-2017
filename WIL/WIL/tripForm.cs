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
            UpdateDGVTrips();     
        }

        private void exitButton_Click(object sender, EventArgs e)
        { 
            //close form to get back to main form
            this.Close();
        }

        private void TripForm_Load(object sender, EventArgs e)
        {
            cmbViewType.SelectedIndex = 0;
            UpdateDGVTrips();
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
            dgvTrips.Columns.Clear();
            dgvTrips.Columns.Add("ID", "Truck ID");
            dgvTrips.Columns.Add("CustomerID", "CustomerID");
            dgvTrips.Columns.Add("Kms", "Kiliometers Travelled");
            dgvTrips.Columns.Add("startDate", "Start Date");
            dgvTrips.Columns.Add("endDate", "End Date");
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
                        end = end.AddDays(7);
                        break;
                    case "Monthly":
                        end = end.AddMonths(1);
                        break;
                    case "Yearly":
                        end = end.AddYears(1);
                        break;
                }

                List<Trip> trips = new DBManager().GetTrips(start,end);
                DataTable table = new DataTable();
                
                foreach (var item in trips)
                {
                    Console.WriteLine(item.ToString());
                    dgvTrips.Rows.Add(item.Truck.ID, item.Customer.ID, item.Route.Kms, item.Start, item.End, item.Route.Destination);
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDGVTrips();
        }

        private void dgvTrips_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void viewPlannedTripsBtn_Click(object sender, EventArgs e)
        {
            UpdateDGVTrips();
        }
    }
}
