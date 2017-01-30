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
    public abstract partial class VAbstractCrearModificarBanner : Form
    {

        protected ControladorDominio iControladorDominio;

        public VAbstractCrearModificarBanner()
        {
            InitializeComponent();
        }

        public VAbstractCrearModificarBanner(ref ControladorDominio pControladorDominio) : this()
        {
            this.iControladorDominio = pControladorDominio;
        }
    }
}
