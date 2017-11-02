using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLogic
{
    public class Incident
    {
        public int ID { get; set; }
        public IncidentType Type { get; set; }
        public User Driver { get; set; }

        public Incident(int id, IncidentType type, User driver)
        {
            ID = id;
            this.Type = type;
            this.Driver = driver;
        }

    }

    public class IncidentType
    {
       public int ID { get; set; }
        public string Description { get; set; }
        public double Cost { get; set; }
        public int RepairTime { get; set; }

        public  IncidentType(int id, string descript, double cost, int repairTime)
        {
            ID = id;
            Description = descript;
            this.Cost = cost;
            this.RepairTime = repairTime;
        }
    }
}
