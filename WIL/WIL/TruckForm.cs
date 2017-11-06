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

        private void TruckForm_Load(object sender, EventArgs e)
        {
            UpdateDGVTrucks();
        }

        private async void UpdateDGVTrucks()
        {
            DBManager db = new DBManager();

            dgvTrucks.Columns.Clear();

            dgvTrucks.Columns.Add("ID", "Truck ID");
            dgvTrucks.Columns.Add("VIN", "VIN Number");
            dgvTrucks.Columns.Add("Reg", "Registration Number");
            dgvTrucks.Columns.Add("Kms", "Mileage");
            dgvTrucks.Columns.Add("Type", "Vehicle Type");
            List<Truck> trucks = await db.GetTrucks();

            foreach (var item in trucks)
            {
                dgvTrucks.Rows.Add(item.ID, item.Vin, item.Reg, item.Kms, item.Type.Type);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
