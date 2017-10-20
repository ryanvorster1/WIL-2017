using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLogic
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserType Type { get; set; }
        public int Hours { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }


        public User(int id, string username, string pass,
            UserType type, int hours, string fname, string lname)
        {
            ID = id;
            this.Username = username;
            Password = pass;
            this.Type = type;
            this.Hours = hours;
            this.Fname = fname;
            this.Lname = lname;
        }


        
    }

    public class UserType
    {
        public int ID { get; set; }
        public string Type { get; set; }

        public UserType(int ID, string type)
        {
            this.ID = ID;
            this.Type = type;
        }
    }
}
