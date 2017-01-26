using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    //ANDA BIEN
    public partial class PruebaRangoHorario : Form
    {
        //Variables propias de este UserControl
        private DateTime TimePickerAnterior;

        /// <summary>
        /// Variable booleana que controla que el dateTimePicker no esté durante la actualización de su Value
        /// </summary>
        private bool navigatingDateTimePicker = false;


        public PruebaRangoHorario()
        {
            InitializeComponent();
            TimePickerAnterior = dateTimePicker.Value;
            navigatingDateTimePicker = false;

            //TODO ESTO TIENE QUE IR EN EL DESIGNER!!!!!!
            dateTimePicker.CustomFormat = "HH:mm";
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.ShowUpDown = true;
            dateTimePicker.Value = DateTime.Now.Date.AddHours(DateTime.Now.Hour);
            dateTimePicker.ValueChanged += new EventHandler(dateTimePicker1_ValueChanged);
        }
        

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (!navigatingDateTimePicker) //Si no está ya actualizando
            {
                //Ponemos la variable booleana a True para prevenir que entre cuando este método ya esté actualizando:
                navigatingDateTimePicker = true;

                //Usamos un TimeSpan para manipular los horarios:
                TimeSpan tempTS = dateTimePicker.Value - dateTimePicker.Value.Date;
                TimeSpan timeSpanRedondeado;

                TimeSpan TDBug = dateTimePicker.Value - TimePickerAnterior;
                if (TDBug.TotalMinutes == 59)
                {
                    //Si volvemos atrás y salteamos una hora, necesita un ajuste:
                    timeSpanRedondeado = TimeSpan.FromMinutes(5 * Math.Floor((tempTS.TotalMinutes - 60) / 5));
                    dateTimePicker.Value = dateTimePicker.Value.Date + timeSpanRedondeado;
                }
                else if (dateTimePicker.Value > TimePickerAnterior)
                {
                    //Redondear hacia arriba al valor siguiente más cercano:
                    timeSpanRedondeado = TimeSpan.FromMinutes(5 * Math.Ceiling(tempTS.TotalMinutes / 5));
                    dateTimePicker.Value = dateTimePicker.Value.Date + timeSpanRedondeado;
                }
                else
                {
                    //Redondear hacia abajo al valor anterior más cercano:
                    timeSpanRedondeado = TimeSpan.FromMinutes(5 * Math.Floor(tempTS.TotalMinutes / 5));
                    dateTimePicker.Value = dateTimePicker.Value.Date + timeSpanRedondeado;
                }
                //Ponemos la variable booleana a False ya que este método ya no está actualizando:
                navigatingDateTimePicker = false;
            }
            TimePickerAnterior = dateTimePicker.Value;
        }
    }
}
