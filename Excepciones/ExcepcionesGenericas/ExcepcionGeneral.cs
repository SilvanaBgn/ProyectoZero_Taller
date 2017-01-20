using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionGeneral : Exception
    {
        public ExcepcionGeneral(string pMensaje, Exception pInnerException) : base(pMensaje,pInnerException)
        {
        }
        public ExcepcionGeneral(string pMensaje) : base(pMensaje)
        {
        }
    }
}
