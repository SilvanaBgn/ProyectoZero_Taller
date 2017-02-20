using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Lecturas;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class Fuente
    {
        /// <summary>
        /// Esta clase representa la información que tiene el objeto fuente del banner
        /// </summary>
        public int FuenteId { get; set; }

        /// <summary>
        /// Denominación o explicación específica de la fuente
        /// </summary>
        //[DataType(DataType.Text),Required/*(ErrorMessage = "Debe completarse Descripción")*/]
        [Required]
        public string Descripcion { get; set; }

        /// <summary>
        /// Información especifica de la Fuente en cuestión
        /// </summary>
        //[DataType(DataType.Text)]
        [StringLength(80)]
        [Required]
        public string origenItems { get; set; }

        public virtual ICollection<Banner> Banners { get; set; }

        public virtual ICollection<Item> Items { get; set; }

        /// <summary>
        /// Indica el método de lectura de esta fuente, según su Tipo
        /// </summary>
        [NotMapped]
        private ILector iLector { get; set; }

        private TipoFuente iTipo;

        public TipoFuente Tipo {
            get { return this.iTipo; }

            set
            {
                
                if (value == TipoFuente.Rss)
                {
                    this.iLector = new LectorRss();
                }
                else //(value == TipoFuente.TextoFijo)
                {
                    this.iLector = null; //Porque el texto fijo no tiene comportamiento adicional
                }
                this.iTipo = value;
            }
        }
        

        /// <summary>
        /// Constructor para el caso del texto fijo, donde no hay origen de items
        /// </summary>
   //     public Fuente(string pDescripcion) : this(pDescripcion, "", TipoFuente.TextoFijo) { }

        public Fuente():this("","",TipoFuente.TextoFijo)
        { }

        /// <summary>
        /// Constructor de una fuente para el caso que tenga un origen de items
        /// </summary>
        public Fuente(string pDescripcion, string pOrigenItems,TipoFuente pTipo)
        {
            this.Banners = new List<Banner>();
            this.Items = new List<Item>();
            this.Tipo = pTipo;
            this.Descripcion = pDescripcion;
            this.origenItems = pOrigenItems;
        }

        /// <summary>
        /// Sobreescribe el método ToString de fuente
        /// </summary>
        /// <returns>devuelve la descripción de la fuente</returns>
        public override string ToString()
        {
            return Descripcion;
        }

        /// <summary>
        /// Lee los datos y actualiza el atributo Items
        /// </summary>
        public void Leer()
        {
            try
            {
                //Con la siguiente sentencia, lee y asigna los items:
                if (this.iLector!=null)
                {
                    this.Items = (List<Item>)this.iLector.Leer(this.origenItems);
                }
            }
            catch(Exception) //excepcion cuando no hay internet u otra.. entendible para el usuario..=> No leyó
            {
            }
        }
    }
}
