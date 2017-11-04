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

        public ServiceForm()
        {
            dbm = new DBManager();
            InitializeComponent();
            dtpDateTime_ValueChanged(null, null);
        }

        void DBManager()
        {

        }

        private void ListBoxHandle()
        {
            lvServiceList.Columns.Add("Truck #", 200);
            lvServiceList.Columns.Add("Service #", 500);
        }


        private void bttnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpDateTime_ValueChanged(object sender, EventArgs e)
        {
            DateTime theDate = dtpDateTime.Value;
            List<Service> services = dbm.GetServices(theDate);

            lvServiceList.Clear();
            ListBoxHandle();
            if (services.Count > 0)
            {
                PopulateListBoxWithResults(services);
            }
        }


        private void PopulateListBoxWithResults(List<Service> results)
        {
            foreach (Service serviceItem in results)
            {
                string[] tRowData = new string[3];
                tRowData[0] = $"{serviceItem.Truck.Type.Type} #{serviceItem.Truck.ID.ToString()}";

                var services = dbm.GetServiceItems(serviceItem);
                string ser = "";
                foreach (var item in services)
                {
                    ser += item.ServiceType.Job + ",";
                }
                tRowData[1] = ser;

                InsertListBoxItem(tRowData);
            }
        }

        private void InsertListBoxItem(string[] row)
        {
            ListViewItem tRowItem = new ListViewItem(row);
            lvServiceList.Items.Add(tRowItem);
        }

        private void lvServiceList_DoubleClick(object sender, EventArgs e)
        {
            if (lvServiceList.SelectedItems.Count >= 0)
            {
                ListViewItem selecteditem = lvServiceList.SelectedItems[0];
                int serviceID = Convert.ToInt32(selecteditem.SubItems[0].Text);
                ServiceDetailsForm svcDetailfrm = new ServiceDetailsForm(serviceID);
                svcDetailfrm.ShowDialog();
            }

        }

        private void bttnServiceReport_Click(object sender, EventArgs e)
        {
            pnlServiceReport.Visible = true;
            btnServiceReport.Visible = false;
            //update 
        }

        private void btnCloseReport_Click(object sender, EventArgs e)
        {
            pnlServiceReport.Visible = false;
            btnServiceReport.Visible = true;
        }

        private void lvServiceList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lvServiceList.SelectedItems.
        }

        private void ServiceForm_Load(object sender, EventArgs e)
        {

        }
    }
}


//DataSet GetSQLResults(string pSql)
//{
//    try
//    {
//        SqlDataAdapter da = new SqlDataAdapter(pSql, dbCon);
//        DataSet ds = new DataSet();
//        da.Fill(ds);
//        return ds;
//    }
//    catch
//    {
//        DataSet ds = new DataSet();
//        return ds;
//    }
//}

//List<TruckService> MapSQLToList(DataSet pResults)
//{
//    List<TruckService> tResults = new List<TruckService>();
//    TruckService tTruckService = null;
//    foreach (DataRow row in pResults.Tables[0].Rows)
//    {
//        int tID = (int)row["ID"];
//        int tTruckID = (int)row["truckID"];
//        int tMechanicID = (int)row["mechanic"];
//        tTruckService = new TruckService(tID, tTruckID, tMechanicID);

//        tResults.Add(tTruckService);
//    }
//    return tResults;
//}

//  private void lvServiceList_SelectedIndexChanged(object sender, EventArgs e)
//  {

// }

// int iUserSelectedServiceID = -1;

//private void lvServiceList_SelectedIndexChanged(object sender, EventArgs e)
//{
//    iUserSelectedServiceID = lvServiceList.SelectedIndices[0];
//}