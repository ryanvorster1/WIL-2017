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
        private DBManager dbm;
        private List<Trip> displayedTrips;
        private bool isCurrentTrips;
        public TripForm()
        {
            dbm = new DBManager();
            InitializeComponent();
            isCurrentTrips = false;
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
            //UpdateDGVTrips();
        }

        private async void btnViewReport_Click(object sender, EventArgs e)
        {
            pnlReportView.Visible = true;
            btnPlannedTrips.Visible = false;
            btnCompleteTrips.Visible = false;
            //clear cols
            dgvTrips.Columns.Clear();
            //add column headingname and text 
            dgvTrips.Columns.Add("ID", "Truck ID");
            dgvTrips.Columns.Add("Username", "Driver");
            dgvTrips.Columns.Add("Kms", "Kiliometers Travelled");
            dgvTrips.Columns.Add("Destination", "Destination");

            // dataGridView1.AllowUserToResizeRows = false;
           // dgvTrips.AutoResizeRows(DataGridViewAutoSizeRowsMode.DisplayedHeaders);

            //clear rows
            dgvTrips.Rows.Clear();
            displayedTrips = await new DBManager().GetTrips();

            foreach (var item in displayedTrips)
            {
                dgvTrips.Rows.Add(item.Truck.ID, item.Driver.Username, item.Route.Kms, item.Route.Destination);

            }

            //get total kms method
            //getOverall();
        }

        private void btnCloseReportView_Click(object sender, EventArgs e)
        {

            UpdateDGVTrips();

            pnlReportView.Visible = false;
            btnPlannedTrips.Visible = true;
            btnCompleteTrips.Visible = true;
        }

        private void dtpTrips_ValueChanged(object sender, EventArgs e)
        {
            UpdateDGVTrips();
        }

        private async void UpdateDGVTrips()
        {
            Console.WriteLine(isCurrentTrips);
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
                if (isCurrentTrips)
                {
                    displayedTrips = await dbm.GetInCompleteTrips(start, end);
                } else
                {
                    displayedTrips = await dbm.GetCompleteTrips(start, end);
                }

                int index = 0;
                foreach (var item in displayedTrips)
                {
                    dgvTrips.Rows.Add(item.Truck.ID, item.Customer.ID, item.Route.Kms, item.Start, item.End, item.Route.Destination);

                    switch (item.Status.ID)
                    {//awaiting
                        case 0:
                            dgvTrips.Rows[index].DefaultCellStyle.BackColor = Color.Red;
                            break;
                        case 1:
                            dgvTrips.Rows[index].DefaultCellStyle.BackColor = Color.Yellow;
                            break;
                        case 2:
                            dgvTrips.Rows[index].DefaultCellStyle.BackColor = Color.Green;
                            break;
                    }
                    index++;
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDGVTrips();
        }
        private void viewPlannedTripsBtn_Click(object sender, EventArgs e)
        {
            isCurrentTrips = false;
            btnPlannedTrips.Visible = false;
            btnCompleteTrips.Visible = true;
            UpdateDGVTrips();
        }
        
        private void btnLogIncident_Click(object sender, EventArgs e)
        {
            foreach (var item in dgvTrips.SelectedCells)
            {
                Console.WriteLine(item);
            }
            //new LogIncidentForm().ShowDialog();
        }

        private void dgvTrips_DoubleClick(object sender, EventArgs e)
        {
            if(dgvTrips.SelectedCells != null)
            {
                Trip selectedTrip = displayedTrips[dgvTrips.CurrentCell.RowIndex];
                new LogIncidentForm(selectedTrip).ShowDialog();
            }
        }

        private void viewCompletedTripsBtn_Click(object sender, EventArgs e)
        {
            isCurrentTrips = true;
            btnCompleteTrips.Visible = false;
            btnPlannedTrips.Visible = true;
            UpdateDGVTrips();
        }
    }

}
