using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Imagen
    {
        /// <summary>
        /// Atributo ID de la imagen
        /// </summary>
        public int ImagenId { get; set; }

        /// <summary>
        /// Descripción de la imagen
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// Imagen representada como cadena de bytes
        /// </summary>
        public byte[] Bytes { get; set; }

        /// <summary>
        /// Atributo que representa el orden de la imagen
        /// </summary>
        public int Orden { get; set; }

        /// <summary>
        /// ID de la Campaña 
        /// </summary>
        public int CampaniaId { get; set; }

        /// <summary>
        /// Objeto campaña
        /// </summary>
        public virtual Campania Campania { get; set; }
    }
}
