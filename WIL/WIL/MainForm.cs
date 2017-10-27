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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Console.WriteLine(new DBManager().GetServiceItems()[0].Service.Mechanic.Fname + new DBManager().GetServiceItems()[0].ServiceType.Job);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            new UserForm().ShowDialog();
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            new ServiceForm().ShowDialog();
        }
    }
}
