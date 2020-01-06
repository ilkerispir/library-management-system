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
    static class SessionsHelper
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

        public static Sessions GetById(int id)
        {
            using (var db = new LibraryDBEntities())
            {
                return db.Sessions.Find(id);
            }
        }

        public static string GetByNameFromID(int id)
        {
            using (var db = new LibraryDBEntities())
            {
                var session = db.Sessions.Where(x => x.SessionID == id).First();
                return session.Name;
            }
        }

        public static int GetByName(string name)
        {
            using (var db = new LibraryDBEntities())
            {
                var session = db.Sessions.Where(x => x.Name == name).First();
                return session.SessionID;
            }
        }

        public static List<StudentsModel> GetSessionsModelList()
        {
            List<StudentsModel> sessionsModelList = new List<StudentsModel>();
            using (var db = new LibraryDBEntities())
            {
                var sessionsList = db.Sessions.ToList();
                foreach (var session in sessionsList)
                {
                    StudentsModel sessionModel = new StudentsModel();

                    sessionModel.SessionID = session.SessionID;
                    sessionModel.Name = session.Name;
                    sessionModel.StartDate = session.StartDate;
                    sessionModel.EndDate = session.EndDate;

                    sessionsModelList.Add(sessionModel);
                }
                return sessionsModelList;
            }
        }

        public static List<string> GetSessionsNameList()
        {
            List<string> sessionsNameList = new List<string>();
            using (var db = new LibraryDBEntities())
            {
                var sessionsList = db.Sessions.ToList();
                foreach (var session in sessionsList)
                {
                    sessionsNameList.Add(session.Name);
                }
                return sessionsNameList;
            }
        }

        public static void Add(Sessions s)
        {
            using (var db = new LibraryDBEntities())
            {
                db.Sessions.Add(s);
                db.SaveChanges();
            }
        }

        public static void Delete(int id)
        {
            using (var db = new LibraryDBEntities())
            {
                var s = db.Sessions.Find(id);

                db.Sessions.Remove(s);

                db.SaveChanges();
            }
        }

        public static void Update(Sessions s)
        {
            using (var db = new LibraryDBEntities())
            {
                db.Entry(s).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public static bool HaveSessionName(string name)
        {
            bool check = false;
            using (var db = new LibraryDBEntities())
            {
                foreach (var session in db.Sessions.ToList())
                {
                    if (session.Name == name)
                    {
                        check = true;
                    }
                }
            }
            return check;
        }
    }
}
