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
namespace WIL
{
    public partial class ServiceDetailsfrm : Form
    {
        private string connectionString = "Data Source=POKKOLS-PC;Initial Catalog=WIL;Integrated Security=True";
        private SqlConnection dbCon;

        public ServiceDetailsfrm(int pSerivceId)
        {
            DBManager();
            InitializeComponent();

            DisplayServiceDetails(pSerivceId);
        }

        void DBManager()
        {
            try
            {
                dbCon = new SqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        void DisplayServiceDetails(int pSerivceId)
        {
            string tSQL = BuildGetFullServiceDetailsSQL(pSerivceId);
            DataSet tResults = GetSQLResults(tSQL);
            ServiceDetailscs tServiceDetails = MapSQLToServiceDetail(tResults);
            PopulateFormWithResults(tServiceDetails);
        }

        string BuildGetFullServiceDetailsSQL(int pSerivceId)
        {
            string tSQL =
                        @"
                        select a3.fname, a3.lname, 
                        a4.vin, a4.reg, 
                        a5.manufacturor, a5.type, a5.engineSize, a5.serviceInterval, 
                        a1.job, a1.cost, a1.hours 
                        from serviceItem a 
                        inner join serviceType a1 on 
                        a1.ID = a.serviceID 
                        inner join service a2 on 
                        a2.ID = a.serviceID 
                        inner join users a3 on 
                        a3.ID = a2.mechanic 
                        inner join truck a4 on 
                        a4.ID = a2.truckID  
                        inner join truckType a5 on 
                        a4.truckType = a5.ID
                        where a.serviceID = " + $"{pSerivceId}";
            return tSQL;
        }

        DataSet GetSQLResults(string pSql)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(pSql, dbCon);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch
            {
                DataSet ds = new DataSet();
                return ds;
            }
        }

        ServiceDetailscs MapSQLToServiceDetail(DataSet pResults)
        {
            ServiceDetailscs tServiceDetails= null;
            foreach (DataRow row in pResults.Tables[0].Rows)
            {
                string MechanicFirstName = (string)row["fname"];
                string MechanicSurname = (string)row["lname"];
                string Vin = (string)row["vin"];
                string Reg = (string)row["reg"];
                string Manufacturor = (string)row["manufacturor"];
                string Type = (string)row["type"];
                int EngineSize = (int)row["engineSize"];
                int ServiceInterval = (int)row["serviceInterval"];
                string Job = (string)row["job"];
                string Cost = row["cost"].ToString();
                int Hours = (int)row["hours"];

                tServiceDetails = new ServiceDetailscs(MechanicFirstName, MechanicSurname, Vin, Reg, Manufacturor, Type, EngineSize, ServiceInterval, Job, Cost, Hours);
            }
            return tServiceDetails;
        }

        void PopulateFormWithResults(ServiceDetailscs pData)
        {
            lblMName.Text = pData.MechanicFirstName;
            lblMSurname.Text = pData.MechanicSurname;
            lblMenumanufacturor.Text = pData.Vin.ToString();
            lblReg.Text = pData.Reg;
            lblManufacturor.Text = pData.Manufacturor;
            lblTruckType.Text = pData.Type;
            lblengineSize.Text = pData.EngineSize.ToString();
            lblserviceInterval.Text = pData.ServiceInterval.ToString();
            lblServiceJob.Text = pData.Job;
            lblCost.Text = pData.Cost.ToString();
            lblHours.Text = pData.Hours.ToString();
        }


        private void bttnComplete_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
