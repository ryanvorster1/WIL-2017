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
            dtpDateTime_ValueChanged(null,null);
        }

        void DBManager()
        {

        }

        private void ListBoxHandle()
        {
            lvServiceList.Columns.Add("Truck ID", 200);
            lvServiceList.Columns.Add("Service ID", 200);
            lvServiceList.Columns.Add("Mechanic", 200);
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

        //string BuildGetServiceListSQL(string pDate)
        //{
        //    //string tSQL = "SELECT * FROM [dbo].[service]";
        //    //return tSQL;
        ///  }

        //DataSet GetSQLResults(string pSql)
        //{
        //    //try
        //    //{
        //    //    SqlDataAdapter da = new SqlDataAdapter(pSql, dbCon);
        //    //    DataSet ds = new DataSet();
        //    //    da.Fill(ds);
        //    //    return ds;
        //    //}
        //    //catch
        //    //{
        //    //    DataSet ds = new DataSet();
        //    //    return ds;
        //    //}
        //  }

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

       private void PopulateListBoxWithResults(List<Service> pResults)
        {
            foreach (Service tServiceItem in pResults)
            {
                string[] tRowData = new string[3];
                tRowData[0] = tServiceItem.ID.ToString();
                tRowData[1] = tServiceItem.Truck.ID.ToString();
                tRowData[2] = tServiceItem.Mechanic.ID.ToString();

                InsertListBoxItem(tRowData);
            }
        }

        private void InsertListBoxItem(string[] pRow)
        {
            ListViewItem tRowItem = new ListViewItem(pRow);
            lvServiceList.Items.Add(tRowItem);
        }

        //int iUserSelectedServiceID = -1;

        //private void lvServiceList_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    iUserSelectedServiceID = lvServiceList.SelectedIndices[0];
        //}

        //private void lvServiceList_DoubleClick(object sender, EventArgs e)
        //{
        //    if (iUserSelectedServiceID > -1)
        //    {
        //        ServiceDetailsForm svcDetailfrm = new ServiceDetailsForm(iUserSelectedServiceID);
        //        svcDetailfrm.ShowDialog();
        //    }
        //}
    }
}
