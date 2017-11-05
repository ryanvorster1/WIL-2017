namespace WIL
{
    partial class TripForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.viewPlannedTripsBtn = new System.Windows.Forms.Button();
            this.viewCompletedTripsBtn = new System.Windows.Forms.Button();
            this.addTripButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.wILDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlReportView = new System.Windows.Forms.Panel();
            this.btnCloseReportView = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTrips = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.viewReportsbtn = new System.Windows.Forms.Button();
            this.truckID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wILDBDataSetBindingSource)).BeginInit();
            this.pnlReportView.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewPlannedTripsBtn
            // 
            this.viewPlannedTripsBtn.Location = new System.Drawing.Point(12, 12);
            this.viewPlannedTripsBtn.Name = "viewPlannedTripsBtn";
            this.viewPlannedTripsBtn.Size = new System.Drawing.Size(117, 40);
            this.viewPlannedTripsBtn.TabIndex = 0;
            this.viewPlannedTripsBtn.Text = "View Planned Trips";
            this.viewPlannedTripsBtn.UseVisualStyleBackColor = true;
            // 
            // viewCompletedTripsBtn
            // 
            this.viewCompletedTripsBtn.Location = new System.Drawing.Point(154, 12);
            this.viewCompletedTripsBtn.Name = "viewCompletedTripsBtn";
            this.viewCompletedTripsBtn.Size = new System.Drawing.Size(121, 40);
            this.viewCompletedTripsBtn.TabIndex = 2;
            this.viewCompletedTripsBtn.Text = "View Completed Trips";
            this.viewCompletedTripsBtn.UseVisualStyleBackColor = true;
            // 
            // addTripButton
            // 
            this.addTripButton.Location = new System.Drawing.Point(483, 12);
            this.addTripButton.Name = "addTripButton";
            this.addTripButton.Size = new System.Drawing.Size(136, 40);
            this.addTripButton.TabIndex = 3;
            this.addTripButton.Text = "Add Trip";
            this.addTripButton.UseVisualStyleBackColor = true;
            this.addTripButton.Click += new System.EventHandler(this.addTripButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(511, 508);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(108, 27);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit ";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.truckID,
            this.customerID,
            this.startDate,
            this.endDate,
            this.departure,
            this.destination});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(9, 116);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(601, 289);
            this.dataGridView1.TabIndex = 5;
            // 
            // pnlReportView
            // 
            this.pnlReportView.Controls.Add(this.btnCloseReportView);
            this.pnlReportView.Controls.Add(this.label5);
            this.pnlReportView.Controls.Add(this.label4);
            this.pnlReportView.Controls.Add(this.label3);
            this.pnlReportView.Location = new System.Drawing.Point(12, 411);
            this.pnlReportView.Name = "pnlReportView";
            this.pnlReportView.Size = new System.Drawing.Size(601, 91);
            this.pnlReportView.TabIndex = 6;
            this.pnlReportView.Visible = false;
            // 
            // btnCloseReportView
            // 
            this.btnCloseReportView.Location = new System.Drawing.Point(237, 65);
            this.btnCloseReportView.Name = "btnCloseReportView";
            this.btnCloseReportView.Size = new System.Drawing.Size(129, 23);
            this.btnCloseReportView.TabIndex = 8;
            this.btnCloseReportView.Text = "Close Report View";
            this.btnCloseReportView.UseVisualStyleBackColor = true;
            this.btnCloseReportView.Click += new System.EventHandler(this.btnCloseReportView_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(492, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Overall hours driving:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Overall fuel expense: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Overall distance travelled: ";
            // 
            // dtpTrips
            // 
            this.dtpTrips.Location = new System.Drawing.Point(12, 86);
            this.dtpTrips.Name = "dtpTrips";
            this.dtpTrips.Size = new System.Drawing.Size(200, 20);
            this.dtpTrips.TabIndex = 0;
            this.dtpTrips.ValueChanged += new System.EventHandler(this.dtpTrips_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Motnhly",
            "Yearly"});
            this.comboBox1.Location = new System.Drawing.Point(322, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Select here<";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select start date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select daily/weekly/Monthly";
            // 
            // viewReportsbtn
            // 
            this.viewReportsbtn.Location = new System.Drawing.Point(322, 12);
            this.viewReportsbtn.Name = "viewReportsbtn";
            this.viewReportsbtn.Size = new System.Drawing.Size(136, 40);
            this.viewReportsbtn.TabIndex = 7;
            this.viewReportsbtn.Text = "View Reports";
            this.viewReportsbtn.UseVisualStyleBackColor = true;
            this.viewReportsbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // truckID
            // 
            this.truckID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.truckID.DefaultCellStyle = dataGridViewCellStyle1;
            this.truckID.HeaderText = "Truck ID";
            this.truckID.Name = "truckID";
            this.truckID.ToolTipText = "Double click to view details.";
            // 
            // customerID
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Plum;
            this.customerID.DefaultCellStyle = dataGridViewCellStyle2;
            this.customerID.HeaderText = "Customer ID";
            this.customerID.Name = "customerID";
            // 
            // startDate
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Plum;
            this.startDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.startDate.HeaderText = "Start Date";
            this.startDate.Name = "startDate";
            // 
            // endDate
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Plum;
            this.endDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.endDate.HeaderText = "End Date";
            this.endDate.Name = "endDate";
            // 
            // departure
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Plum;
            this.departure.DefaultCellStyle = dataGridViewCellStyle5;
            this.departure.HeaderText = "Departure";
            this.departure.Name = "departure";
            // 
            // destination
            // 
            this.destination.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Plum;
            this.destination.DefaultCellStyle = dataGridViewCellStyle6;
            this.destination.HeaderText = "Destination";
            this.destination.Name = "destination";
            this.destination.Width = 85;
            // 
            // TripForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 547);
            this.Controls.Add(this.viewReportsbtn);
            this.Controls.Add(this.pnlReportView);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addTripButton);
            this.Controls.Add(this.dtpTrips);
            this.Controls.Add(this.viewCompletedTripsBtn);
            this.Controls.Add(this.viewPlannedTripsBtn);
            this.Name = "TripForm";
            this.Text = "tripForm";
            this.Load += new System.EventHandler(this.TripForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wILDBDataSetBindingSource)).EndInit();
            this.pnlReportView.ResumeLayout(false);
            this.pnlReportView.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewPlannedTripsBtn;
        private System.Windows.Forms.Button viewCompletedTripsBtn;
        private System.Windows.Forms.Button addTripButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource wILDBDataSetBindingSource;
        private System.Windows.Forms.Panel pnlReportView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dtpTrips;
        private System.Windows.Forms.Button viewReportsbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCloseReportView;
        private System.Windows.Forms.DataGridViewTextBoxColumn truckID;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn departure;
        private System.Windows.Forms.DataGridViewTextBoxColumn destination;
    }
}