using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public interface IBanner
    {
        /// <summary>
        /// Permite leer
        /// </summary>
        /// <returns></returns>
        ICollection<string> Leer(object pObjetoALeer);
    }
}
