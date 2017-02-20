using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ItemRss
    {
        public int ItemRssId { get; set; }

        /// <summary>
        /// Título del ítem.
        /// </summary>
        [StringLength(80)]
        public string Titulo { get; set; }

        /// <summary>
        /// Descripción acerca del ítem.
        /// </summary>
        [StringLength(80)]
        public string Descripcion { get; set; }

        /// <summary>
        /// URL del ítem.
        /// </summary>
        [StringLength(80)]
        public string Url { get; set; }

        /// <summary>
        /// Fecha de publicación.
        /// </summary>
        public DateTime? FechaDePublicacion { get; set; }

        public override string ToString()
        {
            return Titulo.ToUpper() + ": " + Descripcion; //+ FechaDePublicacion.ToString();
        }
    }
}
