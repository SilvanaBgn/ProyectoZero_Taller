using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class RangoHorario
    {
        [Timestamp]
        public TimeSpan HoraInicio { get; set; }
        [Timestamp]
        public TimeSpan HoraFin { get; set; }
    }
}
