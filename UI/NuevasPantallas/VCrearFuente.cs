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
using Excepciones.ExcepcionesEspecíficas;

namespace UI.NuevasPantallas
{
    public partial class VCrearFuente : VAbstractCrearModificarFuente
    {
        Fuente iFuenteAAgregar = new Fuente();

        //CONSTRUCTOR
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
            //try {
            if (this.comboBoxTipoFuente.SelectedItem == null)
                MessageBox.Show("Se debe seleccionar un tipo de fuente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
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
            //}
            //catch (NullReferenceException)
            //{
            //    MessageBox.Show("Se debe seleccionar un tipo de fuente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}


        }

        /// <summary>
        /// En este evento se define el trabajo que tiene que hacer el backgroundworker
        /// </summary>
        private void BgwActualizarRssAlGuardar_DoWork(object sender, DoWorkEventArgs e)
        {
            this.iFuenteAAgregar.Leer();
        }

        /// <summary>
        /// Este evento se ejecuta una vez finalizado el DoWork
        /// </summary>
        private void BgwActualizarRssAlGuardar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                this.iControladorDominio.AgregarFuente(iFuenteAAgregar);
                this.iControladorDominio.GuardarCambios();
                this.Close();
            }
            catch (ExcepcionYaExisteFuente ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ExcepcionCamposSinCompletar ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
