using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionErrorAlGuardar:Exception
    {
        public ExcepcionErrorAlGuardar(string pMensaje, Exception pInnerException) : base(pMensaje,pInnerException)
        {
        }
        public ExcepcionErrorAlGuardar(string pMensaje) : base(pMensaje)
        {
        }
    }
}
