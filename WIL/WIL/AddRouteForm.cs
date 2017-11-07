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

            string name = departmenttxt.Text;

            int kms = Convert.ToInt32(kmsTxt.Text);
            int destID = await db.AddDepartment(new Department(name));

            Department dest = db.GetDepartmentByID(destID);

            Route routes = new Route(db.GetDepartmentByID(0), dest, kms);

            await db.AddRoute(routes);
        }
    }
}
