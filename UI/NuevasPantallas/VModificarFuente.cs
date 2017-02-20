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
    public partial class VModificarFuente : VAbstractCrearModificarFuente
    {

        private Fuente iFuenteAModificar;

        public VModificarFuente(ref ControladorDominio pControladorDominio, Fuente pFuenteAModificar)
        {
            InitializeComponent();
            this.iFuenteAModificar = pFuenteAModificar;
            this.CargarFuenteAModificar(this.iFuenteAModificar);
        }

        private void CargarFuenteAModificar(object iFuenteAModificar)
        /// <summary>
        /// Este evento se activa cuando se hace click en el botón guardar
        /// </summary>
        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            this.comboBoxTipoFuente.Enabled = false;

            switch (this.iFuenteAModificar.Tipo.ToString())
                {
                    case "Rss":
                    this.comboBoxTipoFuente.Text = "Rss";
                        this.panelTextoFijo.Visible = false;
                        this.panelRss.Visible = true;
                    this.textBoxFuenteRss.Text = this.iFuenteAModificar.origenItems;
                    this.textBoxDescripcionRss.Text = this.iFuenteAModificar.Descripcion;
                        break;
                case "TextoFijo":
                    this.comboBoxTipoFuente.Text = "Texto Fijo";
                        this.panelRss.Visible = false;
                        this.panelTextoFijo.Visible = true;
                    this.textoFijo.Descripcion = this.iFuenteAModificar.Descripcion;
                    this.textoFijo.ListaItems = (List<Item>)this.iFuenteAModificar.Items;
                    break;
            }
        }

        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            {
                switch (this.comboBoxTipoFuente.SelectedItem.ToString())
                {
                    case "Rss":
                        this.iFuenteAModificar.origenItems = this.textBoxFuenteRss.Text;
                        this.iFuenteAModificar.Descripcion = this.textBoxDescripcionRss.Text;
                        break;
                    case "Texto Fijo":
                        this.iFuenteAModificar.Descripcion = this.textoFijo.Descripcion;
                        this.iFuenteAModificar.Items = this.textoFijo.ListaItems;
                        break;
                }

                if (!this.bgwActualizarRssAlGuardar.IsBusy)
                    base.bgwActualizarRssAlGuardar.RunWorkerAsync();
            }
        }

    }
}
