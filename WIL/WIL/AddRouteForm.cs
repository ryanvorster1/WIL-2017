using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemLogic;

namespace WIL
{
    public partial class AddRouteForm : Form
    {
        private DBManager db;
        public AddRouteForm()
        {
            InitializeComponent();
            db = new DBManager();

        }

        private void AddRouteForm_Load(object sender, EventArgs e)
        {

        }


        private async void addBtn_Click(object sender, EventArgs e)
        {
            if (departmenttxt.Text.Length > 0 && kmsTxt.Text.Length > 0)
            {
                string name = departmenttxt.Text;
                int kms = Convert.ToInt32(kmsTxt.Text);
                int destID = await db.AddDepartment(new Department(name));



                Department dest = await db.GetDepartmentByID(destID);
                Department capeTown = await db.GetDepartmentByID(0);
                Console.WriteLine(dest);
                Console.WriteLine(capeTown);

                Route routes = new Route(capeTown, dest, kms);
                await db.AddRoute(routes);

                MessageBox.Show("Route added successfully");
                this.Close();
            }
            else
            {
                MessageBox.Show("Complete all fields please"); 

            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
