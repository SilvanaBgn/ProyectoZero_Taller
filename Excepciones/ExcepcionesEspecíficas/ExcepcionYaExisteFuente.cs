using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones.ExcepcionesEspecíficas
{
    public class ExcepcionYaExisteFuente : Exception
    {
        public ExcepcionYaExisteFuente(string pMensaje) : base(pMensaje)
        {
        }


    }
}
