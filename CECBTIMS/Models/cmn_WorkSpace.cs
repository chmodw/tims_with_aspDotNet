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
    
    public partial class cmn_WorkSpace
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cmn_WorkSpace()
        {
            this.cmn_EmployeeVersion = new HashSet<cmn_EmployeeVersion>();
            this.cmn_WorkSpace1 = new HashSet<cmn_WorkSpace>();
        }
    
        public System.Guid WorkSpaceId { get; set; }
        public string WorkSpaceCode { get; set; }
        public string LocationName { get; set; }
        public string WorkSpaceName { get; set; }
        public System.Guid ParentWorkSpaceId { get; set; }
        public System.Guid WorkSpaceTypeId { get; set; }
        public bool IsActive { get; set; }
        public System.Guid BusinessUnitId { get; set; }
        public System.Guid OrganizationId { get; set; }
        public System.DateTime CreatedDateTime { get; set; }
        public System.Guid CreatedUserId { get; set; }
        public Nullable<System.DateTime> UpdatedDateTime { get; set; }
        public Nullable<System.Guid> UpdatedUserId { get; set; }
        public string Incharge { get; set; }
        public Nullable<System.Guid> LocationId { get; set; }
        public Nullable<System.Guid> PhysicalLocationId { get; set; }
        public string BusinessUnitCode { get; set; }
        public string OrganizationCode { get; set; }
        public string WorkSpaceAddress { get; set; }
        public string TelephoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public Nullable<System.Guid> HeadOftheWorkSpace { get; set; }
        public Nullable<System.Guid> AccountCodeGN4Id { get; set; }
        public System.Guid AccountCode { get; set; }
        public Nullable<System.Guid> WorkSpaceAccountant { get; set; }
        public string SWorkSpaceName { get; set; }
    
        public virtual cmn_Employee cmn_Employee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cmn_EmployeeVersion> cmn_EmployeeVersion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cmn_WorkSpace> cmn_WorkSpace1 { get; set; }
        public virtual cmn_WorkSpace cmn_WorkSpace2 { get; set; }
        public virtual cmn_WorkSpaceType cmn_WorkSpaceType { get; set; }
    }
}