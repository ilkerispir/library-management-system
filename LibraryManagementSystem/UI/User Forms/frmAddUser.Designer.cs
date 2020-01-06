namespace LibraryManagementSystem.UI.User_Forms
{
    partial class frmAddUser
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbContactNo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtEnterPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.cmbSelectUser = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkEmail = new System.Windows.Forms.CheckBox();
            this.chkReturnBook = new System.Windows.Forms.CheckBox();
            this.chkStudent = new System.Windows.Forms.CheckBox();
            this.chkGSM = new System.Windows.Forms.CheckBox();
            this.chkIssueBook = new System.Windows.Forms.CheckBox();
            this.chkStaff = new System.Windows.Forms.CheckBox();
            this.chkReport = new System.Windows.Forms.CheckBox();
            this.chkBook = new System.Windows.Forms.CheckBox();
            this.chkConfiguration = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.epUserName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.epConfirmPass = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epConfirmPass)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbContactNo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDesignation);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtConfirmPassword);
            this.groupBox1.Controls.Add(this.txtEnterPassword);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.cmbSelectUser);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 225);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Information";
            // 
            // cmbContactNo
            // 
            this.cmbContactNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbContactNo.FormattingEnabled = true;
            this.cmbContactNo.Location = new System.Drawing.Point(110, 65);
            this.cmbContactNo.Name = "cmbContactNo";
            this.cmbContactNo.Size = new System.Drawing.Size(242, 21);
            this.cmbContactNo.TabIndex = 11;
            this.cmbContactNo.SelectedIndexChanged += new System.EventHandler(this.CmbContactNo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Contact No";
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(110, 97);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.ReadOnly = true;
            this.txtDesignation.Size = new System.Drawing.Size(242, 20);
            this.txtDesignation.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Designation";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(110, 190);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(242, 20);
            this.txtConfirmPassword.TabIndex = 7;
            // 
            // txtEnterPassword
            // 
            this.txtEnterPassword.Location = new System.Drawing.Point(110, 159);
            this.txtEnterPassword.Name = "txtEnterPassword";
            this.txtEnterPassword.PasswordChar = '*';
            this.txtEnterPassword.Size = new System.Drawing.Size(242, 20);
            this.txtEnterPassword.TabIndex = 6;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(110, 128);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(242, 20);
            this.txtUserName.TabIndex = 5;
            // 
            // cmbSelectUser
            // 
            this.cmbSelectUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectUser.FormattingEnabled = true;
            this.cmbSelectUser.Location = new System.Drawing.Point(110, 33);
            this.cmbSelectUser.Name = "cmbSelectUser";
            this.cmbSelectUser.Size = new System.Drawing.Size(242, 21);
            this.cmbSelectUser.TabIndex = 4;
            this.cmbSelectUser.SelectedIndexChanged += new System.EventHandler(this.CmbSelectUser_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirm Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter User Name ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select User";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkEmail);
            this.groupBox2.Controls.Add(this.chkReturnBook);
            this.groupBox2.Controls.Add(this.chkStudent);
            this.groupBox2.Controls.Add(this.chkGSM);
            this.groupBox2.Controls.Add(this.chkIssueBook);
            this.groupBox2.Controls.Add(this.chkStaff);
            this.groupBox2.Controls.Add(this.chkReport);
            this.groupBox2.Controls.Add(this.chkBook);
            this.groupBox2.Controls.Add(this.chkConfiguration);
            this.groupBox2.Location = new System.Drawing.Point(401, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 225);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Privileges";
            // 
            // chkEmail
            // 
            this.chkEmail.AutoSize = true;
            this.chkEmail.Location = new System.Drawing.Point(288, 192);
            this.chkEmail.Name = "chkEmail";
            this.chkEmail.Size = new System.Drawing.Size(51, 17);
            this.chkEmail.TabIndex = 8;
            this.chkEmail.Text = "Email";
            this.chkEmail.UseVisualStyleBackColor = true;
            // 
            // chkReturnBook
            // 
            this.chkReturnBook.AutoSize = true;
            this.chkReturnBook.Location = new System.Drawing.Point(151, 192);
            this.chkReturnBook.Name = "chkReturnBook";
            this.chkReturnBook.Size = new System.Drawing.Size(86, 17);
            this.chkReturnBook.TabIndex = 7;
            this.chkReturnBook.Text = "Return Book";
            this.chkReturnBook.UseVisualStyleBackColor = true;
            // 
            // chkStudent
            // 
            this.chkStudent.AutoSize = true;
            this.chkStudent.Location = new System.Drawing.Point(18, 189);
            this.chkStudent.Name = "chkStudent";
            this.chkStudent.Size = new System.Drawing.Size(63, 17);
            this.chkStudent.TabIndex = 6;
            this.chkStudent.Text = "Student";
            this.chkStudent.UseVisualStyleBackColor = true;
            // 
            // chkGSM
            // 
            this.chkGSM.AutoSize = true;
            this.chkGSM.Location = new System.Drawing.Point(289, 113);
            this.chkGSM.Name = "chkGSM";
            this.chkGSM.Size = new System.Drawing.Size(50, 17);
            this.chkGSM.TabIndex = 5;
            this.chkGSM.Text = "GSM";
            this.chkGSM.UseVisualStyleBackColor = true;
            // 
            // chkIssueBook
            // 
            this.chkIssueBook.AutoSize = true;
            this.chkIssueBook.Location = new System.Drawing.Point(151, 113);
            this.chkIssueBook.Name = "chkIssueBook";
            this.chkIssueBook.Size = new System.Drawing.Size(79, 17);
            this.chkIssueBook.TabIndex = 4;
            this.chkIssueBook.Text = "Issue Book";
            this.chkIssueBook.UseVisualStyleBackColor = true;
            // 
            // chkStaff
            // 
            this.chkStaff.AutoSize = true;
            this.chkStaff.Location = new System.Drawing.Point(18, 113);
            this.chkStaff.Name = "chkStaff";
            this.chkStaff.Size = new System.Drawing.Size(48, 17);
            this.chkStaff.TabIndex = 3;
            this.chkStaff.Text = "Staff";
            this.chkStaff.UseVisualStyleBackColor = true;
            // 
            // chkReport
            // 
            this.chkReport.AutoSize = true;
            this.chkReport.Location = new System.Drawing.Point(288, 37);
            this.chkReport.Name = "chkReport";
            this.chkReport.Size = new System.Drawing.Size(58, 17);
            this.chkReport.TabIndex = 2;
            this.chkReport.Text = "Report";
            this.chkReport.UseVisualStyleBackColor = true;
            // 
            // chkBook
            // 
            this.chkBook.AutoSize = true;
            this.chkBook.Location = new System.Drawing.Point(151, 37);
            this.chkBook.Name = "chkBook";
            this.chkBook.Size = new System.Drawing.Size(51, 17);
            this.chkBook.TabIndex = 1;
            this.chkBook.Text = "Book";
            this.chkBook.UseVisualStyleBackColor = true;
            // 
            // chkConfiguration
            // 
            this.chkConfiguration.AutoSize = true;
            this.chkConfiguration.Location = new System.Drawing.Point(18, 37);
            this.chkConfiguration.Name = "chkConfiguration";
            this.chkConfiguration.Size = new System.Drawing.Size(88, 17);
            this.chkConfiguration.TabIndex = 0;
            this.chkConfiguration.Text = "Configuration";
            this.chkConfiguration.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(713, 244);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(632, 244);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // epUserName
            // 
            this.epUserName.ContainerControl = this;
            // 
            // epPassword
            // 
            this.epPassword.ContainerControl = this;
            // 
            // epConfirmPass
            // 
            this.epConfirmPass.ContainerControl = this;
            // 
            // frmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HideOnClose = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TabText = "User";
            this.Text = "Add User";
            this.Load += new System.EventHandler(this.FrmAddUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epConfirmPass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtEnterPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.ComboBox cmbSelectUser;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkReport;
        private System.Windows.Forms.CheckBox chkBook;
        private System.Windows.Forms.CheckBox chkConfiguration;
        private System.Windows.Forms.CheckBox chkEmail;
        private System.Windows.Forms.CheckBox chkReturnBook;
        private System.Windows.Forms.CheckBox chkStudent;
        private System.Windows.Forms.CheckBox chkGSM;
        private System.Windows.Forms.CheckBox chkIssueBook;
        private System.Windows.Forms.CheckBox chkStaff;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbContactNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider epUserName;
        private System.Windows.Forms.ErrorProvider epPassword;
        private System.Windows.Forms.ErrorProvider epConfirmPass;
    }
}