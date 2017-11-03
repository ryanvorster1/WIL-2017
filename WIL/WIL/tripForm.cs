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
        }

        private void exitButton_Click(object sender, EventArgs e)
        { 
            //close form to get back to main form
            this.Close();
        }

        private void TripForm_Load(object sender, EventArgs e)
        {
          
            List<Trip> trips = new DBManager().GetTrips();
            foreach (var item in trips)
            {
                dataGridView1.Rows.Add(item.Truck.ID,item.Customer.ID,item.Start, item.End,item.Route.Departure,item.Route.Destination );
                
                
            }
            
        }
    }
}
