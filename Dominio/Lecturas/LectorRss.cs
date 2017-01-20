using System;
using System.Collections.Generic;
using Dominio;

namespace Dominio.Lecturas
{
    /// <summary>
    /// Implementación de base del lector de RSS.
    /// </summary>
    public abstract class LectorRss
    {
        private IEnumerable<ItemRss> ItemsRss;

        public IEnumerable<Item> Leer(String pUrl)
        {
            if (String.IsNullOrWhiteSpace(pUrl))
            {
                throw new ArgumentException("pUrl");
            }

            ItemsRss=this.Leer(new Uri(pUrl));
            return this.ItemRss_a_Item();
        }

        public abstract IEnumerable<ItemRss> Leer (Uri pUrl);

        public IEnumerable<Item> ItemRss_a_Item()
        {
            //foreach (var item in this.ItemsRss)
            //{
            //    //Hacer la conversión
            //    new Item();
            //}

            return new List<Item>();
        }
    }
}
