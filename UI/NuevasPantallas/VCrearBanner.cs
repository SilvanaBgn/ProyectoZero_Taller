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

        /// <summary>
        /// Evento que se invoca cuando se hace click en el botón guardar, agregando un nuevo banner
        /// </summary>
        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            Banner bannerAAgregar = new Banner();
            bannerAAgregar.Titulo = this.textBoxTitulo.Text;
            bannerAAgregar.Descripcion = this.textBoxDescripcion.Text;
            bannerAAgregar.FechaInicio = this.rangoFecha.FechaInicio;
            bannerAAgregar.FechaFin = this.rangoFecha.FechaFin;
            bannerAAgregar.HoraInicio = this.rangoHorario.HoraInicio;
            bannerAAgregar.HoraFin = this.rangoHorario.HoraFin;

            if (this.dataGridViewMostrarFuentes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Se debe seleccionar una fuente", "Faltan campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bannerAAgregar.FuenteId = ((Fuente)this.dataGridViewMostrarFuentes.CurrentRow.DataBoundItem).FuenteId;
                this.iControladorDominio.AgregarBanner(bannerAAgregar);
                this.iControladorDominio.GuardarCambios();
                this.Close();
            }
        }
    }
}
