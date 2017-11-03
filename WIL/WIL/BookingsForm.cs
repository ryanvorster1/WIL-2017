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
            tf.ShowDialog();

            this.Close();

        }

        private void AddCustBtn_Click(object sender, EventArgs e)
        {
            //Open add customer form when add customer button is clicked
            AddCustomerForm acf = new AddCustomerForm();
            acf.ShowDialog();
            this.Close();
        }

        private void slctTruckBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            slctTruckBox.DataSource = db.GetTruckType();
            slctTruckBox.DisplayMember = "type";
            slctTruckBox.ValueMember = "ID";
        }

        private void deptartBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            deptartBox.DataSource = db.GetDepartments();
            deptartBox.DisplayMember = "name";
            deptartBox.ValueMember = "ID";
        }

        private void destinationBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            destinationBox.DataSource = db.GetRoutes();
            destinationBox.DisplayMember = "Destination.Name";
            destinationBox.ValueMember = "ID";
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePicker.Value;

        private void bookBtn_Click(object sender, EventArgs e)
        {
            TruckType type = db.GetTruckTypeById((int)slctTruckBox.SelectedValue);

            Truck truck = db.GetAvailiableTrucks(type)[0];
            User user = db.

            Trip trip = new Trip(truck, slctTruckBox.SelectedIndex, slctCustBox.SelectedIndex, dateTimePicker.Value, dateTimePicker.Value.AddDays(3), ,destinationBox.SelectedValue );
            
            //slctCustBox.SelectedValue()

            db.BookTrip();
            MessageBox.Show("Trip booked");
            this.Close();


        }
    }
}
