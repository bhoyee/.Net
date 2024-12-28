//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentInformationSystem.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class PROGRAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROGRAM()
        {
            this.ASSESSMENTs = new HashSet<ASSESSMENT>();
            this.COURSE_ENROLLMENT = new HashSet<COURSE_ENROLLMENT>();
            this.MODULEs = new HashSet<MODULE>();
        }
    
        public int Id { get; set; }
        public string Title { get; set; }
        public string Duration { get; set; }
        public int CohortID { get; set; }
        public bool isDeleted { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public Nullable<int> NumberofModule { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ASSESSMENT> ASSESSMENTs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COURSE_ENROLLMENT> COURSE_ENROLLMENT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MODULE> MODULEs { get; set; }
    }
}
