﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ofis2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OfisDBEntities : DbContext
    {
        public OfisDBEntities()
            : base("name=OfisDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Demirba> Demirbas { get; set; }
        public virtual DbSet<Gider> Giders { get; set; }
        public virtual DbSet<Kullanici> Kullanicis { get; set; }
        public virtual DbSet<OfisTakvimi> OfisTakvimis { get; set; }
        public virtual DbSet<Projeler> Projelers { get; set; }
        public virtual DbSet<Stajyer> Stajyers { get; set; }
        public virtual DbSet<StajyerProjeleri> StajyerProjeleris { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
