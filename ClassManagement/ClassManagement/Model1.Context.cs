﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassManagement
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class StepSchedulerEntities1 : DbContext
    {
        public StepSchedulerEntities1()
            : base("name=StepSchedulerEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ClassRoom> ClassRooms { get; set; }
        public virtual DbSet<Request> Requests { get; set; }
        public virtual DbSet<ReservedRoom> ReservedRooms { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
