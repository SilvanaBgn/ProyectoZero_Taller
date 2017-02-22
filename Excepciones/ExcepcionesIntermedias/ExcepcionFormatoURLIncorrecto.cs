using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones.ExcepcionesIntermedias
{
    public class ExcepcionFormatoURLIncorrecto : Exception
    {
        public ExcepcionFormatoURLIncorrecto(string pMensaje) : base(pMensaje)
        {
        }


    }
}
