using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public abstract class Fuente:ILector
    {
        public int FuenteId { get; set; }
        [DataType(DataType.Text)]
        public string Descripcion { get; set; }

        public virtual ICollection<Banner> Banners { get; set; }

        private TipoFuente iTipo;


        /// <summary>
        /// Constructor
        /// </summary>
        public Fuente()
        {
            this.Banners = new List<Banner>();
            //this.Descripcion = "";
        }

        public override string ToString()
        {
            return Descripcion;
        }

        //Método de lectura
        public abstract IEnumerable<Item> Leer(string pInfo);
        public abstract IEnumerable<Item> Leer();

        //Properties
        public TipoFuente Tipo
        {
            get { return this.iTipo; }
            set { this.iTipo = value; }
        }
    }
}
