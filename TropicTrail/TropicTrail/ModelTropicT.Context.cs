﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TropicTrail
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TropicTEntities : DbContext
    {
        public TropicTEntities()
            : base("name=TropicTEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Offers> Offers { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<TourType> TourType { get; set; }
        public DbSet<UserAccount> UserAccount { get; set; }
        public DbSet<vw_role> vw_role { get; set; }
    }
}
