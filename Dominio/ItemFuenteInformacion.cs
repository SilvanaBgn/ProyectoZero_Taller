using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    /// <summary>
    /// Clase que contiene la inforación del item
    /// </summary>
    public class ItemFuenteInformacion
    {
        /// <summary>
        /// Atributo ID del item
        /// </summary>
        public int ItemId { get; set; }

        /// <summary>
        /// Atributo descripción del item
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// ID de la fuente del item
        /// </summary>
        //[Required]
        public int FuenteId { get; set; }

        /// <summary>
        /// Atributo fuente del item
        /// </summary>
        //public virtual Fuente Fuente { get; set; }

        /// <summary>
        /// Constructores
        /// </summary>
        public ItemFuenteInformacion(): this("") {}
        public ItemFuenteInformacion(string pDescripcion)
        {
            this.Descripcion = pDescripcion;
        }

        /// <summary>
        /// Sobreescribe el método ToString del objeto Item
        /// </summary>
        /// <returns>devuelve la descripción del item</returns>
        public override string ToString()
        {
            return this.Descripcion;
        }
    }
}
