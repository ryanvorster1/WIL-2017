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
    public partial class DriverForm : Form
    {
        public DriverForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DriverForm_Load(object sender, EventArgs e)
        {
            lsbAvailibleTrips.DataSource = new DBManager().GetTrips();
        }
    }
}
