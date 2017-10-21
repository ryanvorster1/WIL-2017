using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemLogic;

namespace WIL
{
    class TestClass
    {
        public static void Main(string[] args)
        {
            DBManager dbm = new DBManager();
            TruckType t = new TruckType("truck", "man", 4000, 20000, 40000, 80000);
            Truck truck = new Truck("789456321", "CA-TRUCK", 0, true, t);

            dbm.AddTruck(ref truck);

            Console.WriteLine(truck.ID);

            Console.ReadLine();
        }
    }
}
