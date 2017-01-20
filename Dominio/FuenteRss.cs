using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class FuenteRss: Fuente
    {
        public string Url { get; set; }

        public FuenteRss():base()
        {
            this.Tipo = TipoFuente.Rss;
            //this.Lector = new ... ESTO SE MAPEA en la UI con el Contenedor (CREO)
        }

        public override IEnumerable<Item> Leer(string Url)
        {
            return new List<Item>();
        }

        public override IEnumerable<Item> Leer()
        {
            //Hacer lo que hacía el LectorRss!!
            return this.Leer(this.Url);
        }

        ///// <summary>
        ///// Lee los datos, de acuerdo al BannerStrategy
        ///// </summary>
        ///// <returns></returns>
        //public ICollection<string> Leer()
        //{
        //    object objetoAPasar = new object();
        //    switch (Tipo)
        //    {
        //        case TipoBanner.TextoPlano:
        //            objetoAPasar = this.PasoBanners;
        //            break;
        //        case TipoBanner.Rss:
        //            objetoAPasar = this.FuenteRss;
        //            break;
        //    }
        //    if (objetoAPasar == null)
        //        return new List<string>();
        //    else
        //        return this.BannerStrategy.Leer(objetoAPasar);
        //}
    }
}
