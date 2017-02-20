using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class Banner
    {
        public int BannerId { get; set; }

        /// <summary>
        /// Título referente que se desea mostrar en la pantalla publicitaria
        /// </summary>
        [Required]
        [StringLength(80)]
        public string Titulo { get; set; }

        /// <summary>
        /// Explicación del contenido del banner
        /// </summary>
        [Required]
        [StringLength(80)]
        public string Descripcion { get; set; }

        [Required]
        public virtual Fuente Fuente { get; set; }

        [DataType(DataType.Date),Required]
        public DateTime FechaInicio { get; set; }
        [DataType(DataType.Date),Required]
        public DateTime FechaFin { get; set; }

        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
    }
}
