//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryManagementSystem.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Students
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Students()
        {
            this.IssueBooks = new HashSet<IssueBooks>();
            this.ReturnBooks = new HashSet<ReturnBooks>();
            this.Fines = new HashSet<Fines>();
        }
    
        public int StudentID { get; set; }
        public int SessionID { get; set; }
        public int DepartmentID { get; set; }
        public int ProgramID { get; set; }
        public int StaffID { get; set; }
        public string Name { get; set; }
        public string TCNO { get; set; }
        public int Status { get; set; }
        public int Gender { get; set; }
        public string EnrollNo { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public System.DateTime RegisterDate { get; set; }
    
        public virtual Departments Departments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IssueBooks> IssueBooks { get; set; }
        public virtual Programs Programs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReturnBooks> ReturnBooks { get; set; }
        public virtual Sessions Sessions { get; set; }
        public virtual Staffs Staffs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fines> Fines { get; set; }
    }
}
