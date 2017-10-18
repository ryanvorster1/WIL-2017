using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLogic
{
    public class Truck
    {
        private int ID;
        private string vin;
        private string reg;
        private int kms;
        private bool availible;
        private TruckType type;

        public Truck()
        {

        }

        public Truck(int id, string vin, string reg, 
            int kms, bool avail, TruckType type)
        {
            ID = id;
            this.vin = vin;
            this.reg = reg;
            this.kms = kms;
            availible = avail;
            this.type = type;
        }

        public string ToString()
        {
            string result = $"ID: {ID}\nVIN: {vin}\nREG: {reg}\nKMS: {kms}\nAvail: {availible}";
            result += type.ToString();
            return result;
        }

    }

   public class TruckType
    {
        private int ID;
        private string type;
        private string manufacturor;
        private int engineSize;
        private int serviceInterval;
        private int maxWeight;
        private int maxVol;
        
        public TruckType()
        {

        }

        public TruckType(int id, string type, string man, 
            int engineSize, int serviceInterval,int maxWeight, int maxVol)
        {
            ID = id;
            this.type = type;
            manufacturor = man;
            this.engineSize = engineSize;
            this.serviceInterval = serviceInterval;
            this.maxWeight = maxWeight;
            this.maxVol = maxVol;
        }

        public string ToString()
        {
            string result = $"\nTRUCKTYPE\nID: {ID}\nType: {type}\nMan: {manufacturor}\nEngine: {engineSize}cc\nService: {serviceInterval}\nMax Weight:{maxWeight}\nMax Vol: {maxVol}";
            return result;
        }
    }
}
