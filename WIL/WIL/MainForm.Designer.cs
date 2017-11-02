namespace WIL
{
    partial class MainForm
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
            this.lblUser = new System.Windows.Forms.Label();
            this.btnTrips = new System.Windows.Forms.Button();
            this.btnTrucks = new System.Windows.Forms.Button();
            this.btnServices = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(429, 18);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(36, 13);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "trucks";
            // 
            // btnTrips
            // 
            this.btnTrips.Location = new System.Drawing.Point(13, 13);
            this.btnTrips.Name = "btnTrips";
            this.btnTrips.Size = new System.Drawing.Size(75, 23);
            this.btnTrips.TabIndex = 1;
            this.btnTrips.Text = "Trips";
            this.btnTrips.UseVisualStyleBackColor = true;
            this.btnTrips.Click += new System.EventHandler(this.btnTrips_Click);
            // 
            // btnTrucks
            // 
            this.btnTrucks.Location = new System.Drawing.Point(201, 13);
            this.btnTrucks.Name = "btnTrucks";
            this.btnTrucks.Size = new System.Drawing.Size(75, 23);
            this.btnTrucks.TabIndex = 2;
            this.btnTrucks.Text = "Trucks";
            this.btnTrucks.UseVisualStyleBackColor = true;
            this.btnTrucks.Click += new System.EventHandler(this.btnTrucks_Click);
            // 
            // btnServices
            // 
            this.btnServices.Location = new System.Drawing.Point(105, 13);
            this.btnServices.Name = "btnServices";
            this.btnServices.Size = new System.Drawing.Size(75, 23);
            this.btnServices.TabIndex = 3;
            this.btnServices.Text = "Services";
            this.btnServices.UseVisualStyleBackColor = true;
            this.btnServices.Click += new System.EventHandler(this.btnServices_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(299, 13);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(75, 23);
            this.btnUsers.TabIndex = 4;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 261);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnServices);
            this.Controls.Add(this.btnTrucks);
            this.Controls.Add(this.btnTrips);
            this.Controls.Add(this.lblUser);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnTrips;
        private System.Windows.Forms.Button btnTrucks;
        private System.Windows.Forms.Button btnServices;
        private System.Windows.Forms.Button btnUsers;
    }
}

