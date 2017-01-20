using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Persistencia
{
    public class UnitOfWork : IUnitOfWork
    {
        private Contexto iContexto = new Contexto();
        private Repositorio<Campania> repoCampanias;
        private Repositorio<Banner> repoBanners;
        private Repositorio<Fuente> repoFuentes;

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

        public void GuardarCambios()
        {
            iContexto.SaveChanges();
        }

        public void Rollback()
        {
            iContexto.ChangeTracker.Entries()
              .ToList()
              .ForEach(entry => entry.State = EntityState.Unchanged);
        }

    }
}



       