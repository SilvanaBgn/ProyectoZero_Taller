using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.NuevasPantallas;
using Dominio;

namespace UI.NuevasPantallas
{
    public partial class VBaseBanner : VAbstractBase
    {
        /// <summary>
        /// Atributo que almacena la Ventana de "Nuevo Banner"
        /// </summary>
        private VNuevoBanner iVentanaNuevo;

        /// <summary>
        /// Atributo que almacena la Ventana de "Editar Banner"
        /// </summary>
        private VEditarBanner iVentanaEditar;


        //CONSTRUCTOR
        public VBaseBanner(ref ControladorDominio pControladorDominio) : base(ref pControladorDominio)
        {
            InitializeComponent();
        }



        #region Funciones privadas
        /// <summary>
        /// Devuelve el banner seleccionado en el datagrid
        /// </summary>
        /// <returns>Banner a modificar</returns>
        private Banner BannerSeleccionado()
        {
            if (this.dataGridViewMostrar.SelectedRows.Count == 0)
                return null;
            else return (Banner)this.dataGridViewMostrar.SelectedRows[0].DataBoundItem;
        }

        /// <summary>
        /// Carga el datagrid con los banners que se le pasen en la lista <paramref name="pListaBanners"/>
        /// </summary>
        private void CargarDataGridBanners(List<Banner> pListaBanners)
        {
            //Cargamos el Datagrid:
            this.dataGridViewMostrar.DataSource = pListaBanners;

            //Cambiamos el orden, visibilidad y nombre de las columnas:
            this.dataGridViewMostrar.Columns["FuenteId"].Visible = false;

            this.dataGridViewMostrar.Columns["BannerId"].DisplayIndex = 0;
            this.dataGridViewMostrar.Columns["Titulo"].DisplayIndex = 1;
            this.dataGridViewMostrar.Columns["FechaInicio"].DisplayIndex = 2;
            this.dataGridViewMostrar.Columns["FechaFin"].DisplayIndex = 3;
            this.dataGridViewMostrar.Columns["HoraInicio"].DisplayIndex = 4;
            this.dataGridViewMostrar.Columns["HoraFin"].DisplayIndex = 5;
            this.dataGridViewMostrar.Columns["Descripcion"].DisplayIndex = 6;

            this.dataGridViewMostrar.Columns["BannerId"].HeaderText = "Cod";
        }
        #endregion

        #region EVENTOS
        #region Botones
        /// <summary>
        /// Evento que se invoca cuando se hace click sobre el botón nuevo creando un nuevo banner
        /// </summary>
        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            this.iVentanaNuevo = new VNuevoBanner(ref this.iControladorDominio);
            this.iVentanaNuevo.Owner = this;
            this.iVentanaNuevo.ShowDialog();
            this.iVentanaNuevo = null;
        }

        /// <summary>
        /// Evento que se invoca cuando se hace click sobre el botón modificar, modificando un banner
        /// </summary>
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (this.BannerSeleccionado() == null)
                MessageBox.Show("Se debe seleccionar un banner", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                this.iVentanaEditar = new VEditarBanner(ref this.iControladorDominio, this.BannerSeleccionado());
                this.iVentanaEditar.Owner = this;
                this.iVentanaEditar.ShowDialog();
                this.iVentanaEditar = null;
            }
        }

        /// <summary>
        /// Evento que se invoca cuando se hace click sobre el botón eliminar, eliminando un banner
        /// Actualiza el DataGrid
        /// </summary>
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            Banner bannerSeleccionado = this.BannerSeleccionado();
            if (bannerSeleccionado == null)
                MessageBox.Show("Se debe seleccionar un banner", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string titulo = bannerSeleccionado.Titulo;
                DialogResult dialogResult = MessageBox.Show(string.Format("¿Está seguro que desea eliminar el banner \"{0}\"?", titulo), "Eliminar Banner", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        int codigo = bannerSeleccionado.BannerId;
                        this.iControladorDominio.BorrarBanner(codigo);
                        this.iControladorDominio.GuardarCambios();
                        this.CargarDataGridBanners(this.iControladorDominio.ObtenerTodosLosBanners());
                    }
                    catch (Exception)
                    { MessageBox.Show("No se pudo borrar el banner", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }
        #endregion

        #region Ventana y Otros Componentes
        /// <summary>
        /// Evento que se invoca cuando se hace click en el botón filtrar y muestra 
        /// el nuevo listado de banners según los filtros
        /// </summary>
        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            DateTime[] filtroFechas = null;
            TimeSpan[] filtroHoras = null;
            string filtroTitulo = null;
            string filtroDescripcion = null;

            if (checkBoxRangoFechas.Checked)
                filtroFechas = new DateTime[] { this.rangoFecha.FechaInicio, this.rangoFecha.FechaFin };
            if (checkBoxRangoHoras.Checked)
                filtroHoras = new TimeSpan[] { this.rangoHorario.HoraInicio, this.rangoHorario.HoraFin };
            if (checkBoxTitulo.Checked)
                filtroTitulo = this.textBoxTitulo.Text;
            if (checkBoxDescripcion.Checked)
                filtroDescripcion = this.textBoxDescripcion.Text;

            List<Banner> listaFiltrada = this.iControladorDominio.FiltrarBanners(filtroFechas, filtroHoras, filtroTitulo, filtroDescripcion);
            this.CargarDataGridBanners(listaFiltrada);
            this.buttonBorrarFiltros.Enabled = true;
        }

        /// <summary>
        /// Evento que se invoca cuando VBaseBanner se activa
        /// </summary>
        private void VBaseBanner_Activated(object sender, EventArgs e)
        {
            //Actualizamos el contenido del Datagrid:
            this.CargarDataGridBanners(this.iControladorDominio.ObtenerTodosLosBanners());

            //Preguntamos si las ventanas hijas son nulas, sino significa que están abiertas
            //y les dejamos el foco 
            if (this.iVentanaNuevo != null)
                this.iVentanaNuevo.Activate();
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
