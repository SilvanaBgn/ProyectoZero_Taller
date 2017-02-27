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
    public partial class VNuevaCampania : VAbstractCrearModificarCampania
    {
        //CONSTRUCTOR
        public VNuevaCampania(ref ControladorDominio pControladorDominio) : base(ref pControladorDominio)
        {
            InitializeComponent();
        }

        #region EVENTOS Botones
        /// <summary>
        /// Evento que se invoca cuando se hace click en el botón guardar, agregando una nueva campania
        /// </summary>
        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            this.iCampania = new Campania();
            this.iCampania.Titulo = this.textBoxTitulo.Text;
            this.iCampania.Descripcion = this.textBoxDescripcion.Text;
            this.iCampania.FechaInicio = this.rangoFecha.FechaInicio;
            this.iCampania.FechaFin = this.rangoFecha.FechaFin;
            this.iCampania.HoraInicio = this.rangoHorario.HoraInicio;
            this.iCampania.HoraFin = this.rangoHorario.HoraFin;
            this.iCampania.Imagenes = this.galeria.ListaImagenes;
            this.iCampania.DuracionImagen = this.galeria.Segundos;

            try
            {
                if (!this.rangoHorario.HorarioValido())
                {
                    MessageBox.Show("La hora de fin debe ser posterior a la hora de inicio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Agregamos la fuente y guardamos los cambios:
                    this.iControladorDominio.AgregarCampania(this.iCampania);
                    this.iControladorDominio.GuardarCambios();

                    this.Close();
                }
            }
            catch (ExcepcionCamposSinCompletar ex)
            {
                MessageBox.Show(ex.Message, "Faltan campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
