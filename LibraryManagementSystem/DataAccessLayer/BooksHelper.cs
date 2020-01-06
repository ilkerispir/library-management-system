using LibraryManagementSystem.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DataAccessLayer
{
    class BooksHelper
    {
        public static void Add(Books b)
        {
            using (var db = new LibraryDBEntities())
            {
                db.Books.Add(b);
                db.SaveChanges();
            }
        }

        public static string GetBookNameByID(int id)
        {
            string name = "";
            using (var db = new LibraryDBEntities())
            {
                foreach (var book in db.Books.ToList())
                {
                    if (book.BookID == id)
                    {
                        name = book.BookName;
                    }
                }
            }
            return name;
        }

        public static List<Books> GetBooksList()
        {
            using (var db = new LibraryDBEntities())
            {
                return db.Books.ToList();
            }
        }

        public static Books GetBookByID(int id)
        {
            using (var db = new LibraryDBEntities())
            {
                return db.Books.Find(id);
            }
        }

        public static void Update(Books b)
        {
            using (var db = new LibraryDBEntities())
            {
                db.Entry(b).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public static bool HaveBook(string bookName, string author, string edition)
        {
            bool check = false;
            using (var db = new LibraryDBEntities())
            {
                foreach (var book in db.Books.ToList())
                {
                    if (book.BookName == bookName && book.Author == author && book.Edition == edition)
                    {
                        check = true;
                    }
                }
            }
            return check;
        }

        public static Books GetById(int id)
        {
            using (var db = new LibraryDBEntities())
            {
                return db.Books.Find(id);
            }
        }
    }
}
