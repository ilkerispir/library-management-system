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
    public partial class frmRememberPassword : Form
    {
        public frmRememberPassword()
        {
            InitializeComponent();
        }

        private void FrmRememberPassword_Load(object sender, EventArgs e)
        {
            lblWrongLogin.Visible = false;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            frmSignIn f = new frmSignIn();
            this.Hide();
            f.ShowDialog();
        }
    }
}
