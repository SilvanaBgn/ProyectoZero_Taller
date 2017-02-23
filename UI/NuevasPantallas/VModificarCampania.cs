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
using Excepciones.ExcepcionesEspecíficas;

namespace UI.NuevasPantallas
{
    public partial class VModificarCampania : VAbstractCrearModificarCampania
    {
        private Campania iCampaniaAModificar;

        //CONSTRUCTOR
        public VModificarCampania(ref ControladorDominio pControladorDominio, Campania pCampaniaAModificar) : base(ref pControladorDominio)
        {
            InitializeComponent();
            this.iCampaniaAModificar = pCampaniaAModificar;
            this.CargarCampaniaAModificar(this.iCampaniaAModificar);
        }

        /// <summary>
        /// Carga en todos los componentes de la ventana VModificarCampania los valores de pCampaniaAModificar
        /// </summary>
        /// <param name="pCampaniaAModificar">campaña a modificar</param>
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

        /// <summary>
        /// Evento que se invoca cuando se hace click en el botón guardar
        /// Guarda todos los datos de la campaña
        /// </summary>
        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            List<Imagen> imagenesViejas = (List<Imagen>)this.iCampaniaAModificar.Imagenes;

            this.iCampaniaAModificar.Titulo = this.textBoxTitulo.Text;
            this.iCampaniaAModificar.Descripcion = this.textBoxDescripcion.Text;
            this.iCampaniaAModificar.FechaInicio = this.rangoFecha.FechaInicio;
            this.iCampaniaAModificar.FechaFin = this.rangoFecha.FechaFin;
            this.iCampaniaAModificar.HoraInicio = this.rangoHorario.HoraInicio;
            this.iCampaniaAModificar.HoraFin = this.rangoHorario.HoraFin;
            this.iCampaniaAModificar.Imagenes = this.galeria.ListaImagenes;
            this.iCampaniaAModificar.DuracionImagen = this.galeria.Segundos;

            //var imagenesABorrar = (from img in imagenesViejas
            //                      let item = iCampaniaAModificar.Imagenes.FirstOrDefault(i => i.ImagenId == img.ImagenId)
            //                      where item == null
            //                      select img).ToList();
            //if (imagenesABorrar.Any())
            //{
            //    foreach (var img in imagenesABorrar)
            //    {
            //        imagenesABorrar = null;
            //    }
            //}





            try
            {
            this.iControladorDominio.ModificarCampania(this.iCampaniaAModificar);
            this.iControladorDominio.GuardarCambios();
            this.Close();
        }
            catch (ExcepcionCamposSinCompletar ex)
            {
                MessageBox.Show(ex.Message, "Faltan campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
