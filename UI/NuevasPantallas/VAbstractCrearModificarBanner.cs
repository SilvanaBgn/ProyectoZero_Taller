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
    public partial class VAbstractCrearModificarBanner : Form
    {
        protected ControladorDominio iControladorDominio;

        public VAbstractCrearModificarBanner()
        {
            InitializeComponent();
        }

        public VAbstractCrearModificarBanner(ref ControladorDominio pControladorDominio) : this()
        {
            this.iControladorDominio = pControladorDominio;
        }

        protected void CargarDataGridViewFuentes(List<Fuente> pListaFuentes)
        {
            this.dataGridViewMostrarFuentes.DataSource = pListaFuentes;
            this.dataGridViewMostrarFuentes.AutoGenerateColumns = false;
            this.dataGridViewMostrarFuentes.Columns["Tipo"].DisplayIndex = 0;
            this.dataGridViewMostrarFuentes.Columns["Descripcion"].DisplayIndex = 1;
            this.dataGridViewMostrarFuentes.Columns["origenItems"].DisplayIndex = 2;
            this.dataGridViewMostrarFuentes.Columns["origenItems"].HeaderText = "Origen items";
            this.dataGridViewMostrarFuentes.Columns["Banners"].Visible = false;
            this.dataGridViewMostrarFuentes.Columns["Items"].Visible = false;
        }



    private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VAbstractCrearModificarBanner_Activated(object sender, EventArgs e)
        {
            this.CargarDataGridViewFuentes(this.iControladorDominio.ObtenerTodasLasFuentes());
        }

        private Fuente fuenteAModificar()
        {
                return (Fuente)this.dataGridViewMostrarFuentes.SelectedRows[0].DataBoundItem;
        }

        /// <summary>
        /// Devuelve la seleccion a la primer fila si no hay filas seleccionadas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewMostrarFuentes_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewMostrarFuentes.Rows.Count > 0 && this.dataGridViewMostrarFuentes.SelectedRows.Count <= 0)
            {
                this.dataGridViewMostrarFuentes.CurrentCell = this.dataGridViewMostrarFuentes.Rows[0].Cells[1];
                this.dataGridViewMostrarFuentes.Rows[0].Selected = true;
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

        private void textBoxValido_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.InputValido(e);
        }
    }
}
