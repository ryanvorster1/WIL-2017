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
    }
}
