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
    public partial class TruckForm : Form
    {
        public TruckForm()
        {
            InitializeComponent();
        }

        private void addTruckBtn_Click(object sender, EventArgs e)
        {
            AddTruckForm atf = new AddTruckForm();
            atf.ShowDialog();
        }
    }
}
