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

namespace LibraryManagementSystem.UI.User_Forms
{
    public partial class frmAddUser : WeifenLuo.WinFormsUI.DockContent
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void FrmAddUser_Load(object sender, EventArgs e)
        {
            cmbSelectUser.DataSource = StaffsHelper.GetStaffsNameList();
        }

        private void CmbSelectUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbContactNo.DataSource = StaffsHelper.GetContactNoList(cmbSelectUser.SelectedItem.ToString());
        }

        private void CmbContactNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDesignation.Text = StaffsHelper.GetDesignation(cmbContactNo.SelectedItem.ToString());
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            epUserName.Clear();
            bool check1 = SessionsHelper.ControlValidate(txtUserName, "Lütfen User Name Giriniz.", epUserName);

            epPassword.Clear();
            bool check2 = SessionsHelper.ControlValidate(txtEnterPassword, "Lütfen Password Giriniz.", epPassword);

            if (txtEnterPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
            {
                epConfirmPass.Clear();
                epConfirmPass.SetError(txtConfirmPassword, "Şifreler eşleşmiyor!");
                return;
            }

            if (check1 && check2)
            {
                if (!UsersHelper.HaveUserID(txtUserName.Text.ToLower()))
                {
                    UserPrivileges up = new UserPrivileges();
                    up.StaffID = StaffsHelper.GetByName(cmbSelectUser.SelectedItem.ToString());
                    up.Configuration = Convert.ToInt32(chkConfiguration.Checked);
                    up.Book = Convert.ToInt32(chkBook.Checked);
                    up.Report = Convert.ToInt32(chkReport.Checked);
                    up.Staff = Convert.ToInt32(chkStaff.Checked);
                    up.IssueBook = Convert.ToInt32(chkIssueBook.Checked);
                    up.Gsm = Convert.ToInt32(chkGSM.Checked);
                    up.Student = Convert.ToInt32(chkStudent.Checked);
                    up.ReturnBook = Convert.ToInt32(chkReturnBook.Checked);
                    up.Email = Convert.ToInt32(chkEmail.Checked);
                    UserPrivilegesHelper.Add(up);

                    Users u = new Users();
                    u.StaffID = StaffsHelper.GetByName(cmbSelectUser.SelectedItem.ToString());
                    u.UserName = txtUserName.Text;
                    u.Password = txtEnterPassword.Text;
                    UsersHelper.Add(u);

                    MessageBox.Show("Üye Ekleme Başarılı", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Eklemek istediğiniz User Name sistemde mevcuttur.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
