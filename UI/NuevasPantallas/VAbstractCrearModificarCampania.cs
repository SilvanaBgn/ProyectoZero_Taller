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
using System.Text.RegularExpressions;

namespace UI.NuevasPantallas
{
    public partial class VAbstractCrearModificarCampania : Form
    {
        protected ControladorDominio iControladorDominio;

        //CONSTRUCTOR
        public VAbstractCrearModificarCampania()
        {
            InitializeComponent();
        }
        //CONSTRUCTOR
        public VAbstractCrearModificarCampania(ref ControladorDominio pControladorDominio) : this()
        {
            this.iControladorDominio = pControladorDominio;
        }

        private void InputValido(KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z0-9\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void textBoxValido_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.InputValido(e);
        }
    }
}
