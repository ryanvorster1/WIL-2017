using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIL
{
    class TruckService
    {
        public int ID { get; set; }
        public int TruckID { get; set; }
        public int MechanicID { get; set; }

        public TruckService()
        {

        }

        public TruckService(int pID, int pTruckID, int pMechanicID)
        {
            ID = pID;
            this.TruckID = pTruckID;
            this.MechanicID = pMechanicID;
        }
    }
}
