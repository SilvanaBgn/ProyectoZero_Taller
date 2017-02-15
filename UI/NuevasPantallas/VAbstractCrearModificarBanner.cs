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

namespace UI.NuevasPantallas
{
    public partial class VAbstractCrearModificarBanner : Form
    {
        protected ControladorDominio iControladorDominio;

        public VAbstractCrearModificarBanner()
        {
            InitializeComponent();
        }

        public VAbstractCrearModificarBanner(ref ControladorDominio pControladorDominio) : this()
        {
            this.iControladorDominio = pControladorDominio;
        }

        private void CargarDataGridViewFuentes(List<Fuente> pListaFuentes)
        {
            this.dataGridViewMostrarFuentes.DataSource = pListaFuentes;
            this.dataGridViewMostrarFuentes.Columns["Banners"].Visible = false;
            this.dataGridViewMostrarFuentes.Columns["Items"].Visible = false;
            this.dataGridViewMostrarFuentes.Columns["FuenteId"].Visible = false;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VAbstractCrearModificarBanner_Load(object sender, EventArgs e)
        {
            this.CargarDataGridViewFuentes(this.iControladorDominio.ObtenerTodasLasFuentes());
        }

        private void VAbstractCrearModificarBanner_Activated(object sender, EventArgs e)
        {
            this.CargarDataGridViewFuentes(this.iControladorDominio.ObtenerTodasLasFuentes());
        }
    }
}
