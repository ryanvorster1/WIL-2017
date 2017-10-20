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

        //get a list of all Trips
        public List<Trip> GetTrips()
        {
            List<Trip> trips = new List<Trip>();

            try
            {
                string sql = "select * from trip";
                SqlDataAdapter da = new SqlDataAdapter(sql, dbCon);
                DataSet ds = new DataSet();
                da.Fill(ds);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int ID = (int)row["ID"];
                    Truck truck = GetTruckByID((int)row["truckID"]);
                    User customer = GetUserByID((int)row["clientID"]);
                    User driver = GetUserByID((int)row["driverID"]);
                    DateTime start = (DateTime)row["StartDate"];
                    DateTime end = (DateTime)row["endDate"];
                    Route route = GetRouteByID((int)row["routeID"]);

                    trips.Add(new Trip(ID,truck,customer,start,end,driver,route));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return trips;
        }

        //get a list of all incidents
        public List<Incident> GetIncidents()
        {
            List<Incident> incidents = new List<Incident>();

            try
            {
                string sql = "select * from Incident";
                SqlDataAdapter da = new SqlDataAdapter(sql, dbCon);
                DataSet ds = new DataSet();
                da.Fill(ds);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int ID = (int)row["ID"];
                    IncidentType type = GetIncidentTypeByID((int)row["incidentType"]);
                    User driver = GetUserByID((int)row["driverID"]);

                    incidents.Add(new Incident(ID, type, driver));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return incidents;
        }

        //get specific incident type by ID
        public IncidentType GetIncidentTypeByID(int id)
        {
            IncidentType incident = null;

            try
            {
                string sql = $"select * from IncidenType where id = {id}";
                SqlDataAdapter da = new SqlDataAdapter(sql, dbCon);
                DataSet ds = new DataSet();
                da.Fill(ds);

                DataRow row = ds.Tables[0].Rows[0];

                int ID = (int)row["ID"];
                string description = row["username"].ToString();
                int cost = (int)row["cost"];
                int hours = (int)row["repairTime"];

                incident = new IncidentType(ID, description, cost, hours);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return incident;
        }

        //get a list of all users
        public List<User> GetUsers()
        {
            List<User> users = new List<User>();

            try
            {
                string sql = "select * from Users";
                SqlDataAdapter da = new SqlDataAdapter(sql, dbCon);
                DataSet ds = new DataSet();
                da.Fill(ds);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int ID = (int)row["ID"];
                    string username = row["username"].ToString();
                    string password = row["password"].ToString();
                    UserType type = GetUserTypeById((int)row["userType"]);
                    int hours = (int)row["hours"];
                    string fname = row["fname"].ToString();
                    string lname = row["lname"].ToString();

                    User u = new User(ID, username, password, type, hours, fname, lname);
                    users.Add(u);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return users;
        }

        //get specific user by ID
        public User GetUserByID(int id)
        {
            User user = null;
            try
            {
                string sql = $"select * from Users where id = {id}";
                SqlDataAdapter da = new SqlDataAdapter(sql, dbCon);
                DataSet ds = new DataSet();
                da.Fill(ds);

                DataRow row = ds.Tables[0].Rows[0];
                int ID = (int)row["ID"];
                string username = row["username"].ToString();
                string password = row["pass"].ToString();
                UserType type = GetUserTypeById((int)row["userType"]);
                int hours = (int)row["hours"];
                string fname = row["fname"].ToString();
                string lname = row["lname"].ToString(); ;

                user = new User(ID, username, password, type, hours, fname, lname);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return user;
        }

        //get user type by ID
        public UserType GetUserTypeById(int id)
        {
            UserType type = null;
            try
            {
                string sql = $"select * from UserType where id = {id}";
                SqlDataAdapter da = new SqlDataAdapter(sql, dbCon);
                DataSet ds = new DataSet();
                da.Fill(ds);

                DataRow row = ds.Tables[0].Rows[0];
                int ID = (int)row["ID"];
                string descr = row["userType"].ToString();

                type = new UserType(id, descr);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return type;
        }

        //get route by id
        public Route GetRouteByID(int id)
        {
            Route route = null;

            try
            {
                string sql = "select * from routes";
                SqlDataAdapter da = new SqlDataAdapter(sql, dbCon);
                DataSet ds = new DataSet();
                da.Fill(ds);

                DataRow row = ds.Tables[0].Rows[0];
                int ID = (int)row["ID"];
                Department deptart = GetDepartmentByID((int)row["departure"]);
                Department dest = GetDepartmentByID((int)row["destination"]);
                int kms = (int)row["kms"];

                route = new Route(ID, deptart, dest, kms);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return route;
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

        //get truck by ID
        public Truck GetTruckByID(int id)
        {
            Truck truck = null;

            try
            {
                string sql = $"select * from truck where id = {id}";
                SqlDataAdapter da = new SqlDataAdapter(sql, dbCon);
                DataSet ds = new DataSet();
                da.Fill(ds);

                DataRow row = ds.Tables[0].Rows[0];
                int ID = (int)row["ID"];
                string vin = row["vin"].ToString();
                string reg = row["reg"].ToString();
                int kms = (int)row["kms"];
                bool availible = (bool)row["availible"];
                TruckType type = GetTruckType((int)row["truckType"]);
                truck = new Truck(ID, vin, reg, kms, availible, type);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return truck;
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
