using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionErrorEnLaBusqueda : Exception
    {
        public ExcepcionErrorEnLaBusqueda(string pMensaje, Exception pInnerException) : base(pMensaje,pInnerException)
        {
        }
        public ExcepcionErrorEnLaBusqueda(string pMensaje) : base(pMensaje)
        {
        }

        //Aclaración: La propiedad predefinida desde Exception (Message) devuelve el iMensaje
    }
}
