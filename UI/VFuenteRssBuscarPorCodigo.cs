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
    public partial class VFuenteRssBuscarPorCodigo : VAbstractBuscarFuenteRss
    {

        public VFuenteRssBuscarPorCodigo(ref ControladorDominio pControlador):base (ref pControlador)
        {
            InitializeComponent();
            this.label1.Text += " código:";
        }

        protected override void buttonBuscar_Click(object sender, EventArgs e)
        {
            List<Fuente> lista = new List<Fuente>();
            lista.Add(this.iControlador.BuscarFuentePorId(Convert.ToInt16(this.textBox.Text)));
            ((VBanner)this.MdiParent).CargarDataGridViewFuentesRss(lista);
        }
    }
}
