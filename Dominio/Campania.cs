using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Dominio
{
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
        [DataType(DataType.Date), Required]
        public DateTime FechaInicio { get; set; }
        [DataType(DataType.Date), Required]
        public DateTime FechaFin { get; set; }

        /// Rango Horario
        public TimeSpan HoraInicio { get; set; }
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
