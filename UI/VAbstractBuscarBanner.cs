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
    public partial class VAbstractBuscarBanner : Form
    {
        protected ControladorDominio iControlador;

        public VAbstractBuscarBanner(ref ControladorDominio pControlador)
        {
            InitializeComponent();
            this.iControlador = pControlador;
        }

        protected virtual void BuscarBanner_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((VBanner)this.MdiParent).CargarDataGridViewBanners(this.iControlador.ObtenerTodosLosBanners().ToList());
        }

        protected virtual void buttonBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
