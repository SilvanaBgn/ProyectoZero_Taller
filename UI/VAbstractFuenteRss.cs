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
using UI;

namespace UI
{
    public abstract partial class VAbstractFuenteRss : Form
    {
        protected ControladorDominio iControlador;
        protected FuenteRss iFuente;

        public VAbstractFuenteRss()
        {
            InitializeComponent();
        }

        public VAbstractFuenteRss(ref ControladorDominio pControlador): this()
        {
            this.iControlador = pControlador;
        }

        protected virtual void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VFuenteRss_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((VBanner)this.MdiParent).CargarDataGridViewFuentesRss(this.iControlador.ObtenerTodasLasFuentes());
        }

        protected abstract void buttonGuardar_Click(object sender, EventArgs e);
    }
}
