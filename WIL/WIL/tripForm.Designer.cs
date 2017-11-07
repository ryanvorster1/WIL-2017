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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TripForm));
            this.btnPlannedTrips = new System.Windows.Forms.Button();
            this.btnCompleteTrips = new System.Windows.Forms.Button();
            this.addTripButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.dgvTrips = new System.Windows.Forms.DataGridView();
            this.truckID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wILDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlReportView = new System.Windows.Forms.Panel();
            this.lblTotalTrips = new System.Windows.Forms.Label();
            this.lblTotalDistance = new System.Windows.Forms.Label();
            this.btnCloseReportView = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTrips = new System.Windows.Forms.DateTimePicker();
            this.cmbViewType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bentViewReport = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogIncident = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrips)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wILDBDataSetBindingSource)).BeginInit();
            this.pnlReportView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlannedTrips
            // 
            this.btnPlannedTrips.Location = new System.Drawing.Point(12, 12);
            this.btnPlannedTrips.Name = "btnPlannedTrips";
            this.btnPlannedTrips.Size = new System.Drawing.Size(117, 40);
            this.btnPlannedTrips.TabIndex = 0;
            this.btnPlannedTrips.Text = "View Planned Trips";
            this.btnPlannedTrips.UseVisualStyleBackColor = true;
            this.btnPlannedTrips.Click += new System.EventHandler(this.viewPlannedTripsBtn_Click);
            // 
            // btnCompleteTrips
            // 
            this.btnCompleteTrips.Location = new System.Drawing.Point(154, 12);
            this.btnCompleteTrips.Name = "btnCompleteTrips";
            this.btnCompleteTrips.Size = new System.Drawing.Size(121, 40);
            this.btnCompleteTrips.TabIndex = 2;
            this.btnCompleteTrips.Text = "View Completed Trips";
            this.btnCompleteTrips.UseVisualStyleBackColor = true;
            this.btnCompleteTrips.Click += new System.EventHandler(this.viewCompletedTripsBtn_Click);
            // 
            // addTripButton
            // 
            this.addTripButton.Location = new System.Drawing.Point(510, 12);
            this.addTripButton.Name = "addTripButton";
            this.addTripButton.Size = new System.Drawing.Size(136, 40);
            this.addTripButton.TabIndex = 3;
            this.addTripButton.Text = "Add Trip";
            this.addTripButton.UseVisualStyleBackColor = true;
            this.addTripButton.Click += new System.EventHandler(this.addTripButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(554, 568);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(92, 38);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit ";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // dgvTrips
            // 
            this.dgvTrips.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvTrips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrips.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.truckID,
            this.customerID,
            this.startDate,
            this.endDate,
            this.departure,
            this.destination});
            this.dgvTrips.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvTrips.Location = new System.Drawing.Point(17, 155);
            this.dgvTrips.MultiSelect = false;
            this.dgvTrips.Name = "dgvTrips";
            this.dgvTrips.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvTrips.RowHeadersVisible = false;
            this.dgvTrips.Size = new System.Drawing.Size(629, 289);
            this.dgvTrips.TabIndex = 5;
            this.dgvTrips.DoubleClick += new System.EventHandler(this.dgvTrips_DoubleClick);
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
            // pnlReportView
            // 
            this.pnlReportView.Controls.Add(this.lblTotalTrips);
            this.pnlReportView.Controls.Add(this.lblTotalDistance);
            this.pnlReportView.Controls.Add(this.btnCloseReportView);
            this.pnlReportView.Controls.Add(this.label5);
            this.pnlReportView.Controls.Add(this.label4);
            this.pnlReportView.Controls.Add(this.label3);
            this.pnlReportView.Location = new System.Drawing.Point(15, 450);
            this.pnlReportView.Name = "pnlReportView";
            this.pnlReportView.Size = new System.Drawing.Size(631, 112);
            this.pnlReportView.TabIndex = 6;
            this.pnlReportView.Visible = false;
            // 
            // lblTotalTrips
            // 
            this.lblTotalTrips.AutoSize = true;
            this.lblTotalTrips.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTotalTrips.Location = new System.Drawing.Point(234, 31);
            this.lblTotalTrips.Name = "lblTotalTrips";
            this.lblTotalTrips.Size = new System.Drawing.Size(46, 17);
            this.lblTotalTrips.TabIndex = 10;
            this.lblTotalTrips.Text = "label6";
            // 
            // lblTotalDistance
            // 
            this.lblTotalDistance.AutoSize = true;
            this.lblTotalDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTotalDistance.Location = new System.Drawing.Point(4, 31);
            this.lblTotalDistance.Name = "lblTotalDistance";
            this.lblTotalDistance.Size = new System.Drawing.Size(46, 17);
            this.lblTotalDistance.TabIndex = 9;
            this.lblTotalDistance.Text = "label6";
            // 
            // btnCloseReportView
            // 
            this.btnCloseReportView.Location = new System.Drawing.Point(227, 86);
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
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(441, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Overall hours driving:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(234, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Total Trips: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Overall distance travelled: ";
            // 
            // dtpTrips
            // 
            this.dtpTrips.Location = new System.Drawing.Point(17, 116);
            this.dtpTrips.Name = "dtpTrips";
            this.dtpTrips.Size = new System.Drawing.Size(200, 20);
            this.dtpTrips.TabIndex = 0;
            this.dtpTrips.ValueChanged += new System.EventHandler(this.dtpTrips_ValueChanged);
            // 
            // cmbViewType
            // 
            this.cmbViewType.FormattingEnabled = true;
            this.cmbViewType.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Monthly",
            "Yearly"});
            this.cmbViewType.Location = new System.Drawing.Point(455, 115);
            this.cmbViewType.Name = "cmbViewType";
            this.cmbViewType.Size = new System.Drawing.Size(191, 21);
            this.cmbViewType.TabIndex = 1;
            this.cmbViewType.Text = "Select here<";
            this.cmbViewType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(14, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select start date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(452, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Daily/Weekly/Monthly";
            // 
            // bentViewReport
            // 
            this.bentViewReport.Location = new System.Drawing.Point(352, 12);
            this.bentViewReport.Name = "bentViewReport";
            this.bentViewReport.Size = new System.Drawing.Size(125, 40);
            this.bentViewReport.TabIndex = 7;
            this.bentViewReport.Text = "View Reports";
            this.bentViewReport.UseVisualStyleBackColor = true;
            this.bentViewReport.Click += new System.EventHandler(this.btnViewReport_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(205, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 172);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogIncident
            // 
            this.btnLogIncident.Location = new System.Drawing.Point(15, 584);
            this.btnLogIncident.Name = "btnLogIncident";
            this.btnLogIncident.Size = new System.Drawing.Size(108, 27);
            this.btnLogIncident.TabIndex = 8;
            this.btnLogIncident.Text = "Log Incident";
            this.btnLogIncident.UseVisualStyleBackColor = true;
            this.btnLogIncident.Click += new System.EventHandler(this.btnLogIncident_Click);
            // 
            // TripForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 623);
            this.Controls.Add(this.btnLogIncident);
            this.Controls.Add(this.bentViewReport);
            this.Controls.Add(this.pnlReportView);
            this.Controls.Add(this.cmbViewType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addTripButton);
            this.Controls.Add(this.dtpTrips);
            this.Controls.Add(this.btnCompleteTrips);
            this.Controls.Add(this.btnPlannedTrips);
            this.Controls.Add(this.dgvTrips);
            this.Name = "TripForm";
            this.Text = "tripForm";
            this.Load += new System.EventHandler(this.TripForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrips)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wILDBDataSetBindingSource)).EndInit();
            this.pnlReportView.ResumeLayout(false);
            this.pnlReportView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlannedTrips;
        private System.Windows.Forms.Button btnCompleteTrips;
        private System.Windows.Forms.Button addTripButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.DataGridView dgvTrips;

        private System.Windows.Forms.BindingSource wILDBDataSetBindingSource;
        private System.Windows.Forms.Panel pnlReportView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbViewType;
        private System.Windows.Forms.DateTimePicker dtpTrips;
        private System.Windows.Forms.Button bentViewReport;
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
        private System.Windows.Forms.Label lblTotalDistance;
        private System.Windows.Forms.Label lblTotalTrips;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogIncident;
    }
}