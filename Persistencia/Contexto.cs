using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Dominio;


namespace Persistencia
{
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // modelBuilder.Entity<Fuente>().HasOptional(c => c.Items).WithOptionalDependent().WillCascadeOnDelete(true);

            modelBuilder.Entity<Item>()
            .HasOptional<Fuente>(s => s.Fuente)
            .WithMany(i => i.Items)
            .WillCascadeOnDelete(true);

            modelBuilder.Entity<Imagen>()
            .HasOptional<Campania>(s => s.Campania)
            .WithMany(i => i.Imagenes)
            .WillCascadeOnDelete(true);

            modelBuilder.Entity<Banner>()
            .HasOptional<Fuente>(s => s.Fuente)
            .WithMany(i => i.Banners)
            .WillCascadeOnDelete(true);

            //modelBuilder.Entity<Campania>().ToTable("Campania");
            //modelBuilder.Entity<Imagen>().ToTable("Imagen");


            //HACER DELETEs EN CASCADA
            //modelBuilder.Entity<Campania>()
        }
    }
}
