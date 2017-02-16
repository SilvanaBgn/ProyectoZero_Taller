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
    public partial class VCrearFuente : VAbstractCrearModificarFuente
    {
        public VCrearFuente(ref ControladorDominio pControladorDominio)
        {
            InitializeComponent();
            this.buttonGuardar.Click += ButtonGuardar_Click;
        }

       private void ButtonGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
