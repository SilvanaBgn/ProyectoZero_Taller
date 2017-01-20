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
    public partial class VCampaniaBuscarPorFechaInicio : VAbstractBuscarCampania
    {
        public VCampaniaBuscarPorFechaInicio(ref ControladorDominio pControlador):base(ref pControlador)
        {
            InitializeComponent();
            this.label1.Text += " fecha:";
        }

        protected override void buttonBuscar_Click(object sender, EventArgs e)
        {
            DateTime fecha = this.dateTimePickerInicio.Value;
            List<Campania> lista = (this.iControlador.BuscarCampaniaPorAtributo
                (x => x.FechaInicio.Month == fecha.Month && x.FechaInicio.Year == fecha.Year && x.FechaInicio.Day
                                                                                                == fecha.Day));
            ((VCampania)this.MdiParent).CargarDataGridViewCampania(lista);
        }
    }
}
