using LibraryManagementSystem.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DataAccessLayer
{
    class FinesHelper
    {
        public static void Add(Fines f)
        {
            using (var db = new LibraryDBEntities())
            {
                db.Fines.Add(f);
                db.SaveChanges();
            }
        }


        public static int GetFineCount(int StudentID)
        {
            int count = 0;
            using (var db = new LibraryDBEntities())
            {
                var totalFines = db.Fines.ToList();
                foreach (var fine in totalFines)
                {
                    if (fine.StudentID == StudentID && fine.Status == 1)
                    {
                        count++;
                    }
                }
                return count;
            }
        }

        public static List<Fines> GetFinesList()
        {
            using (var db = new LibraryDBEntities())
            {
                return db.Fines.ToList();
            }
        }

        public static List<Fines> GetActiveFinesList()
        {
            List<Fines> activeFineList = new List<Fines>();
            using (var db = new LibraryDBEntities())
            {
                foreach (var fine in db.Fines.ToList())
                {
                    if (fine.Status == 1)
                    {
                        activeFineList.Add(fine);
                    }
                }
            }
            return activeFineList;
        }

        public static Fines GetFinesByID(int id)
        {
            using (var db = new LibraryDBEntities())
            {
                return db.Fines.Find(id);
            }
        }

        public static void Update(Fines f)
        {
            using (var db = new LibraryDBEntities())
            {
                db.Entry(f).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
