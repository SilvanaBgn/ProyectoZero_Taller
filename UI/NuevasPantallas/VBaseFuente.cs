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
    public partial class VBaseFuente : Form
    {

        private ControladorDominio iControladorDominio;

        public VBaseFuente()
        {
            InitializeComponent();
        }

        public VBaseFuente(ref ControladorDominio pControladorDominio)
        {
            this.iControladorDominio = pControladorDominio;
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {

        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
