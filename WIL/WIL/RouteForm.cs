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
    public partial class RouteForm : Form
    {     
        private DBManager db;
    
        public RouteForm()
        {
            InitializeComponent();
            db = new DBManager();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddRouteForm arf = new AddRouteForm();
            arf.ShowDialog();
        }
    }
}
