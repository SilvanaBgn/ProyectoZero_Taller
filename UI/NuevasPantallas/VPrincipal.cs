using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Contenedor;
using Dominio;

namespace UI.NuevasPantallas
{
    public partial class VPrincipal : Form
    {

        private ControladorDominio iControladorDominio;
        private ControladorContenedor iControladorContenedor;
        private System.Timers.Timer iTimerBanner;
        private System.Timers.Timer iTimerCampania;


        public VPrincipal()
        {
            InitializeComponent();
            this.iControladorContenedor = new ControladorContenedor();
            this.iControladorDominio = new ControladorDominio(Resolucionador<IUnitOfWork>.Resolver());
        }

        private void bannerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VBaseBanner vBanner = new VBaseBanner(ref this.iControladorDominio);
            vBanner.Show();
        }

        private void campañaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VBaseCampania vCampania = new VBaseCampania();
            vCampania.Show();
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VBaseFuente vFuente = new VBaseFuente();
            vFuente.Show();
        }

        private void verPantallaCompletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.menuStrip1.Visible = false;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
