using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.Close();      
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close form when exit button is clicked and open Main Form
            this.Close();
            MainForm mf = new MainForm();
            mf.ShowDialog();

        }
    }
}
