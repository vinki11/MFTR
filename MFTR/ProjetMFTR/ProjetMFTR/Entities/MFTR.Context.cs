﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetMFTR.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MFTR : DbContext
    {
        public MFTR()
            : base("name=MFTR")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Adresse> Adresse { get; set; }
        public virtual DbSet<Adultes> Adultes { get; set; }
        public virtual DbSet<Communication> Communication { get; set; }
        public virtual DbSet<Dossier> Dossier { get; set; }
        public virtual DbSet<Enfants> Enfants { get; set; }
        public virtual DbSet<LienReferrent> LienReferrent { get; set; }
        public virtual DbSet<Parent> Parent { get; set; }
        public virtual DbSet<Referent> Referent { get; set; }
        public virtual DbSet<Services> Services { get; set; }
        public virtual DbSet<Suivi> Suivi { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Telephone> Telephone { get; set; }
        public virtual DbSet<Transporteur> Transporteur { get; set; }
        public virtual DbSet<new_table> new_table { get; set; }
        public virtual DbSet<Intervenant> Intervenant { get; set; }
        public virtual DbSet<Options> Options { get; set; }
    }
}
