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
            TruckType type = db.GetTruckTypeById((int)slctTruckBox.SelectedValue);

            List<Truck> trucks = db.GetAvailiableTrucks(type);
            Truck truck = trucks[0];
            List<User> users = db.GetAvailibleDrivers();//[0];
            User user = users[0];
            Route route = db.GetRouteByID((int)destinationBox.SelectedValue);
            
            
            Customer customer = db.GetCustomerByID((int)cmbCustomers.SelectedValue);

            Trip trip = new Trip(truck, customer, (DateTime)dateTimePicker.Value, (DateTime)dateTimePicker.Value.AddDays(3), user, route);
            
            await db.BookTrip(trip);
            this.Close();


        }

        private void BookingsForm_Load(object sender, EventArgs e)
        {
            cmbCustomers.DataSource = db.GetCustomers();
            cmbCustomers.DisplayMember = "Fname";
            cmbCustomers.ValueMember = "ID";

            slctTruckBox.DataSource = db.GetTruckType();
            slctTruckBox.DisplayMember = "Type";
            slctTruckBox.ValueMember = "ID";

            destinationBox.DataSource = db.GetRoutes();
            destinationBox.DisplayMember = "Destination";
            destinationBox.ValueMember = "ID";

        }
    }
}
