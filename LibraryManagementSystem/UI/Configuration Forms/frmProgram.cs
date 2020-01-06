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
    public partial class frmProgram : WeifenLuo.WinFormsUI.DockContent
    {
        public frmProgram()
        {
            InitializeComponent();
        }

        private void frmProgram_Load(object sender, EventArgs e)
        {
            SetColumnsWidth();
            FillGrid();
        }

        private void SetColumnsWidth()
        {
            dgvProgramList.Columns[0].Width = 760;
            dgvProgramList.Columns[1].Width = 760;
        }

        private void FillGrid()
        {
            dgvProgramList.Rows.Clear();
            foreach (var program in ProgramsHelper.GetProgramsModelList())
            {
                int row = dgvProgramList.Rows.Add();
                dgvProgramList.Rows[row].Cells[0].Value = program.ProgramID;
                dgvProgramList.Rows[row].Cells[1].Value = program.Name;
                row++;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtProgramName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Lütfen Program ismini giriniz!", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ProgramsHelper.HaveProgramName(txtProgramName.Text))
            {
                Programs p = new Programs();
                p.Name = txtProgramName.Text;

                ProgramsHelper.Add(p);
                MessageBox.Show("Program ekleme başarılı", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillGrid();
            }
            else
            {
                MessageBox.Show("Aynı isimde bir Program zaten ekli!", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void ClearForm()
        {
            txtProgramName.Text = string.Empty;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProgramList.Rows.Count > 0)
                {
                    if (dgvProgramList.SelectedRows.Count == 1)
                    {
                        DialogResult dialogResult = MessageBox.Show("Program'ı silmek istediğinize emin misiniz?", "Library Management System", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            int selectIndex = dgvProgramList.CurrentRow.Index;
                            var programID = dgvProgramList.Rows[selectIndex].Cells[0].Value;

                            ProgramsHelper.Delete(Convert.ToInt32(programID));

                            MessageBox.Show("Program Silme İşlemi Başarılı", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            FillGrid();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen silmek istediğiniz programı seçiniz!", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Program listesi boş!", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen silmek istediğiniz programı seçiniz!", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }  
        }

        private void EnableComponent()
        {
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            dgvProgramList.Enabled = false;
            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void DisableComponent()
        {
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            dgvProgramList.Enabled = true;
            btnUpdate.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvProgramList.Rows.Count > 0)
            {
                if (dgvProgramList.SelectedRows.Count == 1)
                {
                    int selectIndex = dgvProgramList.CurrentRow.Index;
                    var programID = dgvProgramList.Rows[selectIndex].Cells[0].Value;

                    var p = ProgramsHelper.GetById(Convert.ToInt32(programID));

                    txtProgramName.Text = Convert.ToString(p.Name);
                    EnableComponent();
                }
            }
            else
            {
                MessageBox.Show("Program listesi boş!", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            bool check = SessionsHelper.ControlValidate(txtProgramName, "Lütfen Program  İsmini Giriniz.", epProgram);

            if (check)
            {
                int selectIndex = dgvProgramList.CurrentRow.Index;
                var programID = dgvProgramList.Rows[selectIndex].Cells[0].Value;

                var p = ProgramsHelper.GetById(Convert.ToInt32(programID));
                p.Name = txtProgramName.Text.Trim();

                ProgramsHelper.Update(p);

                MessageBox.Show("Program güncelleme başarılı", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                FillGrid();
                DisableComponent();
            }
        }
    }
}
