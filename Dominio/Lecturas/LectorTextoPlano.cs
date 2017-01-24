using System;
using System.Collections.Generic;
using Dominio;

namespace Dominio.Lecturas
{
    /// <summary>
    /// Implementación de base del lector de RSS.
    /// </summary>
    public class LectorTextoPlano:ILector
    {
        private IEnumerable<Item> Items;

        public IEnumerable<Item> Leer(String pData=null)
        {
            //HAACEER!!
            return new List<Item>();
        }
    }
}
