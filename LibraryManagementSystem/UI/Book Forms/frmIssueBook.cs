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
    public partial class frmIssueBook : WeifenLuo.WinFormsUI.DockContent
    {
        private int _staffID;
        public frmIssueBook(int staffID)
        {
            InitializeComponent();
            _staffID = staffID;
        }

        private void FrmIssueBook_Load(object sender, EventArgs e)
        {
            dtpReturnDate.MinDate = dtpIssueDate.Value.AddDays(1);
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

        private void FillGridBook(Books b)
        {
            dgvBookDetail.Rows.Clear();
            dgvBookDetail.Rows.Add($"Adı       : {b.BookName}");
            dgvBookDetail.Rows.Add($"Yazarı    : {b.Author}");
            dgvBookDetail.Rows.Add($"Kategori  : {BookCategoriesHelper.GetByNameFromID(b.BookCategoryID)}");
            dgvBookDetail.Rows.Add($"Bölüm     : {DepartmentsHelper.GetByNameFromID(b.DepartmentID)}");
            dgvBookDetail.Rows.Add($"Miktar    : {b.NoOfCopies}");
        }

        private void TxtStudentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BtnSearchStudent_Click(object sender, EventArgs e)
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
                btnSearchStudent.Enabled = false;
                txtStudentID.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bu ID'ye ait öğrenci bulunamadı", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (btnSearchBook.Enabled == false || btnSearchStudent.Enabled == false)
            {
                btnCancel.Enabled = true;
            }
            if (btnSearchBook.Enabled == false && btnSearchStudent.Enabled == false)
            {
                btnAdd.Enabled = true;
            }
        }

        private void TxtBookID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BtnSearchBook_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txtBookID.Text.Trim().Length == 0)
            {
                ep.SetError(txtBookID, "Book ID giriniz!");
                txtBookID.Focus();
                return;
            }

            try
            {
                var b = BooksHelper.GetBookByID(Convert.ToInt32(txtBookID.Text));
                if (b.NoOfCopies > 0)
                {
                    FillGridBook(b);
                    btnSearchBook.Enabled = false;
                    txtBookID.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Bu ID'ye ait kitap stokta kalmadı.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bu ID'ye ait kitap bulunamadı", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (btnSearchBook.Enabled == false || btnSearchStudent.Enabled == false)
            {
                btnCancel.Enabled = true;
            }
            if (btnSearchBook.Enabled == false && btnSearchStudent.Enabled == false)
            {
                btnAdd.Enabled = true;
            }
        }

        private void DtpIssueDate_ValueChanged(object sender, EventArgs e)
        {
            dtpReturnDate.MinDate = dtpIssueDate.Value.AddDays(1);
        }

        private void btnAddDgv_Click(object sender, EventArgs e)
        {
            if (btnSearchStudent.Enabled==false && btnSearchBook.Enabled == false)
            {
                if (FinesHelper.GetFineCount(Convert.ToInt32(txtStudentID.Text)) < 1)
                {
                    if (!IssueBooksHelper.GetHaveBooks(Convert.ToInt32(txtStudentID.Text), Convert.ToInt32(txtBookID.Text)))
                    {
                        IssueBooks ib = new IssueBooks();
                        ib.StudentID = Convert.ToInt32(txtStudentID.Text);
                        ib.BookID = Convert.ToInt32(txtBookID.Text);
                        ib.StaffID = _staffID;
                        ib.NoOfCopies = 1;
                        ib.DateOfIssue = dtpIssueDate.Value;
                        ib.DateOfReturn = dtpReturnDate.Value;
                        ib.Status = 1;
                        IssueBooksHelper.Add(ib);

                        var b = BooksHelper.GetBookByID(Convert.ToInt32(txtBookID.Text));
                        b.NoOfCopies -= 1;
                        BooksHelper.Update(b);

                        MessageBox.Show("Kitap kiralama başarılı!", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        EnableComponent();
                    }
                    else
                    {
                        MessageBox.Show("Bir Öğrencinin Aynı Kitabı Birden Fazla Alma İhtimali Yoktur.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Öğrencinin Birden Fazla Ödenmemiş Borcu Olduğundan Kitap Kiralama Olanağı Yoktur.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen öğrenci ve kitap seçimini yapınız!", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EnableComponent();
        }

        private void EnableComponent()
        {
            txtStudentID.Text = string.Empty;
            txtStudentID.Enabled = true;

            txtBookID.Text = string.Empty;
            txtBookID.Enabled = true;

            dgvStudentDetail.Rows.Clear();
            dgvBookDetail.Rows.Clear();

            btnCancel.Enabled = false;
            btnAdd.Enabled = false;

            btnSearchStudent.Enabled = true;
            btnSearchBook.Enabled = true;
        }
    }
}
