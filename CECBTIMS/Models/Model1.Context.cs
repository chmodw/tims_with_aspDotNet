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
        public CECB_ERPEntities() : base("name=CECB_ERPEntities")
        {
            // Disable Writing to the ERP Database
            Database.SetInitializer<CECB_ERPEntities>(null);
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();

        }
    
        public virtual DbSet<cmn_Employee> cmn_Employee { get; set; }
        public virtual DbSet<cmn_EmployeeVersion> cmn_EmployeeVersion { get; set; }
        public virtual DbSet<cmn_WorkSpace> cmn_WorkSpace { get; set; }
        public virtual DbSet<cmn_WorkSpaceType> cmn_WorkSpaceType { get; set; }
        public virtual DbSet<hrm_Designation> hrm_Designation { get; set; }
        public virtual DbSet<hrm_DesignationCategory> hrm_DesignationCategory { get; set; }
        public virtual DbSet<hrm_EducationClass> hrm_EducationClass { get; set; }
        public virtual DbSet<hrm_EducationLevel> hrm_EducationLevel { get; set; }
        public virtual DbSet<hrm_EducationQualification> hrm_EducationQualification { get; set; }
        public virtual DbSet<hrm_EducationSpecialization> hrm_EducationSpecialization { get; set; }
        public virtual DbSet<hrm_EmployeeChangeNAp> hrm_EmployeeChangeNAp { get; set; }
        public virtual DbSet<hrm_EmployeeEducationalQualifications> hrm_EmployeeEducationalQualifications { get; set; }
        public virtual DbSet<hrm_EmployeeExtension> hrm_EmployeeExtension { get; set; }
        public virtual DbSet<hrm_EmployeePosts> hrm_EmployeePosts { get; set; }
        public virtual DbSet<hrm_EmployeeProfessionalQualifications> hrm_EmployeeProfessionalQualifications { get; set; }
        public virtual DbSet<hrm_EmployeePromotion> hrm_EmployeePromotion { get; set; }
        public virtual DbSet<hrm_EmployeeReinstatement> hrm_EmployeeReinstatement { get; set; }
        public virtual DbSet<hrm_EmployeeRenewal> hrm_EmployeeRenewal { get; set; }
        public virtual DbSet<hrm_EmployeeReportingAfterLeave> hrm_EmployeeReportingAfterLeave { get; set; }
        public virtual DbSet<hrm_EmployeeTransfer> hrm_EmployeeTransfer { get; set; }
        public virtual DbSet<hrm_EmployeeWorkAllocation> hrm_EmployeeWorkAllocation { get; set; }
        public virtual DbSet<hrm_EmployeeWorkingExperience> hrm_EmployeeWorkingExperience { get; set; }
        public virtual DbSet<hrm_Grade> hrm_Grade { get; set; }
        public virtual DbSet<hrm_Institute> hrm_Institute { get; set; }
        public virtual DbSet<hrm_Post> hrm_Post { get; set; }
        public virtual DbSet<hrm_ProjectRole> hrm_ProjectRole { get; set; }
    }
}
