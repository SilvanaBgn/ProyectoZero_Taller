using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones.ExcepcionesPantalla
{
    public class ExcepcionAlObtenerFuentes : Exception
    {
        public ExcepcionAlObtenerFuentes(string pMensaje, Exception pInnerException) : base(pMensaje, pInnerException)
        {
        }
        public ExcepcionAlObtenerFuentes(string pMensaje) : base(pMensaje)
        {
        }
    }
}
