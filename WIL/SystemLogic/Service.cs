﻿using System;
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
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Complete { get; set; }

        public Service(int id, Truck truck,  DateTime start, DateTime end, bool complete)
        {
            ID = id;
            Truck = truck;
            StartDate = start;
            EndDate = end;
            Complete = complete;
        }

        public Service(Truck truck,  DateTime start, DateTime end, bool complete)
        {
            ID = -1;
            Truck = truck;
            StartDate = start;
            EndDate = end;
            Complete = complete;
        }

        public Service(Truck truck)
        {
            ID = -1;
            Truck = truck;
        }

        public override string ToString()
        {
            return $"ID:{ID} Truck:{Truck.Type.Type} {StartDate} - {EndDate}";
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

        public override string ToString()
        {
            return Job;
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

        public override string ToString()
        {
            return ServiceType.Job;
        }
    }
}
