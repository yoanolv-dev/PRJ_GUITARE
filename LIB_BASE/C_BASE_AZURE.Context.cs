//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LIB_BASE
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class C_BASE_AZURE : DbContext
    {
        public C_BASE_AZURE()
            : base("name=C_BASE_AZURE")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C_BOIS> Les_Bois { get; set; }
        public virtual DbSet<C_CLIENT> Les_Clients { get; set; }
        public virtual DbSet<C_GUITARE> Les_Guitares { get; set; }
        public virtual DbSet<C_MICRO> Les_Micros { get; set; }
        public virtual DbSet<C_VIBRATO> Les_Vibratos { get; set; }
    }
}
