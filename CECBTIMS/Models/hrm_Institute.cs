//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CECBTIMS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class hrm_Institute
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public hrm_Institute()
        {
            this.hrm_EmployeeEducationalQualifications = new HashSet<hrm_EmployeeEducationalQualifications>();
            this.hrm_EmployeeProfessionalQualifications = new HashSet<hrm_EmployeeProfessionalQualifications>();
        }
    
        public System.Guid InstituteId { get; set; }
        public string InstituteName { get; set; }
        public System.DateTime CreatedDateTime { get; set; }
        public System.Guid CreatedUserId { get; set; }
        public System.Guid OrganizationId { get; set; }
        public System.Guid BusinessUnitId { get; set; }
        public Nullable<System.DateTime> UpdatedDateTime { get; set; }
        public Nullable<System.Guid> UpdatedUserId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hrm_EmployeeEducationalQualifications> hrm_EmployeeEducationalQualifications { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hrm_EmployeeProfessionalQualifications> hrm_EmployeeProfessionalQualifications { get; set; }
    }
}
