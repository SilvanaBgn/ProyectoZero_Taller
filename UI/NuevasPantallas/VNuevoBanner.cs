using System;
using Dominio;
using System.Windows.Forms;

namespace UI.NuevasPantallas
{
    public partial class VNuevoBanner : VAbstractCrearModificarBanner
    {
        public VNuevoBanner(ref ControladorDominio pControladorDominio) : base(ref pControladorDominio)
        {
            InitializeComponent();
        }

        #region EVENTOS
        /// <summary>
        /// Evento que se activa cuando la ventana de este Form se muestra
        /// </summary>
        private void VNuevoBanner_Shown(object sender, EventArgs e)
        {
            this.CargarDataGridViewFuentes(this.iControladorDominio.ObtenerTodasLasFuentes());
            this.dataGridViewMostrarFuentes.Columns["FuenteId"].Visible = false;

            //Re-dimensionamos el datagrid para mostrar el botón this.buttonNuevaFuente
            this.dataGridViewMostrarFuentes.Location = new System.Drawing.Point(6, 65);
            this.dataGridViewMostrarFuentes.Size = new System.Drawing.Size(436, 148);
        }


        #region Botones
        /// <summary>
        /// Evento que se invoca cuando se hace click en el botón guardar, agregando un nuevo banner
        /// </summary>
        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            this.buttonGuardar.Enabled = false;
            this.iBanner = new Banner();
            this.iBanner.Titulo = this.textBoxTitulo.Text;
            this.iBanner.Descripcion = this.textBoxDescripcion.Text;
            this.iBanner.FechaInicio = this.rangoFecha.FechaInicio;
            this.iBanner.FechaFin = this.rangoFecha.FechaFin;
            this.iBanner.HoraInicio = this.rangoHorario.HoraInicio;
            this.iBanner.HoraFin = this.rangoHorario.HoraFin;

            Fuente fuenteSeleccionada = this.FuenteSeleccionada();
            if (fuenteSeleccionada==null)
            {
                MessageBox.Show("Se debe seleccionar una fuente", "Faltan campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!this.rangoHorario.HorarioValido())
            {
                MessageBox.Show("La hora de fin debe ser posterior a la hora de inicio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.iBanner.FuenteId = fuenteSeleccionada.FuenteId;

                //Agregamos el banner y guardamos los cambios:
                this.iControladorDominio.AgregarBanner(this.iBanner);
                this.iControladorDominio.GuardarCambios();

                this.Close();
            }
            this.buttonGuardar.Enabled = true;
        }

        /// <summary>
        /// Evento que se activa cuando se apreta el botón this.buttonNuevaFuente, para abrir VNuevaFuente
        /// </summary>
        private void buttonNuevaFuente_Click(object sender, EventArgs e)
        {
            VNuevaFuente vFuente = new VNuevaFuente(ref this.iControladorDominio);
            vFuente.Show();
        }
        #endregion

        #endregion
    }
}
