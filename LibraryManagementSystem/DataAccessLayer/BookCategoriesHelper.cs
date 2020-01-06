using LibraryManagementSystem.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DataAccessLayer
{
    class BookCategoriesHelper
    {
        public static void Add(BookCategories bc)
        {
            using (var db = new LibraryDBEntities())
            {
                db.BookCategories.Add(bc);
                db.SaveChanges();
            }
        }

        public static int GetByName(string name)
        {
            using (var db = new LibraryDBEntities())
            {
                var bookCategory = db.BookCategories.Where(x => x.Name == name).First();
                return bookCategory.BookCategoryID;
            }
        }

        public static string GetByNameFromID(int id)
        {
            using (var db = new LibraryDBEntities())
            {
                var booksCategory = db.BookCategories.Where(x => x.BookCategoryID == id).First();
                return booksCategory.Name;
            }
        }

        public static List<BookCategories> GetBookCategoriesList()
        {
            using (var db = new LibraryDBEntities())
            {
                return db.BookCategories.ToList();
            }
        }

        public static List<string> GetBookCategoriesNameList()
        {
            List<string> bookCategoriesList = new List<string>();
            using (var db = new LibraryDBEntities())
            {
                var bookCategories = db.BookCategories.ToList();
                foreach (var bookCategory in bookCategories)
                {
                    bookCategoriesList.Add(bookCategory.Name);
                }
                return bookCategoriesList;
            }
        }
    }
}
