using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class PruebaBannerDeslizante : Form
    {
        public PruebaBannerDeslizante()
        {
            InitializeComponent();
            this.bannerDeslizante1.Enabled = false;
        }

        private void buttonComenzar_Click(object sender, EventArgs e)
        {
            this.bannerDeslizante1.TextoCompleto = "hola que tal como te va maria magdalena de los champiniones escribo con la computadora que hermoso weee";
            this.bannerDeslizante1.Start();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            this.bannerDeslizante1.Stop();
        }
    }
}
