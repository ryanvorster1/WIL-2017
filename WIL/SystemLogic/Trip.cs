using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLogic
{
    public class Trip
    {
        public int ID { get; set; }
        public Truck Truck { get; set; }
        public Customer Customer { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public User Driver { get; set; }
        public Route Route { get; set; }

        public Trip(int id, Truck truck, Customer customer, DateTime start, DateTime end,
            User driver, Route route)
        {
            ID = id;
            this.Truck = truck;
            this.Customer = customer;
            this.Start = start;
            this.End = end;
            this.Driver = driver;
            this.Route = route;
        }

        public Trip( Truck truck, Customer customer, DateTime start, DateTime end,
           User driver, Route route)
        {
            ID = -1;
            this.Truck = truck;
            this.Customer = customer;
            this.Start = start;
            this.End = end;
            this.Driver = driver;
            this.Route = route;
        }

        public override string ToString()
        {
            return $"{ID}\n {Truck.ToString()}\n{Customer.ToString()}";
        }
    }
}
