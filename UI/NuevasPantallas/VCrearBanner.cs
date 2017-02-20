using System;
using Dominio;
using Excepciones.ExcepcionesIntermedias;
using System.Windows.Forms;

namespace UI.NuevasPantallas
{
    public partial class VCrearBanner : VAbstractCrearModificarBanner
    {
        public VCrearBanner(ref ControladorDominio pControladorDominio) : base(ref pControladorDominio)
        {
            InitializeComponent();
            base.CargarDataGridViewFuentes(this.iControladorDominio.ObtenerTodasLasFuentes());
            base.dataGridViewMostrarFuentes.Columns["FuenteId"].Visible = false;
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

            try
            {
                this.iControladorDominio.AgregarBanner(bannerAAgregar);
                this.iControladorDominio.GuardarCambios();
                this.Close();
            }
            catch (ExcepcionValidacionBBDD)
            {
                MessageBox.Show("La fuente ya existe", "Faltan campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
