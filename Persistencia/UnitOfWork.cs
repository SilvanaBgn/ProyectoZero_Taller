using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.Entity.Infrastructure;
using Excepciones.ExcepcionesIntermedias;

namespace Persistencia
{
    /// <summary>
    /// Esta clase contiene los métodos encargados de la interacción con la base de datos
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        private Contexto iContexto = new Contexto();
        private Repositorio<Campania> repoCampanias;
        private Repositorio<Banner> repoBanners;
        private Repositorio<Fuente> repoFuentes;

        /// <summary>
        /// Si no existe el repositorio campania lo crea
        /// </summary>
        public IRepositorio<Campania> RepositorioCampanias
        {
            get
            {
                if (repoCampanias == null)
                {
                    this.repoCampanias = new Repositorio<Campania>(iContexto);
                }
                return repoCampanias;
            }
        }

        /// <summary>
        /// Si no existe el repositorio banner lo crea
        /// </summary>
        public IRepositorio<Banner> RepositorioBanners
        {
            get
            {
                if (repoBanners == null)
                {
                    this.repoBanners = new Repositorio<Banner>(iContexto);
                }
                return repoBanners;
            }
        }

        /// <summary>
        /// Si no existe el repositorio fuente lo crea
        /// </summary>
        public IRepositorio<Fuente> RepositorioFuentes
        {
            get
            {
                if (repoFuentes == null)
                {
                    this.repoFuentes = new Repositorio<Fuente>(iContexto);
                }
                return repoFuentes;
            }
        }

        /// <summary>
        /// Guarda los cambios en la base de datos
        /// </summary>
        public void GuardarCambios()
        {
            try
            {
                iContexto.SaveChanges();
            }
            catch (DbUpdateException)
            { throw new ExcepcionValidacionBBDD(); }
        }

        /// <summary>
        /// Vuelve a la base de datos a un estado previo
        /// </summary>
        public void Rollback()
        {
            iContexto.ChangeTracker.Entries()
              .ToList()
              .ForEach(entry => entry.State = EntityState.Unchanged);
        }

    }
}



