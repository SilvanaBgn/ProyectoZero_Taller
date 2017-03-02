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
using Helper;

namespace UI.NuevasPantallas
{
    public partial class VAbstractCrearModificarBanner : Form
    {
        /// <summary>
        /// Atributo que almacena el Controlador de Dominio
        /// </summary>
        protected ControladorDominio iControladorDominio;

        /// <summary>
        /// Atributo que se utiliza para almacenar el banner
        /// </summary>
        protected Banner iBanner;



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
        



        #region Funciones protegidas
        /// <summary>
        /// Carga el DataGridViewFuentes con la lista de fuentes
        /// </summary>
        protected void CargarDataGridViewFuentes(List<Fuente> pListaFuentes)
        {
            //Asignamos la lista al DataSource del DataGrid:
            this.dataGridViewMostrarFuentes.DataSource = pListaFuentes;
            //Propiedad para que las columnas no se creen automáticamente:
            this.dataGridViewMostrarFuentes.AutoGenerateColumns = false;

            //Orden, nombre y visibilidad de las columnas:
            this.dataGridViewMostrarFuentes.Columns["Tipo"].DisplayIndex = 0;
            this.dataGridViewMostrarFuentes.Columns["Descripcion"].DisplayIndex = 1;
            this.dataGridViewMostrarFuentes.Columns["origenItems"].DisplayIndex = 2;
            this.dataGridViewMostrarFuentes.Columns["origenItems"].HeaderText = "Origen items";
            this.dataGridViewMostrarFuentes.Columns["FuenteId"].Visible = false;
            this.dataGridViewMostrarFuentes.Columns["Banners"].Visible = false;
            this.dataGridViewMostrarFuentes.Columns["Items"].Visible = false;
        }
 
        /// <summary>
        /// Indica cuál es la fuente que está seleccionada actualmente en el this.dataGridViewMostrarFuentes
        /// </summary>
        /// <returns>Devuelve la fuente seleccionada </returns>
        protected Fuente FuenteSeleccionada()
        {
            if (this.dataGridViewMostrarFuentes.SelectedRows.Count == 0)
                return null;
            return (Fuente)this.dataGridViewMostrarFuentes.SelectedRows[0].DataBoundItem;
        }
        #endregion


        #region EVENTOS
        #region Botones
        /// <summary>
        /// Evento que se activa cuando se apreta el botón this.buttonCancelar, para cancelar la adición/edición
        /// </summary>
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Ventana y Otros Componentes
        /// <summary>
        /// Evento que se invoca cuando se activa VAbstractCrearModificarBanner.
        /// </summary>
        protected void VAbstractCrearModificarBanner_Activated(object sender, EventArgs e)
        {
            this.CargarDataGridViewFuentes(this.iControladorDominio.ObtenerTodasLasFuentes());
        }

        /// <summary>
        /// Devuelve la seleccion a la primer fila si no hay filas seleccionadas
        /// </summary>
        private void dataGridViewMostrarFuentes_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewMostrarFuentes.Rows.Count > 0 && this.dataGridViewMostrarFuentes.SelectedRows.Count <= 0)
            {
                this.dataGridViewMostrarFuentes.CurrentCell = this.dataGridViewMostrarFuentes.Rows[0].Cells[1];
                this.dataGridViewMostrarFuentes.Rows[0].Selected = true;
            }
        }

        /// <summary>
        /// Evento que se activa cuando se quiere introducir texto en algun textBox
        /// </summary>
        private void textBoxValido_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionTexto.InputValido(e);
        }
        #endregion

        #endregion

    }
}
