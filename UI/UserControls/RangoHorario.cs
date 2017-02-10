using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.UserControls
{
    public partial class RangoHorario : UserControl
    {
        public RangoHorario()
        {
            InitializeComponent();
            this.labelDiferenciaEntreInicioFin.Text = this.DiferenciaEntreHoras(this.dateTimePickerHoraInicio, this.dateTimePickerHoraFin);

            this.dateTimePickerHoraInicio.MaxDate = DateTime.Today + new TimeSpan(23,30,0);
            this.dateTimePickerHoraInicio.MinDate = DateTime.Today + new TimeSpan(0, 0, 0);

            this.dateTimePickerHoraFin.MaxDate = DateTime.Today + new TimeSpan(23, 45, 0);
            this.dateTimePickerHoraFin.MinDate = DateTime.Today + new TimeSpan(0, 15, 0);
        }

        public TimeSpan HoraInicio
        {
            get { return new TimeSpan(this.dateTimePickerHoraInicio.Value.Hour, this.dateTimePickerHoraInicio.Value.Minute,0); }
            set { dateTimePickerHoraInicio.Value = DateTime.Today+value; }
        }

        public TimeSpan HoraFin
        {
            get { return new TimeSpan(this.dateTimePickerHoraFin.Value.Hour, this.dateTimePickerHoraFin.Value.Minute, 0); }
            set { dateTimePickerHoraFin.Value = DateTime.Today + value; }
        }

        /// <summary>
        /// Evento que se invoca cuando cambia la hora inicio
        /// </summary>
        private void dateTimePickerHoraInicio_ValueChanged(object sender, EventArgs e)
        {
            this.IntervaloMinutos(this.dateTimePickerHoraInicio, 15);
            this.dateTimePickerHoraFin.MinDate = this.dateTimePickerHoraInicio.Value + TimeSpan.FromMinutes(15);
            this.labelDiferenciaEntreInicioFin.Text = this.DiferenciaEntreHoras(this.dateTimePickerHoraInicio, this.dateTimePickerHoraFin);
        }

        /// <summary>
        /// Evento que se invoca cuando cambia la hora fin
        /// </summary>
        private void dateTimePickerHoraFin_ValueChanged(object sender, EventArgs e)
        {
            this.IntervaloMinutos(this.dateTimePickerHoraFin, 15);
            this.labelDiferenciaEntreInicioFin.Text = this.DiferenciaEntreHoras(this.dateTimePickerHoraInicio, this.dateTimePickerHoraFin);
        }

        /// <summary>
        /// Modifica el pDateTimePicker para que cambie según el intervalo especificado
        /// </summary>
        /// <param name="pDateTimePicker">hora</param>
        /// <param name="pIntervalo">intervalo de salto</param>
        private void IntervaloMinutos(DateTimePicker pDateTimePicker, int pIntervalo)
        {
            if (pDateTimePicker.Value.Minute % pIntervalo == 0)
                return;

            if (pDateTimePicker.Value.Minute % pIntervalo == 1)
            {
                pDateTimePicker.Value = pDateTimePicker.Value.AddMinutes(14);
            }

                if (pDateTimePicker.Value.Minute % pIntervalo == (pIntervalo-1))
                    pDateTimePicker.Value = pDateTimePicker.Value.AddMinutes(-pIntervalo+1);

                if (pDateTimePicker.Value.Minute != 0 && pDateTimePicker.Value.Minute != 15 
                    && pDateTimePicker.Value.Minute != 30 && pDateTimePicker.Value.Minute != 45)
                {
                    this.Redondeo(pDateTimePicker, 1, 15, 0);
                    this.Redondeo(pDateTimePicker, 16, 30, 15);
                    this.Redondeo(pDateTimePicker, 31, 45, 30);
                    this.Redondeo(pDateTimePicker, 46, 60, 45);
                }
            }

        /// <summary>
        /// Si los valores que se le ingresa a los minutos del pDateTimePicker son distintos que 00, 15, 30 o 45,
        /// se los redondea a dichos valores (00, 15, 30, 45)
        /// </summary>
        /// <param name="pDateTimePicker">Hora a redondear</param>
        /// <param name="pPrimero">primer valor de un cuarto de hora</param>
        /// <param name="pUltimo">ultimo valor de un cuarto de hora</param>
        /// <param name="cambio">valor por el que cual se cambian los minutos cuando no corresponden con 00, 15, 30 o 45</param>
        private void Redondeo(DateTimePicker pDateTimePicker, int pPrimero, int pUltimo, int cambio)
        {
            for (int i = pPrimero; i < pUltimo; i++)
            {
                if (pDateTimePicker.Value.Minute == i)
                {
                    pDateTimePicker.Value = pDateTimePicker.Value.Date + new TimeSpan(pDateTimePicker.Value.Hour, cambio, 0);
                }
            }
        }

        /// <summary>
        /// Calcula la diferencia que existe entre dos horas (hora de inicio y hora de fin)
        /// </summary>
        /// <param name="pHoraInicio">Hora de inicio</param>
        /// <param name="pHoraFin">Hora de fin</param>
        /// <returns>Devuelve un string con la diferencia entre las horas</returns>
        private string DiferenciaEntreHoras(DateTimePicker pHoraInicio, DateTimePicker pHoraFin)
        {
            TimeSpan diferenciaHoras = new TimeSpan();
            diferenciaHoras = pHoraFin.Value.Subtract(pHoraInicio.Value);
            string resultado = "";
            resultado = "Un total de ";
            if (diferenciaHoras.Hours != 0) //Si las horas de la diferencia entre horas es distinto de 0
            {
                if (diferenciaHoras.Hours == 1)
                    resultado += diferenciaHoras.Hours + " hs";
            }
            if (diferenciaHoras.Minutes != 0) //Si los minutos de la diferencia entre horas es distinto de 0
            {
                if (diferenciaHoras.Hours != 0)
                    resultado += " y ";
                    resultado += diferenciaHoras.Minutes + " min";
            }
            return resultado;
        }
    }
}
