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
        /// banner que se va a modificar (ver si sacar esto)
        /// </summary>
        private Banner banner = new Banner();

        public VBaseBanner(ref ControladorDominio pControladorDominio) : base(ref pControladorDominio)
        {
            InitializeComponent();
            this.iControladorDominio = pControladorDominio;
        }

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

            List<Banner> listaFiltrada=this.iControladorDominio.FiltrarBanners(filtroFechas,filtroHoras,filtroTitulo,filtroDescripcion);
            this.CargarDataGridBanners(listaFiltrada);
        }

        /// <summary>
        /// Devuelve el banner seleccionado en el datagrid
        /// </summary>
        /// <returns>Banner a modificar</returns>
        private Banner bannerAModificar()
        {
            return (Banner)this.dataGridViewMostrar.SelectedRows[0].DataBoundItem;
        }
        /// <summary>
        /// Muestra en el datagrid los banners que se encuentran en la base de datos
        /// </summary>
        public void CargarDataGridBanners(List<Banner> pListaBanners)
        {
            this.dataGridViewMostrar.DataSource = pListaBanners;
        }

        /// <summary>
        /// Evento que se invoca cuando se hace click sobre el botón nuevo creando un nuevo banner
        /// </summary>
        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            var form2 = new VCrearBanner(ref this.iControladorDominio);
            //form2.Owner = this;
            //this.Hide();
            form2.ShowDialog();
        }

        /// <summary>
        /// Evento que se invoca cuando se hace click sobre el botón modificar, modificando un banner
        /// </summary>
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            this.banner = this.bannerAModificar();
            //this.Hide();
            var nuevoForm = new VModificarBanner(ref iControladorDominio,this.bannerAModificar());
            nuevoForm.Show();
        }

        /// <summary>
        /// Evento que se invoca cuando se hace click sobre el botón eliminar, eliminando un banner
        /// Actualiza el DataGrid
        /// </summary>
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(this.dataGridViewMostrar.SelectedRows[0].Cells[0].Value.ToString());
            this.iControladorDominio.BorrarBanner(codigo);
            this.iControladorDominio.GuardarCambios();
            this.CargarDataGridBanners(this.iControladorDominio.ObtenerTodosLosBanners());
        }

        /// <summary>
        /// Evento que se invoca cuando VBaseBanner se activa
        /// </summary>
        private void VBaseBanner_Activated(object sender, EventArgs e)
        {
            CargarDataGridBanners(this.iControladorDominio.ObtenerTodosLosBanners());
        }

        /// <summary>
        /// Evento que se invoca cuando VBaseBanner se carga
        /// </summary>
        private void VBaseBanner_Load(object sender, EventArgs e)
        {
            CargarDataGridBanners(this.iControladorDominio.ObtenerTodosLosBanners());
        }
    }
}
