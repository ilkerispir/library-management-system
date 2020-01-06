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

namespace LibraryManagementSystem.UI
{
    public partial class frmDesignation : WeifenLuo.WinFormsUI.DockContent
    {
        public frmDesignation()
        {
            InitializeComponent();
        }

        private void frmDesignation_Load(object sender, EventArgs e)
        {
            FillGrid();
            SetColumnsWidth();
        }

        private void FillGrid()
        {
            dgvDesignationList.Rows.Clear();
            foreach (var designation in DesignationsHelper.GetDesignationsModelList())
            {
                int row = dgvDesignationList.Rows.Add();
                dgvDesignationList.Rows[row].Cells[0].Value = designation.DesignationID;
                dgvDesignationList.Rows[row].Cells[1].Value = designation.Name;
                row++;
            }
        }

        private void SetColumnsWidth()
        {
            dgvDesignationList.Columns[0].Width = 760;
            dgvDesignationList.Columns[1].Width = 760;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtDesignation.Text.Trim().Length == 0)
            {
                MessageBox.Show("Lütfen Designation ismini giriniz!", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Designations d = new Designations();
            d.Name = txtDesignation.Text;

            DesignationsHelper.Add(d);
            MessageBox.Show("Designation ekleme başarılı", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FillGrid();
        }
    }
}
