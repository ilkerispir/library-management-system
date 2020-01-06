using LibraryManagementSystem.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DataAccessLayer
{
    class ReturnBooksHelper
    {
        public static void Add(ReturnBooks rb)
        {
            using (var db = new LibraryDBEntities())
            {
                db.ReturnBooks.Add(rb);
                db.SaveChanges();
            }
        }
    }
}
