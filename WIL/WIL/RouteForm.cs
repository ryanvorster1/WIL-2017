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
            UpdateDGVRoutes();
            
        }

        private void RouteForm_Load(object sender, EventArgs e)
        {
            UpdateDGVRoutes();
        }
        private async void UpdateDGVRoutes()
        {
            dgvRoutes.Rows.Clear();
            dgvRoutes.Columns.Clear();
            dgvRoutes.Columns.Add("name", "Name");
            dgvRoutes.Columns.Add("kms", "Kms");

            foreach (var item in await db.GetRoutes())
            {
                dgvRoutes.Rows.Add(item.Destination.Name, item.Kms);

            }

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
  