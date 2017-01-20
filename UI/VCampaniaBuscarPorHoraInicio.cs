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
    public partial class VCampaniaBuscarPorHoraInicio : VAbstractBuscarCampania
    {
        public VCampaniaBuscarPorHoraInicio(ref ControladorDominio pControlador): base(ref pControlador)
        {
            InitializeComponent();
            this.label1.Text += " hora:";
        }

        protected override void buttonBuscar_Click(object sender, EventArgs e)
        {
            TimeSpan tiempo = TimeSpan.FromHours(Convert.ToDouble(comboBoxH1.SelectedValue)) + TimeSpan.FromMinutes((Convert.ToDouble(comboBoxM1.SelectedValue)));
            List<Campania> lista = (this.iControlador.BuscarCampaniaPorAtributo(x => x.HoraInicio == tiempo));
            ((VCampania)this.MdiParent).CargarDataGridViewCampania(lista);
        }
    }
}
