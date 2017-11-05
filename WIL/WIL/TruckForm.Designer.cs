namespace WIL
{
    partial class TruckForm
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
            this.addTruckBtn = new System.Windows.Forms.Button();
            this.dgvTrucks = new System.Windows.Forms.DataGridView();
            this.exitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrucks)).BeginInit();
            this.SuspendLayout();
            // 
            // addTruckBtn
            // 
            this.addTruckBtn.Location = new System.Drawing.Point(12, 12);
            this.addTruckBtn.Name = "addTruckBtn";
            this.addTruckBtn.Size = new System.Drawing.Size(104, 39);
            this.addTruckBtn.TabIndex = 1;
            this.addTruckBtn.Text = "Add Truck";
            this.addTruckBtn.UseVisualStyleBackColor = true;
            this.addTruckBtn.Click += new System.EventHandler(this.addTruckBtn_Click);
            // 
            // dgvTrucks
            // 
            this.dgvTrucks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrucks.Location = new System.Drawing.Point(12, 129);
            this.dgvTrucks.Name = "dgvTrucks";
            this.dgvTrucks.Size = new System.Drawing.Size(560, 333);
            this.dgvTrucks.TabIndex = 3;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(574, 470);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // TruckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 505);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.dgvTrucks);
            this.Controls.Add(this.addTruckBtn);
            this.Name = "TruckForm";
            this.Text = "TruckForm";
            this.Load += new System.EventHandler(this.TruckForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrucks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addTruckBtn;
        private System.Windows.Forms.DataGridView dgvTrucks;
        private System.Windows.Forms.Button exitBtn;
    }
}