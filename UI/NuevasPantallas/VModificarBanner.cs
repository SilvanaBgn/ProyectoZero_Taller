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
    public partial class VModificarBanner : VAbstractCrearModificarBanner
    {
        private Banner iBannerAModificar;

        //CONSTRUCTOR
        public VModificarBanner(ref ControladorDominio pControladorDominio, Banner pBannerAModificar) : base(ref pControladorDominio)
        {
            InitializeComponent();
            this.iBannerAModificar = pBannerAModificar;
            this.CargarBannerAModificar(this.iBannerAModificar);
            base.CargarDataGridViewFuentes(this.iControladorDominio.ObtenerTodasLasFuentes());
            this.dataGridViewMostrarFuentes.Size= new System.Drawing.Size(436, this.dataGridViewMostrarFuentes.Rows[0].Height*2);
        }

        /// <summary>
        /// Este método selecciona la fuente que le corresponda al banner
        /// </summary>
        private void SeleccionarFuenteDelBanner()
        {
            int indiceFila = -1;

            DataGridViewRow row = this.dataGridViewMostrarFuentes.Rows
                .Cast<DataGridViewRow>()
                .Where(r => r.Cells["FuenteId"].Value.ToString().Equals(this.iBannerAModificar.FuenteId.ToString()))
                .First();

            indiceFila = row.Index;

            base.dataGridViewMostrarFuentes.Rows[0].Selected = false;
            base.dataGridViewMostrarFuentes.Rows[indiceFila].Selected = true;
            base.dataGridViewMostrarFuentes.CurrentCell = this.dataGridViewMostrarFuentes.Rows[indiceFila].Cells[1];
            base.dataGridViewMostrarFuentes.Columns["FuenteId"].Visible = false;
        }

        /// <summary>
        /// Craga en todos los componentes de la ventana VModificarBanner los valores de pBannerAModificar
        /// </summary>
        /// <param name="pBannerAModificar">banner a modificar</param>
        private void CargarBannerAModificar(Banner pBannerAModificar)
        {
            this.textBoxTitulo.Text = pBannerAModificar.Titulo;
            this.textBoxDescripcion.Text = pBannerAModificar.Descripcion;
            this.rangoFecha.FechaInicio = pBannerAModificar.FechaInicio;
            this.rangoFecha.FechaFin = pBannerAModificar.FechaFin;
            this.rangoHorario.HoraInicio = pBannerAModificar.HoraInicio;
            this.rangoHorario.HoraFin = pBannerAModificar.HoraFin;
        }

        /// <summary>
        /// Evento que se invoca cuando se hace click en el botón guardar
        /// Guarda todos los datos del banner
        /// </summary>
        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            this.iBannerAModificar.Titulo = this.textBoxTitulo.Text;
            this.iBannerAModificar.Descripcion = this.textBoxDescripcion.Text;
            this.iBannerAModificar.FechaInicio = this.rangoFecha.FechaInicio;
            this.iBannerAModificar.FechaFin = this.rangoFecha.FechaFin;
            this.iBannerAModificar.HoraInicio = this.rangoHorario.HoraInicio;
            this.iBannerAModificar.HoraFin = this.rangoHorario.HoraFin;

            this.iControladorDominio.ModificarBanner(this.iBannerAModificar);
            this.iControladorDominio.GuardarCambios();

            this.Close();
        }


    //private void VModificarBanner_Shown(object sender, EventArgs e)
    //{
    //    //this.dataGridViewMostrarFuentes.ClearSelection();
    //    this.SeleccionarFuenteDelBanner();
    //}

    /// <summary>
    /// Este evento se activa cuando VModificarBanner se encuentra activada
    /// </summary>
    private void VModificarBanner_Activated(object sender, EventArgs e)
    {
        this.dataGridViewMostrarFuentes.ClearSelection();
        this.SeleccionarFuenteDelBanner();
    }
}
}
