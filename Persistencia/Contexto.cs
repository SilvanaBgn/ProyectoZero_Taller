using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Dominio;
using System.Data.Entity.Infrastructure.Annotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Persistencia
{
    /// <summary>
    /// Clase que define el contexto
    /// </summary>
    public class Contexto : DbContext
    {
        public DbSet<Campania> Campanias { get; }
        public DbSet<Banner> Banners { get; }
        public DbSet<Fuente> Fuentes { get; }

        public Contexto() : base("DataBase")
        {
            Database.SetInitializer<Contexto>(new DropCreateDatabaseIfModelChanges<Contexto>());
            var type = typeof(System.Data.Entity.SqlServer.SqlProviderServices);
            if (type == null)
                throw new Exception("Do not remove, ensures static reference to System.Data.Entity.SqlServer");
        }

        /// <summary>
        /// Especifica al Entity Framework como modelar la base de datos
        /// </summary>
        protected override void OnModelCreating(DbModelBuilder pModelBuilder)
        {
            base.OnModelCreating(pModelBuilder);
            pModelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // modelBuilder.Entity<Fuente>().HasOptional(c => c.Items).WithOptionalDependent().WillCascadeOnDelete(true);

            pModelBuilder.Entity<Item>()
            .HasRequired<Fuente>(s => s.Fuente)
            .WithMany(i => i.Items)
            .WillCascadeOnDelete(true);

            pModelBuilder.Entity<Imagen>()
            .HasRequired<Campania>(s => s.Campania)
            .WithMany(i => i.Imagenes)
            .WillCascadeOnDelete(true);

            pModelBuilder.Entity<Banner>()
            .HasRequired<Fuente>(s => s.Fuente)
            .WithMany(i => i.Banners)
            .WillCascadeOnDelete(true);

    //        pModelBuilder
    //.Entity<Fuente>()
    //.Property(t => t.origenItems)
    //.HasColumnAnnotation(
    //    "Index",
    //    new IndexAnnotation(new[]
    //        {
    //            new IndexAttribute("Index1"),
    //            new IndexAttribute("Index2") { IsUnique = true }
    //        }));
        }
    }
}
