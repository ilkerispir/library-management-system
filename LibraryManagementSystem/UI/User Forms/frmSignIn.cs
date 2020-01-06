using LibraryManagementSystem.DataAccessLayer;
using LibraryManagementSystem.Forms;
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
    public partial class frmSignIn : Form
    {
        public frmSignIn()
        {
            InitializeComponent();
        }

        private void FrmSignIn_Load(object sender, EventArgs e)
        {
            lblWrongLogin.Visible = false;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            lblWrongLogin.Visible = false;
            epUserName.Clear();
            epPassword.Clear();

            if (txtUserName.Text.Trim().Length == 0)
            {
                epUserName.SetError(txtUserName, "Kullacı adını giriniz!");
                txtUserName.Focus();
                return;
            }
            if (txtPassword.Text.Trim().Length == 0)
            {
                epPassword.SetError(txtPassword, "Şifre giriniz!");
                txtPassword.Focus();
                return;
            }

            if (UsersHelper.Login(txtUserName.Text, txtPassword.Text).Item1)
            {
                this.Hide();
                int staffID = UsersHelper.Login(txtUserName.Text, txtPassword.Text).Item2;
                frmSplash f = new frmSplash(staffID);
                f.ShowDialog();
                //Application.Exit();
            }
            else
            {
                lblWrongLogin.Visible = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnRememberPassword_Click(object sender, EventArgs e)
        {
            frmRememberPassword f = new frmRememberPassword();
            this.Hide();
            f.ShowDialog();
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSignIn.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}
