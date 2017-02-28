using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones.ExcepcionesDominio
{
    public class ExcepcionErrorDeLectura : Exception
    {
        public ExcepcionErrorDeLectura(string pMensaje, Exception pInnerException) : base(pMensaje,pInnerException)
        {
        }
        public ExcepcionErrorDeLectura(string pMensaje) : base(pMensaje)
        {
        }
    }
}
