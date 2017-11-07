namespace WIL
{
    partial class LogIncidentForm
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
            this.sendIncidentReportButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cnbIncidents = new System.Windows.Forms.ComboBox();
            this.pnlTripDetails = new System.Windows.Forms.Panel();
            this.lblTruck = new System.Windows.Forms.Label();
            this.lblTrip = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTripStatus = new System.Windows.Forms.Button();
            this.lblTripStatus = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.otherDescriptionL = new System.Windows.Forms.Label();
            this.completedTripsbtn = new System.Windows.Forms.Button();
            this.btnLogIncident = new System.Windows.Forms.Button();
            this.pnlIncident = new System.Windows.Forms.Panel();
            this.lblDriver = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlTripDetails.SuspendLayout();
            this.pnlIncident.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendIncidentReportButton
            // 
            this.sendIncidentReportButton.Location = new System.Drawing.Point(203, 198);
            this.sendIncidentReportButton.Name = "sendIncidentReportButton";
            this.sendIncidentReportButton.Size = new System.Drawing.Size(111, 38);
            this.sendIncidentReportButton.TabIndex = 0;
            this.sendIncidentReportButton.Text = "Send Incident Report";
            this.sendIncidentReportButton.UseVisualStyleBackColor = true;
            this.sendIncidentReportButton.Click += new System.EventHandler(this.sendIncidentReportButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(320, 198);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(101, 38);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Incident: ";
            // 
            // cnbIncidents
            // 
            this.cnbIncidents.FormattingEnabled = true;
            this.cnbIncidents.Items.AddRange(new object[] {
            "Select item"});
            this.cnbIncidents.Location = new System.Drawing.Point(69, 43);
            this.cnbIncidents.Name = "cnbIncidents";
            this.cnbIncidents.Size = new System.Drawing.Size(306, 21);
            this.cnbIncidents.TabIndex = 3;
            this.cnbIncidents.SelectedIndexChanged += new System.EventHandler(this.cnbIncidents_SelectedIndexChanged);
            this.cnbIncidents.Click += new System.EventHandler(this.cnbIncidents_Click);
            this.cnbIncidents.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cnbIncidents_MouseClick);
            // 
            // pnlTripDetails
            // 
            this.pnlTripDetails.Controls.Add(this.lblDriver);
            this.pnlTripDetails.Controls.Add(this.label4);
            this.pnlTripDetails.Controls.Add(this.lblTruck);
            this.pnlTripDetails.Controls.Add(this.lblTrip);
            this.pnlTripDetails.Controls.Add(this.label2);
            this.pnlTripDetails.Controls.Add(this.btnTripStatus);
            this.pnlTripDetails.Controls.Add(this.lblTripStatus);
            this.pnlTripDetails.Location = new System.Drawing.Point(23, 41);
            this.pnlTripDetails.Name = "pnlTripDetails";
            this.pnlTripDetails.Size = new System.Drawing.Size(406, 100);
            this.pnlTripDetails.TabIndex = 4;
            // 
            // lblTruck
            // 
            this.lblTruck.AutoSize = true;
            this.lblTruck.Location = new System.Drawing.Point(325, 4);
            this.lblTruck.Name = "lblTruck";
            this.lblTruck.Size = new System.Drawing.Size(52, 13);
            this.lblTruck.TabIndex = 4;
            this.lblTruck.Text = "Truck ID:";
            // 
            // lblTrip
            // 
            this.lblTrip.AutoSize = true;
            this.lblTrip.Location = new System.Drawing.Point(78, 4);
            this.lblTrip.Name = "lblTrip";
            this.lblTrip.Size = new System.Drawing.Size(68, 13);
            this.lblTrip.TabIndex = 3;
            this.lblTrip.Text = "Current Trip: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Truck: ";
            // 
            // btnTripStatus
            // 
            this.btnTripStatus.Location = new System.Drawing.Point(127, 51);
            this.btnTripStatus.Name = "btnTripStatus";
            this.btnTripStatus.Size = new System.Drawing.Size(125, 34);
            this.btnTripStatus.TabIndex = 1;
            this.btnTripStatus.Text = "Start Trip";
            this.btnTripStatus.UseVisualStyleBackColor = true;
            this.btnTripStatus.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // lblTripStatus
            // 
            this.lblTripStatus.AutoSize = true;
            this.lblTripStatus.Location = new System.Drawing.Point(8, 4);
            this.lblTripStatus.Name = "lblTripStatus";
            this.lblTripStatus.Size = new System.Drawing.Size(68, 13);
            this.lblTripStatus.TabIndex = 0;
            this.lblTripStatus.Text = "Current Trip: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(161, 89);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 54);
            this.textBox1.TabIndex = 5;
            // 
            // otherDescriptionL
            // 
            this.otherDescriptionL.AutoSize = true;
            this.otherDescriptionL.Location = new System.Drawing.Point(66, 92);
            this.otherDescriptionL.Name = "otherDescriptionL";
            this.otherDescriptionL.Size = new System.Drawing.Size(93, 13);
            this.otherDescriptionL.TabIndex = 6;
            this.otherDescriptionL.Text = "Other Description*";
            // 
            // completedTripsbtn
            // 
            this.completedTripsbtn.Location = new System.Drawing.Point(283, 147);
            this.completedTripsbtn.Name = "completedTripsbtn";
            this.completedTripsbtn.Size = new System.Drawing.Size(143, 23);
            this.completedTripsbtn.TabIndex = 2;
            this.completedTripsbtn.Text = "Completed Trips";
            this.completedTripsbtn.UseVisualStyleBackColor = true;
            this.completedTripsbtn.Click += new System.EventHandler(this.completedTripsbtn_Click);
            // 
            // btnLogIncident
            // 
            this.btnLogIncident.Location = new System.Drawing.Point(23, 147);
            this.btnLogIncident.Name = "btnLogIncident";
            this.btnLogIncident.Size = new System.Drawing.Size(75, 23);
            this.btnLogIncident.TabIndex = 7;
            this.btnLogIncident.Text = "Log Incident";
            this.btnLogIncident.UseVisualStyleBackColor = true;
            this.btnLogIncident.Visible = false;
            this.btnLogIncident.Click += new System.EventHandler(this.btnLogIncident_Click);
            // 
            // pnlIncident
            // 
            this.pnlIncident.Controls.Add(this.cancelButton);
            this.pnlIncident.Controls.Add(this.sendIncidentReportButton);
            this.pnlIncident.Controls.Add(this.label1);
            this.pnlIncident.Controls.Add(this.otherDescriptionL);
            this.pnlIncident.Controls.Add(this.cnbIncidents);
            this.pnlIncident.Controls.Add(this.textBox1);
            this.pnlIncident.Location = new System.Drawing.Point(5, 177);
            this.pnlIncident.Name = "pnlIncident";
            this.pnlIncident.Size = new System.Drawing.Size(424, 249);
            this.pnlIncident.TabIndex = 8;
            this.pnlIncident.Visible = false;
            // 
            // lblDriver
            // 
            this.lblDriver.AutoSize = true;
            this.lblDriver.Location = new System.Drawing.Point(194, 26);
            this.lblDriver.Name = "lblDriver";
            this.lblDriver.Size = new System.Drawing.Size(68, 13);
            this.lblDriver.TabIndex = 6;
            this.lblDriver.Text = "Current Trip: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Driver: ";
            // 
            // LogIncidentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 438);
            this.Controls.Add(this.pnlIncident);
            this.Controls.Add(this.btnLogIncident);
            this.Controls.Add(this.completedTripsbtn);
            this.Controls.Add(this.pnlTripDetails);
            this.Name = "LogIncidentForm";
            this.Text = "LogIncidentForm";
            this.Load += new System.EventHandler(this.LogIncidentForm_Load);
            this.pnlTripDetails.ResumeLayout(false);
            this.pnlTripDetails.PerformLayout();
            this.pnlIncident.ResumeLayout(false);
            this.pnlIncident.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sendIncidentReportButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cnbIncidents;
        private System.Windows.Forms.Panel pnlTripDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTripStatus;
        private System.Windows.Forms.Label lblTripStatus;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label otherDescriptionL;
        private System.Windows.Forms.Button completedTripsbtn;
        private System.Windows.Forms.Button btnLogIncident;
        private System.Windows.Forms.Panel pnlIncident;
        private System.Windows.Forms.Label lblTruck;
        private System.Windows.Forms.Label lblTrip;
        private System.Windows.Forms.Label lblDriver;
        private System.Windows.Forms.Label label4;
    }
}