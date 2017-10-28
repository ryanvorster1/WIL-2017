using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIL
{
    class ServiceDetailscs
    {
        public string MechanicFirstName{ get; set; }
        public string MechanicSurname { get; set; }
        public string Vin { get; set; }
        public string Reg { get; set; }
        public string Manufacturor { get; set; }
        public string Type { get; set; }
        public int EngineSize { get; set; }
        public int ServiceInterval { get; set; }
        public string Job { get; set; }
        public string Cost { get; set; }
        public int Hours { get; set; }

        public ServiceDetailscs()
        {

        }

        public ServiceDetailscs(string pMechanicFirstName, string pMechanicSurname, string pVin, string pReg, string pManufacturor, string pType, int pEngineSize, int pServiceInterval, string pJob, string pCost, int pHours)
        {
            this.MechanicFirstName = pMechanicFirstName;
            this.MechanicSurname = pMechanicSurname;
            this.Vin = pVin;
            this.Reg = pReg;
            this.Manufacturor = pManufacturor;
            this.Type = pType;
            this.EngineSize = pEngineSize;
            this.ServiceInterval = pServiceInterval;
            this.Job = pJob;
            this.Cost = pCost;
            this.Hours = pHours;
        }
    }
}
