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
    public partial class ServiceForm : Form
    {
        DBManager dbm;
        List<string> service = new List<string>();
        public ServiceForm()
        {
            
            InitializeComponent();
          
        }

        private void ListBoxHandle()
        {
            lboxServiceList.Columns.Add("Truck ID", 200);
            lboxServiceList.Columns.Add("Service ID", 200);
            lboxServiceList.Columns.Add("Mechanic", 200);
        }

      
        private void bttnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
