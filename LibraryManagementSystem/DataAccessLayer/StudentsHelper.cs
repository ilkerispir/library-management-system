using LibraryManagementSystem.EntityFramework;
using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DataAccessLayer
{
    class StudentsHelper
    {
        public static void Add(Students s)
        {
            using (var db = new LibraryDBEntities())
            {
                db.Students.Add(s);

                db.SaveChanges();
            }
        }

        public static List<Students> GetStudentsList()
        {
            using (var db = new LibraryDBEntities())
            {
                return db.Students.ToList();
            }
        }

        public static List<Students> GetActiveStudentsList()
        {
            List<Students> activeStudents = new List<Students>();
            using (var db = new LibraryDBEntities())
            {
                foreach (var student in db.Students.ToList())
                {
                    if (student.Status == 1)
                    {
                        activeStudents.Add(student);
                    }
                }
                
            }
            return activeStudents;
        }

        public static Students GetStudentByID(int id)
        {
            using (var db = new LibraryDBEntities())
            {
                return db.Students.Find(id);
            }
        }

        public static bool HaveTCNO(string TCNO)
        {
            bool check = false;
            using (var db = new LibraryDBEntities())
            {
                foreach (var student in db.Students.ToList())
                {
                    if (student.TCNO == TCNO)
                    {
                        check = true;
                    }
                }
            }
            return check;
        }

        public static bool HaveTCNO(string TCNO, int id)
        {
            bool check = false;
            using (var db = new LibraryDBEntities())
            {
                foreach (var student in db.Students.ToList())
                {
                    if (student.TCNO == TCNO && student.StudentID != id)
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
                foreach (var student in db.Students.ToList())
                {
                    if (student.ContactNo == contactNo)
                    {
                        check = true;
                    }
                }
            }
            return check;
        }

        public static bool HaveContactNo(string contactNo, int id)
        {
            bool check = false;
            using (var db = new LibraryDBEntities())
            {
                foreach (var student in db.Students.ToList())
                {
                    if (student.ContactNo == contactNo && student.StudentID != id)
                    {
                        check = true;
                    }
                }
            }
            return check;
        }

        public static bool HaveEnrollNo(string enrollNo)
        {
            bool check = false;
            using (var db = new LibraryDBEntities())
            {
                foreach (var student in db.Students.ToList())
                {
                    if (student.EnrollNo == enrollNo)
                    {
                        check = true;
                    }
                }
            }
            return check;
        }

        public static bool HaveEnrollNo(string enrollNo, int id)
        {
            bool check = false;
            using (var db = new LibraryDBEntities())
            {
                foreach (var student in db.Students.ToList())
                {
                    if (student.EnrollNo == enrollNo && student.StudentID != id)
                    {
                        check = true;
                    }
                }
            }
            return check;
        }

        public static void Delete(int id)
        {
            using (var db = new LibraryDBEntities())
            {
                var s = db.Students.Find(id);

                db.Students.Remove(s);

                db.SaveChanges();
            }
        }

        public static Students GetById(int id)
        {
            using (var db = new LibraryDBEntities())
            {
                return db.Students.Find(id);
            }
        }

        public static void Update(Students s)
        {
            using (var db = new LibraryDBEntities())
            {
                db.Entry(s).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
