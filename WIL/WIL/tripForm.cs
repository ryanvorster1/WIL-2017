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
            Console.WriteLine(dtpTrips.Value);
            //UpdateDGVTrips(dtpTrips.Value);     
        }

        private void exitButton_Click(object sender, EventArgs e)
        { 
            //close form to get back to main form
            this.Close();
        }

        private void TripForm_Load(object sender, EventArgs e)
        {
            UpdateDGVTrips(dtpTrips.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlReportView.Visible = true;
            viewPlannedTripsBtn.Visible = false;
            viewCompletedTripsBtn.Visible = false;
            //clear cols
            dataGridView1.Columns.Clear();
            //add col headers
            dataGridView1.Columns.Add("ID", "Truck ID");
            dataGridView1.Columns.Add("Username", "Driver");
            dataGridView1.Columns.Add("Kms", "Kiliometers Travelled");
            dataGridView1.Columns.Add("Destination", "Destination");

            //resize rows


            // dataGridView1.AutoResizeColumns();// = DataGridViewAutoSizeColumnsMode.None;
            // dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            //clear rows
            dataGridView1.Rows.Clear();
            List<Trip> trips = new DBManager().GetTrips();
            foreach (var item in trips)
            {
                
                dataGridView1.Rows.Add(item.Truck.ID, item.Driver.Username, item.Route.Kms, item.Route.Destination);
               
               
            }
        
        }

        private void btnCloseReportView_Click(object sender, EventArgs e)
        {

            UpdateDGVTrips(dtpTrips.Value);
            
            pnlReportView.Visible = false;
            viewPlannedTripsBtn.Visible = true;
            viewCompletedTripsBtn.Visible = true;
        }

        private void dtpTrips_ValueChanged(object sender, EventArgs e)
        {
            UpdateDGVTrips(dtpTrips.Value);
        }

        private void UpdateDGVTrips(DateTime selected)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Add("ID", "Truck ID");
            dataGridView1.Columns.Add("Username", "Driver");
            dataGridView1.Columns.Add("Kms", "Kiliometers Travelled");
            dataGridView1.Columns.Add("Destination", "Destination");
            List<Trip> trips = new DBManager().GetTrips(selected);
            foreach (var item in trips)
            {
                dataGridView1.Rows.Add(item.Truck.ID, item.Customer.ID, item.Start, item.End, item.Route.Departure, item.Route.Destination);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
