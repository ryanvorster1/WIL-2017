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
    public partial class LogIncidentForm : Form
    {
        public LogIncidentForm()
        {
            InitializeComponent();
        }

        private void LogIncidentForm_Load(object sender, EventArgs e)
        {
            cnbIncidents.DataSource = new DBManager().GetIncidentTypes();
            cnbIncidents.DisplayMember = "Description";
        }
    }
}
