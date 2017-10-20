using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLogic
{
    public class User
    {
        private int ID;
        private string username;
        private string password;
        private UserType type;
        private int hours;
        private string fname;
        private string lname;


        public User(int id, string username, string pass,
            UserType type, int hours, string fname, string lname)
        {
            ID = id;
            this.username = username;
            password = pass;
            this.type = type;
            this.hours = hours;
            this.fname = fname;
            this.lname = lname;
        }


        
    }

    public class UserType
    {
        private int ID;
        private string type;

        public UserType(int ID, string type)
        {
            this.ID = ID;
            this.type = type;
        }
    }
}
