﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class demoEntities : DbContext
    {
        public demoEntities()
            : base("name=demoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<STUDENT_CGA_MS_SUB> STUDENT_CGA_MS_SUB { get; set; }
        public virtual DbSet<STUDENT_CGA_MV_SUB> STUDENT_CGA_MV_SUB { get; set; }
        public virtual DbSet<STUDENT_NF_SUB> STUDENT_NF_SUB { get; set; }
    }
}
