using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones.ExcepcionesDominio
{
    public class ExcepcionAlLeerFuenteExternaDelBanner : Exception
    {
        public ExcepcionAlLeerFuenteExternaDelBanner(string pMensaje, Exception pInnerException) : base(pMensaje, pInnerException)
        {
        }
        public ExcepcionAlLeerFuenteExternaDelBanner(string pMensaje) : base(pMensaje)
        {
        }
    }
}
