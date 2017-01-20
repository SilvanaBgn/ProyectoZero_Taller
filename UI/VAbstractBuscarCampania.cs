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
    public partial class VAbstractBuscarCampania : Form
    {
        protected ControladorDominio iControlador;

        public VAbstractBuscarCampania(ref ControladorDominio pControlador)
        {
            InitializeComponent();
            this.iControlador = pControlador;
        }

        protected virtual void BuscarBanner_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((VCampania)this.MdiParent).CargarDataGridViewCampania(this.iControlador.ObtenerTodasLasCampanias().ToList());
        }

        protected virtual void buttonBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
