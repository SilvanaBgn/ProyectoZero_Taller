using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Dominio;
using Dominio.Lecturas;

namespace UI
{
    public partial class PruebaLecturaFuente : Form
    {
        public PruebaLecturaFuente()
        {
            InitializeComponent();
            this.dataGrid.AutoGenerateColumns = false;
        }

        private void btnUpdate_Click(Object pSender, EventArgs pEventArgs)
        {
            //this.btnUpdate.Enabled = false;
            try
            {
                Fuente fuente = new Fuente("Fuente Rss", this.comboBoxUrl.Text, TipoFuente.Rss);
                this.dataGrid.DataSource = this.lectorFuente1.ObtenerItems(fuente);
            }
            catch (Exception bEx)
            {
                MessageBox.Show(bEx.Message, "Se ha producido un error al intentar actualizar los feeds", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
