namespace WIL
{
    partial class BookingsForm
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
            this.bookBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.destinationBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.deptartBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.slctTruckBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddCustBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.slctCustBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bookBtn
            // 
            this.bookBtn.Location = new System.Drawing.Point(205, 355);
            this.bookBtn.Name = "bookBtn";
            this.bookBtn.Size = new System.Drawing.Size(107, 23);
            this.bookBtn.TabIndex = 25;
            this.bookBtn.Text = "Book";
            this.bookBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(332, 355);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(107, 23);
            this.cancelBtn.TabIndex = 24;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Select Departure Date:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(141, 258);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 22;
            // 
            // destinationBox
            // 
            this.destinationBox.FormattingEnabled = true;
            this.destinationBox.Location = new System.Drawing.Point(332, 193);
            this.destinationBox.Name = "destinationBox";
            this.destinationBox.Size = new System.Drawing.Size(107, 21);
            this.destinationBox.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Select Destination:";
            // 
            // deptartBox
            // 
            this.deptartBox.FormattingEnabled = true;
            this.deptartBox.Location = new System.Drawing.Point(104, 193);
            this.deptartBox.Name = "deptartBox";
            this.deptartBox.Size = new System.Drawing.Size(107, 21);
            this.deptartBox.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Select Departure:";
            // 
            // slctTruckBox
            // 
            this.slctTruckBox.FormattingEnabled = true;
            this.slctTruckBox.Location = new System.Drawing.Point(130, 118);
            this.slctTruckBox.Name = "slctTruckBox";
            this.slctTruckBox.Size = new System.Drawing.Size(146, 21);
            this.slctTruckBox.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Select Truck:";
            // 
            // AddCustBtn
            // 
            this.AddCustBtn.Location = new System.Drawing.Point(12, 12);
            this.AddCustBtn.Name = "AddCustBtn";
            this.AddCustBtn.Size = new System.Drawing.Size(146, 23);
            this.AddCustBtn.TabIndex = 15;
            this.AddCustBtn.Text = "Add Customer";
            this.AddCustBtn.UseVisualStyleBackColor = true;
            this.AddCustBtn.Click += new System.EventHandler(this.AddCustBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Select Customer:";
            // 
            // slctCustBox
            // 
            this.slctCustBox.FormattingEnabled = true;
            this.slctCustBox.Location = new System.Drawing.Point(130, 68);
            this.slctCustBox.Name = "slctCustBox";
            this.slctCustBox.Size = new System.Drawing.Size(146, 21);
            this.slctCustBox.TabIndex = 13;
            this.slctCustBox.SelectedIndexChanged += new System.EventHandler(this.slctCustBox_SelectedIndexChanged);
            // 
            // BookingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 410);
            this.Controls.Add(this.bookBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.destinationBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.deptartBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.slctTruckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddCustBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.slctCustBox);
            this.Name = "BookingsForm";
            this.Text = "BookingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bookBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox destinationBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox deptartBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox slctTruckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddCustBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox slctCustBox;
    }
}