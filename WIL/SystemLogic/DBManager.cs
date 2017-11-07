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
        //private string connectionString = "Data Source=POKKOLS-PC;Initial Catalog=WIL;Integrated Security=True";
        //private string connectionString = "Data Source=DESKTOP-IHUJDPR;Initial Catalog=WILDB;Integrated Security=True";
        //private string connectionString = "Data Source=RYAN;Initial Catalog=WILDB;Integrated Security=True;Pooling=False";

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

        //update trip status
        public async Task<Trip> StartTrip(Trip trip)
        {
            return await Task.Run(async () =>
            {
                //no trucks available get next availible date
                try
                {
                    string sql = $"update trip set statusID = 1 where ID = {trip.ID}";
                    SqlCommand cmd = new SqlCommand(sql, dbCon);
                    dbCon.Open();
                    cmd.ExecuteNonQuery();
                    dbCon.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return await GetTripByID(trip.ID);
            });
        }

        //update trip status
        public async Task<Trip> CompleteTrip(Trip trip)
        {
            return await Task.Run(async () =>
            {
                //no trucks available get next availible date
                try
                {
                    string sql = $"update trip set statusID = 2 where ID = {trip.ID}";
                    SqlCommand cmd = new SqlCommand(sql, dbCon);
                    dbCon.Open();
                    cmd.ExecuteNonQuery();
                    dbCon.Close();

                }
                catch (Exception ex)
                {
                    throw ex;
                }

                return await GetTripByID(trip.ID);
            });
        }

        public async Task<Truck> GetNextAvailableTruck(TruckType type)
        {
            return await Task.Run(async () =>
            {
                List<Truck> trucks = await GetTrucks();

                foreach (var item in trucks)
                {
                    if(item.Type.ID == type.ID && item.Availible == true)
                    {
                        return item;
                    }
                }
                return null;
            });
        }

        //book trip with next availible date
        public async Task<Trip> BookTrip(Trip trip)
        {
            return await Task.Run(async () =>
            {
                List<Truck> availableTrucks = await GetAvailiableTrucks(trip.Truck.Type);

                if (availableTrucks.Count > 0) //trucks availible for that date. select 0th one
                {
                    trip.Truck = availableTrucks[0];
                }
                else
                {
                    //no trucks available get next availible date
                    try
                    {
                        string sql = $"select enddate as [Available Date], truck.ID as [ID] from trip " +
                        $"join truck on trip.truckID = truck.ID where truckType = {trip.Truck.Type.ID}" +
                        $" order by endDate asc";
                        SqlDataAdapter da = new SqlDataAdapter(sql, dbCon);
                        DataSet ds = new DataSet();
                        da.Fill(ds);

                        DataRow row = ds.Tables[0].Rows[0][0] as DataRow;

                        DateTime startDate = Convert.ToDateTime(row["Available Date"]);
                        Truck truck = await GetTruckByID((int)row["ID"]);
                        trip.Truck = truck;
                        startDate = startDate.AddDays(3.0);                        

                        trip.Start = startDate;

                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                }
                await UpdateTruckStatus(false, trip.Truck);
                await UpdateTruckKms(trip.Route.Kms, trip.Truck);
                await AddTrip(trip);

                return trip;
            });
        }

        public async Task<DateTime> NextAvailibleDate(TruckType type)
        {
            return await Task.Run(async () =>
            {
               Truck availableTrucks = await GetNextAvailableTruck(type);
                DateTime date;

                if (availableTrucks != null) //current date
                {
                    date = DateTime.Now;
                }

                else
                {
                    //no trucks available get next availible date
                    try
                    {
                        string sql = $"select enddate as [Available Date], truck.ID as [ID] from trip join truck on trip.truckID = truck.ID where truckType = {type.ID}" +
                        $" order by endDate asc";
                        SqlDataAdapter da = new SqlDataAdapter(sql, dbCon);
                        DataSet ds = new DataSet();
                        da.Fill(ds);

                        DataRow row = ds.Tables[0].Rows[0][0] as DataRow;

                        date = Convert.ToDateTime(row["Available Date"]);
                        date = date.AddDays(3.0);

                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                }
                return date;
            });
        }

        //get awaiting trip for driver
        public async Task<Trip> GetAwaitingTrip(User _driver)
        {
            return await Task.Run(async () =>
            {
                Trip trip = null;

                try
                {
                    string sql = $"select * from trip join tripStatus on trip.statusID = tripStatus.ID where statusID = 0 and driverID = {_driver.ID}";
                    SqlDataAdapter da = new SqlDataAdapter(sql, dbCon);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    DataRow row = ds.Tables[0].Rows[0];
                    int ID = (int)row["ID"];
                    Truck truck = await GetTruckByID((int)row["truckID"]);
                    Customer customer = await GetCustomerByID((int)row["clientID"]);
                    User driver = await GetUserByID((int)row["driverID"]);
                    DateTime start = (DateTime)row["StartDate"];
                    DateTime end = (DateTime)row["endDate"];
                    Route route = await GetRouteByID((int)row["routeID"]);
                    TripStatus status = await GetTripStatusByID((int)row["statusID"]);

                    trip = new Trip(ID, truck, customer, start, end, driver, route, status);
                }

                catch (Exception ex)
                {
                    throw ex;
                }
                return trip;
            });

        }

        public async Task<Truck> UpdateTruckStatus(bool available, Truck truck)
        {
            return await Task.Run(() =>
            {
                try
                {
                    string sql = $"UPDATE truck set availible = '{available}' where id = {truck.ID}";
                    SqlCommand cmd = new SqlCommand(sql, dbCon);

                    dbCon.Open();
                    //do update
                    cmd.ExecuteNonQuery();

                    dbCon.Close();

                }
                catch (Exception)
                {

                    throw;
                }
                return GetTruckByID(truck.ID);
            });
        }

        private async Task<Truck> UpdateTruckKms(int kms, Truck truck)
        {
            return await Task.Run(() =>
            {
                try
                {
                    string sql = $"UPDATE truck set kms = {truck.Kms + kms} where id = {truck.ID}";
                    SqlCommand cmd = new SqlCommand(sql, dbCon);

                    dbCon.Open();
                    //do update
                    cmd.ExecuteNonQuery();

                    dbCon.Close();

                }
                catch (Exception)
                {

                    throw;
                }

                return GetTruckByID(truck.ID);
            });
        }

        //save Trip to DB
        private async Task<Trip> AddTrip(Trip trip)
        {
            return await Task.Run(() =>
            {
                try
                {
                    string query = "insert into trip(truckID, clientID, startDate, endDate, driverID, routeID, statusID) " +
                        "values(@truckID, @clientID, @startDate, @endDate, @driverID, @routeID, @statusID)";


                    SqlCommand cmd = new SqlCommand(query, dbCon);
                    cmd.Parameters.AddWithValue("@truckID", trip.Truck.ID);
                    cmd.Parameters.AddWithValue("@clientID", trip.Customer.ID);
                    cmd.Parameters.AddWithValue("@startDate", trip.Start);
                    cmd.Parameters.AddWithValue("@endDate", trip.End);
                    cmd.Parameters.AddWithValue("@driverID", trip.Driver.ID);
                    cmd.Parameters.AddWithValue("@routeID", trip.Route.ID);
                    cmd.Parameters.AddWithValue("@statusID", trip.Status.ID);

                    int id = -1;

                    dbCon.Open();
                    //do insert
                    cmd.ExecuteNonQuery();
                    //get ID
                    query = "select @@identity";
                    cmd.CommandText = query;
                    id = Convert.ToInt32(cmd.ExecuteScalar());
                    trip.ID = id;
                    dbCon.Close();
                }
                catch (Exception e)
                {
                    throw e;
                }
                return trip;
            });
        }

        public async Task<List<TripStatus>> GetTripStatuses()
        {
            return await Task.Run(async () =>
            {
                List<TripStatus> tripStatuses = new List<TripStatus>();

                try
                {
                    string sql = $"select * from tripStatus";
                    SqlDataAdapter da = new SqlDataAdapter(sql, dbCon);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        int ID = (int)row["ID"];
                        string status = row["status"].ToString();
                        tripStatuses.Add(new TripStatus(ID, status));

                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return tripStatuses;
            });
        }

        public async Task<TripStatus> GetTripStatusByID(int id)
        {
            return await Task.Run(async () =>
            {
                TripStatus tripStatus = null;

                try
                {
                    string sql = $"select * from tripStatus where id = {id}";
                    SqlDataAdapter da = new SqlDataAdapter(sql, dbCon);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    DataRow row = ds.Tables[0].Rows[0];
                    {
                        int ID = (int)row["ID"];
                        string status = row["status"].ToString();
                        tripStatus = new TripStatus(ID, status);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return tripStatus;
            });
        }

        public async Task<Trip> GetTripByID(int id)
        {
            return await Task.Run(async () =>
            {
                Trip trips = null;

                try
                {
                    string sql = $"select * from trip where id = {id}";
                    SqlDataAdapter da = new SqlDataAdapter(sql, dbCon);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    DataRow row = ds.Tables[0].Rows[0];
                    int ID = (int)row["ID"];
                    Truck truck = await GetTruckByID((int)row["truckID"]);
                    Customer customer = await GetCustomerByID((int)row["clientID"]);
                    User driver = await GetUserByID((int)row["driverID"]);
                    DateTime start = (DateTime)row["StartDate"];
                    DateTime end = (DateTime)row["endDate"];
                    Route route = await GetRouteByID((int)row["routeID"]);
                    TripStatus status = await GetTripStatusByID((int)row["statusID"]);

                    trips = new Trip(ID, truck, customer, start, end, driver, route, status);

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return trips;
            });
        }

        public async Task<List<Trip>> GetTrips(DateTime startDate, DateTime endDate)
        {
            return await Task.Run(async () =>
            {
                List<Trip> trips = new List<Trip>();

                try
                {
                    string sql = $"select * from trip where startDate >= '{startDate.ToShortDateString()}' and startdate <= '{endDate.ToShortDateString()}' or " +
                        $"enddate >= '{startDate.ToShortDateString()}' and enddate <= '{endDate.ToShortDateString()}'";
                    SqlDataAdapter da = new SqlDataAdapter(sql, dbCon);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        int ID = (int)row["ID"];
                        Truck truck = await GetTruckByID((int)row["truckID"]);
                        Customer customer = await GetCustomerByID((int)row["clientID"]);
                        User driver = await GetUserByID((int)row["driverID"]);
                        DateTime start = (DateTime)row["StartDate"];
                        DateTime end = (DateTime)row["endDate"];
                        Route route = await GetRouteByID((int)row["routeID"]);
                        TripStatus status = await GetTripStatusByID((int)row["statusID"]);

                        trips.Add(new Trip(ID, truck, customer, start, end, driver, route, status));

                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return trips;
            });
        }

        public async Task<List<Trip>> GetCompleteTrips(DateTime startDate, DateTime endDate)
        {
            return await Task.Run(async () =>
            {
                List<Trip> trips = new List<Trip>();

                try
                {
                    string sql = $"select * from trip where startDate >= '{startDate.ToShortDateString()}' and startdate <= '{endDate.ToShortDateString()}' or " +
                        $"enddate >= '{startDate.ToShortDateString()}' and enddate <= '{endDate.ToShortDateString()}' and statusID = 2";
                    SqlDataAdapter da = new SqlDataAdapter(sql, dbCon);
                    //dbCon.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        int ID = (int)row["ID"];
                        Truck truck = await GetTruckByID((int)row["truckID"]);
                        Customer customer = await GetCustomerByID((int)row["clientID"]);
                        User driver = await GetUserByID((int)row["driverID"]);
                        DateTime start = (DateTime)row["StartDate"];
                        DateTime end = (DateTime)row["endDate"];
                        Route route = await GetRouteByID((int)row["routeID"]);
                        TripStatus status = await GetTripStatusByID((int)row["statusID"]);

                        trips.Add(new Trip(ID, truck, customer, start, end, driver, route, status));

                    }
                    dbCon.Close();

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return trips;
            });
        }

        public async Task<List<Trip>> GetInCompleteTrips(DateTime startDate, DateTime endDate)
        {
            return await Task.Run(async () =>
            {
                List<Trip> trips = new List<Trip>();

                try
                {
                    string sql = $"select * from trip where startDate >= '{startDate.ToShortDateString()}' and startdate <= '{endDate.ToShortDateString()}' or " +
                        $"enddate >= '{startDate.ToShortDateString()}' and enddate <= '{endDate.ToShortDateString()}' and statusID = 0 or statusID = 1";
                    SqlDataAdapter da = new SqlDataAdapter(sql, dbCon);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        int ID = (int)row["ID"];
                        Truck truck = await GetTruckByID((int)row["truckID"]);
                        Customer customer = await GetCustomerByID((int)row["clientID"]);
                        User driver = await GetUserByID((int)row["driverID"]);
                        DateTime start = (DateTime)row["StartDate"];
                        DateTime end = (DateTime)row["endDate"];
                        Route route = await GetRouteByID((int)row["routeID"]);
                        TripStatus status = await GetTripStatusByID((int)row["statusID"]);


                        trips.Add(new Trip(ID, truck, customer, start, end, driver, route, status));

                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return trips;
            });
        }

        //get a list of all trips 
        public async Task<List<Trip>> GetTrips(DateTime selectedDate)
        {
            return await Task.Run(async () =>
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
                        Truck truck = await GetTruckByID((int)row["truckID"]);
                        Customer customer = await GetCustomerByID((int)row["clientID"]);
                        User driver = await GetUserByID((int)row["driverID"]);
                        DateTime start = (DateTime)row["StartDate"];
                        DateTime end = (DateTime)row["endDate"];
                        Route route = await GetRouteByID((int)row["routeID"]);
                        TripStatus status = await GetTripStatusByID((int)row["statusID"]);

                        trips.Add(new Trip(ID, truck, customer, start, end, driver, route, status));
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return trips;
            });

        }
        //get a list of all Trips
        public async Task<List<Trip>> GetTrips()
        {
            return await Task.Run(async () =>
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
                        Truck truck = await GetTruckByID((int)row["truckID"]);
                        Customer customer = await GetCustomerByID((int)row["clientID"]);
                        User driver = await GetUserByID((int)row["driverID"]);
                        DateTime start = (DateTime)row["StartDate"];
                        DateTime end = (DateTime)row["endDate"];
                        Route route = await GetRouteByID((int)row["routeID"]);
                        TripStatus status = await GetTripStatusByID((int)row["statusID"]);

                        trips.Add(new Trip(ID, truck, customer, start, end, driver, route, status));
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return trips;
            });
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
        public async Task<List<Incident>> GetIncidents()
        {
            return await Task.Run(async () =>
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
                        IncidentType type = await GetIncidentTypeByID((int)row["incidentType"]);
                        User driver = await GetUserByID((int)row["driverID"]);

                        incidents.Add(new Incident(ID, type, driver));
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return incidents;
            });
        }

        public async Task<Incident> GetIncidentByID(int id)
        {
            return await Task.Run(async () =>
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
                        IncidentType type = await GetIncidentTypeByID((int)row["incidentType"]);
                        User driver = await GetUserByID((int)row["driverID"]);
                        //incidents = (new Incident(ID, type, driver));
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return incidents;
            });
        }

        public async Task<int> GetOrCreateLatestServiceID(Truck truck)
        {
            return await Task.Run(async () =>
            {
                string sql = $"select * from serviceItem join service on serviceItem.serviceID = service.ID where truckID = {truck.ID} and complete = 0";
                SqlDataAdapter da = new SqlDataAdapter(sql, dbCon);
                DataSet ds = new DataSet();
                da.Fill(ds);

                int serviceID;
                if (ds.Tables[0].Rows.Count >= 1)
                { //use this id
                    DataRow row = ds.Tables[0].Rows[0];
                    serviceID = (int)(row["ServiceID"]);
                    Console.WriteLine($"current Service {serviceID}");

                }
                else // no id yet...create a new service
                {

                    //TODO how to get start date for service abd enddate
                    Service service = new Service(truck, DateTime.Now, DateTime.Now.AddDays(3), false);
                    serviceID = await AddService(service);

                    Console.WriteLine($"new Service {service.ID}");
                }

                return serviceID;
            });
        }

        //add new service ITEM
        //log incidents from driverform
        public async Task<ServiceItem> AddServiceIem(Service service, ServiceType type)
        {
            return await Task.Run(async () =>
            {
                int id = -1;
                try
                {
                    string sql = "insert into ServiceItem(serviceID, serviceJob) " +
                                "values(@serviceID, @job)";

                    SqlCommand cmd = new SqlCommand(sql, dbCon);
                    cmd.Parameters.AddWithValue("@serviceID", service.ID);
                    cmd.Parameters.AddWithValue("@job", type.ID);

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
                return await GetServiceItemById(id);
            });
            //naz.ID= id;

            //return GetIncidentByID(id);
        }

        //add new service
        //log incidents from driverform
        public async Task<int> AddService(Service service)
        {
            return await Task.Run(async () =>
            {
                int id = -1;
                try
                {
                    string sql = "insert into Service(truckID, startDate, endDate, complete) " +
                                "values(@truckID, @startDate, @endDate, @complete)";

                    SqlCommand cmd = new SqlCommand(sql, dbCon);
                    cmd.Parameters.AddWithValue("@truckID", service.Truck.ID);
                    cmd.Parameters.AddWithValue("@startDate", service.StartDate);
                    cmd.Parameters.AddWithValue("@endDate", service.EndDate);
                    cmd.Parameters.AddWithValue("@complete", false);

                    dbCon.Open();
                    //do insert
                    cmd.ExecuteNonQuery();
                    //get ID
                    sql = "select @@identity";
                    cmd.CommandText = sql;
                    id = Convert.ToInt32(cmd.ExecuteScalar());

                    dbCon.Close();
                    return id;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return id;
            });

        }

        //log incidents from driverform
        public void LogIncident(Incident incident, User driver)
        {
            int id = -1;
            try
            {
                string sql = "insert into Incident(incidentType, driverID) " +
                            "values(@incidentType, @driverID)";

                SqlCommand cmd = new SqlCommand(sql, dbCon);
                cmd.Parameters.AddWithValue("@incidentType", incident.ID);
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
        public async Task<IncidentType> GetIncidentTypeByID(int id)
        {
            return await Task.Run(() =>
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
            });
        }

        public async Task<List<IncidentType>> GetIncidentTypes()
        {
            return await Task.Run(() =>
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
            });
        }

        /////////////////////////////////////////////////////////////////////////////users

        //getcustomer by ID
        public async Task<Customer> GetCustomerByID(int id)
        {
            return await Task.Run(async () =>
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
            });
        }

        //get a list of all customers
        public async Task<List<Customer>> GetCustomers()
        {
            return await Task.Run(() =>
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
            });
        }

        //return ID. ref type Customer so cus.ID is automatically assigned
        public int AddCustomer(Customer cus)
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
            return id;
        }

        //Log in user
        //return null if no user
        public async Task<User> LogInUser(string _username, string _password)
        {
            return await Task.Run(async () =>
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
                    UserType type = await GetUserTypeById((int)row["userType"]);
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
            });
        }


        //add user do DB
        //get ID in return
        //ref user object sets user.ID automatically
        public int AddUser(User user)
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

            return id;
        }

        //get drivers that are not availible
        public async Task<List<User>> GetAvailibleDrivers()
        {
            return await Task.Run(async () =>
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
                        UserType type = await GetUserTypeById((int)row["userType"]);
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
            });
        }

        //get a list of all users
        public async Task<List<User>> GetUsers()
        {
            return await Task.Run(async () =>
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
                        UserType type = await GetUserTypeById((int)row["userType"]);
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
            });
        }

        //get specific user by ID
        public async Task<User> GetUserByID(int id)
        {
            return await Task.Run(async () =>
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
                    UserType type = await GetUserTypeById((int)row["userType"]);
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
            });
        }

        //get user type by ID
        public async Task<UserType> GetUserTypeById(int id)
        {
            return await Task.Run(() =>
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
            });
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
        public async Task<Route> GetRouteByID(int id)
        {
            return await Task.Run(async () =>
            {
                Route route = null;

                try
                {
                    string sql = $"select * from routes where id = {id}";
                    SqlDataAdapter da = new SqlDataAdapter(sql, dbCon);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    DataRow row = ds.Tables[0].Rows[0];
                    int ID = (int)row["ID"];
                    Department deptart = await GetDepartmentByID((int)row["departure"]);
                    Department dest = await GetDepartmentByID((int)row["destination"]);
                    int kms = (int)row["kms"];
                    //get cost method

                    route = new Route(ID, deptart, dest, kms);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return route;
            });
        }

        //get a list of all routes
        public async Task<List<Route>> GetRoutes()
        {
            return await Task.Run(async () =>
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
                        Department deptart = await GetDepartmentByID((int)row["departure"]);
                        Department dest = await GetDepartmentByID((int)row["destination"]);
                        int kms = (int)row["kms"];
                        //add cost method

                        routes.Add(new Route(ID, deptart, dest, kms));
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return routes;
            });
        }

        //get department by ID
        public async Task<Department> GetDepartmentByID(int id)
        {
            return await Task.Run(async () =>
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
            });
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
        public int AddTruck(Truck truck)
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
        public int AddTruckType(TruckType type)
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
            catch (Exception ex)
            {


                throw ex;
            }
            type.ID = id;
            return id;
        }

        //get truck by ID
        public async Task<Truck> GetTruckByID(int id)
        {
            return await Task.Run(async () =>
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
                    bool availible = Convert.ToBoolean(row["availible"]);
                    TruckType type = await GetTruckTypeById((int)row["truckType"]);
                    truck = new Truck(ID, vin, reg, kms, availible, type);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return truck;
            });
        }

        //get a list of all trucks in db
        public async Task<List<Truck>> GetTrucks()
        {
            return await Task.Run(async() =>
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
                        TruckType type = await GetTruckTypeById((int)row["truckType"]);
                        Truck t = new Truck(ID, vin, reg, kms, availible, type);
                        trucks.Add(t);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return trucks;
            });
        }

        //query db for truck type by ID of type
        public async Task<TruckType> GetTruckTypeById(int id)
        {
            return await Task.Run(() =>
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
                    int litersPerHundy = (int)row["litersPerHundy"];

                    truckType = new TruckType(typeID, type, manufacturor, engineSize,
                        serviceInterval, maxWeight, litersPerHundy, maxVol);

                }
                catch (Exception ex)
                {

                    throw ex;
                }

                return truckType;
            });
        }

        public async Task<List<TruckType>> GetTruckType()
        {
            return await Task.Run(() =>
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
                        int litersPerHundy = (int)row["litersPerHundy"];
                        int maxVol = (int)row["maxVol"];

                        truckTypes.Add(new TruckType(typeID, type, manufacturor, engineSize,
                            serviceInterval, maxWeight, litersPerHundy, maxVol));

                    }

                }
                catch (Exception ex)
                {

                    throw ex;
                }
                return truckTypes;
            });
        }

        //get availiable trucks of specified type that are currently free
        public async Task<List<Truck>> GetAvailiableTrucks(TruckType type)
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
                    TruckType truckType = await GetTruckTypeById((int)row["truckType"]);
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
        public async Task<Service> CompleteService(Service service)
        {
            return await Task.Run(() =>
            {
                try
                {
                    string sql = $"update service set complete = 1 where id = @id";
                    SqlCommand cmd = new SqlCommand(sql, dbCon);
                    cmd.Parameters.AddWithValue("@id", service.ID);

                    dbCon.Open();
                    //do insert
                    cmd.ExecuteNonQuery();

                    dbCon.Close();

                }
                catch (Exception ex)
                {

                    throw ex;
                }

                return GetServiceById(service.ID);
            });
        }

        public async Task<List<Service>> GetServices()
        {
            return await Task.Run(async () =>
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
                        Truck truck = await GetTruckByID((int)row["truckID"]);
                        DateTime start = (DateTime)row["startdate"];
                        DateTime end = (DateTime)row["enddate"];
                        bool complete = (bool)row["complete"];

                        Service s = new Service(ID, truck,  start, end, complete);
                        services.Add(s);

                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return services;
            });
        }

        public async Task<List<Service>> GetServices(DateTime date)
        {
            List<Service> services = new List<Service>();

            try
            {
                string sql = $"select * from service where startDate <=  '{date.ToShortDateString()}' and endDate >= '{date.ToShortDateString()}'";
                SqlDataAdapter da = new SqlDataAdapter(sql, dbCon);
                DataSet ds = new DataSet();
                da.Fill(ds);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int ID = (int)row["ID"];
                    Truck truck = await GetTruckByID((int)row["truckID"]);
                    DateTime start = (DateTime)row["startdate"];
                    DateTime end = (DateTime)row["enddate"];
                    bool complete = (bool)row["complete"];

                    Service s = new Service(ID, truck, start, end, complete);
                    services.Add(s);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return services;
        }

        public async Task<List<Service>> GetIncompleteServices(DateTime startDate, DateTime endDate)
        {
            return await Task.Run(async () =>
            {
                List<Service> services = new List<Service>();

                try
                {
                    string sql = $"select * from service where complete = 0 and " +
                    $"startDate >= '{startDate}' and startdate <= '{endDate}' or " +
                    $"enddate >= '{startDate}' and enddate <= '{endDate}'";
                    SqlDataAdapter da = new SqlDataAdapter(sql, dbCon);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        int ID = (int)row["ID"];
                        Truck truck = await GetTruckByID((int)row["truckID"]);
                        DateTime start = (DateTime)row["startdate"];
                        DateTime end = (DateTime)row["enddate"];
                        bool complete = (bool)row["complete"];

                        Service s = new Service(ID, truck,  start, end, complete);
                        services.Add(s);

                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return services;
            });
        }

        public async Task<List<Service>> GetIncompleteServices()
        {
            return await Task.Run(async () =>
            {
                List<Service> services = new List<Service>();

                try
                {
                    string sql = $"select * from service where complete = 0";
                    SqlDataAdapter da = new SqlDataAdapter(sql, dbCon);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        int ID = (int)row["ID"];
                        Truck truck = await GetTruckByID((int)row["truckID"]);
                        DateTime start = (DateTime)row["startdate"];
                        DateTime end = (DateTime)row["enddate"];
                        bool complete = (bool)row["complete"];

                        Service s = new Service(ID, truck, start, end, complete);
                        services.Add(s);

                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return services;
            });
        }

        public async Task<List<Service>> GetCompleteServices()
        {
            return await Task.Run(async () =>
            {
                List<Service> services = new List<Service>();

                try
                {
                    string sql = $"select * from service where complete = 1";
                    SqlDataAdapter da = new SqlDataAdapter(sql, dbCon);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        int ID = (int)row["ID"];
                        Truck truck = await GetTruckByID((int)row["truckID"]);
                        DateTime start = (DateTime)row["startdate"];
                        DateTime end = (DateTime)row["enddate"];
                        bool complete = (bool)row["complete"];

                        Service s = new Service(ID, truck, start, end, complete);
                        services.Add(s);

                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return services;
            });
        }

        public async Task<List<Service>> GetCompleteServices(DateTime startDate, DateTime endDate)
        {
            return await Task.Run(async () =>
            {
                List<Service> services = new List<Service>();

                try
                {
                    string sql = $"select * from service where complete = 1 and " +
                    $"startDate >= '{startDate}' and startdate <= '{endDate}' or " +
                    $"enddate >= '{startDate}' and enddate <= '{endDate}'";
                    SqlDataAdapter da = new SqlDataAdapter(sql, dbCon);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        int ID = (int)row["ID"];
                        Truck truck = await GetTruckByID((int)row["truckID"]);
                        User mechanic = await GetUserByID((int)row["mechanic"]);
                        DateTime start = (DateTime)row["startdate"];
                        DateTime end = (DateTime)row["enddate"];
                        bool complete = (bool)row["complete"];

                        Service s = new Service(ID, truck, start, end, complete);
                        services.Add(s);

                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return services;
            });
        }

        public async Task<List<Service>> GetServices(DateTime startDate, DateTime endDate)
        {
            return await Task.Run(async () =>
            {
                List<Service> services = new List<Service>();

                try
                {
                    string sql = $"select * from service where startDate >= '{startDate}' and startdate <= '{endDate}' or enddate >= '{startDate}' and enddate <= '{endDate}'";
                    SqlDataAdapter da = new SqlDataAdapter(sql, dbCon);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        int ID = (int)row["ID"];
                        Truck truck = await GetTruckByID((int)row["truckID"]);
                        DateTime start = Convert.ToDateTime(row["startdate"]);
                        DateTime end = Convert.ToDateTime(row["enddate"]);
                        bool complete = Convert.ToBoolean(row["complete"]);

                        Service s = new Service(ID, truck, start, end, complete);
                        services.Add(s);

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    throw ex;
                }
                return services;
            });
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

        public async Task<Service> GetServiceById(int id)
        {
            return await Task.Run(async () =>
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
                    Truck truck = await GetTruckByID((int)row["truckID"]);
                    DateTime start = Convert.ToDateTime(row["startdate"]);
                    DateTime end = Convert.ToDateTime(row["enddate"]);
                    bool complete = Convert.ToBoolean(row["complete"]);

                    services = new Service(ID, truck, start, end, complete);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return services;
            });
        }

        public async Task<List<ServiceType>> GetServiceTypes()
        {
            return await Task.Run(async () =>
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
            });
        }

        public async Task<ServiceType> GetServiceTypeById(int id)
        {
            return await Task.Run(async () =>
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
            });
        }

        public async Task<List<ServiceItem>> GetServiceItems()
        {
            return await Task.Run(async () =>
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
                        Service service = await GetServiceById((int)row["serviceID"]);
                        ServiceType type = await GetServiceTypeById((int)row["serviceJob"]);

                        ServiceItem si = new ServiceItem(ID, service, type);
                        serviceItems.Add(si);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return serviceItems;
            });
        }

        public async Task<List<ServiceItem>> GetServiceItems(Service service)
        {
            return await Task.Run(async () =>
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
                        ServiceType type = await GetServiceTypeById((int)row["serviceJob"]);

                        ServiceItem si = new ServiceItem(ID, service, type);
                        serviceItems.Add(si);

                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return serviceItems;
            });
        }

        public async Task<List<ServiceItem>> GetServiceItems(int serviceID)
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
                    Service service = await GetServiceById((int)row["serviceID"]);
                    ServiceType type = await GetServiceTypeById((int)row["serviceJob"]);

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

        public async Task<ServiceItem> GetServiceItemById(int id)
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
                Service service = await GetServiceById((int)row["serviceID"]);
                ServiceType type = await GetServiceTypeById((int)row["serviceJob"]);

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
