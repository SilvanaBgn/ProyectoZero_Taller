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
    /// <summary>
    /// Esta clase representa la información que tiene el objeto banner para su correcta
    /// visulización en la ventana principal
    /// </summary>
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

        /// <summary>
        /// ID de la fuente del banner
        /// </summary>
        [Required]
        public int FuenteId { get; set; }

        /// <summary>
        /// Fuente del banner
        /// </summary>
        [Required]
        public virtual Fuente Fuente { get; set; }

        //Rango fecha
        /// <summary>
        /// Fecha de inicio del banner
        /// </summary>
        [DataType(DataType.Date),Required]
        public DateTime FechaInicio { get; set; }

        /// <summary>
        /// Fecha de finalización del banner
        /// </summary>
        [DataType(DataType.Date),Required]
        public DateTime FechaFin { get; set; }

        //Rango hora
        /// <summary>
        /// Hora de inicio del banner
        /// </summary>
        public TimeSpan HoraInicio { get; set; }

        /// <summary>
        /// Hora de finalización del banner
        /// </summary>
        public TimeSpan HoraFin { get; set; }
    }
}
