﻿using System;
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
using Excepciones;
using Excepciones.ExcepcionesPantalla;

namespace UI.Pantallas
{
    public partial class VBaseFuente : Form
    {
        /// <summary>
        /// Atributo que almacena el Controlador de Dominio
        /// </summary>
        private ControladorDominio iControladorDominio;


        /// <summary>
        /// Atributo que almacena la Ventana de "Nueva Fuente"
        /// </summary>
        private VNuevaFuente iVentanaNueva;

        /// <summary>
        /// Atributo que almacena la Ventana de "Editar Fuente"
        /// </summary>
        private VEditarFuente iVentanaEditar;



        //CONSTRUCTOR
        public VBaseFuente(ref ControladorDominio pControladorDominio)
        {
            InitializeComponent();
            this.iControladorDominio = pControladorDominio;

            //Centramos la pantalla en el centro:
            this.StartPosition = FormStartPosition.CenterScreen;
        }




        #region Funciones privadas
        /// <summary>
        /// Indica cuál es la fuente que está seleccionada actualmente en el this.dataGridViewMostrar
        /// </summary>
        /// <returns>Devuelve la fuente seleccionada </returns>
        private Fuente FuenteSeleccionada()
        {
            if (this.dataGridViewMostrar.SelectedRows.Count == 0)
                return null;
            else
                return (Fuente)this.dataGridViewMostrar.SelectedRows[0].DataBoundItem;
        }
        #endregion

        #region EVENTOS
        #region Botones
        /// <summary>
        /// Evento que se invoca cuando se hace click sobre el botón nuevo, creando una nueva fuente
        /// </summary>
        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            this.iVentanaNueva = new VNuevaFuente(ref this.iControladorDominio);
            this.iVentanaNueva.Owner = this;
            this.iVentanaNueva.ShowDialog();
            this.iVentanaNueva = null;
        }

        /// <summary>
        /// Evento que se invoca cuando se hace click sobre el botón modificar, modificando una fuente
        /// </summary>
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            Fuente fuenteSeleccionada = this.FuenteSeleccionada();
            if (fuenteSeleccionada == null)
                MessageBox.Show("Se debe seleccionar una fuente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                this.iVentanaEditar = new VEditarFuente(ref this.iControladorDominio, fuenteSeleccionada);
                this.iVentanaEditar.Owner = this;
                this.iVentanaEditar.ShowDialog();
                this.iVentanaEditar = null;
            }
        }

        /// <summary>
        /// Carga el DataGridFuentes con la lista en <paramref name="pListaFuentes"/>
        /// </summary>
        /// <param name="pListaFuentes">lista de fuentes a cargar</param>
        public void CargarDataGridFuentes(List<Fuente> pListaFuentes)
        {
            this.dataGridViewMostrar.DataSource = pListaFuentes;
        }

        /// <summary>
        /// Evento que se invoca cuando se hace click sobre el botón eliminar, eliminando una fuente.
        /// </summary>
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            Fuente fuenteSeleccionada = this.FuenteSeleccionada();
            if (fuenteSeleccionada == null)
            { MessageBox.Show("Se debe seleccionar una fuente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                string descripcion = fuenteSeleccionada.Descripcion;
                DialogResult dialogResult = MessageBox.Show(string.Format("¿Está seguro que desea eliminar la fuente \"{0}\"?", descripcion), "Eliminar Fuente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        int codigo = fuenteSeleccionada.FuenteId;
                        this.iControladorDominio.BorrarFuente(codigo);
                        this.iControladorDominio.GuardarCambios();
                        this.CargarDataGridFuentes(this.iControladorDominio.ObtenerTodasLasFuentes());
                    }
                    catch (ExcepcionAlObtenerFuentes) { }
                    catch (ExcepcionAlEliminar ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (ExcepcionAlGuardarCambios ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception)
                    { MessageBox.Show("Ha ocurrido un error. Contacte con el administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }

        /// <summary>
        /// Evento que se invoca cuando se hace click en el botón filtrar
        /// y muestra el nuevo listado de fuentes según los filtros
        /// </summary>
        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            string filtroTipoFuente = null;
            string filtroDescripcion = null;

            if (checkBoxTipo.Checked && this.comboBoxTipo.Text != "")
                switch (this.comboBoxTipo.SelectedItem.ToString())
                {
                    case "Rss":
                        filtroTipoFuente = "Rss";
                        break;
                    case "Texto Fijo":
                        filtroTipoFuente = "TextoFijo";
                        break;
                }

            if (checkBoxDescripcion.Checked)
                filtroDescripcion = this.textBoxDescripcion.Text;
            try
            {
                List<Fuente> listaFiltrada = this.iControladorDominio.FiltrarFuentes(filtroTipoFuente, filtroDescripcion);
                this.CargarDataGridFuentes(listaFiltrada);
            }
            catch (ExcepcionAlObtenerFuentes ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.buttonBorrarFiltros.Enabled = true;
        }

        /// <summary>
        /// Evento que se invoca cuando se hace click en el botón salir, cerrando la ventana
        /// </summary>
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Ventana y Otros Componentes
        /// <summary>
        /// Evento que se invoca cuando cambia el valor del checkBoxDescripcion
        /// </summary>
        private void checkBoxDescripcion_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxDescripcion.Checked)
                this.textBoxDescripcion.Enabled = true;
            else
                this.textBoxDescripcion.Enabled = false;
        }

        /// <summary>
        /// Evento que se invoca cuando cambia el valor del checkBoxTipo
        /// </summary>
        private void checkBoxTipo_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxTipo.Checked)
                this.comboBoxTipo.Enabled = true;
            else
                this.comboBoxTipo.Enabled = false;
        }


        /// <summary>
        /// Evento que se activa cuando se quiere introducir texto en algun textbox
        /// </summary>
        private void textBoxValido_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionTexto.InputValido(e);
        }



        /// <summary>
        /// Devuelve la seleccion a la primer fila si no hay filas seleccionadas
        /// </summary>
        private void dataGridViewMostrar_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewMostrar.Rows.Count > 0 && this.dataGridViewMostrar.SelectedRows.Count <= 0)
            {
                this.dataGridViewMostrar.CurrentCell = this.dataGridViewMostrar.Rows[0].Cells[1];
                this.dataGridViewMostrar.Rows[0].Selected = true;
            }
        }



        /// <summary>
        /// Evento que se activa después de la inicialización, cuando el form se está cargando
        /// </summary>
        private void VBaseFuente_Load(object sender, EventArgs e)
        {
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink; //Que no permita redimensionar la ventana
            this.MaximizeBox = false; //Que no permita maximizar
            this.WindowState = FormWindowState.Normal;
        }

        /// <summary>
        /// Evento que se invoca cuando VBaseFuente se activa
        /// </summary>
        private void VBaseFuente_Activated(object sender, EventArgs e)
        {
            try
            {
                //Actualizamos el contenido del Datagrid:
                this.CargarDataGridFuentes(this.iControladorDominio.ObtenerTodasLasFuentes());
            }
            catch (ExcepcionAlObtenerFuentes) { }

            //Preguntamos si las ventanas hijas son nulas, sino significa que están abiertas
            //y les dejamos el foco 
            if (this.iVentanaNueva != null)
                this.iVentanaNueva.Activate();
            else if (this.iVentanaEditar != null)
                this.iVentanaEditar.Activate();
        }
        #endregion

        #endregion

        private void buttonBorrarFiltros_Click(object sender, EventArgs e)
        {
            this.checkBoxDescripcion.Checked = false;
            this.checkBoxTipo.Checked = false;
            this.textBoxDescripcion.Text = "";
            this.comboBoxTipo.SelectedText = "";
            this.buttonFiltrar_Click(sender, e);
            this.buttonBorrarFiltros.Enabled = false;
        }
    }
}
