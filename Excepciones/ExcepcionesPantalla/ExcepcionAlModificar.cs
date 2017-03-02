using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones.ExcepcionesPantalla
{
    public class ExcepcionAlModificar : Exception
    {
        public ExcepcionAlModificar(string pMensaje, Exception pInnerException) : base(pMensaje, pInnerException)
        {
        }
        public ExcepcionAlModificar(string pMensaje) : base(pMensaje)
        {
        }
    }
}
