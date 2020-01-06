using LibraryManagementSystem.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DataAccessLayer
{
    class UsersHelper
    {
        public static void Add(Users u)
        {
            using (var db = new LibraryDBEntities())
            {
                db.Users.Add(u);
                db.SaveChanges();
            }
        }

        public static (bool,int) Login(string userName, string password)
        {
            using (var db = new LibraryDBEntities())
            {
                var id = db.Users.FirstOrDefault(x => x.UserName == userName && x.Password == password);
               
                if(id != null)
                {
                    return (true,id.StaffID);
                }
                else
                {
                    return (false, 0);
                }
            }
        }

        public static Users GetByStaffID(int staffID)
        {
            using (var db = new LibraryDBEntities())
            {
                var users = db.Users.Where(x => x.StaffID == staffID).First();
                return users;
            }
        }

        public static void Update(Users u)
        {
            using (var db = new LibraryDBEntities())
            {
                db.Entry(u).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public static bool HaveUserID(string userName)
        {
            bool check = false;
            using (var db = new LibraryDBEntities())
            {
                foreach (var user in db.Users.ToList())
                {
                    if (user.UserName.ToLower() == userName)
                    {
                        check = true;
                    }
                }
            }
            return check;
        }

        public static bool HaveUserID(string userName, int id)
        {
            bool check = false;
            using (var db = new LibraryDBEntities())
            {
                foreach (var user in db.Users.ToList())
                {
                    if (user.UserName.ToLower() == userName && user.UserID != id)
                    {
                        check = true;
                    }
                }
            }
            return check;
        }

        public static int GetUserIDbyName(string name)
        {
            using (var db = new LibraryDBEntities())
            {
                var user = db.Users.Where(x => x.UserName == name).First();
                return user.UserID;
            }
        }
    }
}
