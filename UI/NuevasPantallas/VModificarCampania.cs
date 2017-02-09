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
    public partial class VModificarCampania : VAbstractCrearModificarCampania
    {
        private Campania iCampaniaAModificar;

        public VModificarCampania(ref ControladorDominio pControladorDominio, Campania pCampaniaAModificar) : base(ref pControladorDominio)
        {
            InitializeComponent();
            this.iCampaniaAModificar = pCampaniaAModificar;
            this.CargarCampaniaAModificar(this.iCampaniaAModificar);
            this.buttonGuardar.Click += ButtonGuardar_Click;
        }

        private void CargarCampaniaAModificar(Campania campaniaAModificar)
        {
            this.textBoxTitulo.Text = campaniaAModificar.Titulo;
            this.textBoxDescripcion.Text = campaniaAModificar.Descripcion;
            this.rangoFecha.FechaInicio = campaniaAModificar.FechaInicio;
            this.rangoFecha.FechaFin = campaniaAModificar.FechaFin;
            this.rangoHorario.HoraInicio = campaniaAModificar.HoraInicio;
            this.rangoHorario.HoraFin = campaniaAModificar.HoraFin;
            this.galeria.ListaImagenes = (List<Imagen>)campaniaAModificar.Imagenes;
        }

        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            this.iCampaniaAModificar.Titulo = this.textBoxTitulo.Text;
            this.iCampaniaAModificar.Descripcion = this.textBoxDescripcion.Text;
            this.iCampaniaAModificar.FechaInicio = this.rangoFecha.FechaInicio;
            this.iCampaniaAModificar.FechaFin = this.rangoFecha.FechaFin;
            this.iCampaniaAModificar.HoraInicio = this.rangoHorario.HoraInicio;
            this.iCampaniaAModificar.HoraFin = this.rangoHorario.HoraFin;
            this.iCampaniaAModificar.Imagenes = this.galeria.ListaImagenes;

            this.iControladorDominio.ModificarCampania(this.iCampaniaAModificar);
            this.iControladorDominio.GuardarCambios();

            this.Hide();
        }
    }
}
