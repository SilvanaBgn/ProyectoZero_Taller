using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionAlGuardarCambios : Exception
    {
        public ExcepcionAlGuardarCambios(string pMensaje, Exception pInnerException) : base(pMensaje,pInnerException)
        {
        }

        public ExcepcionAlGuardarCambios(string pMensaje) : base(pMensaje)
        {
        }
    }
}
