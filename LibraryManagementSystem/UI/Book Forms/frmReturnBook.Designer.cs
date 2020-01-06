namespace LibraryManagementSystem.UI.Book_Forms
{
    partial class frmReturnBook
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
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.dgvStudentDetail = new System.Windows.Forms.DataGridView();
            this.colInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSelectIssueBook = new System.Windows.Forms.Button();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.dgvIssueBookList = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoOfCopies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateOfIssue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateOfReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbFine = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFinePerDay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalDay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentDetail)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssueBookList)).BeginInit();
            this.gbFine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSearchStudent);
            this.groupBox1.Controls.Add(this.dgvStudentDetail);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtStudentID);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(547, 352);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Student";
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSearchStudent.Location = new System.Drawing.Point(276, 27);
            this.btnSearchStudent.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(141, 34);
            this.btnSearchStudent.TabIndex = 6;
            this.btnSearchStudent.Text = "Search";
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            // 
            // dgvStudentDetail
            // 
            this.dgvStudentDetail.AllowUserToAddRows = false;
            this.dgvStudentDetail.AllowUserToDeleteRows = false;
            this.dgvStudentDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudentDetail.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvStudentDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInfo});
            this.dgvStudentDetail.Enabled = false;
            this.dgvStudentDetail.Location = new System.Drawing.Point(12, 65);
            this.dgvStudentDetail.Margin = new System.Windows.Forms.Padding(4);
            this.dgvStudentDetail.MultiSelect = false;
            this.dgvStudentDetail.Name = "dgvStudentDetail";
            this.dgvStudentDetail.ReadOnly = true;
            this.dgvStudentDetail.RowHeadersVisible = false;
            this.dgvStudentDetail.RowHeadersWidth = 51;
            this.dgvStudentDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudentDetail.Size = new System.Drawing.Size(523, 242);
            this.dgvStudentDetail.TabIndex = 6;
            // 
            // colInfo
            // 
            this.colInfo.HeaderText = "Student Detail";
            this.colInfo.MinimumWidth = 6;
            this.colInfo.Name = "colInfo";
            this.colInfo.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student ID";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(113, 30);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(132, 30);
            this.txtStudentID.TabIndex = 0;
            this.txtStudentID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtStudentID_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btnCancel);
            this.groupBox4.Controls.Add(this.btnSelectIssueBook);
            this.groupBox4.Controls.Add(this.btnReturnBook);
            this.groupBox4.Controls.Add(this.dgvIssueBookList);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(571, 15);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(809, 534);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Issue Book List";
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancel.Location = new System.Drawing.Point(309, 27);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(141, 34);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSelectIssueBook
            // 
            this.btnSelectIssueBook.Enabled = false;
            this.btnSelectIssueBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSelectIssueBook.Location = new System.Drawing.Point(11, 26);
            this.btnSelectIssueBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectIssueBook.Name = "btnSelectIssueBook";
            this.btnSelectIssueBook.Size = new System.Drawing.Size(141, 34);
            this.btnSelectIssueBook.TabIndex = 8;
            this.btnSelectIssueBook.Text = "Select Book";
            this.btnSelectIssueBook.UseVisualStyleBackColor = true;
            this.btnSelectIssueBook.Click += new System.EventHandler(this.btnSelectIssueBook_Click);
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.Enabled = false;
            this.btnReturnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReturnBook.Location = new System.Drawing.Point(160, 26);
            this.btnReturnBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(141, 34);
            this.btnReturnBook.TabIndex = 7;
            this.btnReturnBook.Text = "Return Book";
            this.btnReturnBook.UseVisualStyleBackColor = true;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // dgvIssueBookList
            // 
            this.dgvIssueBookList.AllowUserToAddRows = false;
            this.dgvIssueBookList.AllowUserToDeleteRows = false;
            this.dgvIssueBookList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvIssueBookList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIssueBookList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvIssueBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIssueBookList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colBookId,
            this.colBookName,
            this.colUserName,
            this.colNoOfCopies,
            this.colDateOfIssue,
            this.colDateOfReturn});
            this.dgvIssueBookList.Location = new System.Drawing.Point(11, 69);
            this.dgvIssueBookList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvIssueBookList.MultiSelect = false;
            this.dgvIssueBookList.Name = "dgvIssueBookList";
            this.dgvIssueBookList.ReadOnly = true;
            this.dgvIssueBookList.RowHeadersVisible = false;
            this.dgvIssueBookList.RowHeadersWidth = 51;
            this.dgvIssueBookList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIssueBookList.Size = new System.Drawing.Size(768, 457);
            this.dgvIssueBookList.TabIndex = 2;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colBookId
            // 
            this.colBookId.HeaderText = "Book ID";
            this.colBookId.MinimumWidth = 6;
            this.colBookId.Name = "colBookId";
            this.colBookId.ReadOnly = true;
            // 
            // colBookName
            // 
            this.colBookName.HeaderText = "Book Name";
            this.colBookName.MinimumWidth = 6;
            this.colBookName.Name = "colBookName";
            this.colBookName.ReadOnly = true;
            // 
            // colUserName
            // 
            this.colUserName.HeaderText = "User Name";
            this.colUserName.MinimumWidth = 6;
            this.colUserName.Name = "colUserName";
            this.colUserName.ReadOnly = true;
            // 
            // colNoOfCopies
            // 
            this.colNoOfCopies.HeaderText = "No Of Copies";
            this.colNoOfCopies.MinimumWidth = 6;
            this.colNoOfCopies.Name = "colNoOfCopies";
            this.colNoOfCopies.ReadOnly = true;
            // 
            // colDateOfIssue
            // 
            this.colDateOfIssue.HeaderText = "Date Of Issue";
            this.colDateOfIssue.MinimumWidth = 6;
            this.colDateOfIssue.Name = "colDateOfIssue";
            this.colDateOfIssue.ReadOnly = true;
            // 
            // colDateOfReturn
            // 
            this.colDateOfReturn.HeaderText = "DateOfReturn";
            this.colDateOfReturn.MinimumWidth = 6;
            this.colDateOfReturn.Name = "colDateOfReturn";
            this.colDateOfReturn.ReadOnly = true;
            // 
            // gbFine
            // 
            this.gbFine.Controls.Add(this.label7);
            this.gbFine.Controls.Add(this.label6);
            this.gbFine.Controls.Add(this.label5);
            this.gbFine.Controls.Add(this.txtTotalAmount);
            this.gbFine.Controls.Add(this.label4);
            this.gbFine.Controls.Add(this.txtFinePerDay);
            this.gbFine.Controls.Add(this.label3);
            this.gbFine.Controls.Add(this.txtTotalDay);
            this.gbFine.Controls.Add(this.label2);
            this.gbFine.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbFine.Location = new System.Drawing.Point(17, 375);
            this.gbFine.Margin = new System.Windows.Forms.Padding(4);
            this.gbFine.Name = "gbFine";
            this.gbFine.Padding = new System.Windows.Forms.Padding(4);
            this.gbFine.Size = new System.Drawing.Size(546, 174);
            this.gbFine.TabIndex = 9;
            this.gbFine.TabStop = false;
            this.gbFine.Text = "Book Fine";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(421, 62);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Total Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(276, 65);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fine Per Day";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(147, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total Day";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Enabled = false;
            this.txtTotalAmount.Location = new System.Drawing.Point(412, 85);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(122, 30);
            this.txtTotalAmount.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(384, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "=";
            // 
            // txtFinePerDay
            // 
            this.txtFinePerDay.Enabled = false;
            this.txtFinePerDay.Location = new System.Drawing.Point(275, 85);
            this.txtFinePerDay.Margin = new System.Windows.Forms.Padding(4);
            this.txtFinePerDay.Name = "txtFinePerDay";
            this.txtFinePerDay.Size = new System.Drawing.Size(100, 30);
            this.txtFinePerDay.TabIndex = 5;
            this.txtFinePerDay.Text = "5";
            this.txtFinePerDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox2_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(248, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "X";
            // 
            // txtTotalDay
            // 
            this.txtTotalDay.Enabled = false;
            this.txtTotalDay.Location = new System.Drawing.Point(139, 85);
            this.txtTotalDay.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalDay.Name = "txtTotalDay";
            this.txtTotalDay.Size = new System.Drawing.Size(100, 30);
            this.txtTotalDay.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(8, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Amount = ";
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // frmReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1839, 961);
            this.Controls.Add(this.gbFine);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.HideOnClose = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReturnBook";
            this.TabText = "Return Book";
            this.Text = "Return Book";
            this.Load += new System.EventHandler(this.frmReturnBook_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentDetail)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssueBookList)).EndInit();
            this.gbFine.ResumeLayout(false);
            this.gbFine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.DataGridView dgvStudentDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvIssueBookList;
        private System.Windows.Forms.GroupBox gbFine;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFinePerDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalDay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.Button btnSelectIssueBook;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoOfCopies;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateOfIssue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateOfReturn;
    }
}