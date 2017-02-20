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
    public partial class VBaseFuente : Form
    {

        private ControladorDominio iControladorDominio;

        //CONSTRUCTOR
        public VBaseFuente(ref ControladorDominio pControladorDominio)
        {
            InitializeComponent();
            this.iControladorDominio = pControladorDominio;
            this.comboBoxTipo.Enabled = false;
            this.textBoxDescripcion.Enabled = false;
        }

        /// <summary>
        /// Evento que se invoca cuando se hace click sobre el botón nuevo, creando una nueva fuente
        /// </summary>
        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            VCrearFuente vFuente = new VCrearFuente(ref this.iControladorDominio);
            vFuente.Show();
        }

        /// <summary>
        /// Evento que se invoca cuando se hace click sobre el botón modificar, modificando una fuente
        /// </summary>
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            VModificarFuente vFuente = new VModificarFuente(ref this.iControladorDominio);
            vFuente.Show();
        }

        /// <summary>
        /// Craga el DataGridFuentes con la lista de fuentes
        /// </summary>
        /// <param name="pListaFuentes">lista de fuentes a cargar</param>
        public void CargarDataGridFuentes(List<Fuente> pListaFuentes)
        {
            this.dataGridViewMostrar.DataSource = pListaFuentes;
            this.dataGridViewMostrar.Columns["Banners"].Visible = false;
            this.dataGridViewMostrar.Columns["Tipo"].Visible = false;
            this.dataGridViewMostrar.Columns["Items"].Visible = false;
            this.dataGridViewMostrar.Columns["FuenteId"].Visible = false;
        }

        /// <summary>
        /// Evento que se invoca cuando se hace click sobre el botón eliminar, eliminando una fuente.
        /// Actualiza el DataGrid
        /// </summary>
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(this.dataGridViewMostrar.SelectedRows[0].Cells[0].Value.ToString());
            this.iControladorDominio.BorrarFuente(codigo);
            this.iControladorDominio.GuardarCambios();
            this.CargarDataGridFuentes(this.iControladorDominio.ObtenerTodasLasFuentes());
        }

        /// <summary>
        /// Evento que se invoca cuando se hace click en el botón filtrar
        /// y muestra el nuevo listado de fuentes según los filtros
        /// </summary>
        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            string filtroTipoFuente = null;
            string filtroDescripcion = null;

            if (checkBoxTipo.Checked)
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
        /// Evento que se invoca cuando cambia el valor del checkBoxTipo
        /// </summary>
        private void checkBoxTipo_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxTipo.Checked)
                this.comboBoxTipo.Enabled = true;
            else this.comboBoxTipo.Enabled = false;
        }

        /// <summary>
        /// Evento que se invoca cuando se hace click en el botón salir, cerrando la ventana
        /// </summary>
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento que se invoca cuando VBaseFuente se activa
        /// </summary>
        private void VBaseFuente_Activated(object sender, EventArgs e)
        {
            this.CargarDataGridFuentes(this.iControladorDominio.ObtenerTodasLasFuentes());
        }

        /// <summary>
        /// Evento que se invoca cuando VBaseFuente se carga
        /// </summary>
        private void VBaseFuente_Load(object sender, EventArgs e)
        {
            this.CargarDataGridFuentes(this.iControladorDominio.ObtenerTodasLasFuentes());
        }
    }
}
