using LibraryManagementSystem.DataAccessLayer;
using LibraryManagementSystem.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.UI.Report_Forms
{
    public partial class frmAllFines : WeifenLuo.WinFormsUI.DockContent
    {
        public frmAllFines()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FrmAllStaffs_Load(object sender, EventArgs e)
        {
            FillGridFines();
        }

        private void FillGridFines()
        {
            dgvFineList.Rows.Clear();
            foreach (var fine in FinesHelper.GetActiveFinesList())
            {
                int row = dgvFineList.Rows.Add();
                dgvFineList.Rows[row].Cells[0].Value = fine.FineID;
                dgvFineList.Rows[row].Cells[1].Value = fine.StudentID;
                dgvFineList.Rows[row].Cells[2].Value = fine.BookID;
                dgvFineList.Rows[row].Cells[3].Value = BooksHelper.GetBookNameByID(fine.BookID);
                dgvFineList.Rows[row].Cells[4].Value = fine.Date.ToString("dd MMMM yyyy");
                dgvFineList.Rows[row].Cells[5].Value = fine.FineAmount;
                dgvFineList.Rows[row].Cells[6].Value = fine.RecivedAmount;
                row++;
            }
        }

        private void FillGridStudent(Students s)
        {
            dgvStudentDetail.Rows.Clear();
            dgvStudentDetail.Rows.Add($"Adı   : {s.Name}");
            dgvStudentDetail.Rows.Add($"TC No : {s.TCNO}");
            dgvStudentDetail.Rows.Add($"Dönem : {SessionsHelper.GetByNameFromID(s.SessionID)}");
            dgvStudentDetail.Rows.Add($"Bölüm : {DepartmentsHelper.GetByNameFromID(s.DepartmentID)}");
            dgvStudentDetail.Rows.Add($"Dönem : {ProgramsHelper.GetByNameFromID(s.ProgramID)}");
        }


        private void btnSelectFine_Click(object sender, EventArgs e)
        {
            if (dgvFineList.Rows.Count > 0)
            {
                if (dgvFineList.SelectedRows.Count == 1)
                {
                    int selectIndex = dgvFineList.CurrentRow.Index;
                    var studentID = dgvFineList.Rows[selectIndex].Cells[1].Value;

                    dgvFineList.Enabled = false;
                    gbStudent.Enabled = true;
                    btnCancel.Enabled = true;
                    btnSelectFine.Enabled = false;

                    var s = StudentsHelper.GetStudentByID(Convert.ToInt32(studentID));
                    FillGridStudent(s);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dgvStudentDetail.Rows.Clear();
            txtFinePay.Text = string.Empty;

            dgvFineList.Enabled = true;
            gbStudent.Enabled = false;
            btnCancel.Enabled = false;
            btnSelectFine.Enabled = true;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            int selectIndex = dgvFineList.CurrentRow.Index;
            var fineID = dgvFineList.Rows[selectIndex].Cells[0].Value;

            var f = FinesHelper.GetFinesByID(Convert.ToInt32(fineID));

            ep.Clear();
            if (txtFinePay.Text.Trim().Length == 0)
            {
                ep.SetError(txtFinePay, "Fine boş bırakılamaz!");
                txtFinePay.Focus();
                return;
            }

            if (Convert.ToInt32(txtFinePay.Text) <= (f.FineAmount+f.RecivedAmount))
            {
                f.FineAmount -= Convert.ToInt32(txtFinePay.Text);
                f.RecivedAmount += Convert.ToInt32(txtFinePay.Text);

                if (f.FineAmount == 0)
                {
                    f.Status = 0;
                }

                FinesHelper.Update(f);
                MessageBox.Show("Borç Güncelleme Başarılı.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillGridFines();
            }
            else
            {
                MessageBox.Show("Girdiğimiz borç miktarı, Bu ID'ye ait öğrencideki kalan borç miktarından fazladır.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FillGridFines();
        }
    }
}
