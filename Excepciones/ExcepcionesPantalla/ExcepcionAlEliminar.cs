using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones.ExcepcionesPantalla
{
    public class ExcepcionAlEliminar : Exception
    {
        public ExcepcionAlEliminar(string pMensaje, Exception pInnerException) : base(pMensaje, pInnerException)
        {
        }
        public ExcepcionAlEliminar(string pMensaje) : base(pMensaje)
        {
        }
    }
}
