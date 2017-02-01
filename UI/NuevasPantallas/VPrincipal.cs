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
using Contenedor;

namespace UI.NuevasPantallas
{
    public partial class VPrincipal : Form
    {

        private ControladorDominio iControladorDominio;
        private ControladorContenedor iControladorContenedor;

        public VPrincipal()
        {
            InitializeComponent();
            this.iControladorContenedor = new ControladorContenedor();
            this.iControladorDominio = new ControladorDominio(Resolucionador<IUnitOfWork>.Resolver());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new VBaseBanner(ref iControladorDominio);
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new VCrearCampania(ref iControladorDominio);
            form2.Show();
        }
    }
}
