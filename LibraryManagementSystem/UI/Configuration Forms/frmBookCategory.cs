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

namespace LibraryManagementSystem.UI.Configuration_Forms
{
    public partial class frmBookCategory : WeifenLuo.WinFormsUI.DockContent
    {
        public frmBookCategory()
        {
            InitializeComponent();
        }

        private void frmBookType_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txtBookType.Text.Trim().Length == 0)
            {
                ep.SetError(txtBookType, "Kitap türü boş bırakılamaz!");
                txtBookType.Focus();
                return;
            }

            BookCategories bc = new BookCategories();
            bc.Name = txtBookType.Text;

            BookCategoriesHelper.Add(bc);

            MessageBox.Show("Kitap Türü Ekleme Başarılı", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtBookType.Text = string.Empty;

            FillGrid();
        }

        private void FillGrid()
        {
            dgvBookTypeList.Rows.Clear();
            foreach (var bookCategory in BookCategoriesHelper.GetBookCategoriesList())
            {
                int row = dgvBookTypeList.Rows.Add();
                dgvBookTypeList.Rows[row].Cells[0].Value = bookCategory.BookCategoryID;
                dgvBookTypeList.Rows[row].Cells[1].Value = bookCategory.Name;
                row++;
            }
        }
    }
}
