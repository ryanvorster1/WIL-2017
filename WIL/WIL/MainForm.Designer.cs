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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblUser = new System.Windows.Forms.Label();
            this.btnTrips = new System.Windows.Forms.Button();
            this.btnTrucks = new System.Windows.Forms.Button();
            this.btnServices = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.routeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblUser.Location = new System.Drawing.Point(22, 22);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(59, 24);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "trucks";
            // 
            // btnTrips
            // 
            this.btnTrips.Location = new System.Drawing.Point(67, 211);
            this.btnTrips.Name = "btnTrips";
            this.btnTrips.Size = new System.Drawing.Size(75, 42);
            this.btnTrips.TabIndex = 1;
            this.btnTrips.Text = "Trips";
            this.btnTrips.UseVisualStyleBackColor = true;
            this.btnTrips.Click += new System.EventHandler(this.btnTrips_Click);
            // 
            // btnTrucks
            // 
            this.btnTrucks.Location = new System.Drawing.Point(258, 211);
            this.btnTrucks.Name = "btnTrucks";
            this.btnTrucks.Size = new System.Drawing.Size(75, 42);
            this.btnTrucks.TabIndex = 2;
            this.btnTrucks.Text = "Trucks";
            this.btnTrucks.UseVisualStyleBackColor = true;
            this.btnTrucks.Click += new System.EventHandler(this.btnTrucks_Click);
            // 
            // btnServices
            // 
            this.btnServices.Location = new System.Drawing.Point(163, 211);
            this.btnServices.Name = "btnServices";
            this.btnServices.Size = new System.Drawing.Size(75, 42);
            this.btnServices.TabIndex = 3;
            this.btnServices.Text = "Services";
            this.btnServices.UseVisualStyleBackColor = true;
            this.btnServices.Click += new System.EventHandler(this.btnServices_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(354, 211);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(75, 42);
            this.btnUsers.TabIndex = 4;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(163, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 174);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // routeBtn
            // 
            this.routeBtn.Location = new System.Drawing.Point(450, 211);
            this.routeBtn.Name = "routeBtn";
            this.routeBtn.Size = new System.Drawing.Size(75, 42);
            this.routeBtn.TabIndex = 6;
            this.routeBtn.Text = "Routes";
            this.routeBtn.UseVisualStyleBackColor = true;
            this.routeBtn.Click += new System.EventHandler(this.routeBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 300);
            this.Controls.Add(this.routeBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnServices);
            this.Controls.Add(this.btnTrucks);
            this.Controls.Add(this.btnTrips);
            this.Controls.Add(this.lblUser);
            this.Name = "MainForm";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnTrips;
        private System.Windows.Forms.Button btnTrucks;
        private System.Windows.Forms.Button btnServices;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button routeBtn;
    }
}

