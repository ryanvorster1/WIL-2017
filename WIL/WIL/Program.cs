using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemLogic;

namespace WIL
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //disable logins
            //Application.Run(new LoginForm());

           // Application.Run(new MainForm(new DBManager().LogInUser("Bart", "simps")));
           User loggedIn = new DBManager().LogInUser("jonny", "walks");
            Console.WriteLine(loggedIn.ToString());
            Application.Run(new LogIncidentForm(loggedIn));



        }
    }
}
