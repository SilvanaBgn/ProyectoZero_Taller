using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Dominio
{
    /// <summary>
    /// Esta clase representa la información que tiene el objeto campania para su correcta
    /// visulización en la ventana principal
    /// </summary>
    public class Campania
    {
        public int CampaniaId { get; set; }

        /// <summary>
        /// Título referente que se desea mostrar en la pantalla publicitaria
        /// </summary>
        [Required]
        [StringLength(80)]
        public string Titulo { get; set; }

        /// <summary>
        /// Explicación del contenido de la campaña
        /// </summary>
        [StringLength(80)]
        public string Descripcion { get; set; }

        /// <summary>
        /// Duración en segundos de cada imagen de la campaña
        /// </summary>
        //[Range(1,999)]
        [Required]
        public int DuracionImagen { get; set; }

        /// <summary>
        /// Lista de imágenes pertenecientes a la campaña
        /// </summary>
        public virtual ICollection<Imagen> Imagenes { get; set; }

        /// Rango Fecha
        /// <summary>
        /// Fecha de inicio de la camapaña
        /// </summary>
        [DataType(DataType.Date), Required]
        public DateTime FechaInicio { get; set; }
        /// <summary>
        /// Fecha de finalización de la camapaña
        /// </summary>
        [DataType(DataType.Date), Required]
        public DateTime FechaFin { get; set; }

        /// Rango Horario
        /// <summary>
        /// Hora de inicio de la camapaña
        /// </summary>
        public TimeSpan HoraInicio { get; set; }
        /// <summary>
        /// Hora de finalización de la camapaña
        /// </summary>
        public TimeSpan HoraFin { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public Campania()
        {
            this.Imagenes = new List<Imagen>();
        }
    }
}
