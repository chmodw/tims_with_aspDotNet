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
    
    public partial class hrm_EmployeeProfessionalQualifications
    {
        public System.Guid ProfessionalQualificationId { get; set; }
        public System.Guid EmployeeVersionId { get; set; }
        public System.Guid QualificationsTypeId { get; set; }
        public System.Guid InstituteId { get; set; }
        public System.DateTime EffectiveDate { get; set; }
        public string MembershipNo { get; set; }
        public string Remarks { get; set; }
        public Nullable<System.Guid> OrganizationId { get; set; }
        public Nullable<System.Guid> BusinessUnitId { get; set; }
        public Nullable<System.Guid> WorkSpaceId { get; set; }
        public Nullable<System.DateTime> CreatedDateTime { get; set; }
        public Nullable<System.Guid> CreatedUserId { get; set; }
        public Nullable<System.DateTime> UpdatedDateTime { get; set; }
        public Nullable<System.Guid> UpdatedUserId { get; set; }
    
        public virtual cmn_EmployeeVersion cmn_EmployeeVersion { get; set; }
        public virtual hrm_EducationQualification hrm_EducationQualification { get; set; }
        public virtual hrm_Institute hrm_Institute { get; set; }
    }
}
