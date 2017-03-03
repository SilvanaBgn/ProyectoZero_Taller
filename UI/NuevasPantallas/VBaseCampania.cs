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
using Excepciones;
using Excepciones.ExcepcionesPantalla;

namespace UI.NuevasPantallas
{
    public partial class VBaseCampania : VAbstractBase
    {
        /// <summary>
        /// Atributo que almacena la Ventana de "Nueva Campania"
        /// </summary>
        private VNuevaCampania iVentanaNueva;

        /// <summary>
        /// Atributo que almacena la Ventana de "Editar Campania"
        /// </summary>
        private VEditarCampania iVentanaEditar;



        public VBaseCampania(ref ControladorDominio pControladorDominio) : base(ref pControladorDominio)
        {
            InitializeComponent();
        }



        #region Funciones privadas
        /// <summary>
        /// Busca la campania que se va a modificar
        /// </summary>
        /// <returns>Devuelve la campania encontrada, null si no se selecciona ninguna</returns>
        private Campania CampaniaSeleccionada()
        {
            if (this.dataGridViewMostrar.SelectedRows.Count == 0)
                return null;
            else
                return (Campania)this.dataGridViewMostrar.SelectedRows[0].DataBoundItem;
        }

        /// <summary>
        /// Muestra en el datagrid los banners que se encuentran en la base de datos
        /// </summary>
        public void CargarDataGridCampanias(List<Campania> pListaCampanias)
        {
            //Cargamos el Datagrid:
            this.dataGridViewMostrar.DataSource = pListaCampanias;

            //Cambiamos el orden, visibilidad y nombre de las columnas:
            this.dataGridViewMostrar.Columns["Imagenes"].Visible = false;

            this.dataGridViewMostrar.Columns["CampaniaId"].DisplayIndex = 0;
            this.dataGridViewMostrar.Columns["Titulo"].DisplayIndex = 1;
            this.dataGridViewMostrar.Columns["FechaInicio"].DisplayIndex = 2;
            this.dataGridViewMostrar.Columns["FechaFin"].DisplayIndex = 3;
            this.dataGridViewMostrar.Columns["HoraInicio"].DisplayIndex = 4;
            this.dataGridViewMostrar.Columns["HoraFin"].DisplayIndex = 5;
            this.dataGridViewMostrar.Columns["DuracionImagen"].DisplayIndex = 6;
            this.dataGridViewMostrar.Columns["Descripcion"].DisplayIndex = 7;

            this.dataGridViewMostrar.Columns["DuracionImagen"].HeaderText = "Duración imágenes";
            this.dataGridViewMostrar.Columns["CampaniaId"].HeaderText = "Cod";
        }
        #endregion


        #region EVENTOS
        #region Botones
        /// <summary>
        /// Evento que se invoca cuando se hace click sobre el botón nuevo, creando una nueva campaña
        /// </summary>
        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            this.iVentanaNueva = new VNuevaCampania(ref iControladorDominio);
            this.iVentanaNueva.Owner = this;
            this.iVentanaNueva.ShowDialog();
            this.iVentanaNueva = null;
        }

        /// <summary>
        /// Evento que se invoca cuando se hace click sobre el botón modificar, modificando una campaña
        /// </summary>
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (this.CampaniaSeleccionada() == null)
                MessageBox.Show("Se debe seleccionar una campaña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                this.iVentanaEditar = new VEditarCampania(ref this.iControladorDominio, this.CampaniaSeleccionada());
                this.iVentanaEditar.Owner = this;
                this.iVentanaEditar.ShowDialog();
                this.iVentanaEditar = null;
            }
        }

        /// <summary>
        /// Evento que se invoca cuando se hace click sobre el botón eliminar, eliminando una campaña.
        /// Actualiza el DataGrid
        /// </summary>
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            Campania campaniaSeleccionada = this.CampaniaSeleccionada();
            if (campaniaSeleccionada == null)
            { MessageBox.Show("Se debe seleccionar una campaña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                string titulo = campaniaSeleccionada.Titulo;
                DialogResult resultado = MessageBox.Show(string.Format("¿Está seguro que desea eliminar la Campaña \"{0}\"?", titulo), "Eliminar Campaña", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        int codigo = campaniaSeleccionada.CampaniaId;
                        this.iControladorDominio.BorrarCampania(codigo);
                        this.iControladorDominio.GuardarCambios();
                        this.CargarDataGridCampanias(this.iControladorDominio.ObtenerTodasLasCampanias());
                    }
                    catch (ExcepcionAlObtenerCampanias) { }
                    catch (ExcepcionAlEliminar ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (ExcepcionAlGuardarCambios ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception)
                    { MessageBox.Show("Ha ocurrido un error. Contacte con el administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }
        #endregion

        #region Ventana y Otros Componentes
        /// <summary>
        /// Evento que se invoca cuando se hace click en el botón filtrar
        /// </summary>
        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            DateTime[] filtroFechas = null;
            TimeSpan[] filtroHoras = null;
            string filtroTitulo = null;
            string filtroDescripcion = null;

            if (this.checkBoxRangoFechas.Checked)
                filtroFechas = new DateTime[] { this.rangoFecha.FechaInicio, this.rangoFecha.FechaFin };
            if (this.checkBoxRangoHoras.Checked)
                filtroHoras = new TimeSpan[] { this.rangoHorario.HoraInicio, this.rangoHorario.HoraFin };
            if (this.checkBoxTitulo.Checked)
                filtroTitulo = this.textBoxTitulo.Text;
            if (this.checkBoxDescripcion.Checked)
                filtroDescripcion = this.textBoxDescripcion.Text;

            try
            {
                List<Campania> listaFiltrada = this.iControladorDominio.FiltrarCampanias(filtroFechas, filtroHoras, filtroTitulo, filtroDescripcion);
                this.CargarDataGridCampanias(listaFiltrada);
            }
            catch (ExcepcionAlObtenerCampanias ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento que se invoca cuando VBaseCampania se activa
        /// </summary>
        private void VBaseCampania_Activated(object sender, EventArgs e)
        {
            try
            {
                //Actualizamos el contenido del Datagrid:
                this.CargarDataGridCampanias(this.iControladorDominio.ObtenerTodasLasCampanias());
            }
            catch (ExcepcionAlObtenerCampanias) { }

            //Preguntamos si las ventanas hijas son nulas, sino significa que están abiertas
            //y les dejamos el foco 
            if (this.iVentanaNueva != null)
                this.iVentanaNueva.Activate();
            else if (this.iVentanaEditar != null)
                this.iVentanaEditar.Activate();
        }

        #endregion

        #endregion

        private void buttonBorrarFiltros_Click(object sender, EventArgs e)
        {
            this.checkBoxDescripcion.Checked = false;
            this.checkBoxRangoFechas.Checked = false;
            this.checkBoxRangoHoras.Checked = false;
            this.checkBoxTitulo.Checked = false;
            this.textBoxDescripcion.Text = "";
            this.textBoxTitulo.Text = "";
            this.buttonFiltrar_Click(sender, e);
            this.buttonBorrarFiltros.Enabled = false;
        }
    }
}
