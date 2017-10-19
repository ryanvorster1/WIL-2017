using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLogic
{
    public class DBManager
    {
        private string connectionString = "Data Source=GEIMAJ;Initial Catalog=WIL2017;Integrated Security=True";
        private SqlConnection dbCon;

        public DBManager()
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

        //get a list of all routes
        public List<Route> GetRoutes()
        {
            List<Route> routes = new List<Route>();

            try
            {
                string sql = "select * from routes";
                SqlDataAdapter da = new SqlDataAdapter(sql, dbCon);
                DataSet ds = new DataSet();
                da.Fill(ds);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int ID = (int)row["ID"];
                    Department deptart = GetDepartmentByID((int)row["departure"]);
                    Department dest = GetDepartmentByID((int)row["destination"]);
                    int kms = (int)row["kms"];

                    routes.Add(new Route(ID, deptart, dest, kms));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return routes;
        }

        //get department by ID
        public Department GetDepartmentByID(int id)
        {
            Department depo;
            try
            {
                string sql = $"select * from department where id = {id}";
                SqlDataAdapter da = new SqlDataAdapter(sql, dbCon);
                DataSet ds = new DataSet();
                da.Fill(ds);

                DataRow row = ds.Tables[0].Rows[0];
                int ID = (int)row["ID"];
                string name = row["name"].ToString();

                depo = new Department(ID, name);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return depo;
        }

        //get a list of all departments
        public List<Department> GetDepartments()
        {
            List<Department> depos = new List<Department>();

            try
            {
                string sql = "select * from department";
                SqlDataAdapter da = new SqlDataAdapter(sql, dbCon);
                DataSet ds = new DataSet();
                da.Fill(ds);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int ID = (int)row["ID"];
                    string name = row["name"].ToString();

                    depos.Add(new Department(ID, name));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return depos;
        }

        //get a list of all trucks in db
        public List<Truck> GetTrucks()
        {
            List<Truck> trucks = new List<Truck>();

            try
            {
                string sql = "select * from truck";
                SqlDataAdapter da = new SqlDataAdapter(sql, dbCon);
                DataSet ds = new DataSet();
                da.Fill(ds);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int ID = (int)row["ID"];
                    string vin = row["vin"].ToString();
                    string reg = row["reg"].ToString();
                    int kms = (int)row["kms"];
                    bool availible = (bool)row["availible"];
                    TruckType type = GetTruckType((int)row["truckType"]);
                    Truck t = new Truck(ID, vin, reg, kms, availible, type);
                    trucks.Add(t);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return trucks;
        }

        //query db for truck type by ID of type
        public TruckType GetTruckType(int id)
        {
            TruckType truckType = null;

            try
            {
                string sql = $"select * from trucktype where ID = {id}";
                SqlDataAdapter da = new SqlDataAdapter(sql, dbCon);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataRow row = ds.Tables[0].Rows[0];

                int typeID = (int)row["ID"];
                string type = row["type"].ToString();
                string manufacturor = row["manufacturor"].ToString();
                int engineSize = (int)row["engineSize"];
                int serviceInterval = (int)row["serviceInterval"];
                int maxWeight = (int)row["maxWeight"];
                int maxVol = (int)row["maxVol"];

                truckType = new TruckType(typeID, type, manufacturor, engineSize,
                    serviceInterval, maxWeight, maxVol);

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return truckType;
        }

    }
}
