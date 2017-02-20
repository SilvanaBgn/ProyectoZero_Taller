﻿using System;
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
        }

        public DateTime FechaInicio
        {
            get { return new DateTime(this.dateTimePickerInicio.Value.Year,this.dateTimePickerInicio.Value.Month,
                this.dateTimePickerInicio.Value.Day); }
            set { dateTimePickerInicio.Value = value; }
        }

        public DateTime FechaFin
        {
            get {return new DateTime(this.dateTimePickerFin.Value.Year, this.dateTimePickerFin.Value.Month,
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
            this.dateTimePickerFin.MinDate= this.dateTimePickerInicio.Value;
            this.labelCantDias.Text = "Un total de "+
                            this.DiferenciaFechas(this.dateTimePickerFin.Value, this.dateTimePickerInicio.Value);
        }

        /// <summary>
        /// Evento que ejecuta al cambiar el valor del dateTimePickerFin, mostrando en labelCantDias
        /// la cantidad de días que existe entre la fecha inicio y la fecha fin
        /// </summary>
        private void dateTimePickerFin_ValueChanged(object sender, EventArgs e)
        {
            //this.dateTimePickerInicio.MaxDate = this.dateTimePickerFin.Value;
            this.labelCantDias.Text = "Un total de " +
                            this.DiferenciaFechas(this.dateTimePickerFin.Value, this.dateTimePickerInicio.Value);
        }

        /// <summary>
        /// Calcula la diferencia de tiempo entre dos fechas
        /// </summary>
        private string DiferenciaFechas(DateTime pFechaNueva, DateTime pFechaVieja)
        {
            int anos;
            int meses;
            int dias;
            string str = "";

            anos = (pFechaNueva.Year - pFechaVieja.Year);
            meses = (pFechaNueva.Month - pFechaVieja.Month);
            dias = (pFechaNueva.Day - pFechaVieja.Day);

            if (meses < 0)
            {
                anos -= 1;
                meses += 12;
            }

            if (dias < 0)
            {
                meses -= 1;
                int DiasAno = pFechaNueva.Year;
                int DiasMes = pFechaNueva.Month;

                if ((pFechaNueva.Month - 1) == 0)
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
                    str = str + anos.ToString() + " año";
                else
                    str = str + anos.ToString() + " años";
            }

            if (meses > 0)
            {
                if (anos>0)
                {
                    str = str + ", ";
                }
                if (meses == 1)
                    str = str + meses.ToString() + " mes";
                else
                    str = str + meses.ToString() + " meses";
            }

            if (dias > 0)
            {
                if (meses > 0)
                {
                    str = str + ", ";
                }
                if (dias == 1)
                    str = str + dias.ToString() + " día ";
                else
                    str = str + dias.ToString() + " días ";
            }

            return str;
        }
    }
}
