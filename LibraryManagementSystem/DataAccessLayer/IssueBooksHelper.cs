using LibraryManagementSystem.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DataAccessLayer
{
    class IssueBooksHelper
    {
        public static void Add(IssueBooks ib)
        {
            using (var db = new LibraryDBEntities())
            {
                db.IssueBooks.Add(ib);
                db.SaveChanges();
            }
        }

        public static List<IssueBooks> GetIssueBookListFromStudentID(int id)
        {
            List<IssueBooks> issueBookList = new List<IssueBooks>();
            using (var db = new LibraryDBEntities())
            {
                var totalIssueBooks = db.IssueBooks.ToList();
                foreach (var issueBook in totalIssueBooks)
                {
                    if (issueBook.StudentID == id && issueBook.Status == 1)
                    {
                        issueBookList.Add(issueBook);
                    } 
                }
                return issueBookList;
            }
        }

        public static bool GetHaveBooks(int StudentID, int BookID)
        {
            bool check = false;
            using (var db = new LibraryDBEntities())
            {
                var totalIssueBooks = db.IssueBooks.ToList();
                foreach (var issueBook in totalIssueBooks)
                {
                    if (issueBook.StudentID == StudentID && issueBook.BookID == BookID && issueBook.Status == 1)
                    {
                        check = true; 
                    }
                }               
            }
            return check;
        }

        public static IssueBooks GetIssueBookByID(int id)
        {
            using (var db = new LibraryDBEntities())
            {
                return db.IssueBooks.Find(id);
            }
        }

        public static void Update(IssueBooks ib)
        {
            using (var db = new LibraryDBEntities())
            {
                db.Entry(ib).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }


    }
}
