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
        public VCrearFuente(ref ControladorDominio pControladorDominio)
        {
            InitializeComponent();
            this.buttonGuardar.Click += ButtonGuardar_Click;
            this.comboBoxTipoFuente.SelectedValueChanged += MostrarPanel;
        }

        private void MostrarPanel(object sender, EventArgs e)
        {

            switch (this.comboBoxTipoFuente.SelectedItem.ToString())
            {
                case "Rss":
                    this.panelTextoFijo.Visible = false;
                    this.panelRss.Visible = true;
                    break;
                case "Texto Fijo":
                    this.panelTextoFijo.Visible = true;
                    break;
            }
        }

        private void ButtonGuardar_Click(object sender, EventArgs e)
        {

            Fuente fuenteAAgregar = new Fuente();

            switch (this.comboBoxTipoFuente.SelectedItem.ToString())
            {
                case "Rss":
                    this.panelTextoFijo.Visible = false;
                    this.panelRss.Visible = true;
                    break;
                case "Texto Fijo":
                    this.panelTextoFijo.Visible = true;
                    break;
            }
        }


    }
}
