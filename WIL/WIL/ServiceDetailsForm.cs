using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SystemLogic;

namespace WIL
{
    public partial class ServiceDetailsForm : Form
    {
        private Service service;
        private bool updating;
        private DBManager dbm;

        private void ServiceDetailsForm_Load(object sender, EventArgs e)
        {
            PopulateFormWithResults(service);
        }

        public ServiceDetailsForm(Service service)
        {
            InitializeComponent();
            this.service = service;
            dbm = new DBManager();
        }

        private async void PopulateFormWithResults(Service pData)
        {
            lblMenumanufacturor.Text = pData.Truck.Vin.ToString();
            lblReg.Text = pData.Truck.Reg;
            lblManufacturor.Text = pData.Truck.Type.Manufacturor;
            lblTruckType.Text = pData.Truck.Type.Type;
            lblengineSize.Text = pData.Truck.Type.EngineSize.ToString();
            lblserviceInterval.Text = pData.Truck.Type.ServiceInterval.ToString();
            updating = true;
            List<ServiceItem> serviceItems = await dbm.GetServiceItems(pData);

            foreach (var item in serviceItems)
            {
                Console.WriteLine(item.ToString());
            }

            lsbServiceJobs.DataSource = serviceItems;
            lsbServiceJobs.DisplayMember = "ServiceType";
            lsbServiceJobs.ValueMember = "ID";
            updating = false;
        }


        private void bttnComplete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void lsbServiceJobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!updating)
            {
                ServiceItem serviceItem = await dbm.GetServiceItemById((int)lsbServiceJobs.SelectedValue);

                ServiceType serviceType = serviceItem.ServiceType;

                lblCost.Text = serviceType.Cost.ToString();
                lblHours.Text = serviceType.Hours.ToString();
            }
        }
    }
}
