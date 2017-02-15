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
    public partial class VAbstractCrearModificarCampania : Form
    {
        protected ControladorDominio iControladorDominio;

        public VAbstractCrearModificarCampania()
        {
            InitializeComponent();
        }

        public VAbstractCrearModificarCampania(ref ControladorDominio pControladorDominio) : this()
        {
            this.iControladorDominio = pControladorDominio;
        }
    }
}
