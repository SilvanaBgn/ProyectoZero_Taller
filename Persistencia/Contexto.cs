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
        public DbSet<FuenteInformacion> Fuentes { get; }

        public Contexto() : base("DataBase")
        {
            //Database.SetInitializer<Contexto>(new DropCreateDatabaseIfModelChanges<Contexto>());
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

            //Establece la navegabilidad entre las clases
            pModelBuilder.Entity<Campania>()
            .HasMany(o => o.Imagenes)
            .WithOptional()
            .HasForeignKey(oi => oi.CampaniaId);

            pModelBuilder.Entity<FuenteInformacion>()
            .HasMany(o => o.Banners)
            .WithRequired()
            .HasForeignKey(oi => oi.FuenteId);

            pModelBuilder.Entity<FuenteInformacion>()
            .HasMany(o => o.Items)
            .WithOptional()
            .HasForeignKey(oi => oi.FuenteId);

            //Establece las claves foráneas
            pModelBuilder.Entity<Imagen>()
            .HasKey(oi => new { oi.ImagenId, oi.CampaniaId })
            .Property(oi => oi.ImagenId)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            pModelBuilder.Entity<ItemFuenteInformacion>()
            .HasKey(oi => new { oi.ItemId, oi.FuenteId })
            .Property(oi => oi.ItemId)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
