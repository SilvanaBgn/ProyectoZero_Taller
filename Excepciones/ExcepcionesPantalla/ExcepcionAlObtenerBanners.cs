using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones.ExcepcionesPantalla
{
    public class ExcepcionAlObtenerBanners : Exception
    {
        public ExcepcionAlObtenerBanners(string pMensaje, Exception pInnerException) : base(pMensaje, pInnerException)
        {
        }
        public ExcepcionAlObtenerBanners(string pMensaje) : base(pMensaje)
        {
        }
    }
}
