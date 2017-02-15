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
    public partial class VCrearFuente : VAbstractCrearModificarFuente
    {
        public VCrearFuente(ref ControladorDominio pControladorDominio) : base(ref pControladorDominio)
        {
            InitializeComponent();
            this.buttonGuardar.Click += ButtonGuardar_Click;
            this.comboBoxTipoFuente.SelectedValueChanged += MostrarPanel;
            //this.bgwActualizarRssAlGuardar.DoWork += BgwActualizarRssAlGuardar_DoWork;
            //this.bgwActualizarRssAlGuardar.RunWorkerCompleted += BgwActualizarRssAlGuardar_RunWorkerCompleted;
            this.panelTextoFijo.Visible = false;
            this.panelRss.Visible = false;
        }

        Fuente fuenteAAgregar = new Fuente();

        private void MostrarPanel(object sender, EventArgs e)
        {
            switch (this.comboBoxTipoFuente.SelectedItem.ToString())
            {
                case "Rss":
                    this.panelTextoFijo.Visible = false;
                    this.panelRss.Visible = true;
                    break;
                case "Texto Fijo":
                    this.panelRss.Visible = false;
                    this.panelTextoFijo.Visible = true;
                    break;
            }
        }

        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            switch (this.comboBoxTipoFuente.SelectedItem.ToString())
            {
                case "Rss":
                    this.fuenteAAgregar.Tipo = TipoFuente.Rss;
                    this.fuenteAAgregar.origenItems = this.textBoxFuenteRss.Text;
                    break;
                case "Texto Fijo":
                    this.fuenteAAgregar.Tipo = TipoFuente.TextoPlano;
                    break;
            }

            if (!this.bgwActualizarRssAlGuardar.IsBusy)
                this.bgwActualizarRssAlGuardar.RunWorkerAsync();
        }

        private void BgwActualizarRssAlGuardar_DoWork(object sender, DoWorkEventArgs e)
        {
            this.fuenteAAgregar.Leer();
        }

        private void BgwActualizarRssAlGuardar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.fuenteAAgregar.Descripcion = this.textBoxDescripcionRss.Text;
            this.iControladorDominio.AgregarFuente(fuenteAAgregar);
            this.iControladorDominio.GuardarCambios();
            this.Close();
        }

    }
}
