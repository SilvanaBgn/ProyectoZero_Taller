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
    public partial class RangoFecha : UserControl
    {
        //CONSTRUCTOR
        public RangoFecha()
        {
            InitializeComponent();
            //this.FechaFin = DateTime.Today;
            //this.FechaInicio = DateTime.Today;
        }

        public DateTime FechaInicio
        {
            get
            {
                return new DateTime(this.dateTimePickerInicio.Value.Year, this.dateTimePickerInicio.Value.Month,
              this.dateTimePickerInicio.Value.Day);
            }
            set { dateTimePickerInicio.Value = value; }
        }

        public DateTime FechaFin
        {
            get
            {
                return new DateTime(this.dateTimePickerFin.Value.Year, this.dateTimePickerFin.Value.Month,
             this.dateTimePickerFin.Value.Day);
            }
            set { dateTimePickerFin.Value = value; }
        }

        /// <summary>
        /// Evento que ejecuta al cambiar el valor del dateTimePickerInicio, mostrando en labelCantDias
        /// la cantidad de días que existe entre la fecha inicio y la fecha fin
        /// </summary>
        private void dateTimePickerInicio_ValueChanged(object sender, EventArgs e)
        {
            this.dateTimePickerFin.MinDate = this.dateTimePickerInicio.Value;
            this.labelCantDias.Text = this.DiferenciaFechas(this.dateTimePickerFin.Value, this.dateTimePickerInicio.Value);
        }

        /// <summary>
        /// Evento que ejecuta al cambiar el valor del dateTimePickerFin, mostrando en labelCantDias
        /// la cantidad de días que existe entre la fecha inicio y la fecha fin
        /// </summary>
        private void dateTimePickerFin_ValueChanged(object sender, EventArgs e)
        {
            //this.dateTimePickerInicio.MaxDate = this.dateTimePickerFin.Value;
            this.labelCantDias.Text = this.DiferenciaFechas(this.dateTimePickerFin.Value, this.dateTimePickerInicio.Value);
        }

        /// <summary>
        /// Calcula la diferencia de tiempo entre dos fechas
        /// </summary>
        private string DiferenciaFechas(DateTime pFechaFin, DateTime pFechaInicio)
        {
            int anos;
            int meses;
            int dias;
            string resultado = "Un total de ";

            anos = (pFechaFin.Year - pFechaInicio.Year);
            meses = (pFechaFin.Month - pFechaInicio.Month);
            dias = (pFechaFin.Day - pFechaInicio.Day);
            if (anos == 0 && meses == 0 && dias == 0) //pFechaNueva==pFechaInicio:
                resultado += "0 días";
            else //pFechaNueva != pFechaInicio:
            {
                if (meses < 0)
                {
                    anos -= 1;
                    meses += 12;
                }

                if (dias < 0)
                {
                    meses -= 1;
                    int DiasAno = pFechaFin.Year;
                    int DiasMes = pFechaFin.Month;

                    if ((pFechaFin.Month - 1) == 0)
                    {
                        DiasAno = DiasAno - 1;
                        DiasMes = 12;
                    }
                    else
                    {
                        DiasMes = DiasMes - 1;
                    }

                    dias += DateTime.DaysInMonth(DiasAno, DiasMes);
                }

                if (anos < 0)
                {
                    return "La fecha inicial es mayor a la fecha final";
                }

                if (anos > 0)
                {
                    if (anos == 1)
                        resultado += anos.ToString() + " año";
                    else
                        resultado += anos.ToString() + " años";
                }

                if (meses > 0)
                {
                    if (anos > 0)
                    {
                        resultado += ", ";
                    }
                    if (meses == 1)
                        resultado += meses.ToString() + " mes";
                    else
                        resultado += meses.ToString() + " meses";
                }

                if (dias > 0)
                {
                    if (meses > 0)
                    {
                        resultado += ", ";
                    }
                    if (dias == 1)
                        resultado += dias.ToString() + " día ";
                    else
                        resultado += dias.ToString() + " días ";
                }
            }
            return resultado;
        }
    }
}
