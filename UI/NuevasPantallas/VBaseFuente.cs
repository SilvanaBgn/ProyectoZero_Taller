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
    public partial class VBaseFuente : Form
    {

        private ControladorDominio iControladorDominio;

        public VBaseFuente(ref ControladorDominio pControladorDominio)
        {
            InitializeComponent();
            this.iControladorDominio = pControladorDominio;
            this.comboBoxTipo.Enabled = false;
            this.textBoxDescripcion.Enabled = false;
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            VCrearFuente vFuente = new VCrearFuente(ref this.iControladorDominio);
            vFuente.Show();
        }

        private Fuente fuenteAModificar()
        {
            return (Fuente)this.dataGridViewMostrar.SelectedRows[0].DataBoundItem;
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            VModificarFuente vFuente = new VModificarFuente(ref this.iControladorDominio, this.fuenteAModificar());
            vFuente.Show();
        }

        public void CargarDataGridFuentes(List<Fuente> pListaFuentes)
        {
            this.dataGridViewMostrar.DataSource = pListaFuentes;
            this.dataGridViewMostrar.Columns["Tipo"].DisplayIndex = 0;
            this.dataGridViewMostrar.Columns["Descripcion"].DisplayIndex = 1;
            this.dataGridViewMostrar.Columns["origenItems"].DisplayIndex = 2;
            this.dataGridViewMostrar.Columns["origenItems"].HeaderText = "Fuente";
            this.dataGridViewMostrar.Columns["Banners"].Visible = false;
            this.dataGridViewMostrar.Columns["Items"].Visible = false;
            this.dataGridViewMostrar.Columns["FuenteId"].Visible = false;
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(this.dataGridViewMostrar.SelectedRows[0].Cells[0].Value.ToString());
            this.iControladorDominio.BorrarFuente(codigo);
            this.iControladorDominio.GuardarCambios();
            this.CargarDataGridFuentes(this.iControladorDominio.ObtenerTodasLasFuentes());
        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            string filtroTipoFuente = null;
            string filtroDescripcion = null;

            if (checkBoxTipo.Checked && this.comboBoxTipo.Text != "")
                switch (this.comboBoxTipo.SelectedItem.ToString())
                {
                    case "Rss":
                        filtroTipoFuente = "Rss";
                        break;
                    case "Texto Fijo":
                        filtroTipoFuente = "TextoFijo";
                        break;
                }

            if (checkBoxDescripcion.Checked)
                filtroDescripcion = this.textBoxDescripcion.Text;

            List<Fuente> listaFiltrada = this.iControladorDominio.FiltrarFuentes(filtroTipoFuente, filtroDescripcion);
            this.dataGridViewMostrar.DataSource = listaFiltrada;
        }

        private void checkBoxDescripcion_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxDescripcion.Checked)
                this.textBoxDescripcion.Enabled = true;
            else this.textBoxDescripcion.Enabled = false;
        }

        private void checkBoxTipo_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxTipo.Checked)
                this.comboBoxTipo.Enabled = true;
            else this.comboBoxTipo.Enabled = false;
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VBaseFuente_Activated(object sender, EventArgs e)
        {
            this.CargarDataGridFuentes(this.iControladorDominio.ObtenerTodasLasFuentes());
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
    }
}
