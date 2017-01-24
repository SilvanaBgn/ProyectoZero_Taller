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
    public partial class VFuenteRssNueva : VAbstractFuenteRss
    {
        public VFuenteRssNueva(ref ControladorDominio pControlador):base(ref pControlador)
        {
            InitializeComponent();
            this.buttonCancelar.Name = "Cancelar";
            this.iFuente = new Fuente();
        }

        protected override void buttonGuardar_Click(object sender, EventArgs e)
        {
            //EXCEPCIONES:
            //this.textBoxTitulo y this. textBoxURL completado
            this.iFuente.origenItems = this.textBoxURL.Text;
            this.iFuente.Descripcion = this.textBoxTitulo.Text;
            this.iControlador.AgregarFuente(this.iFuente);
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
