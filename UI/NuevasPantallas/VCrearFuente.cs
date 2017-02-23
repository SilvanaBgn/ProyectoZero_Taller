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
using Excepciones.ExcepcionesIntermedias;

namespace UI.NuevasPantallas
{
    public partial class VCrearFuente : VAbstractCrearModificarFuente
    {
        /// <summary>
        /// Atributo que se utiliza para almacenar la fuente a agregar
        /// </summary>
        Fuente iFuenteAAgregar;

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
            try
            {
                if (this.comboBoxTipoFuente.SelectedItem == null)
                MessageBox.Show("Se debe seleccionar un tipo de fuente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                //Creamos la fuente:
                this.iFuenteAAgregar = new Fuente();

                //Vemos el tipo, a partir de lo que completamos:
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
                try //Intentamos agregarla al repositorio y luego guardarla en base de datos:
                {
                    this.iControladorDominio.AgregarFuente(this.iFuenteAAgregar);
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
            catch (NullReferenceException)
            {
                MessageBox.Show("Se debe seleccionar un tipo de fuente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        /// <summary>
        /// En este evento el backgroundworker se hace el intento de leer la Fuente recién agregada
        /// </summary>
        private void BgwActualizarRssAlGuardar_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                this.iFuenteAAgregar.Leer();
        }
            catch (ExcepcionFormatoURLIncorrecto ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
}

        /// <summary>
        /// Una vez leída la Fuente, se guardan los cambios
        /// </summary>
        private void BgwActualizarRssAlGuardar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.iControladorDominio.ModificarFuente(this.iFuenteAAgregar);
                this.iControladorDominio.GuardarCambios();
        }

        /// <summary>
        /// Cuando el Form se esta cerrando, le pedimos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VCrearFuente_FormClosing(object sender, FormClosingEventArgs e)
            {
            //this.iFuenteAAgregar es distinta de null cuando se apretó el botón Guardar
            //Además, sólo ejecutamos el 
            if (this.iFuenteAAgregar!=null && !this.bgwActualizarRssAlGuardar.IsBusy)
                this.bgwActualizarRssAlGuardar.RunWorkerAsync();
        }
    }
}
