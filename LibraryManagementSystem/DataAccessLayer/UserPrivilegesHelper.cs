using LibraryManagementSystem.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.DataAccessLayer
{
    class UserPrivilegesHelper
    {
        public static bool ControlValidate(TextBox txtBox, string message, ErrorProvider ep)
        {
            if (txtBox.Text.Trim().Length == 0)
            {
                ep.SetError(txtBox, $"{message}");
                txtBox.Focus();
                txtBox.SelectAll();
                return false;
            }
            else
            {
                return true;
            }
        }

        public static void Add(UserPrivileges up)
        {
            using (var db = new LibraryDBEntities())
            {
                db.UserPrivileges.Add(up);
                db.SaveChanges();
            }
        }

        public static UserPrivileges GetByStaffID(int staffID)
        {
            using (var db = new LibraryDBEntities())
            {
                var userPrivileges = db.UserPrivileges.Where(x => x.StaffID == staffID).First();
                return userPrivileges;
            }
        }

        public static void Update(UserPrivileges up)
        {
            using (var db = new LibraryDBEntities())
            {
                db.Entry(up).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
