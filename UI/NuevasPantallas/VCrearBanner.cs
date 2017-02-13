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
    public partial class VCrearBanner : VAbstractCrearModificarBanner
    {
        public VCrearBanner(ref ControladorDominio pControladorDominio) : base(ref pControladorDominio)
        {
            InitializeComponent();
            this.buttonGuardar.Click += ButtonGuardar_Click;
        }

        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            Banner bannerAAgregar = new Banner();
            bannerAAgregar.Titulo = this.textBoxTitulo.Text;
            bannerAAgregar.Descripcion = this.textBoxDescripcion.Text;
            bannerAAgregar.FechaInicio = this.rangoFecha.FechaInicio;
            bannerAAgregar.FechaFin = this.rangoFecha.FechaFin;
            bannerAAgregar.HoraInicio = this.rangoHorario.HoraInicio;
            bannerAAgregar.HoraFin = this.rangoHorario.HoraFin;
            bannerAAgregar.Fuente = (Fuente)this.dataGridViewMostrarFuentes.CurrentRow.DataBoundItem;

            this.iControladorDominio.AgregarBanner(bannerAAgregar);
            this.iControladorDominio.GuardarCambios();
        }
    }
}
