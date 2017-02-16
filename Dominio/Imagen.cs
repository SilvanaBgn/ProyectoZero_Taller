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
        public int ImagenId { get; set; }
        /// <summary>
        /// Nombre del archivo de imagen
        /// </summary>
        public string Descripcion { get; set; }
        public byte[] Bytes { get; set; }
        public int Orden { get; set; }

        public virtual Campania Campania { get; set; }
    }
}
