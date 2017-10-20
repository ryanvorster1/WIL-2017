using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLogic
{
    public class Incident
    {
        private int ID;
        private IncidentType type;
        private User driver;

        public Incident(int id, IncidentType type, User driver)
        {
            id = id;
            this.type = type;
            this.driver = driver;
        }

    }

    public class IncidentType
    {
        private int ID;
        private string description;
        private double cost;
        private int repairTime;

        public  IncidentType(int id, string descript, double cost, int repairTime)
        {
            ID = id;
            description = descript;
            this.cost = cost;
            this.repairTime = repairTime;
        }
    }
}
