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


        public Truck()
        {

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

    }
}
