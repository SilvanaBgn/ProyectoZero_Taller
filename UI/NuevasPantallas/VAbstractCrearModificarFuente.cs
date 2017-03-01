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
using System.Text.RegularExpressions;
using Helper;
using Excepciones.ExcepcionesDominio;

namespace UI.NuevasPantallas
{
    public partial class VAbstractCrearModificarFuente : Form
    {
        /// <summary>
        /// Atributo que almacena el Controlador de Dominio
        /// </summary>
        protected ControladorDominio iControladorDominio;

        /// <summary>
        /// Atributo que se utiliza para almacenar la fuente
        /// </summary>
        protected Fuente iFuente;

        /// <summary>
        /// Variable booleana que se actualiza a true cuando se ha podido Guardar la Nueva fuente. Su finalidad 
        /// es controlar que la Lectura de items con el BackgroundWorker sólo se realice cuando se haya guardado
        /// correctamente una nueva fuente
        /// </summary>
        protected bool iGuardadoCorrecto = false;


        //CONSTRUCTOR
        public VAbstractCrearModificarFuente()
        {
            InitializeComponent();
        }

        //CONSTRUCTOR
        public VAbstractCrearModificarFuente(ref ControladorDominio pControladorDominio) : this()
        {
            this.iControladorDominio = pControladorDominio;

            //Centramos la pantalla en el centro:
            this.StartPosition = FormStartPosition.CenterScreen;
        }



        #region Funciones privadas
        /// <summary>
        /// Si se selecciona RSS en el comboBox se muestra el panel RSS
        /// Si se selecciona Texto Fijo en el comboBox se muestra el panel texto fijo
        /// </summary>
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
        #endregion

        #region EVENTOS
        #region Botones
        /// <summary>
        /// Evento que se activa al presionar el botón this.buttonCancelar
        /// </summary>
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Ventana y Otros Componentes
        /// <summary>
        /// Evento que se activa cuando se quiere introducir texto en algun textBox
        /// </summary>
        private void textBoxValido_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionTexto.InputValido(e);
        }

        /// <summary>
        /// /// En este evento el backgroundworker se hace el intento de leer la Fuente recién agregada
        /// </summary>
        private void bgwActualizarItemsAlGuardar_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                //Realizamos la lectura de items:
                this.iControladorDominio.LeerFuente(this.iFuente);

                //Una vez leída la Fuente, modificamos y guardamos los cambios:
                this.iControladorDominio.ModificarFuente(this.iFuente);
                this.iControladorDominio.GuardarCambios();
            }
            catch (ExcepcionAlLeerFuenteExternaDelBanner)
            { }
        }

        /// <summary>
        /// Evento que se ejecuta cuando el Form se esta cerrando
        /// </summary>
        private void VAbstractCrearModificarFuente_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Le pedimos que haga la Lectura de Items en segundo plano:
            if (this.iGuardadoCorrecto && !this.bgwActualizarItemsAlGuardar.IsBusy)
                this.bgwActualizarItemsAlGuardar.RunWorkerAsync();
        }
        #endregion
        #endregion
    }
}