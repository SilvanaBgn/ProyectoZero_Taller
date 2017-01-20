using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionAlCargarPantalla:Exception
    {
        public ExcepcionAlCargarPantalla(string pMensaje,Exception pInnerException ) : base(pMensaje,pInnerException)
        {
        }

        public ExcepcionAlCargarPantalla(string pMensaje) : base(pMensaje)
        {
        }
    }
}
