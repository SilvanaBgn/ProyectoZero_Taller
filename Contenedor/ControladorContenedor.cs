using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Contenedor
{
    /// <summary>
    /// Clase controladora del contenedor
    /// </summary>
    public class ControladorContenedor
    {
        /// <summary>
        /// Obtiene la instancia de banner
        /// </summary>
        /// <returns>devuelve la instancia del banner</returns>
        public IRepositorio<Banner> ObtenerRepositorioBanner()
        {
            return Resolucionador<IRepositorio<Banner>>.Resolver();
        }

        /// <summary>
        /// Obtiene la instancia de la campaña
        /// </summary>
        /// <returns>devuelve la instancia de la campaña</returns>
        public IRepositorio<Campania> ObtenerRepositorioCampania()
        {
            return Resolucionador<IRepositorio<Campania>>.Resolver();
        }

        /// <summary>
        ///  Obtiene la instancia de la fuente
        /// </summary>
        /// <returns>devuelve la instancia de la fuente</returns>
        public IRepositorio<Fuente> ObtenerRepositorioFuente()
        {
            return Resolucionador<IRepositorio<Fuente>>.Resolver();
        }
    }
}
