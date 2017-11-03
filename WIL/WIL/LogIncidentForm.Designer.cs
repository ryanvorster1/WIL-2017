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
            this.panelIncidentDetails = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.startbtn = new System.Windows.Forms.Button();
            this.currentTripLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.otherDescriptionL = new System.Windows.Forms.Label();
            this.completedTripsbtn = new System.Windows.Forms.Button();
            this.btnLogIncident = new System.Windows.Forms.Button();
            this.pnlIncident = new System.Windows.Forms.Panel();
            this.panelIncidentDetails.SuspendLayout();
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
            // panelIncidentDetails
            // 
            this.panelIncidentDetails.Controls.Add(this.label2);
            this.panelIncidentDetails.Controls.Add(this.startbtn);
            this.panelIncidentDetails.Controls.Add(this.currentTripLabel);
            this.panelIncidentDetails.Location = new System.Drawing.Point(23, 41);
            this.panelIncidentDetails.Name = "panelIncidentDetails";
            this.panelIncidentDetails.Size = new System.Drawing.Size(406, 100);
            this.panelIncidentDetails.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Truck ID:";
            // 
            // startbtn
            // 
            this.startbtn.Location = new System.Drawing.Point(127, 51);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(125, 34);
            this.startbtn.TabIndex = 1;
            this.startbtn.Text = "Start Trip";
            this.startbtn.UseVisualStyleBackColor = true;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // currentTripLabel
            // 
            this.currentTripLabel.AutoSize = true;
            this.currentTripLabel.Location = new System.Drawing.Point(8, 4);
            this.currentTripLabel.Name = "currentTripLabel";
            this.currentTripLabel.Size = new System.Drawing.Size(68, 13);
            this.currentTripLabel.TabIndex = 0;
            this.currentTripLabel.Text = "Current Trip: ";
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
            // LogIncidentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 438);
            this.Controls.Add(this.pnlIncident);
            this.Controls.Add(this.btnLogIncident);
            this.Controls.Add(this.completedTripsbtn);
            this.Controls.Add(this.panelIncidentDetails);
            this.Name = "LogIncidentForm";
            this.Text = "LogIncidentForm";
            this.Load += new System.EventHandler(this.LogIncidentForm_Load);
            this.panelIncidentDetails.ResumeLayout(false);
            this.panelIncidentDetails.PerformLayout();
            this.pnlIncident.ResumeLayout(false);
            this.pnlIncident.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sendIncidentReportButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cnbIncidents;
        private System.Windows.Forms.Panel panelIncidentDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.Label currentTripLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label otherDescriptionL;
        private System.Windows.Forms.Button completedTripsbtn;
        private System.Windows.Forms.Button btnLogIncident;
        private System.Windows.Forms.Panel pnlIncident;
    }
}