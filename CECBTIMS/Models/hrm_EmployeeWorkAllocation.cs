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
    
    public partial class hrm_EmployeeWorkAllocation
    {
        public System.Guid EmployeeId { get; set; }
        public System.Guid WorkSpaceId { get; set; }
        public Nullable<System.Guid> ProjectRoleId { get; set; }
        public System.DateTime SheduledStartDate { get; set; }
        public System.DateTime SheduledEndDate { get; set; }
        public System.DateTime ActualStartDate { get; set; }
        public System.DateTime ActualEndDate { get; set; }
        public bool IsDutyResumed { get; set; }
        public bool IsActive { get; set; }
        public System.Guid BusinessUnitId { get; set; }
        public string BusinessUnitCode { get; set; }
        public System.Guid OrganizationId { get; set; }
        public string OrganizationCode { get; set; }
        public System.DateTime CreatedDateTime { get; set; }
        public System.Guid CreatedUserId { get; set; }
        public Nullable<System.DateTime> UpdatedDateTime { get; set; }
        public Nullable<System.Guid> UpdatedUserId { get; set; }
    
        public virtual cmn_Employee cmn_Employee { get; set; }
        public virtual cmn_WorkSpace cmn_WorkSpace { get; set; }
        public virtual hrm_ProjectRole hrm_ProjectRole { get; set; }
    }
}
