﻿namespace WIL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceForm));
            this.btnServiceReport = new System.Windows.Forms.Button();
            this.lvServiceList = new System.Windows.Forms.ListView();
            this.bttnExit = new System.Windows.Forms.Button();
            this.dtpDateTime = new System.Windows.Forms.DateTimePicker();
            this.pnlServiceReport = new System.Windows.Forms.Panel();
            this.btnCloseReport = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.totalHoursLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbltotalService = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbViewType = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblServiceReport = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlServiceReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnServiceReport
            // 
            this.btnServiceReport.Location = new System.Drawing.Point(546, 40);
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
            this.bttnExit.Location = new System.Drawing.Point(1048, 462);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(90, 23);
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
            this.pnlServiceReport.Controls.Add(this.label4);
            this.pnlServiceReport.Controls.Add(this.lblServiceReport);
            this.pnlServiceReport.Controls.Add(this.pictureBox1);
            this.pnlServiceReport.Controls.Add(this.btnCloseReport);
            this.pnlServiceReport.Controls.Add(this.label5);
            this.pnlServiceReport.Controls.Add(this.totalHoursLbl);
            this.pnlServiceReport.Controls.Add(this.label3);
            this.pnlServiceReport.Controls.Add(this.lbltotalService);
            this.pnlServiceReport.Controls.Add(this.label2);
            this.pnlServiceReport.Controls.Add(this.lblTotalCost);
            this.pnlServiceReport.Location = new System.Drawing.Point(712, 35);
            this.pnlServiceReport.Name = "pnlServiceReport";
            this.pnlServiceReport.Size = new System.Drawing.Size(426, 399);
            this.pnlServiceReport.TabIndex = 37;
            this.pnlServiceReport.Visible = false;
            // 
            // btnCloseReport
            // 
            this.btnCloseReport.Location = new System.Drawing.Point(336, 363);
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
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Total Hours:";
            // 
            // totalHoursLbl
            // 
            this.totalHoursLbl.AutoSize = true;
            this.totalHoursLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalHoursLbl.Location = new System.Drawing.Point(172, 328);
            this.totalHoursLbl.Name = "totalHoursLbl";
            this.totalHoursLbl.Size = new System.Drawing.Size(65, 20);
            this.totalHoursLbl.TabIndex = 6;
            this.totalHoursLbl.Text = "T Hours";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total Cost:";
            // 
            // lbltotalService
            // 
            this.lbltotalService.AutoSize = true;
            this.lbltotalService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalService.Location = new System.Drawing.Point(172, 251);
            this.lbltotalService.Name = "lbltotalService";
            this.lbltotalService.Size = new System.Drawing.Size(44, 20);
            this.lbltotalService.TabIndex = 4;
            this.lbltotalService.Text = "Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total Services:";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(172, 290);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(55, 20);
            this.lblTotalCost.TabIndex = 2;
            this.lblTotalCost.Text = "T Cost";
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
            "Monthly",
            "Yearly"});
            this.cmbViewType.Location = new System.Drawing.Point(282, 42);
            this.cmbViewType.Name = "cmbViewType";
            this.cmbViewType.Size = new System.Drawing.Size(150, 21);
            this.cmbViewType.TabIndex = 9;
            this.cmbViewType.SelectedIndexChanged += new System.EventHandler(this.dtpDateTime_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 178);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lblServiceReport
            // 
            this.lblServiceReport.AutoSize = true;
            this.lblServiceReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblServiceReport.Location = new System.Drawing.Point(22, 215);
            this.lblServiceReport.Name = "lblServiceReport";
            this.lblServiceReport.Size = new System.Drawing.Size(134, 24);
            this.lblServiceReport.TabIndex = 10;
            this.lblServiceReport.Text = "Service Report";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(145, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "R";
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 497);
            this.Controls.Add(this.cmbViewType);
            this.Controls.Add(this.pnlServiceReport);
            this.Controls.Add(this.dtpDateTime);
            this.Controls.Add(this.bttnExit);
            this.Controls.Add(this.lvServiceList);
            this.Controls.Add(this.btnServiceReport);
            this.Controls.Add(this.label1);
            this.Name = "ServiceForm";
            this.Text = "Service Home";
            this.Load += new System.EventHandler(this.ServiceForm_Load);
            this.pnlServiceReport.ResumeLayout(false);
            this.pnlServiceReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label totalHoursLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbltotalService;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbViewType;
        private System.Windows.Forms.Label lbServiceReport;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblServiceReport;
        private System.Windows.Forms.Label label4;
    }
}