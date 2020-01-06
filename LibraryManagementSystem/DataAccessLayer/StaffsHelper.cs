using LibraryManagementSystem.EntityFramework;
using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.DataAccessLayer
{
    class StaffsHelper
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

        public static bool ControlValidate(MaskedTextBox txtBox, string message, ErrorProvider ep)
        {
            if (Convert.ToString(txtBox.Text).Contains("_"))
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

        public static Staffs GetById(int id)
        {
            using (var db = new LibraryDBEntities())
            {
                return db.Staffs.Find(id);
            }
        }

        public static string GetByNameFromID(int id)
        {
            using (var db = new LibraryDBEntities())
            {
                var staff = db.Staffs.Where(x => x.StaffID == id).First();
                return staff.Name;
            }
        }

        public static List<StaffsModel> GetStaffsModelList()
        {
            List<StaffsModel> staffsModelList = new List<StaffsModel>();
            using (var db = new LibraryDBEntities())
            {
                var staffsList = db.Staffs.ToList();
                foreach (var staff in staffsList)
                {
                    if (staff.Status == 1)
                    {
                        StaffsModel staffModel = new StaffsModel();

                        staffModel.StaffID = staff.StaffID;
                        staffModel.Designations.DesignationID = staff.Designations.DesignationID;
                        staffModel.Designations.Name = staff.Designations.Name;
                        staffModel.Name = staff.Name;
                        staffModel.TCNO = staff.TCNO;
                        staffModel.Gender = staff.Gender;
                        staffModel.Address = staff.Address;
                        staffModel.ContactNo = staff.ContactNo;

                        staffsModelList.Add(staffModel);
                    }    
                }
                return staffsModelList;
            }
        }

        public static void Add(Staffs s)
        {
            using (var db = new LibraryDBEntities())
            {
                db.Staffs.Add(s);

                db.SaveChanges();
            }
        }

        public static void Delete(int id)
        {
            using (var db = new LibraryDBEntities())
            {
                var s = db.Staffs.Find(id);

                db.Staffs.Remove(s);

                db.SaveChanges();
            }
        }

        public static void Update(Staffs s)
        {
            using (var db = new LibraryDBEntities())
            {
                db.Entry(s).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public static List<string> GetStaffsNameList()
        {
            List<string> staffsNameList = new List<string>();
            using (var db = new LibraryDBEntities())
            {
                var staffsList = db.Staffs.ToList();
                foreach (var staff in staffsList)
                {
                    staffsNameList.Add(staff.Name);
                }
                return staffsNameList;
            }
        }

        public static List<string> GetContactNoList(string name)
        {
            List<string> staffsContactNoList = new List<string>();
            using (var db = new LibraryDBEntities())
            {
                var staffsList = db.Staffs.Where(x => x.Name == name).ToList();
                foreach (var staff in staffsList)
                {
                    staffsContactNoList.Add(staff.ContactNo);
                }
                return staffsContactNoList;
            }
        }

        public static string GetDesignation(string ContactNo)
        {
            using (var db = new LibraryDBEntities())
            {
                var staff = db.Staffs.Where(x => x.ContactNo == ContactNo).FirstOrDefault();
                return staff.Designations.Name;
            }
        }

        public static int GetByName(string name)
        {
            using (var db = new LibraryDBEntities())
            {
                var staff = db.Staffs.Where(x => x.Name == name).First();
                return staff.StaffID;
            }
        }

        public static bool HaveTCNO(string TCNO)
        {
            bool check = false;
            using (var db = new LibraryDBEntities())
            {
                foreach (var staff in db.Staffs.ToList())
                {
                    if (staff.TCNO == TCNO)
                    {
                        check = true;
                    }
                }
            }
            return check;
        }

        public static bool HaveContactNo(string contactNo)
        {
            bool check = false;
            using (var db = new LibraryDBEntities())
            {
                foreach (var staff in db.Staffs.ToList())
                {
                    if (staff.ContactNo == contactNo)
                    {
                        check = true;
                    }
                }
            }
            return check;
        }

        public static List<Staffs> GetActiveStaffsList()
        {
            List<Staffs> activeStaffs = new List<Staffs>();
            using (var db = new LibraryDBEntities())
            {
                foreach (var staff in db.Staffs.ToList())
                {
                    if (staff.Status == 1)
                    {
                        activeStaffs.Add(staff);
                    }
                }

            }
            return activeStaffs;
        }
    }
}
