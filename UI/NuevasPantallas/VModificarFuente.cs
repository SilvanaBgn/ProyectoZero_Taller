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
        public VModificarFuente(ref ControladorDominio pControladorDominio)
        {
            InitializeComponent();
        }

        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            {
                if (!this.bgwActualizarRssAlGuardar.IsBusy)
                    base.bgwActualizarRssAlGuardar.RunWorkerAsync();

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
        }

    }
}
