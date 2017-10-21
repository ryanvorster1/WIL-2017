namespace WIL
{
    partial class UserForm
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
            this.pnlUsers = new System.Windows.Forms.Panel();
            this.lsbUsers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAddUser = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.txbSurname = new System.Windows.Forms.TextBox();
            this.txbPass1 = new System.Windows.Forms.TextBox();
            this.txbPass2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUserType = new System.Windows.Forms.ComboBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.pnlUsers.SuspendLayout();
            this.pnlAddUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUsers
            // 
            this.pnlUsers.Controls.Add(this.lsbUsers);
            this.pnlUsers.Controls.Add(this.label1);
            this.pnlUsers.Location = new System.Drawing.Point(12, 25);
            this.pnlUsers.Name = "pnlUsers";
            this.pnlUsers.Size = new System.Drawing.Size(200, 361);
            this.pnlUsers.TabIndex = 0;
            // 
            // lsbUsers
            // 
            this.lsbUsers.FormattingEnabled = true;
            this.lsbUsers.Location = new System.Drawing.Point(13, 50);
            this.lsbUsers.Name = "lsbUsers";
            this.lsbUsers.Size = new System.Drawing.Size(170, 303);
            this.lsbUsers.TabIndex = 1;
            this.lsbUsers.SelectedIndexChanged += new System.EventHandler(this.lsbUsers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Users";
            // 
            // pnlAddUser
            // 
            this.pnlAddUser.Controls.Add(this.btnOK);
            this.pnlAddUser.Controls.Add(this.txbSurname);
            this.pnlAddUser.Controls.Add(this.txbPass1);
            this.pnlAddUser.Controls.Add(this.txbPass2);
            this.pnlAddUser.Controls.Add(this.label6);
            this.pnlAddUser.Controls.Add(this.label5);
            this.pnlAddUser.Controls.Add(this.txbName);
            this.pnlAddUser.Controls.Add(this.label4);
            this.pnlAddUser.Controls.Add(this.label3);
            this.pnlAddUser.Controls.Add(this.label2);
            this.pnlAddUser.Controls.Add(this.cmbUserType);
            this.pnlAddUser.Location = new System.Drawing.Point(238, 25);
            this.pnlAddUser.Name = "pnlAddUser";
            this.pnlAddUser.Size = new System.Drawing.Size(312, 361);
            this.pnlAddUser.TabIndex = 1;
            this.pnlAddUser.Visible = false;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(154, 199);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txbSurname
            // 
            this.txbSurname.Location = new System.Drawing.Point(108, 97);
            this.txbSurname.Name = "txbSurname";
            this.txbSurname.Size = new System.Drawing.Size(121, 20);
            this.txbSurname.TabIndex = 2;
            // 
            // txbPass1
            // 
            this.txbPass1.Location = new System.Drawing.Point(108, 124);
            this.txbPass1.Name = "txbPass1";
            this.txbPass1.Size = new System.Drawing.Size(121, 20);
            this.txbPass1.TabIndex = 3;
            // 
            // txbPass2
            // 
            this.txbPass2.Location = new System.Drawing.Point(108, 153);
            this.txbPass2.Name = "txbPass2";
            this.txbPass2.Size = new System.Drawing.Size(121, 20);
            this.txbPass2.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Confirm Password";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(108, 66);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(121, 20);
            this.txbName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Type";
            // 
            // cmbUserType
            // 
            this.cmbUserType.FormattingEnabled = true;
            this.cmbUserType.Location = new System.Drawing.Point(108, 21);
            this.cmbUserType.Name = "cmbUserType";
            this.cmbUserType.Size = new System.Drawing.Size(121, 21);
            this.cmbUserType.TabIndex = 0;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(119, 392);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 23);
            this.btnAddUser.TabIndex = 2;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 427);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.pnlAddUser);
            this.Controls.Add(this.pnlUsers);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.pnlUsers.ResumeLayout(false);
            this.pnlUsers.PerformLayout();
            this.pnlAddUser.ResumeLayout(false);
            this.pnlAddUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUsers;
        private System.Windows.Forms.ListBox lsbUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlAddUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txbSurname;
        private System.Windows.Forms.TextBox txbPass1;
        private System.Windows.Forms.TextBox txbPass2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUserType;
    }
}