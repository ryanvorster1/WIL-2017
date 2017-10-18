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
            foreach(Truck t in dbm.GetTrucks())
            {
                Console.WriteLine(t.ToString());
            }
            Console.ReadLine();
        }
    }
}
