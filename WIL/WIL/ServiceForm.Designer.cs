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
            this.bttnServiceReport = new System.Windows.Forms.Button();
            this.lvServiceList = new System.Windows.Forms.ListView();
            this.bttnExit = new System.Windows.Forms.Button();
            this.dtpDateTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // bttnServiceReport
            // 
            this.bttnServiceReport.Location = new System.Drawing.Point(546, 22);
            this.bttnServiceReport.Name = "bttnServiceReport";
            this.bttnServiceReport.Size = new System.Drawing.Size(124, 23);
            this.bttnServiceReport.TabIndex = 0;
            this.bttnServiceReport.Text = "Service Report";
            this.bttnServiceReport.UseVisualStyleBackColor = true;
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
            this.dtpDateTime.Location = new System.Drawing.Point(12, 42);
            this.dtpDateTime.Name = "dtpDateTime";
            this.dtpDateTime.Size = new System.Drawing.Size(200, 20);
            this.dtpDateTime.TabIndex = 36;
            this.dtpDateTime.ValueChanged += new System.EventHandler(this.dtpDateTime_ValueChanged);
            // 
            // Servicefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 500);
            this.Controls.Add(this.dtpDateTime);
            this.Controls.Add(this.bttnExit);
            this.Controls.Add(this.lvServiceList);
            this.Controls.Add(this.bttnServiceReport);
            this.Name = "Servicefrm";
            this.Text = "Vehicles to be serviced";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttnServiceReport;
        private System.Windows.Forms.ListView lvServiceList;
        private System.Windows.Forms.Button bttnExit;
        private System.Windows.Forms.DateTimePicker dtpDateTime;
    }
}