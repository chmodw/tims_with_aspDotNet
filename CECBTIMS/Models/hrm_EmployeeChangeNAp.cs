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
    
    public partial class hrm_EmployeeChangeNAp
    {
        public System.Guid ChangeNApId { get; set; }
        public System.Guid EmployeeVersionId { get; set; }
        public string NewNAp { get; set; }
        public System.DateTime EffectiveDate { get; set; }
        public string Reference { get; set; }
        public bool IsActive { get; set; }
        public System.Guid OrganizationId { get; set; }
        public System.Guid BusinessUnitId { get; set; }
        public System.Guid WorkSpaceId { get; set; }
        public System.DateTime CreatedDateTime { get; set; }
        public System.Guid CreatedUserId { get; set; }
        public Nullable<System.DateTime> UpdatedDateTime { get; set; }
        public Nullable<System.Guid> UpdatedUserId { get; set; }
        public string EPFNo { get; set; }
        public string OldEPFNo { get; set; }
        public string TypeOfContract { get; set; }
        public bool IsCancel { get; set; }
    
        public virtual cmn_EmployeeVersion cmn_EmployeeVersion { get; set; }
    }
}
