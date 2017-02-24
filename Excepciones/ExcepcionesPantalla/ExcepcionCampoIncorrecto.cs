using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones.ExcepcionesPantalla
{
    public class ExcepcionCampoIncorrecto : Exception
    {
        public ExcepcionCampoIncorrecto(string pMensaje, Exception pInnerException) : base(pMensaje, pInnerException)
        {
        }

        public ExcepcionCampoIncorrecto(string pMensaje) : base(pMensaje)
        {
        }
    }
}
