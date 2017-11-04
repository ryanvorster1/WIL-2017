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
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=2017WIL;Integrated Security=True;Pooling=False";
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

        //get a list of all trips 
        public List<Trip> GetTrips(DateTime selectedDate)
        {
            List<Trip> trips = new List<Trip>();

            try
            {
                string sql = $"select * from trip where startDate <= '{selectedDate}' and endDate >= '{selectedDate}'";
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

                    trips.Add(new Trip(ID, truck, customer, start, end, driver, route));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return trips;
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

                    trips.Add(new Trip(ID, truck, customer, start, end, driver, route));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return trips;
        }

        public DataSet GetTripsDataSet()
        {
            DataSet trips = null;

            try
            {
                string sql = "select * from trip";
                SqlDataAdapter da = new SqlDataAdapter(sql, dbCon);
                trips = new DataSet();
                da.Fill(trips);

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
        public Incident GetIncidentByID(int id)
        {
            Incident incidents = null;

            try
            {
                string sql = $"select * from Incident where id = {id}";
                SqlDataAdapter da = new SqlDataAdapter(sql, dbCon);
                DataSet ds = new DataSet();
                da.Fill(ds);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int ID = (int)row["ID"];
                    IncidentType type = GetIncidentTypeByID((int)row["incidentType"]);
                    User driver = GetUserByID((int)row["driverID"]);
                    Console.WriteLine(ID);
                    Console.WriteLine(type);
                    Console.WriteLine(driver.ToString());
                    //incidents = (new Incident(ID, type, driver));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return incidents;
        }

        //log incidents from driverform
        public void  logIncident(int incidentId , User driver)
        {
            int id = -1;
            Console.WriteLine(incidentId);
            Console.WriteLine(driver.ToString());
            try
            {
                string sql = "insert into Incident(incidentType, driverID) " +
                            "values(@incidentType, @driverID)";

                SqlCommand cmd = new SqlCommand(sql, dbCon);
                cmd.Parameters.AddWithValue("@incidentType", incidentId);
                cmd.Parameters.AddWithValue("@driverID", driver.ID);
                


                dbCon.Open();
                //do insert
                cmd.ExecuteNonQuery();
                //get ID
                sql = "select @@identity";
                cmd.CommandText = sql;
                id = Convert.ToInt32(cmd.ExecuteScalar());

                dbCon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            //naz.ID= id;

            //return GetIncidentByID(id);
        }
    
        //get specific incident type by ID
        public IncidentType GetIncidentTypeByID(int id)
        {
            IncidentType incident = null;

            try
            {
                string sql = $"select * from IncidentType where id = {id}";
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

        public List<IncidentType> GetIncidentTypes()
        {
            List<IncidentType> incident = new List<IncidentType>();

            try
            {
                string sql = $"select * from IncidentType";
                SqlDataAdapter da = new SqlDataAdapter(sql, dbCon);
                DataSet ds = new DataSet();
                da.Fill(ds);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int ID = (int)row["ID"];
                    string description = row["Description"].ToString();
                    double cost = Convert.ToDouble(row["cost"]);
                    int hours = (int)row["repairTime"];
     


                    incident.Add(new IncidentType(ID, description, cost, hours));
                  
                   
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return incident;
        }

        /////////////////////////////////////////////////////////////////////////////users

        //getcustomer by ID
        public Customer GetCustomerByID(int id)
        {
            Customer customer = null;
            try
            {
                string sql = $"select * from customer where id = {id}";
                SqlDataAdapter da = new SqlDataAdapter(sql, dbCon);
                DataSet ds = new DataSet();
                da.Fill(ds);

                DataRow row = ds.Tables[0].Rows[0];
                int ID = (int)row["ID"];
                string fname = row["fname"].ToString();
                string lname = row["lname"].ToString();
                string email = row["email"].ToString();
                string cell = row["cell"].ToString();

                customer = new Customer(ID, fname, lname, email, cell);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return customer;
        }

        //get a list of all customers
        public List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();

            try
            {
                string sql = "select * from customer";
                SqlDataAdapter da = new SqlDataAdapter(sql, dbCon);
                DataSet ds = new DataSet();
                da.Fill(ds);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int ID = (int)row["ID"];
                    string fname = row["fname"].ToString();
                    string lname = row["lname"].ToString();
                    string email = row["email"].ToString();
                    string cell = row["cell"].ToString();

                    Customer c = new Customer(ID, fname, lname, email, cell);
                    customers.Add(c);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return customers;
        }

        //return ID. ref type Customer so cus.ID is automatically assigned
        public int AddCustomer(ref Customer cus)
        {
            int id = -1;
            try
            {
                string sql = "insert into customer(fname, lname, email,cell) " +
                            "values(@fname, @lname, @email, @cell)";

                SqlCommand cmd = new SqlCommand(sql, dbCon);
                cmd.Parameters.AddWithValue("@fname", cus.Fname);
                cmd.Parameters.AddWithValue("@lname", cus.Lname);
                cmd.Parameters.AddWithValue("@email", cus.Email);
                cmd.Parameters.AddWithValue("@cell", cus.Cell);


                dbCon.Open();
                //do insert
                cmd.ExecuteNonQuery();
                //get ID
                sql = "select @@identity";
                cmd.CommandText = sql;
                id = Convert.ToInt32(cmd.ExecuteScalar());

                dbCon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            cus.ID = id;

            return id;
        }

        //Log in user
        //return null if no user
        public User LogInUser(string _username, string _password)
        {
            User user = null;

            try
            {
                string sql = $"select * from users  where username = '{_username}' and pass = '{_password}'";
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
                    string lname = row["lname"].ToString();

                    user = new User(ID, username, password, type, hours, fname, lname);
                Console.WriteLine(user.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //throw ex;
            }
            return user;
        }


        //add user do DB
        //get ID in return
        //ref user object sets user.ID automatically
        public int AddUser(ref User user)
        {
            int id = -1;
            try
            {
                string sql = "insert into users(username, pass, userType, hours, fname, lname) " +
                            "values(@user, @pass, @userType, @hours, @fname, @lname)";

                SqlCommand cmd = new SqlCommand(sql, dbCon);
                cmd.Parameters.AddWithValue("@user", user.Username);
                cmd.Parameters.AddWithValue("@pass", user.Password);
                cmd.Parameters.AddWithValue("@userType", user.Type.ID);
                cmd.Parameters.AddWithValue("@hours", user.Hours);
                cmd.Parameters.AddWithValue("@fname", user.Fname);
                cmd.Parameters.AddWithValue("@lname", user.Lname);

                dbCon.Open();
                //do insert
                cmd.ExecuteNonQuery();
                //get ID
                sql = "select @@identity";
                cmd.CommandText = sql;
                id = Convert.ToInt32(cmd.ExecuteScalar());

                dbCon.Close();

            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Message.StartsWith("Violation of UNIQUE KEY constraint 'UQ__users"))
                {
                    throw new Exception("username already taken.");
                }
                else
                {
                    throw new Exception("error when connecting to db.");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            user.ID = id;

            return id;
        }

        //get drivers that are not availible
        public List<User> GetAvailibleDrivers()
        {
            List<User> users = new List<User>();

            try
            {
                string sql = "select* from users join userType on users.userType = userType.ID where users.userType = 0 and avaliable = 1";
                SqlDataAdapter da = new SqlDataAdapter(sql, dbCon);
                DataSet ds = new DataSet();
                da.Fill(ds);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int ID = (int)row["ID"];
                    string username = row["username"].ToString();
                    string password = row["pass"].ToString();
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
                    string password = row["pass"].ToString();
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
                string lname = row["lname"].ToString(); 

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

        //get all user types
        public List<UserType> GetUserTypes()
        {
            List<UserType> types = new List<UserType>();
            try
            {
                string sql = $"select * from UserType";
                SqlDataAdapter da = new SqlDataAdapter(sql, dbCon);
                DataSet ds = new DataSet();
                da.Fill(ds);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int ID = (int)row["ID"];
                    string descr = row["userType"].ToString();
                    types.Add(new UserType(ID, descr));
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return types;
        }

        ////////////////////////////////////////////////////////////////////////////routes

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

        ////////////////////////////////////////////////////////////////////////////////////trucks


        //save truck to DB and get ID in return
        //returns -1 for failure
        //ref type is used to set ID of passed object automatically
        public int AddTruck(ref Truck truck)
        {
            int id = -1;
            try
            {
                string sql = "insert into truck(vin,reg,kms,availible,truckType)" +
                             "values(@vin,@reg,@kms,@avail,@truckType)";

                SqlCommand cmd = new SqlCommand(sql, dbCon);
                cmd.Parameters.AddWithValue("@vin", truck.Vin);
                cmd.Parameters.AddWithValue("@reg", truck.Reg);
                cmd.Parameters.AddWithValue("@kms", truck.Kms);
                cmd.Parameters.AddWithValue("@avail", truck.Availible);
                cmd.Parameters.AddWithValue("@truckType", truck.Type.ID);

                dbCon.Open();
                //do insert
                cmd.ExecuteNonQuery();
                //get ID
                sql = "select @@identity";
                cmd.CommandText = sql;
                id = Convert.ToInt32(cmd.ExecuteScalar());

                dbCon.Close();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            truck.ID = id;

            return id;
        }

        //save truckType to DB 
        //recieve ID in return or -1 if failure
        //ref type is used to set ID of passed object automatically
        public int AddTruckType(ref TruckType type)
        {
            int id = -1;
            try
            {
                string sql = "insert into truckType(type, manufacturor, engineSize, serviceInterval, maxWeight, maxVol)" +
                             "values(@type, @manufacturor, @engineSize, @serviceInterval, @maxWeight, @maxVol)";

                SqlCommand cmd = new SqlCommand(sql, dbCon);
                cmd.Parameters.AddWithValue("@type", type.Type);
                cmd.Parameters.AddWithValue("@manufacturor", type.Manufacturor);
                cmd.Parameters.AddWithValue("@engineSize", type.EngineSize);
                cmd.Parameters.AddWithValue("@serviceInterval", type.ServiceInterval);
                cmd.Parameters.AddWithValue("@maxWeight", type.MaxWeight);
                cmd.Parameters.AddWithValue("@maxVol", type.MaxVol);

                dbCon.Open();
                //do insert
                cmd.ExecuteNonQuery();
                //get ID
                sql = "select @@identity";
                cmd.CommandText = sql;
                id = Convert.ToInt32(cmd.ExecuteScalar());

                dbCon.Close();

            }
            catch (Exception ex) { 
         

                throw ex;
            }
            type.ID = id;
            return id;
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
                TruckType type = GetTruckTypeById((int)row["truckType"]);
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
                    TruckType type = GetTruckTypeById((int)row["truckType"]);
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
        public TruckType GetTruckTypeById(int id)
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

        public List<TruckType> GetTruckType()
        {
            List<TruckType> truckTypes = new List<TruckType>();

            try
            {
                string sql = $"select * from trucktype";
                SqlDataAdapter da = new SqlDataAdapter(sql, dbCon);
                DataSet ds = new DataSet();
                da.Fill(ds);

                foreach (DataRow row in ds.Tables[0].Rows)
                {

                    int typeID = (int)row["ID"];
                    string type = row["type"].ToString();
                    string manufacturor = row["manufacturor"].ToString();
                    int engineSize = (int)row["engineSize"];
                    int serviceInterval = (int)row["serviceInterval"];
                    int maxWeight = (int)row["maxWeight"];
                    int maxVol = (int)row["maxVol"];

                    truckTypes.Add( new TruckType(typeID, type, manufacturor, engineSize,
                        serviceInterval, maxWeight, maxVol));

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return truckTypes;
        }

        //get availiable trucks of specified type that are currently free
        public List<Truck> GetAvailiableTrucks(TruckType type)
        {
            List<Truck> trucks = new List<Truck>();

            try
            {
                string sql = $"select * from truck where availible = 1 and truckType = {type.ID}";
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
                    TruckType truckType = GetTruckTypeById((int)row["truckType"]);
                    Truck t = new Truck(ID, vin, reg, kms, availible, truckType);
                    trucks.Add(t);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return trucks;
        }

        //TODO: getAvailiableTrucks(Type type, Trip trip?) 

        //////////////////////////////////////////////////////////////////////////////////services
        public List<Service> GetServices()
        {
            List<Service> services = new List<Service>();

            try
            {
                string sql = "select * from service";
                SqlDataAdapter da = new SqlDataAdapter(sql, dbCon);
                DataSet ds = new DataSet();
                da.Fill(ds);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int ID = (int)row["ID"];
                    Truck truck = GetTruckByID((int)row["truckID"]);
                    User mechanic = GetUserByID((int)row["mechanic"]);
                    Service s = new Service(ID, truck, mechanic);
                    services.Add(s);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return services;
        }

        public List<Service> GetServices(DateTime date)
        {
            List<Service> services = new List<Service>();

            try
            {
                string sql = $"select* from service where startDate <=  '{date.ToShortDateString()}' and endDate >= '{date.ToShortDateString()}'";
                SqlDataAdapter da = new SqlDataAdapter(sql, dbCon);
                DataSet ds = new DataSet();
                da.Fill(ds);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int ID = (int)row["ID"];
                    Truck truck = GetTruckByID((int)row["truckID"]);
                    User mechanic = GetUserByID((int)row["mechanic"]);
                    Service s = new Service(ID, truck, mechanic);
                    services.Add(s);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return services;
        }

        public DataSet GetServicesDataSet()
        {
            DataSet services = null;

            try
            {
                string sql = "select * from service";
                SqlDataAdapter da = new SqlDataAdapter(sql, dbCon);
                services = new DataSet();
                da.Fill(services);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return services;
        }

        public Service GetServiceById(int id)
        {
            Service services = null;
            try
            {
                string sql = $"select * from service where id = {id}";
                SqlDataAdapter da = new SqlDataAdapter(sql, dbCon);
                DataSet ds = new DataSet();
                da.Fill(ds);

                DataRow row = ds.Tables[0].Rows[0];
                int ID = (int)row["ID"];
                Truck truck = GetTruckByID((int)row["truckID"]);
                User mechanic = GetUserByID((int)row["mechanic"]);
                services = new Service(ID, truck, mechanic);


            }
            catch (Exception ex)
            {
                throw ex;
            }
            return services;
        }

        public List<ServiceType> GetServiceTypes()
        {
            List<ServiceType> serviceTypes = new List<ServiceType>();

            try
            {
                string sql = "select * from serviceType";
                SqlDataAdapter da = new SqlDataAdapter(sql, dbCon);
                DataSet ds = new DataSet();
                da.Fill(ds);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int ID = (int)row["ID"];
                    string job = row["job"].ToString();
                    double cost = Convert.ToDouble(row["cost"]);
                    int hours = (int)row["hours"];

                    ServiceType st = new ServiceType(ID, job, cost, hours);
                    serviceTypes.Add(st);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return serviceTypes;
        }

        public ServiceType GetServiceTypeById(int id)
        {
            ServiceType serviceType = null;

            try
            {
                string sql = $"select * from serviceType where id = {id}";
                SqlDataAdapter da = new SqlDataAdapter(sql, dbCon);
                DataSet ds = new DataSet();
                da.Fill(ds);

                DataRow row = ds.Tables[0].Rows[0];
                int ID = (int)row["ID"];
                string job = row["job"].ToString();
                double cost = Convert.ToDouble(row["cost"]);
                int hours = (int)row["hours"];

                serviceType = new ServiceType(ID, job, cost, hours);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return serviceType;
        }

        public List<ServiceItem> GetServiceItems()
        {
            List<ServiceItem> serviceItems = new List<ServiceItem>();

            try
            {
                string sql = "select * from serviceItem";
                SqlDataAdapter da = new SqlDataAdapter(sql, dbCon);
                DataSet ds = new DataSet();
                da.Fill(ds);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int ID = (int)row["ID"];
                    Service service = GetServiceById((int)row["serviceID"]);
                    ServiceType type = GetServiceTypeById((int)row["serviceJob"]);

                    ServiceItem si = new ServiceItem(ID, service, type);
                    serviceItems.Add(si);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return serviceItems;
        }

        public List<ServiceItem> GetServiceItems(Service service)
        {
            List<ServiceItem> serviceItems = new List<ServiceItem>();

            try
            {
                string sql = $"select * from serviceItem join serviceType on serviceItem.ID = serviceType.ID where serviceID = {service.ID}";
                SqlDataAdapter da = new SqlDataAdapter(sql, dbCon);
                DataSet ds = new DataSet();
                da.Fill(ds);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int ID = (int)row["ID"];
                    ServiceType type = GetServiceTypeById((int)row["serviceJob"]);

                    ServiceItem si = new ServiceItem(ID, service, type);
                    serviceItems.Add(si);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return serviceItems;
        }

        public List<ServiceItem> GetServiceItems(int serviceID)
        {
            List<ServiceItem> serviceItems = new List<ServiceItem>();

            try
            {
                string sql = $"select * from serviceItem where id = {serviceID}";
                SqlDataAdapter da = new SqlDataAdapter(sql, dbCon);
                DataSet ds = new DataSet();
                da.Fill(ds);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int ID = (int)row["ID"];
                    Service service = GetServiceById((int)row["serviceID"]);
                    ServiceType type = GetServiceTypeById((int)row["serviceJob"]);

                    ServiceItem si = new ServiceItem(ID, service, type);
                    serviceItems.Add(si);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return serviceItems;
        }

        public ServiceItem GetServiceItemById(int id)
        {
            ServiceItem serviceItem = null;

            try
            {
                string sql = $"select * from serviceItem where id = {id}";
                SqlDataAdapter da = new SqlDataAdapter(sql, dbCon);
                DataSet ds = new DataSet();
                da.Fill(ds);

                DataRow row = ds.Tables[0].Rows[0];
                int ID = (int)row["ID"];
                Service service = GetServiceById((int)row["serviceID"]);
                ServiceType type = GetServiceTypeById((int)row["serviceJob"]);

                serviceItem = new ServiceItem(ID, service, type);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return serviceItem;
        }
    }
}
