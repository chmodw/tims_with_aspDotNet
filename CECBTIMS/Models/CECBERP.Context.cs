﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CECB_ERPEntities : DbContext
    {
        public CECB_ERPEntities()
            : base("name=CECB_ERPEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<cmn_Employee> cmn_Employee { get; set; }
        public virtual DbSet<cmn_EmployeeVersion> cmn_EmployeeVersion { get; set; }
        public virtual DbSet<cmn_WorkSpace> cmn_WorkSpace { get; set; }
        public virtual DbSet<cmn_WorkSpaceHistory> cmn_WorkSpaceHistory { get; set; }
        public virtual DbSet<cmn_WorkSpaceType> cmn_WorkSpaceType { get; set; }
        public virtual DbSet<hrm_Designation> hrm_Designation { get; set; }
        public virtual DbSet<hrm_DesignationCategory> hrm_DesignationCategory { get; set; }
        public virtual DbSet<hrm_DesignationGroup> hrm_DesignationGroup { get; set; }
        public virtual DbSet<hrm_EducationLevel> hrm_EducationLevel { get; set; }
        public virtual DbSet<hrm_Grade> hrm_Grade { get; set; }
        public virtual DbSet<hrm_Institute> hrm_Institute { get; set; }

        public System.Data.Entity.DbSet<CECBTIMS.Models.Employee> Employees { get; set; }
    }
}
