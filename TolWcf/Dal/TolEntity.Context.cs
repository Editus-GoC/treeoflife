﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tol.Dal
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TOLEntities : DbContext
    {
        public TOLEntities()
            : base("name=TOLEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AVATAR> AVATAR { get; set; }
        public virtual DbSet<BUBBLE> BUBBLE { get; set; }
        public virtual DbSet<ITEM> ITEM { get; set; }
        public virtual DbSet<LINK_ITEM_FILTER> LINK_ITEM_FILTER { get; set; }
        public virtual DbSet<PROFIL> PROFIL { get; set; }
        public virtual DbSet<TIME> TIME { get; set; }
        public virtual DbSet<STAT> STAT { get; set; }
        public virtual DbSet<FILTER> FILTER { get; set; }
    }
}