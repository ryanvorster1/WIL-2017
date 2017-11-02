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
        private User loggedIn;
        public LogIncidentForm(User user)
        {
            loggedIn = user;
            InitializeComponent();
        }

        private void LogIncidentForm_Load(object sender, EventArgs e)
        {
            cnbIncidents.DataSource = new DBManager().GetIncidentTypes();
            cnbIncidents.DisplayMember = "Description";
            cnbIncidents.ValueMember = "ID";
        }

        private void btnLogIncident_Click(object sender, EventArgs e)
        {
            pnlIncident.Visible = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            pnlIncident.Visible = false;
        }

        private void sendIncidentReportButton_Click(object sender, EventArgs e)
        {
            DBManager db = new DBManager();
            Console.WriteLine(loggedIn.ToString());
            Incident inc = db.logIncident((int)cnbIncidents.SelectedValue,loggedIn);

        }
    }
}
