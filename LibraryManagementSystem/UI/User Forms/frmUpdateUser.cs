using LibraryManagementSystem.DataAccessLayer;
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
    public partial class frmUpdateUser : WeifenLuo.WinFormsUI.DockContent
    {
        public frmUpdateUser()
        {
            InitializeComponent();
        }

        private void FrmUpdateUser_Load(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            ep.Clear();

            if (txtSearchUserName.Text.Trim().Length == 0)
            {
                ep.SetError(txtSearchUserName, "Kullacı adı boş bırakılamaz!");
                txtSearchUserName.Focus();
                return;
            }
            if (txtSearchPassword.Text.Trim().Length == 0)
            {
                ep.SetError(txtSearchPassword, "Şifre boş bırakılamaz!");
                txtSearchPassword.Focus();
                return;
            }


            var check = UsersHelper.Login(txtSearchUserName.Text, txtSearchPassword.Text).Item1;
            var staffID = UsersHelper.Login(txtSearchUserName.Text, txtSearchPassword.Text).Item2;
            if (check)
            {
                var userPrivileges = UserPrivilegesHelper.GetByStaffID(staffID);

                chkConfiguration.Checked = Convert.ToBoolean(userPrivileges.Configuration);
                chkStaff.Checked = Convert.ToBoolean(userPrivileges.Staff);
                chkStudent.Checked = Convert.ToBoolean(userPrivileges.Student);
                chkBook.Checked = Convert.ToBoolean(userPrivileges.Book);
                chkIssueBook.Checked = Convert.ToBoolean(userPrivileges.IssueBook);
                chkReturnBook.Checked = Convert.ToBoolean(userPrivileges.ReturnBook);
                chkReport.Checked = Convert.ToBoolean(userPrivileges.Report);
                chkGSM.Checked = Convert.ToBoolean(userPrivileges.Gsm);
                chkEmail.Checked = Convert.ToBoolean(userPrivileges.Email);

                var staff = StaffsHelper.GetById(staffID);
                txtUpdateUser.Text = staff.Name;
                txtContactNo.Text = staff.ContactNo;

                var designation = DesignationsHelper.GetById(staff.DesignationID);
                txtDesignation.Text = designation.Name;

                btnUpdate.Enabled = true;
                txtSearchUserName.Enabled = false;
                txtSearchPassword.Enabled = false;
                btnSearch.Enabled = false;
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı ve Şifre Eşleşmiyor.", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            ep.Clear();

            if (txtUserName.Text.Trim().Length == 0)
            {
                ep.SetError(txtUserName, "Kullacı adı boş bırakılamaz!");
                txtUserName.Focus();
                return;
            }
            if (txtNewPassword.Text.Trim().Length == 0)
            {
                ep.SetError(txtNewPassword, "Şifre boş bırakılamaz!");
                txtNewPassword.Focus();
                return;
            }

            if (txtNewPassword.Text.Trim() == txtConfirmPassword.Text.Trim())
            {
                var userid = UsersHelper.GetUserIDbyName(txtUserName.Text);
                if (!UsersHelper.HaveUserID(txtUserName.Text.ToLower(), userid))
                {
                    var staffID = UsersHelper.Login(txtSearchUserName.Text, txtSearchPassword.Text).Item2;

                    var up = UserPrivilegesHelper.GetByStaffID(staffID);
                    up.Configuration = Convert.ToInt32(chkConfiguration.Checked);
                    up.Book = Convert.ToInt32(chkBook.Checked);
                    up.Report = Convert.ToInt32(chkReport.Checked);
                    up.Staff = Convert.ToInt32(chkStaff.Checked);
                    up.IssueBook = Convert.ToInt32(chkIssueBook.Checked);
                    up.Gsm = Convert.ToInt32(chkGSM.Checked);
                    up.Student = Convert.ToInt32(chkStudent.Checked);
                    up.ReturnBook = Convert.ToInt32(chkReturnBook.Checked);
                    up.Email = Convert.ToInt32(chkEmail.Checked);
                    UserPrivilegesHelper.Update(up);

                    var u = UsersHelper.GetByStaffID(staffID);
                    u.UserName = txtUserName.Text;
                    u.Password = txtNewPassword.Text;
                    UsersHelper.Update(u);

                    MessageBox.Show("Üye Güncelleme Başarılı", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnUpdate.Enabled = false;
                    txtSearchUserName.Enabled = true;
                    txtSearchPassword.Enabled = true;
                    btnSearch.Enabled = true;

                    txtSearchUserName.Text = string.Empty;
                    txtSearchPassword.Text = string.Empty;

                    txtUpdateUser.Text = string.Empty;
                    txtContactNo.Text = string.Empty;
                    txtDesignation.Text = string.Empty;
                    txtUserName.Text = string.Empty;
                    txtNewPassword.Text = string.Empty;
                    txtConfirmPassword.Text = string.Empty;

                    chkConfiguration.Checked = false;
                    chkStaff.Checked = false;
                    chkStudent.Checked = false;
                    chkBook.Checked = false;
                    chkIssueBook.Checked = false;
                    chkReturnBook.Checked = false;
                    chkReport.Checked = false;
                    chkGSM.Checked = false;
                    chkEmail.Checked = false;
                }
                else
                {
                    MessageBox.Show("Sistemde bu User Name zaten kayıtlı", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                ep.SetError(txtConfirmPassword, "Şifreler eşleşmiyor!");
                txtConfirmPassword.Focus();
                return;
            }
        }
    }
}
