using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLogic
{
    public class Route
    {
        private int ID;
        private Department departure;
        private Department destination;
        private int kms;

        public Route(int id, Department depart, Department dest, int kms)
        {
            ID = id;
            departure = depart;
            destination = dest;
            this.kms = kms;
        }

        public string ToString()
        {
            string result = $"depoID: {ID}\nDestination\n {destination.ToString()}";
            result += $"\nDeparture\n {departure.ToString()}\n KMS: {kms}";
            return result;
        }

    }

    public class Department
    {
        private int ID;
        private string name;

        public Department(int id, string name)
        {
            ID = id;
            this.name = name;
        }

        public String ToString()
        {
            string result = $"DepoID: {ID}\nDepoName: {name}";
            return result;
        }

    }
}
