﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HealthBDContainer : DbContext
    {
        public HealthBDContainer()
            : base("name=HealthBDContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Medico> Medicos { get; set; }
        public virtual DbSet<Proficiencia> Proficiencias { get; set; }
        public virtual DbSet<Utente> Utentes { get; set; }
        public virtual DbSet<Consulta> Consultas { get; set; }
        public virtual DbSet<HelpDesk> HelpDesks { get; set; }
        public virtual DbSet<LogIn> LogIns { get; set; }
    }
}
