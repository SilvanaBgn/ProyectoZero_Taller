using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Dominio;
using Excepciones;

namespace UI
{
    public abstract partial class VAbstractCampania : Form
    {
        protected ControladorDominio iControladorDominio;
        /// <summary>
        /// Variable que contendrá los títulos del listBoxImagenes. De estos items, se señalizarán con un * aquellos que ya estén guardados en 
        /// previamente (para una Campaña a modificar), y con el path aquellas imagenes recientemente agregadas
        /// </summary>
        protected List<String> iListaCampanias;
        protected int iIndice, iCount;

        public VAbstractCampania()
        {
            InitializeComponent();
        }

        public VAbstractCampania(ref ControladorDominio pControlador) :this()
        {
            this.iControladorDominio = pControlador;
            this.pictureBoxCampania.SizeMode = PictureBoxSizeMode.Zoom;
            this.iIndice = this.iCount = 0;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            this.timer1.Interval = 1000;
            this.iListaCampanias = new List<string>();
        }

        protected abstract void timer1_Tick(object sender, EventArgs e);

        /// <summary>
        /// Evento que se activa cuando se da click al botón de agregar imágenes al this.listBoxImagenes
        /// </summary>
        protected abstract void buttonAgregar_Click(object sender, EventArgs e);

        /// <summary>
        /// Evento que se activa al guardar los cambios
        /// </summary>
        protected abstract void buttonGuardar_Click(object sender, EventArgs e);

        /// <summary>
        /// Evento que se activa cuando cambia el item seleccionado en el this.listBoxImagenes
        /// </summary>
        protected abstract void listBoxImagenes_SelectedIndexChanged(object sender, EventArgs e);

        /// <summary>
        /// Evento que se activa al presionar el botón this.buttonArriba, para cambiar el orden de las imágenes
        /// </summary>
        protected virtual void buttonArriba_Click(object sender, EventArgs e)
        {
            object item = listBoxImagenes.SelectedItem;
            if (listBoxImagenes.SelectedIndex > 0)
            {
                string curItem = item.ToString();
                listBoxImagenes.Items[listBoxImagenes.SelectedIndex] = listBoxImagenes.Items[listBoxImagenes.SelectedIndex - 1];
                listBoxImagenes.Items[listBoxImagenes.SelectedIndex - 1] = curItem;
                listBoxImagenes.SelectedItem = item;
            }
        }

        /// <summary>
        /// Evento que se activa al presionar el botón this.buttonAbajo, para cambiar el orden de las imágenes
        /// </summary>
        protected virtual void buttonAbajo_Click(object sender, EventArgs e)
        {
            object item = listBoxImagenes.SelectedItem;
            if (listBoxImagenes.SelectedIndex < listBoxImagenes.Items.Count - 1)
            {
                string curItem = item.ToString();
                listBoxImagenes.Items[listBoxImagenes.SelectedIndex] = listBoxImagenes.Items[listBoxImagenes.SelectedIndex + 1];
                listBoxImagenes.Items[listBoxImagenes.SelectedIndex + 1] = curItem;
                listBoxImagenes.SelectedItem = item;
            }
        }

        /// <summary>
        /// Evento que se activa al presionar el botón buttonBorrarImagenes
        /// </summary>
        protected virtual void buttonBorrar_Click(object sender, EventArgs e)
        {
            this.listBoxImagenes.Items.Remove(this.listBoxImagenes.SelectedItem);
            //Aclaración: Si no se encuentra el SelectedItem en el listBoxImagenes, éste permanece sin cambios y no tira ninguna excepción

            //Luego de borrado el item correspondiente, de quedar elementos en el this.listBoxImagenes,selecciona el primer elemento:
            try
            {
                this.listBoxImagenes.SelectedIndex = 0;
            }
            catch (ArgumentOutOfRangeException) // if (this.listBoxImagenes.Items.Count == 0)
            {
                this.pictureBoxCampania.Load(Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())) + "/icono/NoImage.png");
            }
        }

        /// <summary>
        /// Evento que se activa al presionar el botón buttonVistaPrevia, que emula cómo se verían las imágenes de la campania
        /// </summary>
        protected virtual void buttonVistaPrevia_Click(object sender, EventArgs e)
        {
            //EXCEPCION!: que los segundos del intervalo sean mayores a 5 y menores a 30 (por ejemplo)

            if (listBoxImagenes.Items.Count > 0)
            {
                if (!timer1.Enabled)
                {
                    this.buttonVistaPrevia.Text="Detener";
                    this.buttonVistaPrevia.Refresh();
                    this.iListaCampanias.Clear();
                    foreach (var item in this.listBoxImagenes.Items)
                    {
                        this.iListaCampanias.Add(item.ToString());
                    }
                    if (textBoxSegundos.Text != "")
                        timer1.Interval = Convert.ToInt32(this.textBoxSegundos.Text) * 1000;
                    listBoxImagenes.Enabled = false;
                    timer1.Start();
                }
                else
                {
                    this.buttonVistaPrevia.Text = "Vista previa";
                    this.buttonVistaPrevia.Refresh();
                    timer1.Stop();
                    listBoxImagenes.Enabled = true;
                }
            }

        }

        /// <summary>
        /// Evento que se activa al presionar el botón this.buttonCancelar, y sale de la ventana sin guardar los cambios
        /// </summary>
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.iControladorDominio.CancelarCambios();
            this.Close();
        }

        /// <summary>
        /// Evento que se activa al cambiar el valor del día del this.dateTimePickerInicio
        /// </summary>
        private void dateTimePickerInicio_ValueChanged(object sender, EventArgs e)
        {
            //Controles para que la Fecha de Fin sea siempre Mayor a la de Inicio
            try
            {
                if (this.dateTimePickerInicio.Value > this.dateTimePickerFin.Value)
                {
                    throw new ExcepcionFechaFinMayorAFechaInicio("");
                }
            }
            catch (ExcepcionFechaFinMayorAFechaInicio)
            {
                this.dateTimePickerFin.Value = this.dateTimePickerInicio.Value;
            }
            finally
            {
            }
        }

        /// <summary>
        /// Evento que se activa al cambiar el valor del día del this.dateTimePickerFin
        /// </summary>
        private void dateTimePickerFin_ValueChanged(object sender, EventArgs e)
        {
            //Controles para que la Fecha de Fin sea siempre Menor a la de Inicio
            try
            {
                if (this.dateTimePickerInicio.Value > this.dateTimePickerFin.Value)
                {
                    throw new ExcepcionFechaFinMenorAFechaInicio("");
                }
            }
            catch (ExcepcionFechaFinMenorAFechaInicio)
            {
                this.dateTimePickerInicio.Value = this.dateTimePickerFin.Value;
            }
            finally
            {
            }
        }

        /// <summary>
        /// Evento que se activa cuando se está cerrando el formulario.
        /// Aquí nos aseguramos de actualizar los items de DataGridViewCampania de la ventana contenedora principal (VCampania)
        /// </summary>
        private void VAbstractCampania_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((VCampania)this.MdiParent).CargarDataGridViewCampania(this.iControladorDominio.ObtenerTodasLasCampanias());
        }


        /// <summary>
        /// Función auxiliar que controla que todos los textBoxs estén completados, lanzando una excepción si no fuese así
        /// </summary>
        protected void ValidarTodoCompleto()
        {
            foreach (Control oControls in this.Controls) // Buscamos en cada TextBox de nuestro Formulario. 
            {
                if (oControls is TextBox & oControls.Text == String.Empty) // Verificamos que no este vacio. 
                {
                    throw new ExcepcionCampoSinCompletar("Debe completar todos los campos");
                }
            }
        }
    }
}
