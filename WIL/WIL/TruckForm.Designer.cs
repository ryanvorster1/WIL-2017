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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TruckForm));
            this.addTruckBtn = new System.Windows.Forms.Button();
            this.dgvTrucks = new System.Windows.Forms.DataGridView();
            this.exitBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrucks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addTruckBtn
            // 
            this.addTruckBtn.Location = new System.Drawing.Point(517, 162);
            this.addTruckBtn.Name = "addTruckBtn";
            this.addTruckBtn.Size = new System.Drawing.Size(104, 39);
            this.addTruckBtn.TabIndex = 1;
            this.addTruckBtn.Text = "Add Truck";
            this.addTruckBtn.UseVisualStyleBackColor = true;
            this.addTruckBtn.Click += new System.EventHandler(this.addTruckBtn_Click);
            // 
            // dgvTrucks
            // 
            this.dgvTrucks.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dgvTrucks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrucks.GridColor = System.Drawing.Color.Plum;
            this.dgvTrucks.Location = new System.Drawing.Point(12, 220);
            this.dgvTrucks.Name = "dgvTrucks";
            this.dgvTrucks.RowHeadersVisible = false;
            this.dgvTrucks.Size = new System.Drawing.Size(609, 350);
            this.dgvTrucks.TabIndex = 3;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(546, 583);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 34);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(188, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 179);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // TruckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 629);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.dgvTrucks);
            this.Controls.Add(this.addTruckBtn);
            this.Name = "TruckForm";
            this.Text = "TruckForm";
            this.Load += new System.EventHandler(this.TruckForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrucks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addTruckBtn;
        private System.Windows.Forms.DataGridView dgvTrucks;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}