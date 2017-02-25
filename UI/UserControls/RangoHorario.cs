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
        //CONSTRUCTOR
        public RangoHorario()
        {
            InitializeComponent();

            //Establecemos los valores por defecto de los comboBox de la hora:
            this.comboBoxH1.SelectedIndex = 0;
            this.comboBoxH2.SelectedIndex = 0;
            this.comboBoxM1.SelectedIndex = 0;
            this.comboBoxM2.SelectedIndex = 0;
        }

        

        /// <summary>
        /// Calcula la diferencia que existe entre dos horas (hora de inicio y hora de fin)
        /// </summary>
        /// <param name="pHoraInicio">Hora de inicio</param>
        /// <param name="pHoraFin">Hora de fin</param>
        /// <returns>Devuelve un string con la diferencia entre las horas</returns>
        private string DiferenciaEntreHoras(TimeSpan pHoraInicio, TimeSpan pHoraFin)
        {
            TimeSpan diferenciaHoras = new TimeSpan();
            diferenciaHoras = pHoraFin.Subtract(pHoraInicio);
            string resultado = "Un total de ";
            //pHoraInicio==pHoraFin (excepto en el caso de Inicio=00:00 y Fin=00:00):
            if (diferenciaHoras.TotalMinutes == 0) 
                resultado += "0 m";
            else //pHoraInicio!=pHoraFin (o Inicio=00:00 y Fin=00:00):
            {
                 //pHoraInicio != pHoraFin
                if (diferenciaHoras.Hours > 0) //Si las horas de la diferencia entre horas es distinto de 0
                    resultado += diferenciaHoras.Hours + " h";

                if (diferenciaHoras.Minutes > 0) //Si los minutos de la diferencia entre horas es distinto de 0
                {
                    if (diferenciaHoras.Hours > 0)
                        resultado += ", ";
                    resultado += diferenciaHoras.Minutes + " m";
                }
            }
            return resultado;
        }

        private void comboBoxH1_SelectedIndexChanged(object sender, EventArgs e)
        {//Actualizamos el label que muestra la diferencia de tiempo:
            this.labelDiferenciaEntreInicioFin.Text = this.DiferenciaEntreHoras(this.HoraInicio, this.HoraFin);
        }

        private void comboBoxM1_SelectedIndexChanged(object sender, EventArgs e)
        {//Actualizamos el label que muestra la diferencia de tiempo:
            this.labelDiferenciaEntreInicioFin.Text = this.DiferenciaEntreHoras(this.HoraInicio, this.HoraFin);
        }

        private void comboBoxH2_SelectedIndexChanged(object sender, EventArgs e)
        {//Actualizamos el label que muestra la diferencia de tiempo:
            this.labelDiferenciaEntreInicioFin.Text = this.DiferenciaEntreHoras(this.HoraInicio, this.HoraFin);
        }

        private void comboBoxM2_SelectedIndexChanged(object sender, EventArgs e)
        {//Actualizamos el label que muestra la diferencia de tiempo:
            this.labelDiferenciaEntreInicioFin.Text = this.DiferenciaEntreHoras(this.HoraInicio, this.HoraFin);
        }


//PROPERTIES
        public TimeSpan HoraInicio
        {
            get { return new TimeSpan(Convert.ToInt16(this.comboBoxH1.SelectedItem), Convert.ToInt16(this.comboBoxM1.SelectedItem), 0); }
            set
            {
                this.comboBoxH1.SelectedIndex = value.Hours;
                this.comboBoxM1.SelectedIndex = value.Minutes * 4 / 60;
            }
        }

        public TimeSpan HoraFin
        {
            get
            {
                TimeSpan horaFin;
                if (Convert.ToInt16(this.comboBoxH2.SelectedItem) == 0 && Convert.ToInt16(this.comboBoxM2.SelectedItem) == 0)
                    horaFin = new TimeSpan(23, 59, 59);
                else
                    horaFin = new TimeSpan(Convert.ToInt16(this.comboBoxH2.SelectedItem), Convert.ToInt16(this.comboBoxM2.SelectedItem), 0);
                return horaFin;
            }
            set
            {
                if (value.Hours == 23 && value.Minutes == 59)
                {
                    this.comboBoxH2.SelectedIndex = 0;
                    this.comboBoxM2.SelectedIndex = 0;
                }
                else
                {
                    this.comboBoxH2.SelectedIndex = value.Hours;
                    this.comboBoxM2.SelectedIndex = (value.Minutes) * 4 / 60;
                }
                this.labelDiferenciaEntreInicioFin.Text = this.DiferenciaEntreHoras(this.HoraInicio, this.HoraFin);
            }
        }
    }
}
