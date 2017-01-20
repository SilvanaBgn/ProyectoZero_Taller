using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class Banner
    {
        public int BannerId { get; set; }
        public string Descripcion { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaInicio { get; set; }
        [DataType(DataType.Date)]
        public DateTime FechaFin { get; set; }

        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }

        //public IBanner BannerStrategy { get; set; }

        public int? FuenteId { get; set; }
        public virtual Fuente Fuente{get; set;} 

        //Constructor
        public Banner()
        {
            this.Fuente = null;
        }
    }
}
