namespace WIL
{
    partial class AddTruckForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.vinTxtBox = new System.Windows.Forms.TextBox();
            this.regTxtBox = new System.Windows.Forms.TextBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.AddTruckBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.mileageBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Vehicle Vin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Input Vehicle Reg:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Input Vehicle Mileage:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Select Truck Type:";
            // 
            // vinTxtBox
            // 
            this.vinTxtBox.Location = new System.Drawing.Point(155, 44);
            this.vinTxtBox.Name = "vinTxtBox";
            this.vinTxtBox.Size = new System.Drawing.Size(192, 20);
            this.vinTxtBox.TabIndex = 4;
            // 
            // regTxtBox
            // 
            this.regTxtBox.Location = new System.Drawing.Point(155, 100);
            this.regTxtBox.Name = "regTxtBox";
            this.regTxtBox.Size = new System.Drawing.Size(192, 20);
            this.regTxtBox.TabIndex = 5;
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(155, 205);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(192, 21);
            this.typeComboBox.TabIndex = 7;
            // 
            // AddTruckBtn
            // 
            this.AddTruckBtn.Location = new System.Drawing.Point(243, 280);
            this.AddTruckBtn.Name = "AddTruckBtn";
            this.AddTruckBtn.Size = new System.Drawing.Size(75, 23);
            this.AddTruckBtn.TabIndex = 8;
            this.AddTruckBtn.Text = "Add Truck";
            this.AddTruckBtn.UseVisualStyleBackColor = true;
            this.AddTruckBtn.Click += new System.EventHandler(this.AddTruckBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(327, 280);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // mileageBox
            // 
            this.mileageBox.Location = new System.Drawing.Point(155, 152);
            this.mileageBox.Name = "mileageBox";
            this.mileageBox.Size = new System.Drawing.Size(192, 20);
            this.mileageBox.TabIndex = 6;
            
            // 
            // AddTruckForm
            // 
            this.ClientSize = new System.Drawing.Size(414, 315);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.AddTruckBtn);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.mileageBox);
            this.Controls.Add(this.regTxtBox);
            this.Controls.Add(this.vinTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddTruckForm";
            this.Load += new System.EventHandler(this.AddTruckForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox vinTxtBox;
        private System.Windows.Forms.TextBox regTxtBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Button AddTruckBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mileageBox;
    }
}