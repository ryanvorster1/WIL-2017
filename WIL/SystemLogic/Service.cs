using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLogic
{
    public class Service
    {
        public int ID { get; set; }
        public Truck Truck { get; set; }
        public User Mechanic { get; set; }

        public Service(int id, Truck truck, User mechanic)
        {
            ID = id;
            Truck = truck;
            Mechanic = mechanic;
        }

        public Service(Truck truck, User mechanic)
        {
            ID = -1;
            Truck = truck;
            Mechanic = mechanic;
        }
    }

    public class ServiceType
    {
        public int ID { get; set; }
        public string Job { get; set; }
        public double Cost { get; set; }
        public int Hours { get; set; }

        public ServiceType(int id, string job, double cost, int hours)
        {
            ID = id;
            Job = job;
            Cost = cost;
            Hours = hours;
        }


        public ServiceType(string job, double cost, int hours)
        {
            ID = -1;
            Job = job;
            Cost = cost;
            Hours = hours;
        }
    }

    public class ServiceItem
    {
        public int ID { get; set; }
        public Service Service { get; set; }
        public ServiceType ServiceType { get; set; } 

        public ServiceItem(int id, Service service, ServiceType type)
        {
            ID = id;
            Service = service;
            ServiceType = type;
        }

        public ServiceItem(Service service, ServiceType type)
        {
            ID = -1;
            Service = service;
            ServiceType = type;
        }

    }
}
