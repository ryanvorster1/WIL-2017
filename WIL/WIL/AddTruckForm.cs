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

        private void AddTruckForm_Load(object sender, EventArgs e)
        {
            typeComboBox.DataSource = db.GetTruckType();
            typeComboBox.DisplayMember = "Type";
            typeComboBox.ValueMember = "ID";
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            //Open Truck Form when cancel button is clicked
            this.Close();
        }

        private void AddTruckBtn_Click(object sender, EventArgs e)
        {
            
            string Vin = vinTxtBox.Text;
            string Reg = regTxtBox.Text;
            int Kms = Convert.ToInt32(mileageBox.Text);
            TruckType type = db.GetTruckTypeById((int)typeComboBox.SelectedValue);
            
            Truck truck = new Truck(Vin, Reg, Kms, type);

            db.AddTruck( ref truck);
        }
    }
}
