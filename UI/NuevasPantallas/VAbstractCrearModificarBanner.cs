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

        //CONSTRUCTOR
        public VAbstractCrearModificarBanner()
        {
            InitializeComponent();

            //Centramos la pantalla en el centro:
            this.StartPosition = FormStartPosition.CenterParent;
        }

        //CONSTRUCTOR
        public VAbstractCrearModificarBanner(ref ControladorDominio pControladorDominio) : this()
        {
            this.iControladorDominio = pControladorDominio;

            //Centramos la pantalla en el centro:
            this.StartPosition = FormStartPosition.CenterScreen;

            this.rangoFecha.FechaInicio = this.rangoFecha.FechaFin = DateTime.Today;
        }

        /// <summary>
        /// Craga el DataGridViewFuentes con la lista de fuentes
        /// </summary>
        protected void CargarDataGridViewFuentes(List<Fuente> pListaFuentes)
        {
            this.dataGridViewMostrarFuentes.DataSource = pListaFuentes;
            this.dataGridViewMostrarFuentes.AutoGenerateColumns = false;
            this.dataGridViewMostrarFuentes.Columns["Tipo"].DisplayIndex = 0;
            this.dataGridViewMostrarFuentes.Columns["Descripcion"].DisplayIndex = 1;
            this.dataGridViewMostrarFuentes.Columns["origenItems"].DisplayIndex = 2;
            this.dataGridViewMostrarFuentes.Columns["origenItems"].HeaderText = "Origen items";
            this.dataGridViewMostrarFuentes.Columns["FuenteId"].Visible = false;
            this.dataGridViewMostrarFuentes.Columns["Banners"].Visible = false;
            this.dataGridViewMostrarFuentes.Columns["Items"].Visible = false;
        }



        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        /// <summary>
        /// Evento que se invoca cuando se activa VAbstractCrearModificarBanner
        /// </summary>
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

        private void VAbstractCrearModificarBanner_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Owner.Show();
        }

        //private void VAbstractCrearModificarBanner_Shown(object sender, EventArgs e)
        //{
        //    this.dataGridViewMostrarFuentes.ClearSelection();
        //}
        private void textBoxValido_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.InputValido(e);
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            VCrearFuente vFuente = new VCrearFuente(ref this.iControladorDominio);
            vFuente.Show();
        }
    }
}
