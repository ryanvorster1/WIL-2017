using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLogic
{
    public class Truck
    {
        public int ID { get; set; }
        public string Vin { get; set; }
        public string Reg { get; set; }
        public int Kms { get; set; }
        public bool Availible { get; set; }
        public TruckType Type { get; set; }

        public Truck()
        {

        }

        public Truck(int id, string vin, string reg, 
            int kms, bool avail, TruckType type)
        {
            ID = id;
            this.Vin = vin;
            this.Reg = reg;
            this.Kms = kms;
            Availible = avail;
            this.Type = type;
        }

        public string ToString()
        {
            string result = $"ID: {ID}\nVIN: {Vin}\nREG: {Reg}\nKMS: {Kms}\nAvail: {Availible}";
            result += Type.ToString();
            return result;
        }

    }

   public class TruckType
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public string Manufacturor { get; set; }
        public int EngineSize { get; set; }
        public int ServiceInterval { get; set; }
        public int MaxWeight { get; set; }
        public int MaxVol { get; set; }

        public TruckType()
        {

        }

        public TruckType(int id, string type, string man, 
            int engineSize, int serviceInterval,int maxWeight, int maxVol)
        {
            ID = id;
            this.Type = type;
            Manufacturor = man;
            this.EngineSize = engineSize;
            this.ServiceInterval = serviceInterval;
            this.MaxWeight = maxWeight;
            this.MaxVol = maxVol;
        }

        public string ToString()
        {
            string result = $"\nTRUCKTYPE\nID: {ID}\nType: {Type}\nMan: {Manufacturor}\nEngine: {EngineSize}cc\nService: {ServiceInterval}\nMax Weight:{MaxWeight}\nMax Vol: {MaxVol}";
            return result;
        }
    }
}
