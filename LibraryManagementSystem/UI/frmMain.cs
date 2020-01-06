using LibraryManagementSystem.DataAccessLayer;
using LibraryManagementSystem.Forms.Configuration_Forms;
using LibraryManagementSystem.UI;
using LibraryManagementSystem.UI.Book_Forms;
using LibraryManagementSystem.UI.Configuration_Forms;
using LibraryManagementSystem.UI.Report_Forms;
using LibraryManagementSystem.UI.Staff_Forms;
using LibraryManagementSystem.UI.Student_Forms;
using LibraryManagementSystem.UI.User_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI;

namespace LibraryManagementSystem.Forms
{
    public partial class frmMain : Form
    {
        private int _staffID;
        public frmMain(int staffID)
        {
            _staffID = staffID;
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            UserPre();
            toolStripStatusLabel1.Text = StaffsHelper.GetByNameFromID(_staffID);
        }

        private void UserPre()
        {
            var userPre = UserPrivilegesHelper.GetByStaffID(_staffID);

            if (userPre.Configuration == 1)
            {
                configurationToolStripMenuItem.Enabled = true;
                toolStripDepartment.Enabled = true;
                toolStripSession.Enabled = true;
                toolStripProgram.Enabled = true;
            }
            else
            {
                configurationToolStripMenuItem.Enabled = false;
                toolStripDepartment.Enabled = false;
                toolStripSession.Enabled = false;
                toolStripProgram.Enabled = false;
            }

            if (userPre.Staff == 1)
            {
                toolStripAddStaff.Enabled = true;
                staffToolStripMenuItem.Enabled = true;
            }
            else
            {
                toolStripAddStaff.Enabled = false;
                staffToolStripMenuItem.Enabled = false;
            }

            if (userPre.Student == 1)
            {
                studentsToolStripMenuItem.Enabled = true;
                toolStripStudent.Enabled = true;
            }
            else
            {
                studentsToolStripMenuItem.Enabled = false;
                toolStripStudent.Enabled = false;
            }

            if (userPre.Book == 1)
            {
                toolStripAddBook.Enabled = true;
                booksToolStripMenuItem.Enabled = true;
            }
            else
            {
                toolStripAddBook.Enabled = false;
                booksToolStripMenuItem.Enabled = false;
            }

            if (userPre.IssueBook == 1)
            {
                toolStripIssueBooks.Enabled = true;
                issueBookToolStripMenuItem.Enabled = true;
            }
            else
            {
                toolStripIssueBooks.Enabled = false;
                issueBookToolStripMenuItem.Enabled = false;
            }

            if (userPre.ReturnBook == 1)
            {
                toolStripReturnBooks.Enabled = true;
                returnBookToolStripMenuItem.Enabled = true;
            }
            else
            {
                toolStripReturnBooks.Enabled = false;
                returnBookToolStripMenuItem.Enabled = false;
            }

            if (userPre.Report == 1)
            {
                toolStripReports.Enabled = true;
                reportsToolStripMenuItem.Enabled = true;
            }
            else
            {
                toolStripReports.Enabled = false;
                reportsToolStripMenuItem.Enabled = false;
            }

            if (userPre.Gsm == 1)
            {
                servicesToolStripMenuItem.Enabled = true;
            }
            else
            {
                servicesToolStripMenuItem.Enabled = false;
            }

            if (userPre.Email == 1)
            {
                eMailToolStripMenuItem.Enabled = true;
            }
            else
            {
                eMailToolStripMenuItem.Enabled = false;
            }
        }

        private frmSession _frmSession;
        private void sessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmSession == null)
            {
                _frmSession = new frmSession();
                _frmSession.Show(dp, DockState.Document);
            }
            else
            {
                _frmSession.Activate();
            }
        }

        private void toolStripSession_Click(object sender, EventArgs e)
        {
            sessionToolStripMenuItem_Click(sender, e);
        }

        private frmProgram _frmProgram;
        private void programmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmProgram == null)
            {
                _frmProgram = new frmProgram();
                _frmProgram.Show(dp, DockState.Document);
            }
            else
            {
                _frmProgram.Activate();
            }
        }

        private void toolStripProgram_Click(object sender, EventArgs e)
        {
            programmeToolStripMenuItem_Click(sender, e);
        }

        private frmDepartment _frmDepartment;
        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmDepartment == null)
            {
                _frmDepartment = new frmDepartment();
                _frmDepartment.Show(dp, DockState.Document);
            }
            else
            {
                _frmDepartment.Activate();
            }
        }

        private void toolStripDepartment_Click(object sender, EventArgs e)
        {
            departmentToolStripMenuItem_Click(sender, e);
        }

        private frmAddStaff _frmAddStaff;
        private void addStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmAddStaff == null)
            {
                _frmAddStaff = new frmAddStaff();
                _frmAddStaff.Show(dp, DockState.Document);
            }
            else
            {
                _frmAddStaff.Activate();
            }
        }

        private void toolStripAddStaff_Click(object sender, EventArgs e)
        {
            addStaffToolStripMenuItem_Click(sender, e);
        }

        private frmDesignation _frmDesignation;
        private void designationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmDesignation == null)
            {
                _frmDesignation = new frmDesignation();
                _frmDesignation.Show(dp, DockState.Document);
            }
            else
            {
                _frmDesignation.Activate();
            }
        }

        private frmAddUser _frmAddUser;
        private void CreateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmAddUser == null)
            {
                _frmAddUser = new frmAddUser();
                _frmAddUser.Show(dp, DockState.Document);
            }
            else
            {
                _frmAddUser.Activate();
            }
        }

        private void toolStripSignIn_Click(object sender, EventArgs e)
        {
            frmSignIn f = new frmSignIn();
            f.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private frmUpdateUser _frmUpdateUser;
        private void UpdateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmUpdateUser == null)
            {
                _frmUpdateUser = new frmUpdateUser();
                _frmUpdateUser.Show(dp, DockState.Document);
            }
            else
            {
                _frmUpdateUser.Activate();
            }
        }

        private frmStudent _frmStudent;
        private void StudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmStudent == null)
            {
                _frmStudent = new frmStudent(_staffID);
                _frmStudent.Show(dp, DockState.Document);
            }
            else
            {
                _frmStudent.Activate();
            }
        }

        private void ToolStripStudent_Click(object sender, EventArgs e)
        {
            StudentsToolStripMenuItem_Click(sender, e);
        }

        private frmBookCategory _frmBookType;
        private void bookTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmBookType == null)
            {
                _frmBookType = new frmBookCategory();
                _frmBookType.Show(dp, DockState.Document);
            }
            else
            {
                _frmBookType.Activate();
            }
        }

        private frmAddBook _frmAddBook;
        private void AddBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmAddBook == null)
            {
                _frmAddBook = new frmAddBook(_staffID);
                _frmAddBook.Show(dp, DockState.Document);
            }
            else
            {
                _frmAddBook.Activate();
            }
        }

        private void ToolStripAddBook_Click(object sender, EventArgs e)
        {
            AddBookToolStripMenuItem_Click(sender, e);
        }

        private frmIssueBook _frmIssueBook;
        private void İssueBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmIssueBook == null)
            {
                _frmIssueBook = new frmIssueBook(_staffID);
                _frmIssueBook.Show(dp, DockState.Document);
            }
            else
            {
                _frmIssueBook.Activate();
            }
        }

        private void ToolStripIssueBooks_Click(object sender, EventArgs e)
        {
            İssueBookToolStripMenuItem_Click(sender, e);
        }

        private frmReturnBook _frmReturnBook;
        private void ReturnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmReturnBook == null)
            {
                _frmReturnBook = new frmReturnBook(_staffID);
                _frmReturnBook.Show(dp, DockState.Document);
            }
            else
            {
                _frmReturnBook.Activate();
            }
        }

        private void ToolStripReturnBooks_Click(object sender, EventArgs e)
        {
            ReturnBookToolStripMenuItem_Click(sender, e);
        }

        private frmAllFines _frmAllFines;
        private void ToolStripReports_Click(object sender, EventArgs e)
        {
            if (_frmAllFines == null)
            {
                _frmAllFines = new frmAllFines();
                _frmAllFines.Show(dp, DockState.Document);
            }
            else
            {
                _frmAllFines.Activate();
            }
        }
    }
}
