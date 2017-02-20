using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace UI.NuevasPantallas
{
    public partial class VAbstractBase : Form
    {

        protected ControladorDominio iControladorDominio;

        public VAbstractBase()
        {
            InitializeComponent();
        }

        public VAbstractBase(ref ControladorDominio pControladorDominio) : this()
        {
            this.iControladorDominio = pControladorDominio;
        }

        /// <summary>
        /// Evento que se invoca cuando cambia el valor del checkBoxRangoFechas
        /// </summary>
        private void checkBoxRangoFechas_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxRangoFechas.Checked)
                this.rangoFecha.Enabled = true;
            else this.rangoFecha.Enabled = false;
        }

        /// <summary>
        /// Evento que se invoca cuando cambia el valor del checkBoxRangoHoras
        /// </summary>
        private void checkBoxRangoHoras_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxRangoHoras.Checked)
                this.rangoHorario.Enabled = true;
            else this.rangoHorario.Enabled = false;
        }

        /// <summary>
        /// Evento que se invoca cuando cambia el valor del checkBoxTitulo
        /// </summary>
        private void checkBoxTitulo_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxTitulo.Checked)
                this.textBoxTitulo.Enabled = true;
            else this.textBoxTitulo.Enabled = false;
        }

        /// <summary>
        /// Evento que se invoca cuando cambia el valor del checkBoxDescripcion
        /// </summary>
        private void checkBoxDescripcion_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxDescripcion.Checked)
                this.textBoxDescripcion.Enabled = true;
            else this.textBoxDescripcion.Enabled = false;
        }

        /// <summary>
        /// Botón salir
        /// </summary>
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            //this.Owner.ShowDialog();
            this.Close();
        }

        /// <summary>
        ///  Evento que se invoca cuando se hace click con el mouse sobre una celda
        /// </summary>
        private void dataGridViewMostrar_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Control) == Keys.Control)
            {
                if (e.Button == MouseButtons.Left)
                {
                    dataGridViewMostrar.ClearSelection();
                }
            }
        }

        private void VAbstractBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
