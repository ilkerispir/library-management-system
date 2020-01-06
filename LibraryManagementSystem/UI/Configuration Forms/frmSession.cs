using LibraryManagementSystem.DataAccessLayer;
using LibraryManagementSystem.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;   
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI;

namespace LibraryManagementSystem.Forms.Configuration_Forms
{
    public partial class frmSession : WeifenLuo.WinFormsUI.DockContent
    {
        public frmSession()
        {
            InitializeComponent();
        }

        private void FrmSession_Load(object sender, EventArgs e)
        {
            SetColumnsWidth();
            FillGrid();
        }
        private void SetColumnsWidth()
        {
            dgvProgramList.Columns[0].Width = 200;
            dgvProgramList.Columns[1].Width = 350;
            dgvProgramList.Columns[2].Width = 500;
            dgvProgramList.Columns[3].Width = 500;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            epProgram.Clear();
            bool check = SessionsHelper.ControlValidate(txtSessionName, "Lütfen Session İsmini Giriniz.", epProgram);

            if (check)
            {
                if (!SessionsHelper.HaveSessionName(txtSessionName.Text))
                {
                    Sessions s = new Sessions();
                    s.Name = Convert.ToString(txtSessionName.Text).Trim();
                    s.StartDate = dtpStartDate.Value;
                    s.EndDate = dtpEndDate.Value;

                    SessionsHelper.Add(s);

                    MessageBox.Show("Program Ekleme Başarılı", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillGrid();
                }
                else
                {
                    MessageBox.Show("Aynı isimde bir Session zaten ekli!", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }           
        }
        private void FillGrid()
        {
            dgvProgramList.Rows.Clear();
            foreach (var session in SessionsHelper.GetSessionsModelList())
            {
                int row = dgvProgramList.Rows.Add();
                dgvProgramList.Rows[row].Cells[0].Value = session.SessionID;
                dgvProgramList.Rows[row].Cells[1].Value = session.Name;
                dgvProgramList.Rows[row].Cells[2].Value = session.StartDate.ToString("dd MMMM yyyy");
                dgvProgramList.Rows[row].Cells[3].Value = session.EndDate.ToString("dd MMMM yyyy");
                row++;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProgramList.Rows.Count > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Session'u silmek istediğinize emin misiniz?", "Library Management System", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int selectIndex = dgvProgramList.CurrentRow.Index;
                        var sessionID = dgvProgramList.Rows[selectIndex].Cells[0].Value;

                        SessionsHelper.Delete(Convert.ToInt32(sessionID));

                        MessageBox.Show("Session Silme Başarılı", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        FillGrid();
                    }
                }              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Herhangi bir eleman seçmediniz!", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void EnableComponent()
        {
            BtnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            dgvProgramList.Enabled = false;
            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void DisableComponent()
        {
            BtnAdd.Enabled = true;
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
                    var sessionID = dgvProgramList.Rows[selectIndex].Cells[0].Value;

                    var s = SessionsHelper.GetById(Convert.ToInt32(sessionID));

                    txtSessionName.Text = Convert.ToString(s.Name);
                    dtpStartDate.Value = Convert.ToDateTime(s.StartDate);
                    dtpEndDate.Value = Convert.ToDateTime(s.EndDate);
                    EnableComponent();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
            DisableComponent();
        }

        private void ClearForm()
        {
            txtSessionName.Text = string.Empty;
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            epProgram.Clear();
            bool check = SessionsHelper.ControlValidate(txtSessionName, "Lütfen Session İsmini Giriniz.", epProgram);

            if (check)
            {
                int selectIndex = dgvProgramList.CurrentRow.Index;
                var sessionID = dgvProgramList.Rows[selectIndex].Cells[0].Value;

                var s = SessionsHelper.GetById(Convert.ToInt32(sessionID));
                s.Name = txtSessionName.Text.Trim();
                s.StartDate = dtpStartDate.Value;
                s.EndDate = dtpEndDate.Value;

                SessionsHelper.Update(s);

                MessageBox.Show("Session güncelleme başarılı", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                FillGrid();
                DisableComponent();
            }
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            dtpEndDate.MinDate = dtpStartDate.Value;
        }
    }
}
