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
    static class ProgramsHelper
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

        public static Programs GetById(int id)
        {
            using (var db = new LibraryDBEntities())
            {
                return db.Programs.Find(id);
            }
        }

        public static int GetByName(string name)
        {
            using (var db = new LibraryDBEntities())
            {
                var program = db.Programs.Where(x => x.Name == name).First();
                return program.ProgramID;
            }
        }

        public static string GetByNameFromID(int id)
        {
            using (var db = new LibraryDBEntities())
            {
                var program = db.Programs.Where(x => x.ProgramID == id).First();
                return program.Name;
            }
        }

        public static List<ProgramsModel> GetProgramsModelList()
        {
            List<ProgramsModel> programsModelList = new List<ProgramsModel>();
            using (var db = new LibraryDBEntities())
            {
                var programsList = db.Programs.ToList();
                foreach (var program in programsList)
                {
                    ProgramsModel programsModel = new ProgramsModel();

                    programsModel.ProgramID = program.ProgramID;
                    programsModel.Name = program.Name;

                    programsModelList.Add(programsModel);
                }
                return programsModelList;
            }
        }

        public static List<string> GetProgramsNameList()
        {
            List<string> programsNameList = new List<string>();
            using (var db = new LibraryDBEntities())
            {
                var programsList = db.Programs.ToList();
                foreach (var program in programsList)
                {
                    programsNameList.Add(program.Name);
                }
                return programsNameList;
            }
        }

        public static void Add(Programs p)
        {
            using (var db = new LibraryDBEntities())
            {
                db.Programs.Add(p);
                db.SaveChanges();
            }
        }

        public static void Update(Programs p)
        {
            using (var db = new LibraryDBEntities())
            {
                db.Entry(p).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public static void Delete(int id)
        {
            using (var db = new LibraryDBEntities())
            {
                var p = db.Programs.Find(id);

                db.Programs.Remove(p);

                db.SaveChanges();
            }
        }

        public static bool HaveProgramName(string name)
        {
            bool check = false;
            using (var db = new LibraryDBEntities())
            {
                foreach (var program in db.Programs.ToList())
                {
                    if (program.Name == name)
                    {
                        check = true;
                    }
                }
            }
            return check;
        }
    }

}
