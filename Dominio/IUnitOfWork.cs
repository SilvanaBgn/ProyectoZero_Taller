using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    /// <summary>
    /// Iterface que se encarga de la conección con la base de datos
    /// </summary>
    public interface IUnitOfWork
    {
        /// <summary>
        /// Repositorio de las campañas
        /// </summary>
        IRepositorio<Campania> RepositorioCampanias { get; }

        /// <summary>
        /// Repositorio de los banners
        /// </summary>
        IRepositorio<Banner> RepositorioBanners { get; }

        /// <summary>
        /// Repositorio de las fuentes
        /// </summary>
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
