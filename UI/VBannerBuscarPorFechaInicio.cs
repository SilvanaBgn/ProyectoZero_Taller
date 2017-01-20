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
    public partial class VBannerBuscarPorFechaInicio : VAbstractBuscarBanner
    {

        public VBannerBuscarPorFechaInicio(ref ControladorDominio pControlador): base(ref pControlador)
        {
            InitializeComponent();
            this.iControlador = pControlador;
            this.textBox.Visible = false;
            this.label1.Text += " fecha de inicio:";
        }

        protected override void buttonBuscar_Click(object sender, EventArgs e)
        {
            DateTime fecha = this.dateTimePickerInicio.Value;
            List<Banner> lista = (this.iControlador.BuscarBannerPorAtributo(x => x.FechaInicio.Month==fecha.Month && x.FechaInicio.Year==fecha.Year && x.FechaInicio.Day
            ==fecha.Day));
            ((VBanner)this.MdiParent).CargarDataGridViewBanners(lista);
        }
    }
}
