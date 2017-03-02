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
using HelperUI;

namespace UI.NuevasPantallas
{
    public partial class VAbstractBase : Form
    {
        /// <summary>
        /// Atributo que almacena el Controlador de Dominio
        /// </summary>
        protected ControladorDominio iControladorDominio;



        //CONSTRUCTOR
        public VAbstractBase()
        {
            InitializeComponent();
        }

        //CONSTRUCTOR
        public VAbstractBase(ref ControladorDominio pControladorDominio) : this()
        {
            this.iControladorDominio = pControladorDominio;

            //Centramos la pantalla en el centro:
            this.StartPosition = FormStartPosition.CenterScreen;
        }



        #region EVENTOS
        #region Botones
        /// <summary>
        /// Evento que se activa cuando se apreta el this.buttonSalir
        /// </summary>
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Ventana y Otros Componentes
        /// <summary>
        /// Evento que se invoca cuando cambia el valor del this.checkBoxRangoFechas
        /// </summary>
        private void checkBoxRangoFechas_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxRangoFechas.Checked)
                this.rangoFecha.Enabled = true;
            else this.rangoFecha.Enabled = false;
        }

        /// <summary>
        /// Evento que se invoca cuando cambia el valor del this.checkBoxRangoHoras
        /// </summary>
        private void checkBoxRangoHoras_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxRangoHoras.Checked)
                this.rangoHorario.Enabled = true;
            else this.rangoHorario.Enabled = false;
        }

        /// <summary>
        /// Evento que se invoca cuando cambia el valor del this.checkBoxTitulo
        /// </summary>
        private void checkBoxTitulo_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxTitulo.Checked)
                this.textBoxTitulo.Enabled = true;
            else this.textBoxTitulo.Enabled = false;
        }

        /// <summary>
        /// Evento que se invoca cuando cambia el valor del this.checkBoxDescripcion
        /// </summary>
        private void checkBoxDescripcion_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxDescripcion.Checked)
                this.textBoxDescripcion.Enabled = true;
            else this.textBoxDescripcion.Enabled = false;
        }



        /// <summary>
        /// Evento que se activa cuando se quiere introducir texto en un textBox
        /// </summary>
        private void textValido_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionTexto.InputValido(e);
        }



        /// <summary>
        ///  Evento que se invoca cuando se hace click con el mouse sobre una celda
        /// </summary>
        private void dataGridViewMostrar_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (this.dataGridViewMostrar.Rows.Count > 0 && this.dataGridViewMostrar.SelectedRows.Count <= 0)
            {
                this.dataGridViewMostrar.CurrentCell = this.dataGridViewMostrar.Rows[0].Cells[1];
                this.dataGridViewMostrar.Rows[0].Selected = true;
            }
        }

        /// <summary>
        /// Evento que se activa cuando cambia la seleccion en el this.dataGridViewMostrar
        /// </summary>
        private void dataGridViewMostrar_SelectionChanged(object sender, EventArgs e)
        {
           //Si no hay filas seleccionadas, se selecciona la primera (para que siempre haya una fila seleccionada)
            if (this.dataGridViewMostrar.Rows.Count > 0 && this.dataGridViewMostrar.SelectedRows.Count <= 0)
            {
                this.dataGridViewMostrar.CurrentCell = this.dataGridViewMostrar.Rows[0].Cells[1];
                this.dataGridViewMostrar.Rows[0].Selected = true;
            }
        }




        /// <summary>
        /// Evento que se activa después de la inicialización, cuando el form se está cargando
        /// </summary>
        private void VAbstractBase_Load(object sender, EventArgs e)
        {
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink; //Que no permita redimensionar la ventana
            this.MaximizeBox = false; //Que no permita maximizar
            this.WindowState = FormWindowState.Normal;

            //Actualizamos el rangoFecha para que por defecto aparezca con la fecha del día de hoy:
            this.rangoFecha.FechaInicio = this.rangoFecha.FechaFin = DateTime.Today;
        }

        #endregion

        #endregion
    }
}
