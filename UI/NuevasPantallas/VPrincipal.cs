using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.NuevasPantallas
{
    public partial class VPrincipal : Form
    {
        public VPrincipal()
        {
            InitializeComponent();
        }

        private void bannerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VBaseBanner vBanner = new VBaseBanner();
            vBanner.Show();
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VBaseFuente vFuente = new VBaseFuente();
            vFuente.Show();
        }

        private void campañaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VBaseCampania vCampania = new VBaseCampania();
            vCampania.Show();
        }

        private void vistaToolStripMenuItem_Click(object sender, EventArgs e)
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
