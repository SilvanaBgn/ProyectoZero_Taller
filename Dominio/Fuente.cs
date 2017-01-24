using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Lecturas;

namespace Dominio
{
    public class Fuente
    {
        public int FuenteId { get; set; }

        /// <summary>
        /// Denominación o explicación específica de la fuente
        /// </summary>
        [DataType(DataType.Text),Required/*(ErrorMessage = "Debe completarse Descripción")*/]
        public string Descripcion { get; set; }

        /// <summary>
        /// Información especíifica de la Fuente en cuestión
        /// </summary>
        [DataType(DataType.Text)]
        public string origenItems { get; set; }

        public virtual ICollection<Banner> Banners { get; set; }

        public TipoFuente Tipo {
            get { return this.Tipo; }

            set
            {
                if (value == TipoFuente.TextoPlano)
                {
                    this.iLector = new LectorTextoPlano();
                }
                else //(value == TipoFuente.Rss)
                {
                    this.iLector = new LectorRss();
                }
                this.Tipo = value;
            }
        }


        /// <summary>
        /// Indica el método de lectura de esta fuente, según su Tipo
        /// </summary>
        private ILector iLector;

        /// <summary>
        /// Constructor
        /// </summary>
        public Fuente()
        {
            this.Banners = new List<Banner>();
            this.Tipo = TipoFuente.TextoPlano;
        }

        public override string ToString()
        {
            return Descripcion;
        }


        /// <summary>
        /// Lee los datos
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Item> Leer()
        {
            return this.iLector.Leer(this.origenItems);
        }
    }
}
