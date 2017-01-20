using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Contenedor
{
    public class ControladorContenedor
    {
        public IRepositorio<Banner> ObtenerRepositorioBanner()
        {
            return Resolucionador<IRepositorio<Banner>>.Resolver();
        }

        public IRepositorio<Campania> ObtenerRepositorioCampania()
        {
            return Resolucionador<IRepositorio<Campania>>.Resolver();
        }

        public IRepositorio<Fuente> ObtenerRepositorioFuente()
        {
            return Resolucionador<IRepositorio<Fuente>>.Resolver();
        }
    }
}
