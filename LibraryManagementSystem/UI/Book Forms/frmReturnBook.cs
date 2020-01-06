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

namespace LibraryManagementSystem.UI.Book_Forms
{
    public partial class frmReturnBook : WeifenLuo.WinFormsUI.DockContent
    {
        private int _staffID;
        public frmReturnBook(int staffID)
        {
            InitializeComponent();
            _staffID = staffID;
        }

        private void frmReturnBook_Load(object sender, EventArgs e)
        {
            btnReturnBook.Enabled = false;
            gbFine.Enabled = false;
        }

        private void TxtStudentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
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

        private void FillGridBook(int studentID)
        {
            dgvIssueBookList.Rows.Clear();
            foreach (var issueBook in IssueBooksHelper.GetIssueBookListFromStudentID(studentID))
            {
                int row = dgvIssueBookList.Rows.Add();
                dgvIssueBookList.Rows[row].Cells[0].Value = issueBook.IssueID;
                dgvIssueBookList.Rows[row].Cells[1].Value = issueBook.BookID;
                dgvIssueBookList.Rows[row].Cells[2].Value = BooksHelper.GetBookNameByID(issueBook.BookID);
                dgvIssueBookList.Rows[row].Cells[3].Value = StaffsHelper.GetByNameFromID(issueBook.StaffID);
                dgvIssueBookList.Rows[row].Cells[4].Value = issueBook.NoOfCopies;
                dgvIssueBookList.Rows[row].Cells[5].Value = issueBook.DateOfIssue.ToString("dd MMMM yyyy");
                dgvIssueBookList.Rows[row].Cells[6].Value = issueBook.DateOfReturn.ToString("dd MMMM yyyy");
                row++;
            }
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txtStudentID.Text.Trim().Length == 0)
            {
                ep.SetError(txtStudentID, "Öğrenci ID giriniz!");
                txtStudentID.Focus();
                return;
            }

            try
            {
                var s = StudentsHelper.GetStudentByID(Convert.ToInt32(txtStudentID.Text));
                FillGridStudent(s);
                FillGridBook(Convert.ToInt32(txtStudentID.Text));
                if (dgvIssueBookList.Rows.Count > 0)
                {
                    btnSearchStudent.Enabled = false;
                    btnSelectIssueBook.Enabled = true;
                    txtStudentID.Enabled = false;
                    dgvIssueBookList.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Bu ID'ye ait öğrencide kitap yoktur.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Bu ID'ye ait öğrenci bulunamadı", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            int selectIndex = dgvIssueBookList.CurrentRow.Index;
            var issueBookID = dgvIssueBookList.Rows[selectIndex].Cells[0].Value;

            var ib = IssueBooksHelper.GetIssueBookByID(Convert.ToInt32(issueBookID));
            ib.Status = 0;
            IssueBooksHelper.Update(ib);

            if (DateTime.Now > ib.DateOfReturn)
            {
                gbFine.Enabled = true;
                Fines f = new Fines();
                f.StudentID = ib.StudentID;
                f.BookID = ib.BookID;
                f.StaffID = _staffID;
                f.Date = DateTime.Now;
                f.FineAmount = Convert.ToInt32(txtTotalAmount.Text);
                f.RecivedAmount = 0;
                f.Status = 1;
                FinesHelper.Add(f);
            }

            ReturnBooks rb = new ReturnBooks();
            rb.BookID = ib.BookID;
            rb.StudentID = ib.StudentID;
            rb.StaffID = _staffID;
            rb.IssueDate = ib.DateOfIssue;
            rb.ReturnDate = ib.DateOfReturn;
            rb.Date = DateTime.Now;
            ReturnBooksHelper.Add(rb);

            Books b = BooksHelper.GetBookByID(ib.BookID);
            b.NoOfCopies += 1;
            BooksHelper.Update(b);

            MessageBox.Show("Kitap iade başarılı!", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DisableComponent();
        }

        private void btnSelectIssueBook_Click(object sender, EventArgs e)
        {
            dgvIssueBookList.Enabled = false;

            int selectIndex = dgvIssueBookList.CurrentRow.Index;
            var issueBookID = dgvIssueBookList.Rows[selectIndex].Cells[0].Value;

            var ib = IssueBooksHelper.GetIssueBookByID(Convert.ToInt32(issueBookID));

            if (DateTime.Now > ib.DateOfReturn)
            {
                int day = Convert.ToInt32((DateTime.Now - ib.DateOfReturn).TotalDays);
                txtTotalDay.Text = day.ToString();

                int fine = Convert.ToInt32(txtFinePerDay.Text);

                int totalAmount = day * fine;

                txtTotalAmount.Text = totalAmount.ToString();
                gbFine.Enabled = true;
            }
            
            btnSearchStudent.Enabled = false;
            btnSelectIssueBook.Enabled = false;
            btnReturnBook.Enabled = true;
            btnCancel.Enabled = true;
            dgvIssueBookList.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DisableComponent();
        }

        private void DisableComponent()
        {
            txtStudentID.Text = string.Empty;
            txtStudentID.Enabled = true;
            btnSearchStudent.Enabled = true;
            btnCancel.Enabled = false;
            btnReturnBook.Enabled = false;
            dgvStudentDetail.Rows.Clear();
            dgvIssueBookList.Rows.Clear();
            gbFine.Enabled = false;
            txtTotalDay.Text = string.Empty;
            txtTotalAmount.Text = string.Empty;
        }
    }
}
