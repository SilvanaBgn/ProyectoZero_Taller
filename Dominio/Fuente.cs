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
        public int FuenteId { get; set; }

        /// <summary>
        /// Denominación o explicación específica de la fuente
        /// </summary>
        [DataType(DataType.Text),Required/*(ErrorMessage = "Debe completarse Descripción")*/]
        public string Descripcion { get; set; }

        /// <summary>
        /// Información especifica de la Fuente en cuestión
        /// </summary>
        [DataType(DataType.Text)]
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
                else //(value == TipoFuente.TextoPlano)
                {
                    this.iLector = null; //Porque el texto plano no tiene comportamiento adicional
                }
                //this.Tipo = value;
            }
        }
        

        /// <summary>
        /// Constructor para el caso del texto plano, donde no hay origen de items
        /// </summary>
   //     public Fuente(string pDescripcion) : this(pDescripcion, "", TipoFuente.TextoPlano) { }

        public Fuente():this("","",TipoFuente.TextoPlano)
        { }

        /// <summary>
        /// Constructor
        /// </summary>
        public Fuente(string pDescripcion, string pOrigenItems,TipoFuente pTipo)
        {
            this.Banners = new List<Banner>();
            this.Items = new List<Item>();
            this.Tipo = pTipo;
            this.Descripcion = pDescripcion;
            this.origenItems = pOrigenItems;
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
            try
            {
                //Con la siguiente sentencia, está guardando en la BD:
                if (this.iLector!=null)
                {
                    this.Items = (ICollection<Item>)this.iLector.Leer(this.origenItems);
                }
        }
            catch(Exception) //excepcion cuando no hay internet u otra.. entendible para el usuario..
            {

            }
            //Con la siguiente sentencia, los devuelve a la pantalla
            return this.Items;
        }
    }
}
