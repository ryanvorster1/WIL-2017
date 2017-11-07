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
    public partial class BookingsForm : Form
    {
        private DBManager db;
        public BookingsForm()
        {
            InitializeComponent();
            db = new DBManager();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            //Open trip Form when cancel button is clicked
            this.Close();

        }

        private void AddCustBtn_Click(object sender, EventArgs e)
        {
            //Open add customer form when add customer button is clicked
            AddCustomerForm acf = new AddCustomerForm();
            acf.ShowDialog();

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePicker.Value;
        }

        private async void bookBtn_Click(object sender, EventArgs e)
        {
            TruckType type = await db.GetTruckTypeById((int)slctTruckBox.SelectedValue);

            //List<Truck> trucks = await db.GetAvailiableTrucks(type);
            try
            {
                Truck truck = await db.GetNextAvailableTruck(type);
                List<User> users = await db.GetAvailibleDrivers();//[0];
                User user = users[0];
                Route route = await db.GetRouteByID((int)destinationBox.SelectedValue);
                TripStatus status = await db.GetTripStatusByID(0);

                Customer customer = await db.GetCustomerByID((int)cmbCustomers.SelectedValue);

                Trip trip = new Trip(truck, customer, (DateTime)dateTimePicker.Value, (DateTime)dateTimePicker.Value.AddDays(3), user, route, status);

                trip = await db.BookTrip(trip);

                MessageBox.Show($"Trip booked for {trip.Start} with Truck {trip.Truck.ID}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Next availible date: " + await db.NextAvailibleDate(type));
                return;
            }

          

            this.Close();
            
        }

        private async void BookingsForm_Load(object sender, EventArgs e)
        {
            cmbCustomers.DataSource = await db.GetCustomers();
            cmbCustomers.DisplayMember = "Fname";
            cmbCustomers.ValueMember = "ID";

            slctTruckBox.DataSource = await db.GetTruckType();
            slctTruckBox.DisplayMember = "Type";
            slctTruckBox.ValueMember = "ID";

            destinationBox.DataSource = await db.GetRoutes();
            destinationBox.DisplayMember = "Destination";
            destinationBox.ValueMember = "ID";

        }
    }
}
