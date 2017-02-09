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

        public VModificarBanner(ref ControladorDominio pControladorDominio, Banner pBannerAModificar) : base(ref pControladorDominio)
        {
            InitializeComponent();
            this.iBannerAModificar = pBannerAModificar;
            this.CargarBannerAModificar(this.iBannerAModificar);
            this.buttonGuardar.Click += ButtonGuardar_Click;
        }

        private void CargarBannerAModificar(Banner bannerAModificar)
        {
            this.textBoxTitulo.Text = bannerAModificar.Titulo;
            this.textBoxDescripcion.Text = bannerAModificar.Descripcion;
            this.rangoFecha.FechaInicio = bannerAModificar.FechaInicio;
            this.rangoFecha.FechaFin = bannerAModificar.FechaFin;
            this.rangoHorario.HoraInicio = bannerAModificar.HoraInicio;
            this.rangoHorario.HoraFin = bannerAModificar.HoraFin;
        }

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

            this.Hide();
        }
    }
}
