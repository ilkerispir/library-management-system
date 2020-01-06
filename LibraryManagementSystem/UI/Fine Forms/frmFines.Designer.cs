namespace LibraryManagementSystem.UI.Report_Forms
{
    partial class frmAllFines
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvFineList = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDatw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFineAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecivedAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbStudent = new System.Windows.Forms.GroupBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvStudentDetail = new System.Windows.Forms.DataGridView();
            this.colInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFinePay = new System.Windows.Forms.TextBox();
            this.btnSelectFine = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFineList)).BeginInit();
            this.gbStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFineList
            // 
            this.dgvFineList.AllowUserToAddRows = false;
            this.dgvFineList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFineList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFineList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFineList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFineList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFineList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colStudentID,
            this.colBookID,
            this.colBookName,
            this.colDatw,
            this.colFineAmount,
            this.colRecivedAmount});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFineList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFineList.Location = new System.Drawing.Point(16, 416);
            this.dgvFineList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFineList.MultiSelect = false;
            this.dgvFineList.Name = "dgvFineList";
            this.dgvFineList.ReadOnly = true;
            this.dgvFineList.RowHeadersVisible = false;
            this.dgvFineList.RowHeadersWidth = 51;
            this.dgvFineList.RowTemplate.Height = 24;
            this.dgvFineList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFineList.Size = new System.Drawing.Size(1679, 555);
            this.dgvFineList.TabIndex = 2;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colStudentID
            // 
            this.colStudentID.HeaderText = "StudentID";
            this.colStudentID.MinimumWidth = 6;
            this.colStudentID.Name = "colStudentID";
            this.colStudentID.ReadOnly = true;
            // 
            // colBookID
            // 
            this.colBookID.HeaderText = "Book ID";
            this.colBookID.MinimumWidth = 6;
            this.colBookID.Name = "colBookID";
            this.colBookID.ReadOnly = true;
            // 
            // colBookName
            // 
            this.colBookName.HeaderText = "Book Name";
            this.colBookName.MinimumWidth = 6;
            this.colBookName.Name = "colBookName";
            this.colBookName.ReadOnly = true;
            // 
            // colDatw
            // 
            this.colDatw.HeaderText = "Date";
            this.colDatw.MinimumWidth = 6;
            this.colDatw.Name = "colDatw";
            this.colDatw.ReadOnly = true;
            // 
            // colFineAmount
            // 
            this.colFineAmount.HeaderText = "Fine Amount";
            this.colFineAmount.MinimumWidth = 6;
            this.colFineAmount.Name = "colFineAmount";
            this.colFineAmount.ReadOnly = true;
            // 
            // colRecivedAmount
            // 
            this.colRecivedAmount.HeaderText = "Recived Amount";
            this.colRecivedAmount.MinimumWidth = 6;
            this.colRecivedAmount.Name = "colRecivedAmount";
            this.colRecivedAmount.ReadOnly = true;
            // 
            // gbStudent
            // 
            this.gbStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbStudent.Controls.Add(this.btnPay);
            this.gbStudent.Controls.Add(this.label2);
            this.gbStudent.Controls.Add(this.dgvStudentDetail);
            this.gbStudent.Controls.Add(this.txtFinePay);
            this.gbStudent.Enabled = false;
            this.gbStudent.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbStudent.Location = new System.Drawing.Point(16, 15);
            this.gbStudent.Margin = new System.Windows.Forms.Padding(4);
            this.gbStudent.Name = "gbStudent";
            this.gbStudent.Padding = new System.Windows.Forms.Padding(4);
            this.gbStudent.Size = new System.Drawing.Size(547, 352);
            this.gbStudent.TabIndex = 3;
            this.gbStudent.TabStop = false;
            this.gbStudent.Text = "Student";
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPay.Location = new System.Drawing.Point(299, 31);
            this.btnPay.Margin = new System.Windows.Forms.Padding(4);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(141, 34);
            this.btnPay.TabIndex = 6;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fine Amount";
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
            this.dgvStudentDetail.Location = new System.Drawing.Point(8, 76);
            this.dgvStudentDetail.Margin = new System.Windows.Forms.Padding(4);
            this.dgvStudentDetail.MultiSelect = false;
            this.dgvStudentDetail.Name = "dgvStudentDetail";
            this.dgvStudentDetail.ReadOnly = true;
            this.dgvStudentDetail.RowHeadersVisible = false;
            this.dgvStudentDetail.RowHeadersWidth = 51;
            this.dgvStudentDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudentDetail.Size = new System.Drawing.Size(523, 268);
            this.dgvStudentDetail.TabIndex = 6;
            // 
            // colInfo
            // 
            this.colInfo.HeaderText = "Student Detail";
            this.colInfo.MinimumWidth = 6;
            this.colInfo.Name = "colInfo";
            this.colInfo.ReadOnly = true;
            // 
            // txtFinePay
            // 
            this.txtFinePay.Location = new System.Drawing.Point(149, 35);
            this.txtFinePay.Margin = new System.Windows.Forms.Padding(4);
            this.txtFinePay.Name = "txtFinePay";
            this.txtFinePay.Size = new System.Drawing.Size(132, 30);
            this.txtFinePay.TabIndex = 0;
            this.txtFinePay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btnSelectFine
            // 
            this.btnSelectFine.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSelectFine.Location = new System.Drawing.Point(165, 375);
            this.btnSelectFine.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectFine.Name = "btnSelectFine";
            this.btnSelectFine.Size = new System.Drawing.Size(141, 33);
            this.btnSelectFine.TabIndex = 6;
            this.btnSelectFine.Text = "Select";
            this.btnSelectFine.UseVisualStyleBackColor = true;
            this.btnSelectFine.Click += new System.EventHandler(this.btnSelectFine_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancel.Location = new System.Drawing.Point(314, 375);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(141, 34);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRefresh.Location = new System.Drawing.Point(16, 375);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(141, 33);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmAllFines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1711, 986);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSelectFine);
            this.Controls.Add(this.gbStudent);
            this.Controls.Add(this.dgvFineList);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAllFines";
            this.TabText = "Fines";
            this.Text = "Fines";
            this.Load += new System.EventHandler(this.FrmAllStaffs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFineList)).EndInit();
            this.gbStudent.ResumeLayout(false);
            this.gbStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFineList;
        private System.Windows.Forms.GroupBox gbStudent;
        private System.Windows.Forms.Button btnSelectFine;
        private System.Windows.Forms.DataGridView dgvStudentDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInfo;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFinePay;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDatw;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFineAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecivedAmount;
        private System.Windows.Forms.Button btnRefresh;
    }
}