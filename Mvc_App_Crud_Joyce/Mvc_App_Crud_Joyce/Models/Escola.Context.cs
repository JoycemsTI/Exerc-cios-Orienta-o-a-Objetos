//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mvc_App_Crud_Joyce.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EscolaEntities : DbContext
    {
        public EscolaEntities()
            : base("name=EscolaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Aluno> Alunoes { get; set; }
        public virtual DbSet<Assunto> Assuntoes { get; set; }
        public virtual DbSet<Departamento> Departamentoes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
