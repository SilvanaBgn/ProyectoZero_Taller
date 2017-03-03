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
using HelperUI;

namespace UI.Pantallas
{
    public partial class VAbstractCrearModificarCampania : Form
    {
        /// <summary>
        /// Atributo que almacena el Controlador de Dominio
        /// </summary>
        protected ControladorDominio iControladorDominio;

        /// <summary>
        /// Atributo que se utiliza para almacenar la campania
        /// </summary>
        protected Campania iCampania;

        //CONSTRUCTOR
        public VAbstractCrearModificarCampania()
        {
            InitializeComponent();
        }
        //CONSTRUCTOR
        public VAbstractCrearModificarCampania(ref ControladorDominio pControladorDominio) : this()
        {
            this.iControladorDominio = pControladorDominio;

            //Centramos la pantalla en el centro:
            this.StartPosition = FormStartPosition.CenterScreen;
        }



        #region EVENTOS

        #region Botones
        /// <summary>
        /// Evento que se activa cuando se apreta el botón this.buttonCancelar, para cancelar la adición/edición
        /// </summary>
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Ventana y Otros Componentes
        /// <summary>
        /// Evento que se activa cuando se quiere introducir texto en el this.textBox
        /// </summary>
        private void textBoxValido_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionTexto.InputValido(e);
        }

        /// <summary>
        /// Evento que se activa después de la inicialización, cuando el form se está cargando
        /// </summary>
        private void VAbstractCrearModificarCampania_Load(object sender, EventArgs e)
        {
            //Actualizamos el rangoFecha para que por defecto aparezca con la fecha del día de hoy:
            this.rangoFecha.FechaInicio = this.rangoFecha.FechaFin = DateTime.Today;
        }
        #endregion
        #endregion
    }
}
