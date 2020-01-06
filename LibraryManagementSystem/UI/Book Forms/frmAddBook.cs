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
    public partial class frmAddBook : WeifenLuo.WinFormsUI.DockContent
    {
        private int _staffID;
        public frmAddBook(int staffID)
        {
            InitializeComponent();
            _staffID = staffID;
        }

        private void FrmAddBook_Load(object sender, EventArgs e)
        {
            cmbDepartment.DataSource = DepartmentsHelper.GetDepartmentsNameList();
            cmbCategory.DataSource = BookCategoriesHelper.GetBookCategoriesNameList();
            FillGrid();
        }

        private void FillGrid()
        {
            dgvBookList.Rows.Clear();
            foreach (var book in BooksHelper.GetBooksList())
            {
                int row = dgvBookList.Rows.Add();
                dgvBookList.Rows[row].Cells[0].Value = book.BookID;
                dgvBookList.Rows[row].Cells[1].Value = book.BookName;
                dgvBookList.Rows[row].Cells[2].Value = BookCategoriesHelper.GetByNameFromID(book.BookCategoryID);
                dgvBookList.Rows[row].Cells[3].Value = DepartmentsHelper.GetByNameFromID(book.DepartmentID);
                dgvBookList.Rows[row].Cells[4].Value = book.Author;
                dgvBookList.Rows[row].Cells[5].Value = book.Title;
                dgvBookList.Rows[row].Cells[6].Value = book.Edition;
                dgvBookList.Rows[row].Cells[7].Value = book.NoOfCopies;
                dgvBookList.Rows[row].Cells[8].Value = book.DateOfRegister.ToString("dd MMMM yyyy");
                dgvBookList.Rows[row].Cells[9].Value = book.Price;
                dgvBookList.Rows[row].Cells[10].Value = StaffsHelper.GetByNameFromID(_staffID);
                row++;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ep.Clear();

            if (txtBookName.Text.Trim().Length == 0)
            {
                ep.SetError(txtBookName, "Book Name boş bırakılamaz!");
                txtBookName.Focus();
                return;
            }
            if (txtTitle.Text.Trim().Length == 0)
            {
                ep.SetError(txtTitle, "Title boş bırakılamaz!");
                txtTitle.Focus();
                return;
            }
            if (txtAuthor.Text.Trim().Length == 0)
            {
                ep.SetError(txtAuthor, "Author boş bırakılamaz!");
                txtAuthor.Focus();
                return;
            }
            if (txtEdition.Text.Trim().Length == 0)
            {
                ep.SetError(txtEdition, "Edition boş bırakılamaz!");
                txtEdition.Focus();
                return;
            }
            if (txtNoOfCopies.Text.Trim().Length == 0)
            {
                ep.SetError(txtNoOfCopies, "Edition boş bırakılamaz!");
                txtNoOfCopies.Focus();
                return;
            }
            if (txtPrice.Text.Trim().Length == 0)
            {
                ep.SetError(txtPrice, "Price boş bırakılamaz!");
                txtPrice.Focus();
                return;
            }

            if (!BooksHelper.HaveBook(txtBookName.Text, txtAuthor.Text, txtAuthor.Text))
            {
                Books b = new Books();
                b.BookCategoryID = BookCategoriesHelper.GetByName(cmbCategory.SelectedItem.ToString());
                b.StaffID = _staffID;
                b.DepartmentID = DepartmentsHelper.GetByName(cmbDepartment.SelectedItem.ToString());
                b.BookName = txtBookName.Text;
                b.Author = txtAuthor.Text;
                b.Title = txtTitle.Text;
                b.Edition = txtEdition.Text;
                b.NoOfCopies = Convert.ToInt32(txtNoOfCopies.Text);
                b.DateOfRegister = dtpRegDate.Value;
                b.Price = Convert.ToInt32(txtPrice.Text);
                BooksHelper.Add(b);

                MessageBox.Show("Kitap Ekleme Başarılı", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cmbDepartment.SelectedIndex = 0;
                cmbCategory.SelectedIndex = 0;
                txtBookName.Text = string.Empty;
                txtTitle.Text = string.Empty;
                txtAuthor.Text = string.Empty;
                txtEdition.Text = string.Empty;
                txtNoOfCopies.Text = string.Empty;
                dtpRegDate.Value = DateTime.Now;
                txtPrice.Text = string.Empty;

                FillGrid();
            }
            else
            {
                MessageBox.Show("Eklemk istediğiniz kitap sistemde zaten mevcut!", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtNoOfCopies_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvBookList.Rows.Count > 0)
            {
                if (dgvBookList.SelectedRows.Count == 1)
                {
                    int selectIndex = dgvBookList.CurrentRow.Index;
                    var bookID = dgvBookList.Rows[selectIndex].Cells[0].Value;

                    var book = BooksHelper.GetBookByID(Convert.ToInt32(bookID));

                    cmbDepartment.SelectedItem = DepartmentsHelper.GetByNameFromID(book.DepartmentID);
                    cmbCategory.SelectedItem = BookCategoriesHelper.GetByNameFromID(book.BookCategoryID);
                    txtBookName.Text = book.BookName;
                    txtTitle.Text = book.Title;
                    txtAuthor.Text = book.Author;
                    txtEdition.Text = book.Edition;
                    txtEdition.Text = string.Empty;
                    dtpRegDate.Value = book.DateOfRegister;
                    txtPrice.Text = book.Price.ToString();

                    DisableComponent();
                }
            }
        }

        private void DisableComponent()
        {
            cmbDepartment.Enabled = false;
            cmbCategory.Enabled = false;
            txtBookName.Enabled = false;
            txtTitle.Enabled = false;
            txtAuthor.Enabled = false;
            txtEdition.Enabled = false;
            dtpRegDate.Enabled = false;
            txtPrice.Enabled = false;
            dgvBookList.Enabled = false;
            btnAdd.Enabled = false;
            btnClear.Enabled = false;
            btnEdit.Enabled = false;
            btnCancel.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void EnabledComponent()
        {
            cmbDepartment.Enabled = true;
            cmbCategory.Enabled = true;
            txtBookName.Enabled = true;
            txtTitle.Enabled = true;
            txtAuthor.Enabled = true;
            txtEdition.Enabled = true;
            dtpRegDate.Enabled = true;
            txtPrice.Enabled = true;
            dgvBookList.Enabled = true;
            btnAdd.Enabled = true;
            btnClear.Enabled = true;
            btnEdit.Enabled = true;
            btnCancel.Enabled = false;
            btnUpdate.Enabled = false;
            
        }

        private void ClearForm()
        {
            cmbDepartment.SelectedIndex = 0;
            cmbCategory.SelectedIndex = 0;
            txtBookName.Text = string.Empty;
            txtTitle.Text = string.Empty;
            txtAuthor.Text = string.Empty;
            txtEdition.Text = string.Empty;
            dtpRegDate.Value = DateTime.Now;
            txtPrice.Text = string.Empty;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EnabledComponent();
            ClearForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int selectIndex = dgvBookList.CurrentRow.Index;
            var bookID = dgvBookList.Rows[selectIndex].Cells[0].Value;

            var b = BooksHelper.GetBookByID(Convert.ToInt32(bookID));
            b.NoOfCopies += Convert.ToInt32(txtNoOfCopies.Text);
            BooksHelper.Update(b);

            MessageBox.Show("Kitap Güncelleme Başarılı", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            EnabledComponent();
            ClearForm();
            FillGrid();
        }
    }
}
