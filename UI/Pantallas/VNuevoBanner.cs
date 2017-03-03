using System;
using Dominio;
using System.Windows.Forms;
using Excepciones.ExcepcionesPantalla;
using Excepciones;

namespace UI.Pantallas
{
    public partial class VNuevoBanner : VAbstractCrearModificarBanner
    {
        /// <summary>
        /// Atributo que almacena la Ventana de "Nueva Fuente"
        /// </summary>
        private VNuevaFuente iVentanaNuevaFuente;

        //CONSTRUCTOR
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
            try
            {
                this.CargarDataGridViewFuentes(this.iControladorDominio.ObtenerTodasLasFuentes());
            }
            catch (ExcepcionAlObtenerFuentes) { }

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
            FuenteInformacion fuenteSeleccionada = this.FuenteSeleccionada();

            if (fuenteSeleccionada == null)
            {
                MessageBox.Show("Se debe seleccionar una fuente", "Faltan campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.buttonGuardar.Enabled = true;
            }
            else if (!this.rangoHorario.HorarioValido())
            {
                MessageBox.Show("La hora de fin debe ser posterior a la hora de inicio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.buttonGuardar.Enabled = true;
            }
            else
            {
                try
                {
                    this.iBanner = new Banner();
                    this.iBanner.Titulo = this.textBoxTitulo.Text;
                    this.iBanner.Descripcion = this.textBoxDescripcion.Text;
                    this.iBanner.FechaInicio = this.rangoFecha.FechaInicio;
                    this.iBanner.FechaFin = this.rangoFecha.FechaFin;
                    this.iBanner.HoraInicio = this.rangoHorario.HoraInicio;
                    this.iBanner.HoraFin = this.rangoHorario.HoraFin;
                    this.iBanner.FuenteId = fuenteSeleccionada.FuenteId;

                    //Agregamos el banner y guardamos los cambios:
                    this.iControladorDominio.AgregarBanner(this.iBanner);
                    this.iControladorDominio.GuardarCambios();
                    this.Close();
                }
                catch (ExcepcionCamposSinCompletar ex)
                {
                    MessageBox.Show(ex.Message, "Faltan campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.buttonGuardar.Enabled = true;
                }
                catch (ExcepcionAlAgregar ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.buttonGuardar.Enabled = true;
                }
                catch (ExcepcionAlGuardarCambios ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.buttonGuardar.Enabled = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error. Contacte con el administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.buttonGuardar.Enabled = true;
                }
            }
        }

        /// <summary>
        /// Evento que se activa cuando se apreta el botón this.buttonNuevaFuente, para abrir VNuevaFuente
        /// </summary>
        private void buttonNuevaFuente_Click(object sender, EventArgs e)
        {
            this.iVentanaNuevaFuente = new VNuevaFuente(ref this.iControladorDominio);
            this.iVentanaNuevaFuente.Owner = this;
            this.iVentanaNuevaFuente.ShowDialog();
            this.iVentanaNuevaFuente = null;
        }

        /// <summary>
        /// Evento que se invoca cuando se activa VNuevoBanner.
        /// </summary>
        private void VNuevoBanner_Activated(object sender, EventArgs e)
        {
            //Ejecuta el Activated del padre:
            base.VAbstractCrearModificarBanner_Activated(sender, e);

            //Activa la ventana atributo this.iVentanaNuevaFuente:
            if (this.iVentanaNuevaFuente != null)
                this.iVentanaNuevaFuente.Activate();
        }
        #endregion

        #endregion


    }
}
