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
    
    public partial class cmn_WorkSpaceType
    {
        public System.Guid WorkSpaceTypeId { get; set; }
        public string WorkSpaceTypeName { get; set; }
        public bool IsActive { get; set; }
        public System.Guid BusinessUnitId { get; set; }
        public System.Guid OrganizationId { get; set; }
        public System.DateTime CreatedDateTime { get; set; }
        public System.Guid CreatedUserId { get; set; }
        public Nullable<System.DateTime> UpdatedDateTime { get; set; }
        public Nullable<System.Guid> UpdatedUserId { get; set; }
    }
}
