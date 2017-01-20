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
    public partial class VFuenteRssBuscarPorTitulo : VAbstractBuscarFuenteRss
    {
        public VFuenteRssBuscarPorTitulo(ref ControladorDominio pControlador) : base(ref pControlador)
        {
            InitializeComponent();
            this.label1.Text += " descripción:";
        }

        protected override void buttonBuscar_Click(object sender, EventArgs e)
        {
            List<Fuente> lista = (this.iControlador.BuscarFuentePorAtributo(x => x.Descripcion.Contains(this.textBox.Text)));
            ((VBanner)this.MdiParent).CargarDataGridViewFuentesRss(lista);
        }
    }
}
