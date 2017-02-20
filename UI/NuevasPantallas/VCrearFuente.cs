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
        Fuente iFuenteAAgregar = new Fuente();

        public VCrearFuente(ref ControladorDominio pControladorDominio) : base(ref pControladorDominio)
        {
            InitializeComponent();
            this.panelTextoFijo.Visible = false;
            this.panelRss.Visible = false;
        }

        /// <summary>
        /// Evento que se invoca cuando se hace click en el botón guardar, agregando una nueva fuente
        /// </summary>
        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            switch (this.comboBoxTipoFuente.SelectedItem.ToString())
            {
                case "Rss":
                    this.iFuenteAAgregar.Tipo = TipoFuente.Rss;
                    this.iFuenteAAgregar.origenItems = this.textBoxFuenteRss.Text;
                    this.iFuenteAAgregar.Descripcion = this.textBoxDescripcionRss.Text;
                    break;
                case "Texto Fijo":
                    this.iFuenteAAgregar.Tipo = TipoFuente.TextoFijo;
                    this.iFuenteAAgregar.Descripcion = this.textoFijo.Descripcion;
                    this.iFuenteAAgregar.Items = this.textoFijo.ListaItems;
                    break;
            }

            if (!this.bgwActualizarRssAlGuardar.IsBusy)
                this.bgwActualizarRssAlGuardar.RunWorkerAsync();
        }

        private void BgwActualizarRssAlGuardar_DoWork(object sender, DoWorkEventArgs e)
        {
            this.iFuenteAAgregar.Leer();
        }

        private void BgwActualizarRssAlGuardar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.iControladorDominio.AgregarFuente(iFuenteAAgregar);
            this.iControladorDominio.GuardarCambios();

            this.Close();
        }
    }
}
