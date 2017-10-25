using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLogic
{
    public class Customer
    {
        public int ID { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
        public string Cell { get; set; }

        public Customer()
        {

        }
        
        public Customer(int id, string fname, string lname, string email, string cell)
        {
            ID = id;
            Fname = fname;
            Lname = lname;
            Email = email;
            Cell = cell;
        }

        public Customer(string fname, string lname, string email, string cell)
        {
            ID = -1;
            Fname = fname;
            Lname = lname;
            Email = email;
            Cell = cell;
        }

        public string ToString()
        {
            return $"{ID}) {Fname + Lname} {Email} {Cell}";
        }
    }
}
