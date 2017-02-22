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
using System.Data.Entity.Validation;

namespace Persistencia
{
    /// <summary>
    /// Esta clase contiene los métodos encargados de la interacción con la base de datos
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        private Contexto iContexto = new Contexto();
        private Repositorio<Campania> iRepoCampanias;
        private Repositorio<Banner> iRepoBanners;
        private Repositorio<Fuente> iRepoFuentes;

        /// <summary>
        /// Si no existe el repositorio campania lo crea
        /// </summary>
        public IRepositorio<Campania> RepositorioCampanias
        {
            get
            {
                if (this.iRepoCampanias == null)
                {
                    this.iRepoCampanias = new Repositorio<Campania>(this.iContexto);
                }
                return this.iRepoCampanias;
            }
        }

        /// <summary>
        /// Si no existe el repositorio banner lo crea
        /// </summary>
        public IRepositorio<Banner> RepositorioBanners
        {
            get
            {
                if (this.iRepoBanners == null)
                {
                    this.iRepoBanners = new Repositorio<Banner>(this.iContexto);
                }
                return this.iRepoBanners;
            }
        }

        /// <summary>
        /// Si no existe el repositorio fuente lo crea
        /// </summary>
        public IRepositorio<Fuente> RepositorioFuentes
        {
            get
            {
                if (this.iRepoFuentes == null)
                {
                    this.iRepoFuentes = new Repositorio<Fuente>(this.iContexto);
                }
                return this.iRepoFuentes;
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
            //catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            //{
            //    Exception raise = dbEx;
            //    foreach (var validationErrors in dbEx.EntityValidationErrors)
            //    {
            //        foreach (var validationError in validationErrors.ValidationErrors)
            //        {
            //            string message = string.Format("{0}:{1}",
            //                validationErrors.Entry.Entity.ToString(),
            //                validationError.ErrorMessage);
            //            // raise a new exception nesting
            //            // the current instance as InnerException
            //            raise = new InvalidOperationException(message, raise);
            //        }
            //    }
            //    throw raise;
            //}
            catch (DbUpdateException)
            { throw new ExcepcionValidacionBBDD(); }
        }






        /// <summary>
        /// Vuelve a la base de datos a un estado previo
        /// </summary>
        public void Rollback()
        {
            this.iContexto.ChangeTracker.Entries()
              .ToList()
              .ForEach(entry => entry.State = EntityState.Unchanged);
        }

    }
}



