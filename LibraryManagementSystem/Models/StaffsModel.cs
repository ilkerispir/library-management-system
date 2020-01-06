using LibraryManagementSystem.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    class StaffsModel
    {
        public int StaffID { get; set; }
        public int DesignationID { get; set; }
        public string Name { get; set; }
        public string TCNO { get; set; }
        public int Gender { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }

        public Designations Designations = new Designations();

        public string _Gender
        {
            get
            {
                if (Gender == 0)
                {
                    return "Erkek";
                }
                else if (Gender == 1)
                {
                    return "Kadın";
                }
                else
                {
                    return "Cinsiyet Belirtilmemiş";
                }
            }
        }
    }
}
