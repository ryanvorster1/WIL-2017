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
            //needs fixing check ID value

        }

        void PopulateFormWithResults(Service pData)
        {
                   //TODO
            //lblMName.Text = pData.Mechanic.Fname;
            //lblMSurname.Text = pData.Mechanic.Lname;
            lblMenumanufacturor.Text = pData.Truck.Vin.ToString();
            lblReg.Text = pData.Truck.Reg;
            lblManufacturor.Text = pData.Truck.Type.Manufacturor;
            lblTruckType.Text = pData.Truck.Type.Type;
            lblengineSize.Text = pData.Truck.Type.EngineSize.ToString();
            lblserviceInterval.Text = pData.Truck.Type.ServiceInterval.ToString();
            updating = true;
            var serviceItems = dbm.GetServiceItems(pData);

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
                var serviceItem = await dbm.GetServiceItemById((int)lsbServiceJobs.SelectedValue);

                ServiceType serviceType = serviceItem.ServiceType;

                lblCost.Text = serviceType.Cost.ToString();
                lblHours.Text = serviceType.Hours.ToString();
            }
        }
    }
}

//shouldnt have DB code in form. USE DBManager instead

//private string connectionString = "Data Source=POKKOLS-PC;Initial Catalog=WIL;Integrated Security=True";
//private SqlConnection dbCon;

/////////////////////////////////////////////////////////////////////////////////////////////////////////////

//try
//{
//    dbCon = new SqlConnection(connectionString);
//}
//catch (Exception ex)
//{
//    throw ex;
//}

//////////////////////////////////////////////////////////////////////////////////////////////////////////////

//   DisplayServiceDetails(pSerivceId);

///////////////////////////////////////////////////////////////////////////////////////////////////////////////


//use appropriate methods from DBManager

//void DisplayServiceDetails(int pSerivceId)
//{
//    string tSQL = BuildGetFullServiceDetailsSQL(pSerivceId);
//    DataSet tResults = GetSQLResults(tSQL);
//    ServiceDetailscs tServiceDetails = MapSQLToServiceDetail(tResults);
//    PopulateFormWithResults(tServiceDetails);
//}

//string BuildGetFullServiceDetailsSQL(int pSerivceId)
//{
//    string tSQL =
//                @"
//                select a3.fname, a3.lname, 
//                a4.vin, a4.reg, 
//                a5.manufacturor, a5.type, a5.engineSize, a5.serviceInterval, 
//                a1.job, a1.cost, a1.hours 
//                from serviceItem a 
//                inner join serviceType a1 on 
//                a1.ID = a.serviceID 
//                inner join service a2 on 
//                a2.ID = a.serviceID 
//                inner join users a3 on 
//                a3.ID = a2.mechanic 
//                inner join truck a4 on 
//                a4.ID = a2.truckID  
//                inner join truckType a5 on 
//                a4.truckType = a5.ID
//                where a.serviceID = " + $"{pSerivceId}";
//    return tSQL;
//}

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

//ServiceDetailscs MapSQLToServiceDetail(DataSet pResults)
//{
//    ServiceDetailscs tServiceDetails= null;
//    foreach (DataRow row in pResults.Tables[0].Rows)
//    {
//        string MechanicFirstName = (string)row["fname"];
//        string MechanicSurname = (string)row["lname"];
//        string Vin = (string)row["vin"];
//        string Reg = (string)row["reg"];
//        string Manufacturor = (string)row["manufacturor"];
//        string Type = (string)row["type"];
//        int EngineSize = (int)row["engineSize"];
//        int ServiceInterval = (int)row["serviceInterval"];
//        string Job = (string)row["job"];
//        string Cost = row["cost"].ToString();
//        int Hours = (int)row["hours"];

//        tServiceDetails = new ServiceDetailscs(MechanicFirstName, MechanicSurname, Vin, Reg, Manufacturor, Type, EngineSize, ServiceInterval, Job, Cost, Hours);
//    }
//    return tServiceDetails;
//}

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//pData.Truck.

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//lblServiceJob.Text = pData
//lblCost.Text = pData.Cost.ToString();
//lblHours.Text = pData.Hours.ToString();