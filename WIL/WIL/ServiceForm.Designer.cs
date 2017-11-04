namespace WIL
{
    partial class ServiceForm
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
            this.btnServiceReport = new System.Windows.Forms.Button();
            this.lvServiceList = new System.Windows.Forms.ListView();
            this.bttnExit = new System.Windows.Forms.Button();
            this.dtpDateTime = new System.Windows.Forms.DateTimePicker();
            this.pnlServiceReport = new System.Windows.Forms.Panel();
            this.btnCloseReport = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalHours = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalServices = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbViewType = new System.Windows.Forms.ComboBox();
            this.lbServiceReport = new System.Windows.Forms.Label();
            this.pnlServiceReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnServiceReport
            // 
            this.btnServiceReport.Location = new System.Drawing.Point(546, 22);
            this.btnServiceReport.Name = "btnServiceReport";
            this.btnServiceReport.Size = new System.Drawing.Size(124, 23);
            this.btnServiceReport.TabIndex = 0;
            this.btnServiceReport.Text = "Service Report";
            this.btnServiceReport.UseVisualStyleBackColor = true;
            this.btnServiceReport.Click += new System.EventHandler(this.bttnServiceReport_Click);
            // 
            // lvServiceList
            // 
            this.lvServiceList.FullRowSelect = true;
            this.lvServiceList.GridLines = true;
            this.lvServiceList.Location = new System.Drawing.Point(12, 68);
            this.lvServiceList.MultiSelect = false;
            this.lvServiceList.Name = "lvServiceList";
            this.lvServiceList.Size = new System.Drawing.Size(658, 366);
            this.lvServiceList.TabIndex = 34;
            this.lvServiceList.UseCompatibleStateImageBehavior = false;
            this.lvServiceList.View = System.Windows.Forms.View.Details;
            this.lvServiceList.SelectedIndexChanged += new System.EventHandler(this.lvServiceList_SelectedIndexChanged);
            this.lvServiceList.DoubleClick += new System.EventHandler(this.lvServiceList_DoubleClick);
            // 
            // bttnExit
            // 
            this.bttnExit.Location = new System.Drawing.Point(575, 459);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(95, 23);
            this.bttnExit.TabIndex = 35;
            this.bttnExit.Text = "Exit";
            this.bttnExit.UseVisualStyleBackColor = true;
            this.bttnExit.Click += new System.EventHandler(this.bttnExit_Click);
            // 
            // dtpDateTime
            // 
            this.dtpDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateTime.Location = new System.Drawing.Point(65, 42);
            this.dtpDateTime.Name = "dtpDateTime";
            this.dtpDateTime.Size = new System.Drawing.Size(200, 20);
            this.dtpDateTime.TabIndex = 36;
            this.dtpDateTime.ValueChanged += new System.EventHandler(this.dtpDateTime_ValueChanged);
            // 
            // pnlServiceReport
            // 
            this.pnlServiceReport.Controls.Add(this.lbServiceReport);
            this.pnlServiceReport.Controls.Add(this.btnCloseReport);
            this.pnlServiceReport.Controls.Add(this.label5);
            this.pnlServiceReport.Controls.Add(this.lblTotalHours);
            this.pnlServiceReport.Controls.Add(this.label3);
            this.pnlServiceReport.Controls.Add(this.label4);
            this.pnlServiceReport.Controls.Add(this.label2);
            this.pnlServiceReport.Controls.Add(this.lblTotalServices);
            this.pnlServiceReport.Location = new System.Drawing.Point(13, 459);
            this.pnlServiceReport.Name = "pnlServiceReport";
            this.pnlServiceReport.Size = new System.Drawing.Size(351, 130);
            this.pnlServiceReport.TabIndex = 37;
            this.pnlServiceReport.Visible = false;
            // 
            // btnCloseReport
            // 
            this.btnCloseReport.Location = new System.Drawing.Point(259, 93);
            this.btnCloseReport.Name = "btnCloseReport";
            this.btnCloseReport.Size = new System.Drawing.Size(75, 23);
            this.btnCloseReport.TabIndex = 8;
            this.btnCloseReport.Text = "Close";
            this.btnCloseReport.UseVisualStyleBackColor = true;
            this.btnCloseReport.Click += new System.EventHandler(this.btnCloseReport_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Total Hours:";
            // 
            // lblTotalHours
            // 
            this.lblTotalHours.AutoSize = true;
            this.lblTotalHours.Location = new System.Drawing.Point(107, 81);
            this.lblTotalHours.Name = "lblTotalHours";
            this.lblTotalHours.Size = new System.Drawing.Size(35, 13);
            this.lblTotalHours.TabIndex = 6;
            this.lblTotalHours.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total Cost:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total Services:";
            // 
            // lblTotalServices
            // 
            this.lblTotalServices.AutoSize = true;
            this.lblTotalServices.Location = new System.Drawing.Point(107, 36);
            this.lblTotalServices.Name = "lblTotalServices";
            this.lblTotalServices.Size = new System.Drawing.Size(35, 13);
            this.lblTotalServices.TabIndex = 2;
            this.lblTotalServices.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // cmbViewType
            // 
            this.cmbViewType.FormattingEnabled = true;
            this.cmbViewType.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Monthly"});
            this.cmbViewType.Location = new System.Drawing.Point(282, 42);
            this.cmbViewType.Name = "cmbViewType";
            this.cmbViewType.Size = new System.Drawing.Size(121, 21);
            this.cmbViewType.TabIndex = 9;
            // 
            // lbServiceReport
            // 
            this.lbServiceReport.AutoSize = true;
            this.lbServiceReport.Location = new System.Drawing.Point(11, 9);
            this.lbServiceReport.Name = "lbServiceReport";
            this.lbServiceReport.Size = new System.Drawing.Size(78, 13);
            this.lbServiceReport.TabIndex = 9;
            this.lbServiceReport.Text = "Service Report";
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 601);
            this.Controls.Add(this.cmbViewType);
            this.Controls.Add(this.pnlServiceReport);
            this.Controls.Add(this.dtpDateTime);
            this.Controls.Add(this.bttnExit);
            this.Controls.Add(this.lvServiceList);
            this.Controls.Add(this.btnServiceReport);
            this.Controls.Add(this.label1);
            this.Name = "ServiceForm";
            this.Text = "Vehicles to be serviced";
            this.Load += new System.EventHandler(this.ServiceForm_Load);
            this.pnlServiceReport.ResumeLayout(false);
            this.pnlServiceReport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnServiceReport;
        private System.Windows.Forms.ListView lvServiceList;
        private System.Windows.Forms.Button bttnExit;
        private System.Windows.Forms.DateTimePicker dtpDateTime;
        private System.Windows.Forms.Panel pnlServiceReport;
        private System.Windows.Forms.Button btnCloseReport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalHours;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalServices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbViewType;
        private System.Windows.Forms.Label lbServiceReport;
    }
}