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
        Fuente fuenteAAgregar = new Fuente();

        public VCrearFuente(ref ControladorDominio pControladorDominio) : base(ref pControladorDominio)
        {
            InitializeComponent();
            this.panelTextoFijo.Visible = false;
            this.panelRss.Visible = false;
        }

        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            switch (this.comboBoxTipoFuente.SelectedItem.ToString())
            {
                case "Rss":
                    this.fuenteAAgregar.Tipo = TipoFuente.Rss;
                    break;
                case "Texto Fijo":
                    this.fuenteAAgregar.Tipo = TipoFuente.TextoFijo;
                    break;
            }

            this.fuenteAAgregar.origenItems = this.textBoxFuenteRss.Text;

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
