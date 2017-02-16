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

        protected void CargarDataGridViewFuentes(List<Fuente> pListaFuentes)
        {
            this.dataGridViewMostrarFuentes.DataSource = pListaFuentes;
            this.dataGridViewMostrarFuentes.AutoGenerateColumns = false;
            this.dataGridViewMostrarFuentes.Columns["Tipo"].DisplayIndex = 0;
            this.dataGridViewMostrarFuentes.Columns["Descripcion"].DisplayIndex = 1;
            this.dataGridViewMostrarFuentes.Columns["origenItems"].DisplayIndex = 2;
            this.dataGridViewMostrarFuentes.Columns["origenItems"].HeaderText = "Origen items";
            this.dataGridViewMostrarFuentes.Columns["FuenteId"].Width = 0;
            this.dataGridViewMostrarFuentes.Columns["Banners"].Visible = false;
            this.dataGridViewMostrarFuentes.Columns["Items"].Visible = false;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VAbstractCrearModificarBanner_Activated(object sender, EventArgs e)
        {
            this.CargarDataGridViewFuentes(this.iControladorDominio.ObtenerTodasLasFuentes());
        }

        //private void VAbstractCrearModificarBanner_Shown(object sender, EventArgs e)
        //{
        //    this.dataGridViewMostrarFuentes.ClearSelection();
        //}
    }
}
