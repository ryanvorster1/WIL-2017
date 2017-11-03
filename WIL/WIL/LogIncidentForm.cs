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
        private bool updating;
        public LogIncidentForm(User user)
        {
            loggedIn = user;
            InitializeComponent();

        }

        private void LogIncidentForm_Load(object sender, EventArgs e)
        {
            cnbIncidents.Items.Clear();
            cnbIncidents.Items.Add("Select item here>");
            updating = true;
            cnbIncidents.SelectedIndex = 0;
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
           db.logIncident((int)cnbIncidents.SelectedValue,loggedIn);

            MessageBox.Show("Report succesful");
            pnlIncident.Visible = false;
        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            btnLogIncident.Visible = true;
        }

        private void cnbIncidents_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (!updating)
            //{
            //    cnbIncidents.DataSource = new DBManager().GetIncidentTypes();
            //    cnbIncidents.DisplayMember = "Description";
            //    cnbIncidents.ValueMember = "ID";
            //}
            //updating = false;
        }

        private void cnbIncidents_MouseClick(object sender, MouseEventArgs e)
        {
           
                cnbIncidents.DataSource = new DBManager().GetIncidentTypes();
                cnbIncidents.DisplayMember = "Description";
                cnbIncidents.ValueMember = "ID";
            
            updating = false;
        }

        private void cnbIncidents_Click(object sender, EventArgs e)
        {

        }

        private void completedTripsbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
