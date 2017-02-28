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
using Excepciones.ExcepcionesPantalla;

namespace UI.NuevasPantallas
{
    public partial class VEditarCampania : VAbstractCrearModificarCampania
    {

        //CONSTRUCTOR
        public VEditarCampania(ref ControladorDominio pControladorDominio, Campania pCampaniaAModificar) : base(ref pControladorDominio)
        {
            InitializeComponent();
            this.iCampania = pCampaniaAModificar;

        }


        #region Funciones privadas
        /// <summary>
        /// Carga en todos los componentes de la ventana VModificarCampania los valores de pCampaniaAModificar
        /// </summary>
        /// <param name="pCampaniaAModificar">Campania a modificar</param>
        private void CargarCampaniaAModificar(Campania pCampaniaAModificar)
        {
            this.textBoxTitulo.Text = pCampaniaAModificar.Titulo;
            this.textBoxDescripcion.Text = pCampaniaAModificar.Descripcion;
            this.rangoFecha.FechaInicio = pCampaniaAModificar.FechaInicio;
            this.rangoFecha.FechaFin = pCampaniaAModificar.FechaFin;
            this.rangoHorario.HoraInicio = pCampaniaAModificar.HoraInicio;
            this.rangoHorario.HoraFin = pCampaniaAModificar.HoraFin;
            this.galeria.ListaImagenes = (List<Imagen>)pCampaniaAModificar.Imagenes;
            this.galeria.Segundos = pCampaniaAModificar.DuracionImagen;
        }
        #endregion

        #region EVENTOS
        #region Botones
        /// <summary>
        /// Evento que se invoca cuando se hace click en el botón guardar
        /// Guarda todos los datos de la campaña
        /// </summary>
        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            this.buttonGuardar.Enabled = false;
            this.iCampania.Titulo = this.textBoxTitulo.Text;
            this.iCampania.Descripcion = this.textBoxDescripcion.Text;
            this.iCampania.FechaInicio = this.rangoFecha.FechaInicio;
            this.iCampania.FechaFin = this.rangoFecha.FechaFin;
            this.iCampania.Imagenes = this.galeria.ListaImagenes;
            this.iCampania.DuracionImagen = this.galeria.Segundos;

            if (!this.rangoHorario.HorarioValido())
            {
                MessageBox.Show("La hora de fin debe ser posterior a la hora de inicio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.buttonGuardar.Enabled = true;
            }
            else
            {
                this.iCampania.HoraInicio = this.rangoHorario.HoraInicio;
                this.iCampania.HoraFin = this.rangoHorario.HoraFin;

                try
                {
                    //Modificamos la campania y guardamos los cambios:
                    this.iControladorDominio.ModificarCampania(this.iCampania);
                    this.iControladorDominio.GuardarCambios();
                    this.Close();
                }

                catch (ExcepcionCamposSinCompletar ex)
                {
                    MessageBox.Show(ex.Message, "Faltan campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.buttonGuardar.Enabled = true;
                }
                catch (Exception)
                { throw new Exception(); }
            }
        }

        #endregion

        #region Ventana
        /// <summary>
        /// Evento que se activa cuando la ventana ya se ha inicializado y se está cargando
        /// </summary>
        private void VModificarCampania_Load(object sender, EventArgs e)
        {
            this.CargarCampaniaAModificar(this.iCampania);
        }
        #endregion
        #endregion
    }
}
