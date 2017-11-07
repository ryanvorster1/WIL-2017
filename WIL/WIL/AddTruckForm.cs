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
    public partial class AddTruckForm : Form
    {
        private DBManager db;
        public AddTruckForm()
        {
            InitializeComponent();
            db = new DBManager();
        }

        private async void AddTruckForm_Load(object sender, EventArgs e)
        {
            typeComboBox.DataSource = await db.GetTruckTypes();
            typeComboBox.DisplayMember = "Type";
            typeComboBox.ValueMember = "ID";
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            //Open Truck Form when cancel button is clicked
             this.Close();
        }

        private async void AddTruckBtn_Click(object sender, EventArgs e)
        {
            if (vinTxtBox.Text.Length > 0 && regTxtBox.Text.Length > 0 && mileageBox.Text.Length > 0 && typeComboBox.SelectedValue != null)
            {

                string Vin = vinTxtBox.Text;
                string Reg = regTxtBox.Text;
                int Kms = Convert.ToInt32(mileageBox.Text);
                TruckType type = await db.GetTruckTypeById((int)typeComboBox.SelectedValue);

                Truck truck = new Truck(Vin, Reg, Kms, true, type);

                db.AddTruck(truck);
                MessageBox.Show("Truck added");
            } else
            {
                MessageBox.Show("Complete all fields.");

            }
        }
    }
}
