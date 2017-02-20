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
    public partial class VCrearCampania : VAbstractCrearModificarCampania
    {
        public VCrearCampania(ref ControladorDominio pControladorDominio) : base(ref pControladorDominio)
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento que se invoca cuando se hace click en el botón guardar, agregando una nueva campaña
        /// </summary>
        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            Campania campaniaAAgregar = new Campania();
            campaniaAAgregar.Titulo = this.textBoxTitulo.Text;
            campaniaAAgregar.Descripcion = this.textBoxDescripcion.Text;
            campaniaAAgregar.FechaInicio = this.rangoFecha.FechaInicio;
            campaniaAAgregar.FechaFin = this.rangoFecha.FechaFin;
            campaniaAAgregar.HoraInicio = this.rangoHorario.HoraInicio;
            campaniaAAgregar.HoraFin = this.rangoHorario.HoraFin;
            campaniaAAgregar.Imagenes = this.galeria.ListaImagenes;

            this.iControladorDominio.AgregarCampania(campaniaAAgregar);
            this.iControladorDominio.GuardarCambios();
            this.Close();
        }

    }
}
