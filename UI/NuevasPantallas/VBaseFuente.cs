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
        private VCrearFuente iVentanaNueva;
        private VModificarFuente iVentanaEditar;

        private ControladorDominio iControladorDominio;


        //CONSTRUCTOR
        public VBaseFuente(ref ControladorDominio pControladorDominio)
        {
            InitializeComponent();
            this.iControladorDominio = pControladorDominio;
            this.comboBoxTipo.Enabled = false;
            this.textBoxDescripcion.Enabled = false;

            //Centramos la pantalla en el centro:
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// Evento que se invoca cuando se hace click sobre el botón nuevo, creando una nueva fuente
        /// </summary>
        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            this.iVentanaNueva = new VCrearFuente(ref this.iControladorDominio);
            this.iVentanaNueva.Owner = this;
            this.iVentanaNueva.ShowDialog();
            this.iVentanaNueva = null;
        }

        private Fuente fuenteSeleccionada()
        {
            if (this.dataGridViewMostrar.SelectedRows.Count == 0)
                return null;
            else return (Fuente)this.dataGridViewMostrar.SelectedRows[0].DataBoundItem;

        }

        /// <summary>
        /// Evento que se invoca cuando se hace click sobre el botón modificar, modificando una fuente
        /// </summary>
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (this.fuenteSeleccionada() == null)
                MessageBox.Show("Se debe seleccionar una fuente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                this.iVentanaEditar = new VModificarFuente(ref this.iControladorDominio, this.fuenteSeleccionada());
                this.iVentanaEditar.Owner = this;
                this.iVentanaEditar.ShowDialog();
                this.iVentanaEditar = null;
            }
        }

        /// <summary>
        /// Craga el DataGridFuentes con la lista de fuentes
        /// </summary>
        /// <param name="pListaFuentes">lista de fuentes a cargar</param>
        public void CargarDataGridFuentes(List<Fuente> pListaFuentes)
        {
            this.dataGridViewMostrar.DataSource = pListaFuentes;
        }

        /// <summary>
        /// Evento que se invoca cuando se hace click sobre el botón eliminar, eliminando una fuente.
        /// Actualiza el DataGrid
        /// </summary>
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (this.fuenteSeleccionada() == null)
            { MessageBox.Show("Se debe seleccionar una fuente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea eliminar la fuente seleccionada?", "Eliminar Fuente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    int codigo = this.fuenteSeleccionada().FuenteId;
                    this.iControladorDominio.BorrarFuente(codigo);
                    this.iControladorDominio.GuardarCambios();
                    this.CargarDataGridFuentes(this.iControladorDominio.ObtenerTodasLasFuentes());

                }
            }
        }

        /// <summary>
        /// Evento que se invoca cuando se hace click en el botón filtrar
        /// y muestra el nuevo listado de fuentes según los filtros
        /// </summary>
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
            //Actualizamos el contenido del Datagrid:
            this.CargarDataGridFuentes(this.iControladorDominio.ObtenerTodasLasFuentes());

            //Preguntamos si las ventanas hijas son nulas, sino significa que están abiertas
            //y les dejamos el foco 
            if (this.iVentanaNueva != null)
                this.iVentanaNueva.Activate();
            else if (this.iVentanaEditar != null)
                this.iVentanaEditar.Activate();
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

        private void VBaseFuente_Load(object sender, EventArgs e)
        {
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink; //Que no permita redimensionar la ventana
            this.MaximizeBox = false; //Que no permita maximizar
            this.WindowState = FormWindowState.Normal;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
