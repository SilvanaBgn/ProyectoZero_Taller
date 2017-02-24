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
using Excepciones.ExcepcionesPantalla;

namespace UI.NuevasPantallas
{
    public partial class VModificarFuente : VAbstractCrearModificarFuente
    {
        private Fuente iFuenteAModificar;

        public VModificarFuente(ref ControladorDominio pControladorDominio, Fuente pFuenteAModificar) : base(ref pControladorDominio)
        {
            InitializeComponent();
            this.iFuenteAModificar = pFuenteAModificar;
            this.CargarFuenteAModificar(this.iFuenteAModificar);
        }

        private void CargarFuenteAModificar(object iFuenteAModificar)
        {
            this.comboBoxTipoFuente.Enabled = false;

            switch (this.iFuenteAModificar.Tipo.ToString())
            {
                case "Rss":
                    this.comboBoxTipoFuente.Text = "Rss";
                    this.panelTextoFijo.Visible = false;
                    this.panelRss.Visible = true;
                    this.textBoxFuenteRss.Text = this.iFuenteAModificar.OrigenItems;
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
            switch (this.comboBoxTipoFuente.SelectedItem.ToString())
            {
                case "Rss":
                    this.iFuenteAModificar.OrigenItems = this.textBoxFuenteRss.Text;
                    this.iFuenteAModificar.Descripcion = this.textBoxDescripcionRss.Text;
                    break;
                case "Texto Fijo":
                    this.iFuenteAModificar.Descripcion = this.textoFijo.Descripcion;
                    this.iFuenteAModificar.Items = this.textoFijo.ListaItems;
                    break;
            }
            try //Intentamos agregarla al repositorio y luego guardarla en base de datos:
            {
                this.iControladorDominio.ModificarFuente(this.iFuenteAModificar);
                this.iControladorDominio.GuardarCambios();
                this.Close();
            }
            catch (ExcepcionCamposSinCompletar ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// En este evento el backgroundworker se hace el intento de leer la Fuente recién agregada
        /// </summary>
        private void BgwActualizarRssAlGuardar_DoWork(object sender, DoWorkEventArgs e)
        {
            //try
            //{
            this.iFuenteAModificar.Leer();

            // Una vez leída la Fuente, se guardan los cambios:
            this.iControladorDominio.ModificarFuente(this.iFuenteAModificar);
            this.iControladorDominio.GuardarCambios();
            //}
            //catch (ExcepcionFormatoURLIncorrecto ex)
            //{ MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void VModificarFuente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.bgwActualizarRssAlGuardar.IsBusy)
                this.bgwActualizarRssAlGuardar.RunWorkerAsync();
        }
    }
}