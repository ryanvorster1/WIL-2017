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
            this.SuspendLayout();
            // 
            // sendIncidentReportButton
            // 
            this.sendIncidentReportButton.Location = new System.Drawing.Point(211, 380);
            this.sendIncidentReportButton.Name = "sendIncidentReportButton";
            this.sendIncidentReportButton.Size = new System.Drawing.Size(111, 38);
            this.sendIncidentReportButton.TabIndex = 0;
            this.sendIncidentReportButton.Text = "Send Incident Report";
            this.sendIncidentReportButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(328, 380);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(101, 38);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Incident: ";
            // 
            // cnbIncidents
            // 
            this.cnbIncidents.FormattingEnabled = true;
            this.cnbIncidents.Location = new System.Drawing.Point(128, 225);
            this.cnbIncidents.Name = "cnbIncidents";
            this.cnbIncidents.Size = new System.Drawing.Size(255, 21);
            this.cnbIncidents.TabIndex = 3;
            // 
            // LogIncidentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 438);
            this.Controls.Add(this.cnbIncidents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.sendIncidentReportButton);
            this.Name = "LogIncidentForm";
            this.Text = "LogIncidentForm";
            this.Load += new System.EventHandler(this.LogIncidentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendIncidentReportButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cnbIncidents;
    }
}