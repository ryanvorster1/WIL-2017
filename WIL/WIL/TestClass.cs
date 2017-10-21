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
            TruckType type = dbm.GetTruckTypeById(0);
            Truck truck = new Truck("45321789", "VA-CILL", 300, false, type);
            dbm.AddTruck(ref truck);

            foreach (var t in dbm.GetAvailiableTrucks(type))
            {
                Console.WriteLine(t.ToString());
            }


            Console.WriteLine(truck.ID);

            Console.ReadLine();
        }
    }
}
