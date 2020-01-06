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
    class DesignationsHelper
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

        public static Designations GetById(int id)
        {
            using (var db = new LibraryDBEntities())
            {
                return db.Designations.Find(id);
            }
        }

        public static int GetByName(string name)
        {
            using (var db = new LibraryDBEntities())
            {
                var designation = db.Designations.Where(x => x.Name == name).First();
                return designation.DesignationID;
            }
        }

        public static List<DesignationsModel> GetDesignationsModelList()
        {
            List<DesignationsModel> designationsModelList = new List<DesignationsModel>();
            using (var db = new LibraryDBEntities())
            {
                var designationsList = db.Designations.ToList();
                foreach (var designation in designationsList)
                {
                    DesignationsModel designationsModel = new DesignationsModel();

                    designationsModel.DesignationID = designation.DesignationID;
                    designationsModel.Name = designation.Name;

                    designationsModelList.Add(designationsModel);
                }
                return designationsModelList;
            }
        }

        public static List<string> GetDesignationsNameList()
        {
            List<string> designationsNameList = new List<string>();
            using (var db = new LibraryDBEntities())
            {
                var designationsList = db.Designations.ToList();
                foreach (var designation in designationsList)
                {
                    designationsNameList.Add(designation.Name);
                }
                return designationsNameList;
            }
        }

        public static void Add(Designations d)
        {
            using (var db = new LibraryDBEntities())
            {
                db.Designations.Add(d);
                db.SaveChanges();
            }
        }

        public static void Update(Designations d)
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
                var d = db.Designations.Find(id);

                db.Designations.Remove(d);

                db.SaveChanges();
            }
        }
    }
}
