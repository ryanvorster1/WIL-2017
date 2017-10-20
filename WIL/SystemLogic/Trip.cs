using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLogic
{
    public class Trip
    {
        private int ID;
        private Truck truck;
        private User customer;
        private DateTime start;
        private DateTime end;
        private User driver;
        private Route route;

        public Trip(int id, Truck truck, User customer, DateTime start, DateTime end,
            User driver, Route route)
        {
            ID = id;
            this.truck = truck;
            this.customer = customer;
            this.start = start;
            this.end = end;
            this.driver = driver;
            this.route = route;
        }

        public string ToString()
        {
            return $"{ID}\n {truck.ToString()}\n{customer.ToString()}";
        }
    }
}
