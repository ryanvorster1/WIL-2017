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

        public Truck(string vin, string reg,
            int kms, bool avail, TruckType type)
        {
            ID = -1;
            this.Vin = vin;
            this.Reg = reg;
            this.Kms = kms;
            Availible = avail;
            this.Type = type;
        }

        public override string ToString()
        {
            //string result = $"ID: {ID}\nVIN: {Vin}\nREG: {Reg}\nKMS: {Kms}\nAvail: {Availible}";
            //result += Type.ToString();
            //return result;
            return $"{Type.Manufacturor} {Type.Type} #{ID}";
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
        public float LitersPerHundy { get; set; }
        public int MaxVol { get; set; }

        //default constructor
        public TruckType()
        {

        }

        //constructor will all paramaters
        public TruckType(int id, string type, string man,
            int engineSize, int serviceInterval, int maxWeight, float litersPerHundy, int maxVol)
        {
            ID = id;
            this.Type = type;
            Manufacturor = man;
            this.EngineSize = engineSize;
            this.ServiceInterval = serviceInterval;
            this.MaxWeight = maxWeight;
            this.LitersPerHundy = litersPerHundy; 
            this.MaxVol = maxVol;
        }

        //constructor without ID
        public TruckType(string type, string man,
            int engineSize, int serviceInterval, int maxWeight, float litersPerHundy, int maxVol)
        {
            this.Type = type;
            Manufacturor = man;
            this.EngineSize = engineSize;
            this.ServiceInterval = serviceInterval;
            this.MaxWeight = maxWeight;
            this.LitersPerHundy = litersPerHundy;
            this.MaxVol = maxVol;
        }

        public override string ToString()
        {
            return $"{Manufacturor} {Type}";
        }
    }
}

