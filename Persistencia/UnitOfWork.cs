﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using Excepciones;

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
            catch (ExcepcionAlGuardarCambios ex)
            {
                throw new ExcepcionAlGuardarCambios("No se pudo guardar", ex);
            }
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



