using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Dominio
{
    public class Banner
    {
        public int BannerId { get; set; }

        /// <summary>
        /// Título referente que se desea mostrar en la pantalla publicitaria
        /// </summary>
        [Required]
        public string Titulo { get; set; }

        /// <summary>
        /// Explicación del contenido del banner
        /// </summary>
        [Required]
        public string Descripcion { get; set; }


        [Required]
        public int FuenteId { get; set; }
        [Required]
        public virtual Fuente Fuente{get; set;}

        [Required]
        public int RangoHorarioId { get; set; }
        [Required]
        public virtual RangoHorario RangoHorario { get; set; }

        [Required]
        public int RangoFechaId { get; set; }
        [Required]
        public virtual RangoFecha RangoFecha { get; set; }
    }
}
