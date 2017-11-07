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
using System.Data.SqlClient;

namespace WIL
{
    public partial class ServiceForm : Form
    {

        private DBManager dbm;
        private bool isReport;
        private List<Service> displayedServices;

        public ServiceForm()
        {
            dbm = new DBManager();

            InitializeComponent();
           // dtpDateTime_ValueChanged(null, null);
        }

        private void DisplayServiceHeadings()
        {
            lvServiceList.Columns.Add("Truck ID", 100);
            lvServiceList.Columns.Add("Truck Type", 200);
            lvServiceList.Columns.Add("Service #", 800);
        }


        private void bttnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private async void displayIncompleteServices()
        //{

        //    DateTime theDate = dtpDateTime.Value;
        //    List<Service> services = new List<Service>();

        //    if (cmbViewType.SelectedItem != null)
        //    {
        //        switch (cmbViewType.SelectedItem.ToString())
        //        {
        //            case "Daily":
        //                services = await dbm.GetIncompleteServices(theDate,theDate.AddDays(1));
        //                break;
        //            case "Weekly":
        //                services = await dbm.GetIncompleteServices(theDate, theDate.AddDays(7));
        //                break;
        //            case "Monthly":
        //                services = await dbm.GetIncompleteServices(theDate, theDate.AddMonths(1));
        //                break;
        //        }

        //        lvServiceList.Clear();
        //        DisplayServiceHeadings();
        //        if (services.Count > 0)
        //        {
        //            UpdateListBox(services);
        //            lvServiceList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        //            //ServiceReport();
        //        }
        //    }

        //}

        private async void dtpDateTime_ValueChanged(object sender, EventArgs e)
        {
            DateTime theDate = dtpDateTime.Value;
            List<Service> services = new List<Service>();

            if (cmbViewType.SelectedItem != null)
            {
                switch(cmbViewType.SelectedItem.ToString())
                {
                    case "Daily":
                        services = await dbm.GetServices(theDate, theDate.AddDays(1));

                    break;
                    case "Weekly":
                        services = await dbm.GetServices(theDate, theDate.AddDays(7));

                    break;
                    case "Monthly":
                        services = await dbm.GetServices(theDate, theDate.AddMonths(1));

                    break;
                    case "Yearly":
                        services = await dbm.GetServices(theDate, theDate.AddYears(1));
                    
                    break;
                }

                lvServiceList.Clear();
                DisplayServiceHeadings();
                displayedServices = services;
                if (services.Count > 0)
                {
                    UpdateListBox(services);
                    lvServiceList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                }

            
            }
        }


        private async void UpdateListBox(List<Service> results)
        {
            lvServiceList.Items.Clear();

            foreach (Service item in results)
            {
                string serviceJobs = "";
                List<ServiceItem> serviceItems = await dbm.GetServiceItems(item);
                foreach (ServiceItem i in serviceItems)
                {
                    serviceJobs += i.ServiceType.Job + ",";
                }
                if (serviceJobs.Length > 80)
                {
                    serviceJobs = serviceJobs.Substring(0, 79) + "...";
                }
                String[] items = { item.Truck.ID.ToString(), item.Truck.Type.ToString(), serviceJobs};
                ListViewItem lvi = new ListViewItem(items);
                if (item.Complete)
                {
                    lvi.BackColor = Color.Green;
                } else
                {
                    lvi.BackColor = Color.Red;
                }
                lvServiceList.Items.Add(lvi);
            }
            lvServiceList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
          
        }

  
        private async void lvServiceList_DoubleClick(object sender, EventArgs e)
        {
            if (lvServiceList.SelectedItems.Count >= 0)
            {
                ListViewItem selecteditem = lvServiceList.SelectedItems[0];
                int truckID = Convert.ToInt32(selecteditem.SubItems[0].Text);
                List<Service> services = await dbm.GetServices();
                int serviceID = -1;

                foreach (var item in services)
                {
                    if(item.Truck.ID == truckID)
                    {
                        serviceID = item.ID;
                            break;
                    }
                }
                Service service = services[serviceID];
                ServiceDetailsForm svcDetailfrm = new ServiceDetailsForm(service);
                svcDetailfrm.ShowDialog();
            }

        }

        private void bttnServiceReport_Click(object sender, EventArgs e)
        {
            pnlServiceReport.Visible = true;
            btnServiceReport.Visible = false;
            //update 
            ServiceReport();
            isReport = true;

        }

        private void btnCloseReport_Click(object sender, EventArgs e)
        {
            pnlServiceReport.Visible = false;
            btnServiceReport.Visible = true;
        }

        private void lvServiceList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void ServiceForm_Load(object sender, EventArgs e)
        {
            cmbViewType.SelectedIndex = 0;
           // dtpDateTime_ValueChanged(sender, e);
            isReport = false;
        }

        private void cmbViewType_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtpDateTime_ValueChanged(sender, e);

        }

        private async void ServiceReport()
        {
            DateTime theDate = dtpDateTime.Value;
            List<Service> services = new List<Service>();
            List<Truck> trucks = new List<Truck>();

            if (cmbViewType.SelectedItem != null)
            {
                switch (cmbViewType.SelectedItem.ToString())
                {
                    case "Daily":
                        services = await dbm.GetServices(theDate, theDate.AddDays(1));
                        lblServiceReport.Text = "Daily Service Report";

                        break;
                    case "Weekly":
                        services = await dbm.GetServices(theDate, theDate.AddDays(7));
                        lblServiceReport.Text = "Weekly Service Report";

                        break;
                    case "Monthly":
                        services = await dbm.GetServices(theDate, theDate.AddMonths(1));
                        lblServiceReport.Text = "Monthly Service Report";
                        break;

                    case "Yearly":
                        services = await dbm.GetServices(theDate, theDate.AddYears(1));
                        lblServiceReport.Text = "Yearly Service Report";
                        break; 
                }

                double cost = 0;
                double hours = 0;
                foreach (var service in services)
                {
                    List<ServiceItem> serviceItems = await dbm.GetServiceItems(service);
                    foreach (var serviceItem in serviceItems)
                    {
                        cost += serviceItem.ServiceType.Cost;
                        hours += serviceItem.ServiceType.Hours;
                    }
                }

                lbltotalService.Text = services.Count.ToString();
                lblTotalCost.Text = cost.ToString();
                totalHoursLbl.Text = hours.ToString();
            }
        }


    }
}
