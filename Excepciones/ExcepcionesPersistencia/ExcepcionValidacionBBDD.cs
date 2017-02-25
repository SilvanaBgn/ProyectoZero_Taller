using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones.ExcepcionesPersistencia
{
    public class ExcepcionValidacionBBDD : Exception
    {
        public ExcepcionValidacionBBDD(string pMensaje, Exception pInnerException) : base(pMensaje,pInnerException)
        {
        }

        public ExcepcionValidacionBBDD(string pMensaje) : base(pMensaje)
        {
        }
    }
}
