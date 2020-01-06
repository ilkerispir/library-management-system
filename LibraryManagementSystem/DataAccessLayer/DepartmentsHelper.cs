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
    class DepartmentsHelper
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

        public static Departments GetById(int id)
        {
            using (var db = new LibraryDBEntities())
            {
                return db.Departments.Find(id);
            }
        }

        public static string GetByNameFromID(int id)
        {
            using (var db = new LibraryDBEntities())
            {
                var department = db.Departments.Where(x => x.DepartmentID == id).First();
                return department.Name;
            }
        }

        public static int GetByName(string name)
        {
            using (var db = new LibraryDBEntities())
            {
                var department = db.Departments.Where(x => x.Name == name).First();
                return department.DepartmentID;
            }
        }

        public static List<DepartmentsModel> GetDepartmentsModelList()
        {
            List<DepartmentsModel> departmentsModelList = new List<DepartmentsModel>();
            using (var db = new LibraryDBEntities())
            {
                var departmentsList = db.Departments.ToList();
                foreach (var departments in departmentsList)
                {
                    DepartmentsModel departmentsModel = new DepartmentsModel();

                    departmentsModel.DepartmentID = departments.DepartmentID;
                    departmentsModel.Name = departments.Name;
                    departmentsModel.EstablishDate = departments.EstablishDate;

                    departmentsModelList.Add(departmentsModel);
                }
                return departmentsModelList;
            }
        }

        public static List<string> GetDepartmentsNameList()
        {
            List<string> departmentsNameList = new List<string>();
            using (var db = new LibraryDBEntities())
            {
                var departmentsList = db.Departments.ToList();
                foreach (var department in departmentsList)
                {
                    departmentsNameList.Add(department.Name);
                }
                return departmentsNameList;
            }
        }

        public static void Add(Departments d)
        {
            using (var db = new LibraryDBEntities())
            {
                db.Departments.Add(d);
                db.SaveChanges();
            }
        }

        public static void Update(Departments d)
        {
            using (var db = new LibraryDBEntities())
            {
                db.Entry(d).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public static void Delete(int id)
        {
            using (var db = new LibraryDBEntities())
            {
                var d = db.Departments.Find(id);

                db.Departments.Remove(d);

                db.SaveChanges();
            }
        }

        public static bool HaveDepartmentName(string name)
        {
            bool check = false;
            using (var db = new LibraryDBEntities())
            {
                foreach (var department in db.Departments.ToList())
                {
                    if (department.Name == name)
                    {
                        check = true;
                    }
                }
            }
            return check;
        }
    }
}
