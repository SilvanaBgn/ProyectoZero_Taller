using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Imagen
    {
        public int ImagenId { get; set; }
        public int CampaniaId { get; set; }
        public byte[] Bytes { get; set; }
        public int Orden { get; set; }

        public virtual Campania Campania { get; set; }
    }
}
