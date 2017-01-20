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
    public partial class VBannerBuscarPorCodigo : UI.VAbstractBuscarBanner
    {

        public VBannerBuscarPorCodigo(ref ControladorDominio pControlador):base (ref pControlador)
        {
            InitializeComponent();
            this.label1.Text += " código:";
        }

        protected override void buttonBuscar_Click(object sender, EventArgs e)
        {
            List<Banner> lista = new List<Banner>();
            lista.Add(this.iControlador.BuscarBannerPorId(Convert.ToInt16(this.textBox.Text)));
            ((VBanner)this.MdiParent).CargarDataGridViewBanners(lista);
        }
    }
}
