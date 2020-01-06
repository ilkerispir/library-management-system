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
    public partial class frmDepartment : WeifenLuo.WinFormsUI.DockContent
    {
        public frmDepartment()
        {
            InitializeComponent();
        }

        private void frmDepartment_Load(object sender, EventArgs e)
        {
            SetColumnsWidth();
            FillGrid();
        }

        private void SetColumnsWidth()
        {
            dgvDepartmentList.Columns[0].Width = 505;
            dgvDepartmentList.Columns[1].Width = 505;
            dgvDepartmentList.Columns[2].Width = 505;
        }

        private void FillGrid()
        {
            dgvDepartmentList.Rows.Clear();
            foreach (var department in DepartmentsHelper.GetDepartmentsModelList())
            {
                int row = dgvDepartmentList.Rows.Add();
                dgvDepartmentList.Rows[row].Cells[0].Value = department.DepartmentID;
                dgvDepartmentList.Rows[row].Cells[1].Value = department.Name;
                dgvDepartmentList.Rows[row].Cells[2].Value = department.EstablishDate.ToString("dd MMMM yyyy");
                row++;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtDepartmentName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Lütfen Department ismini giriniz!", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!DepartmentsHelper.HaveDepartmentName(txtDepartmentName.Text))
            {
                Departments d = new Departments();
                d.Name = txtDepartmentName.Text;
                d.EstablishDate = dtpEstablishDate.Value;

                DepartmentsHelper.Add(d);
                MessageBox.Show("Department ekleme başarılı", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillGrid();
            }
            else
            {
                MessageBox.Show("Aynı isimde bir Department zaten ekli!", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void ClearForm()
        {
            txtDepartmentName.Text = string.Empty;
            dtpEstablishDate.Value = DateTime.Now;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDepartmentList.Rows.Count > 0)
                {
                    if (dgvDepartmentList.SelectedRows.Count == 1)
                    {
                        DialogResult dialogResult = MessageBox.Show("Department'i silmek istediğinize emin misiniz?", "Library Management System", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            int selectIndex = dgvDepartmentList.CurrentRow.Index;
                            var departmentID = dgvDepartmentList.Rows[selectIndex].Cells[0].Value;

                            DepartmentsHelper.Delete(Convert.ToInt32(departmentID));

                            MessageBox.Show("Department Silme İşlemi Başarılı", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            FillGrid();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen silmek istediğiniz department'i seçiniz!", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Department listesi boş!", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen silmek istediğiniz Department'i seçiniz!", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EnableComponent()
        {
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            dgvDepartmentList.Enabled = false;
            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void DisableComponent()
        {
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            dgvDepartmentList.Enabled = true;
            btnUpdate.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvDepartmentList.Rows.Count > 0)
            {
                if (dgvDepartmentList.SelectedRows.Count == 1)
                {
                    int selectIndex = dgvDepartmentList.CurrentRow.Index;
                    var departmentID = dgvDepartmentList.Rows[selectIndex].Cells[0].Value;

                    var d = DepartmentsHelper.GetById(Convert.ToInt32(departmentID));

                    txtDepartmentName.Text = Convert.ToString(d.Name);
                    dtpEstablishDate.Value = d.EstablishDate;

                    EnableComponent();
                }
            }
            else
            {
                MessageBox.Show("Department listesi boş!", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
            DisableComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            epProgram.Clear();
            bool check = DepartmentsHelper.ControlValidate(txtDepartmentName, "Lütfen Department  İsmini Giriniz.", epProgram);

            if (check)
            {
                int selectIndex = dgvDepartmentList.CurrentRow.Index;
                var dDepartmentID = dgvDepartmentList.Rows[selectIndex].Cells[0].Value;

                var d = DepartmentsHelper.GetById(Convert.ToInt32(dDepartmentID));
                d.Name = txtDepartmentName.Text.Trim();
                d.EstablishDate = dtpEstablishDate.Value;

                DepartmentsHelper.Update(d);

                MessageBox.Show("Department güncelleme başarılı", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                FillGrid();
                DisableComponent();
            }
        }
    }
}
