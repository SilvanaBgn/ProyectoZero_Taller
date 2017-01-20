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
    public partial class VBannerBuscarPorHoraInicio : VAbstractBuscarBanner
    {
        public VBannerBuscarPorHoraInicio(ref ControladorDominio pControlador):base(ref pControlador)
        {
            InitializeComponent();
            this.label1.Text += " hora:";
            this.textBox.Visible = false;
        }

        protected override void buttonBuscar_Click(object sender, EventArgs e)
        {
            TimeSpan tiempo = TimeSpan.FromHours(Convert.ToDouble(comboBoxH1.SelectedValue)) + TimeSpan.FromMinutes((Convert.ToDouble(comboBoxM1.SelectedValue)));
            List<Banner> lista = (this.iControlador.BuscarBannerPorAtributo(x => x.HoraInicio == tiempo));
            ((VBanner)this.MdiParent).CargarDataGridViewBanners(lista);
        }
    }
}
