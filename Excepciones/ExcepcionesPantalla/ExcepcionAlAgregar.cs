using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones.ExcepcionesPantalla
{
    public class ExcepcionAlAgregar : Exception
    {
        public ExcepcionAlAgregar(string pMensaje, Exception pInnerException) : base(pMensaje, pInnerException)
        {
        }
        public ExcepcionAlAgregar(string pMensaje) : base(pMensaje)
        {
        }
    }
}
