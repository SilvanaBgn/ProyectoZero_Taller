using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public interface IUnitOfWork
    {
        IRepositorio<Campania> RepositorioCampanias { get; }
        IRepositorio<Banner> RepositorioBanners { get; }
        IRepositorio<Fuente> RepositorioFuentes { get; }

        /// <summary>
        /// Commit sobre la base de datos. Si hay un problema de concurrencia lanzará una excepción
        /// </summary>
        void GuardarCambios();
        
        /// <summary>
        /// Rollback de los cambios que se han producido en la Unit of Work y que están siendo observados por ella
        /// </summary>
        void Rollback();
    }
}
