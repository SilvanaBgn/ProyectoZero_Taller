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

namespace UI
{
    public partial class VFuenteRssModificar : UI.VAbstractFuenteRss
    {
        public VFuenteRssModificar(ref ControladorDominio pControlador, int pCodigoRss) : base(ref pControlador)
        {
            InitializeComponent();
            this.buttonCancelar.Name = "Cancelar";

            this.iFuente = this.iControlador.BuscarFuentePorId(pCodigoRss);
            this.textBoxTitulo.Text = this.iFuente.Descripcion;

            //this.textBoxURL.Text = this.iFuente.Url.ToString();
        }

        protected override void buttonGuardar_Click(object sender, EventArgs e)
        {
            //EXCEPCIONES:
            //this.textBoxTitulo completado
            //this.listBoxPasosBanners con al menos un item
            //this.dateTimePickerInicio <= this.dateTimePickerFin
            //que los comboBox de la hora de inicio sean menores a los de la hora de fin
            this.iFuente.Descripcion = this.textBoxTitulo.Text;

            //this.iFuente.Url = this.textBoxURL.Text;

            this.iControlador.ModificarFuente(this.iFuente);
            this.iControlador.GuardarCambios();
            
            this.Close();
        }

        protected override void buttonSalir_Click(object sender, EventArgs e)
        {
            this.iControlador.CancelarCambios();
            base.buttonSalir_Click(sender, e);
        }
    }
}
