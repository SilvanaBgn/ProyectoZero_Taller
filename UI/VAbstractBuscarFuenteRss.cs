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
    public partial class VAbstractBuscarFuenteRss : Form
    {
        protected ControladorDominio iControlador;

        public VAbstractBuscarFuenteRss(ref ControladorDominio pControlador)
        {
            InitializeComponent();
        }

        protected virtual void BuscarFuente_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((VBanner)this.MdiParent).CargarDataGridViewBanners(this.iControlador.ObtenerTodosLosBanners().ToList());
        }

        protected virtual void buttonBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
