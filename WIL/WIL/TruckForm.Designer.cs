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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.addTruckBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(13, 240);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(629, 251);
            this.treeView1.TabIndex = 0;
            // 
            // addTruckBtn
            // 
            this.addTruckBtn.Location = new System.Drawing.Point(538, 12);
            this.addTruckBtn.Name = "addTruckBtn";
            this.addTruckBtn.Size = new System.Drawing.Size(104, 39);
            this.addTruckBtn.TabIndex = 1;
            this.addTruckBtn.Text = "Add Truck";
            this.addTruckBtn.UseVisualStyleBackColor = true;
            this.addTruckBtn.Click += new System.EventHandler(this.addTruckBtn_Click);
            // 
            // TruckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 503);
            this.Controls.Add(this.addTruckBtn);
            this.Controls.Add(this.treeView1);
            this.Name = "TruckForm";
            this.Text = "TruckForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button addTruckBtn;
    }
}