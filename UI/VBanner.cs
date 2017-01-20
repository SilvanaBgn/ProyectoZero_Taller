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
using Microsoft.Practices.Unity;
using Contenedor;
using Excepciones;

namespace UI
{
    public partial class VBanner : Form
    {
        private ControladorDominio iControladorDominio;
        private ControladorContenedor iControladorContenedor;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="pControladorDominio">controlador de dominio</param>
        /// <param name="pControladorContenedor">controlador del contenedor</param>
        public VBanner(ref ControladorDominio pControladorDominio,ref ControladorContenedor pControladorContenedor)
        {
            InitializeComponent();
            this.iControladorDominio = pControladorDominio;
            this.iControladorContenedor = pControladorContenedor;
        }
        
        #region ToolStripMenuItem
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento que se activa cuando se hace click sobre StripMenu, Archivo --> Nuevo --> Banner
        /// </summary>
        private void textoPlanoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VBannerNuevo vNuevoTextoPlano = new VBannerNuevo(ref this.iControladorDominio);
            vNuevoTextoPlano.MdiParent = this;
            vNuevoTextoPlano.Show();
        }

        /// <summary>
        /// Evento que se activa cuando se hace click sobre StripMenu, Archivo --> Nuevo --> Fuente RSS
        /// </summary>
        private void fuenteRssToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VFuenteRssNueva VNuevaFuenteRss = new VFuenteRssNueva(ref this.iControladorDominio);
            VNuevaFuenteRss.MdiParent = this;
            VNuevaFuenteRss.Show();
        }

        /// <summary>
        /// Evento que se activa cuando se da click en StripMenu, editar y luego modificar
        /// </summary>
        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewBanners.SelectedRows.Count == 1)
            {
                string codigo = this.dataGridViewBanners.SelectedRows[0].Cells[0].Value.ToString();
                VBannerModificar ventana = new VBannerModificar(ref this.iControladorDominio, Convert.ToInt32(codigo));
                ventana.MdiParent = this;
                ventana.Show();
            }
            else if (this.dataGridViewFuentesRss.SelectedRows.Count == 1)
                 {
                    string codigo = this.dataGridViewFuentesRss.SelectedRows[0].Cells[0].Value.ToString();
                    VFuenteRssModificar ventana = new VFuenteRssModificar(ref this.iControladorDominio, Convert.ToInt16(codigo));
                    ventana.MdiParent = this;
                    ventana.Show();
                 }
                 else
                    MessageBox.Show("Debe seleccionar una fila a modificar ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        /// <summary>
        /// Evento que se activa cuando se da click en StripMenu, editar y luego borrar
        /// </summary>
        private void borrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridViewBanners.ContainsFocus)
                {

                    var result = MessageBox.Show("¿Está seguro de que desea borrar los Banners seleccionados?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes)
                    {
                        for (int i = 0; i < this.dataGridViewBanners.SelectedRows.Count; i++)
                        {
                            int codigo = Convert.ToInt32(this.dataGridViewBanners.SelectedRows[i].Cells[0].Value.ToString());
                            this.iControladorDominio.BorrarBanner(codigo);
                        }
                        this.iControladorDominio.GuardarCambios();
                        this.CargarDataGridViewBanners(this.iControladorDominio.ObtenerTodosLosBanners());
                        this.CargarDataGridViewFuentesRss(this.iControladorDominio.ObtenerTodasLasFuentes());
                    }
                }
                else
                {
                    if (this.dataGridViewFuentesRss.ContainsFocus)
                    {
                        var result = MessageBox.Show("¿Está seguro de que desea borrar las Fuentes Rss seleccionadas?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (result == DialogResult.Yes)
                        {
                            for (int i = 0; i < this.dataGridViewFuentesRss.SelectedRows.Count; i++)
                            {
                                int codigo = Convert.ToInt32(this.dataGridViewFuentesRss.SelectedRows[i].Cells[0].Value.ToString());
                                this.iControladorDominio.BorrarFuente(codigo);
                            }
                            this.iControladorDominio.GuardarCambios();
                            this.CargarDataGridViewFuentesRss(this.iControladorDominio.ObtenerTodasLasFuentes());
                            this.CargarDataGridViewBanners(this.iControladorDominio.ObtenerTodosLosBanners());
                        }
                    }
                    else
                        MessageBox.Show("Debe seleccionar las filas a borrar ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch(ExcepcionErrorEnLaBusqueda ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ExcepcionAlCargarPantalla ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            catch(ExcepcionErrorAlGuardar)
            {
                MessageBox.Show("Error al guardar: no se pudo borrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ExcepcionGeneral)
            {
                MessageBox.Show("Error: no se pudo borrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion


        #region Eventos

        /// <summary>
        /// Evento que se activa cuando se carga la ventana VBanner
        /// </summary>
        private void VBanner_Load(object sender, EventArgs e)
        {
            try
            {
                this.CambiarColorVentana();
                this.CargarDataGridViewBanners(this.iControladorDominio.ObtenerTodosLosBanners());
                this.CargarDataGridViewFuentesRss(this.iControladorDominio.ObtenerTodasLasFuentes());
            }
            catch(ExcepcionAlCargarPantalla ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        /// <summary>
        /// Establece el fondo de esta ventana del color establecido en la propiedad BackColor
        /// </summary>
        private void CambiarColorVentana()
        {
            MdiClient ctlMDI;

            // Hacemos un for entre todos los controles del Form buscando el control MdiClient
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    //Casteamos el control a un MdiClient
                    ctlMDI = (MdiClient)ctl;

                    ctlMDI.BackColor = this.BackColor;
                }
                catch (InvalidCastException) { } //Agarramos e ignoramos el error si el Casting falla
            }
        }

        /// <summary>
        /// Evento que se activa cuando se hace click sobre una fila del dataGridViewFuenteRSS
        /// </summary>
        private void dataGridViewFuentesRss_Enter(object sender, EventArgs e)
        {
            this.dataGridViewBanners.ClearSelection();
        }

        /// <summary>
        /// Evento que se activa cuando se hace click sobre una fila del dataGridViewBanner
        /// </summary>
        private void dataGridViewBanners_Enter(object sender, EventArgs e)
        {
            this.dataGridViewFuentesRss.ClearSelection();
        }
        #endregion

        #region Buscadores Banner
        /// <summary>
        /// Evento que se activa cuando se da click en StripMenu, buscar y luego buscar por codigo de banner
        /// </summary>
        private void porCódigoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VBannerBuscarPorCodigo buscar = new VBannerBuscarPorCodigo(ref this.iControladorDominio);
            buscar.MdiParent = this;
            buscar.Show();
        }

        /// <summary>
        /// Evento que se activa cuando se da click en StripMenu, buscar y luego buscar por descripcion del banner
        /// </summary>
        private void porDescripciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VBannerBuscarPorDescripcion buscar = new VBannerBuscarPorDescripcion(ref this.iControladorDominio);
            buscar.MdiParent = this;
            buscar.Show();
        }

        /// <summary>
        /// Evento que se activa cuando se da click en StripMenu, buscar y luego buscar por fecha de inicio del banner
        /// </summary>
        private void porFechaDeInicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VBannerBuscarPorFechaInicio buscar = new VBannerBuscarPorFechaInicio(ref this.iControladorDominio);
            buscar.MdiParent = this;
            buscar.Show();
        }

        /// <summary>
        /// Evento que se activa cuando se da click en StripMenu, buscar y luego buscar por hora de inicio del banner
        /// </summary>
        private void porHoraDeInicioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VBannerBuscarPorHoraInicio buscar = new VBannerBuscarPorHoraInicio(ref this.iControladorDominio);
            buscar.MdiParent = this;
            buscar.Show();
        }
        #endregion

        #region Buscadores Fuente Rss
        /// <summary>
        /// Evento que se activa cuando se da click en StripMenu, buscar y luego buscar por codigo de fuente RSS
        /// </summary>
        private void porCódigoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            VFuenteRssBuscarPorCodigo buscar = new VFuenteRssBuscarPorCodigo(ref this.iControladorDominio);
            buscar.MdiParent = this;
            buscar.Show();
        }

        /// <summary>
        /// Evento que se activa cuando se da click en StripMenu, buscar y luego buscar por descripcion de fuente RSS
        /// </summary>
        private void porDescripciónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VFuenteRssBuscarPorTitulo buscar = new VFuenteRssBuscarPorTitulo(ref this.iControladorDominio);
            buscar.MdiParent = this;
            buscar.Show();
        }
        #endregion

        #region Carga de DataGridViews
        /// <summary>
        /// Método para cargar los datos del Data Grid de los Banners
        /// </summary>
        public void CargarDataGridViewBanners(IList<Banner> pLista)
        {
            try
            {
                //this.dataGridViewBanners.DataSource = null;
                //this.dataGridViewBanners.DataSource = pLista;

                ////Visibilidad de Columnas:
                //this.dataGridViewBanners.Columns["PasoBanners"].Visible = false;
                //this.dataGridViewBanners.Columns["FuenteRssId"].Visible = false;
                //this.dataGridViewBanners.Columns["FuenteRss"].Visible = false;
                //this.dataGridViewBanners.Columns["BannerStrategy"].Visible = false;

                ////Nombre de Columnas
                //this.dataGridViewBanners.Columns["BannerId"].HeaderText = "CodBanner";
            }
            catch(Exception ex)
            {
                throw new ExcepcionAlCargarPantalla("Error al cargar los banners",ex);
            }
        }

        /// <summary>
        /// Método para cargar los datos del Data Grid de los Banners
        /// </summary>
        public void CargarDataGridViewFuentesRss(IList<Fuente> pLista)
        {
            try
            {
                this.dataGridViewFuentesRss.DataSource = null;
                this.dataGridViewFuentesRss.DataSource = pLista;

                //Visibilidad de Columnas:
                this.dataGridViewFuentesRss.Columns["Banners"].Visible = false;

                //Nombre de Columnas
                this.dataGridViewFuentesRss.Columns["FuenteId"].HeaderText = "CodFuente";
            }
            catch (Exception ex)
            {
                throw new ExcepcionAlCargarPantalla("Error al cargar las fuentes rss",ex);
            }
        }
        #endregion
    }
}
