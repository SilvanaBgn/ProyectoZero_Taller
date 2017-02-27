using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones.ExcepcionesPantalla
{
    public class ExcepcionAlObtenerCampanias : Exception
    {
        public ExcepcionAlObtenerCampanias(string pMensaje, Exception pInnerException) : base(pMensaje, pInnerException)
        {
        }
        public ExcepcionAlObtenerCampanias(string pMensaje) : base(pMensaje)
        {
        }
    }
}
