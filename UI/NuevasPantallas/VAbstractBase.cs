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
using System.Text.RegularExpressions;

namespace UI.NuevasPantallas
{
    public partial class VAbstractBase : Form
    {

        protected ControladorDominio iControladorDominio;

        public VAbstractBase()
        {
            InitializeComponent();

            //Centramos la pantalla en el centro:
            this.StartPosition = FormStartPosition.CenterScreen;
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
            if (this.dataGridViewMostrar.Rows.Count>0 && this.dataGridViewMostrar.SelectedRows.Count <= 0)
            {
                this.dataGridViewMostrar.CurrentCell = this.dataGridViewMostrar.Rows[0].Cells[1];
                this.dataGridViewMostrar.Rows[0].Selected = true;
            }
        }

        private void InputValido(KeyPressEventArgs e)
            {
            var regex = new Regex(@"[^a-zA-Z0-9\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
                {
                e.Handled = true;
            }
        }

        private void textBoxDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.InputValido(e);
            }
            
        private void textBoxTitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.InputValido(e);
        }

        /// <summary>
        /// Devuelve la seleccion a la primer fila si no hay filas seleccionadas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewMostrar_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewMostrar.Rows.Count > 0 && this.dataGridViewMostrar.SelectedRows.Count <= 0)
            {
                this.dataGridViewMostrar.CurrentCell = this.dataGridViewMostrar.Rows[0].Cells[1];
                this.dataGridViewMostrar.Rows[0].Selected = true;
            }
        }

        private void VAbstractBase_Load(object sender, EventArgs e)
        {
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink; //Que no permita redimensionar la ventana
            this.MaximizeBox = false; //Que no permita maximizar
            this.WindowState = FormWindowState.Normal;
        }
    }
}
