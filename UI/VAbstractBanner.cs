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
using Contenedor;
using Excepciones;

namespace UI
{
    public abstract partial class VAbstractBanner : Form
    {
        protected ControladorDominio iControladorDominio;
        protected Banner iBanner;

        /// <summary>
        /// Toma el ID de la fuente que se muestra actualmente en el listView, 
        /// para buscar esa fuente cuando se haga clic en guardar
        /// </summary>
        protected int iIdFuenteNuevaSeleccionada;

        /// <summary>
        /// Constructor
        /// </summary>
        public VAbstractBanner()
        {
            InitializeComponent();
        }

        public VAbstractBanner(ref ControladorDominio pControladorDominio) : this()
        {
            this.iControladorDominio = pControladorDominio;
            this.listView1.Visible = false;
        }

        #region Eventos de Botones (Click)
        /// <summary>
        /// Evento que se activa cuando se da click al botón agregar,
        /// agrega un paso banner en el this.listBoxPasosBanners
        /// </summary>
        protected virtual void buttonAgregarPasoBanner_Click(object sender, EventArgs e)
        {
            this.listBoxPasosBanners.Items.Add(this.textBoxNuevoPasoBanner.Text);
            this.textBoxNuevoPasoBanner.Text = "";
            //MOVER EL CURSOR AL this.textBoxNuevoPasoBanner
            //SendKeys.Send("{TAB}");
        }

        /// <summary>
        /// Evento que se activa cuando se da click al botón con la flecha indicando hacia arriba,
        /// permite mover un paso banner una posición hacia arriba
        /// </summary>
        protected virtual void buttonUp_Click(object sender, EventArgs e)
        {
            object item = listBoxPasosBanners.SelectedItem;
            if (this.listBoxPasosBanners.SelectedIndex > 0)
            {
                string curItem = item.ToString();
                this.listBoxPasosBanners.Items[this.listBoxPasosBanners.SelectedIndex] = this.listBoxPasosBanners.Items[this.listBoxPasosBanners.SelectedIndex - 1];
                this.listBoxPasosBanners.Items[this.listBoxPasosBanners.SelectedIndex - 1] = curItem;
                this.listBoxPasosBanners.SelectedItem = item;
            }
        }

        /// <summary>
        /// Evento que se activa cuando se da click al botón con la flecha indicando hacia abajo,
        /// permite mover un paso banner una posición hacia abajo
        /// </summary>
        protected virtual void buttonDown_Click(object sender, EventArgs e)
        {
            object item = this.listBoxPasosBanners.SelectedItem;
            if (this.listBoxPasosBanners.SelectedIndex < this.listBoxPasosBanners.Items.Count - 1)
            {
                string curItem = item.ToString();
                this.listBoxPasosBanners.Items[this.listBoxPasosBanners.SelectedIndex] = this.listBoxPasosBanners.Items[this.listBoxPasosBanners.SelectedIndex + 1];
                this.listBoxPasosBanners.Items[this.listBoxPasosBanners.SelectedIndex + 1] = curItem;
                this.listBoxPasosBanners.SelectedItem = item;
            }
        }

        /// <summary>
        /// Evento que se activa cuando se da click al botón borrar un paso banner,
        /// elimina un paso banner de el this.listBoxPasosBanners
        /// </summary>
        protected virtual void buttonBorrarPasoBanner_Click(object sender, EventArgs e)
        {
            this.listBoxPasosBanners.Items.Remove(this.listBoxPasosBanners.SelectedItem);
            //Aclaración: Si no se encuentra el SelectedItem en el listBoxPasosBanners, éste permanece sin cambios y no tira ninguna excepción

            //Luego de borrado el item correspondiente, de quedar elementos en el this.listBoxImagenes,selecciona el primer elemento:
            try
            {
                this.listBoxPasosBanners.SelectedIndex = 0;
            }
            catch (ArgumentOutOfRangeException) // if (this.listBoxImagenes.Items.Count == 0)
            {
            }
        }

        /// <summary>
        /// Evento que se activa cuando se da click al botón cancelar,
        /// permite salir de la ventana de Banner
        /// </summary>
        protected virtual void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.iControladorDominio.CancelarCambios();
            this.Close();
        }

        protected abstract void buttonGuardar_Click(object sender, EventArgs e);
        #endregion


        protected virtual void radioButtonFuenteRss_Click(object sender, EventArgs e)
        {
            this.panelTextoPlano.Visible = false;
            this.panelFuenteRss.Visible = true;
        }

        protected virtual void radioButtonTextoPlano_CheckedChanged(object sender, EventArgs e)
        {
            this.panelFuenteRss.Visible = false;
            this.panelTextoPlano.Visible = true;
        }

        /// <summary>
        /// Evento que se activa cuando se da click al botón agregar fuente RSS,
        /// despliega una nueva ventana VNuevaFuenteRSS y permite agregar una nueva fuente
        /// </summary>
        protected virtual void buttonAgregarFuenteRss_Click(object sender, EventArgs e)
        {
            VFuenteRssNueva VNuevaFuenteRss = new VFuenteRssNueva(ref this.iControladorDominio);
            VNuevaFuenteRss.MdiParent = this.MdiParent;
            VNuevaFuenteRss.Show();
        }

        protected void VAbstractBanner_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((VBanner)this.MdiParent).CargarDataGridViewBanners(this.iControladorDominio.ObtenerTodosLosBanners().ToList());
        }

        /// <summary>
        /// Evento que se activa cuando se da click al botón con la flechita hacia abajo,
        /// muestra todas las fuentes 
        /// </summary>
        private void buttonDesplegarFuentes_Click(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();
            if (!this.listView1.Visible)
            {
                List<Fuente> listaDeFuentes = this.iControladorDominio.ObtenerTodasLasFuentes();
                foreach (var item in listaDeFuentes)
                {
                    ListViewItem itemDeListView = new ListViewItem(new[] { item.Descripcion, /*item.Url*/ });
                    this.listView1.Items.Add(itemDeListView);
                }
                listView1.Refresh();
                this.listView1.Visible = true;
                this.listView1.Enabled = true;
            }
            else
            {
                this.listView1.Visible = false;
            }
        }

        /// <summary>
        /// Evento que se activa cuando se hace click en una fuente en el listView1
        /// </summary>
        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ////foreach (var item in (IEnumerable<String>)this.listView1.SelectedItems[0])
            ////{
            ////    item.ToString();
            ////}

            //string urlFuenteABuscar = this.listView1.SelectedItems[0].SubItems[1].Text;

            //FuenteRss fuenteAMostrar = this.iControladorDominio.ObtenerTodasLasFuentes().FirstOrDefault(x => x.Url == urlFuenteABuscar);

            //this.iIdFuenteNuevaSeleccionada = fuenteAMostrar.FuenteId;

            //this.textBoxFuente.Text = fuenteAMostrar.Descripcion;

            ////var selectedItem = (dynamic)this.listView1.SelectedItems[0];
            ////this.textBoxFuente.Text = selectedItem.Text;


            ////this.textBoxFuente.Text = this.listView1.SelectedItems[0].SubItems[0].Text;
            //this.listView1.Visible = false;

        }

        #region OcultarFuentes


        private void panelFuenteRss_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.listView1.Visible)
                this.listView1.Visible = false;
        }

        private void VAbstractBanner_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.listView1.Visible)
                this.listView1.Visible = false;
        }

        private void groupBoxHora_Enter(object sender, EventArgs e)
        {
            if (this.listView1.Visible)
                this.listView1.Visible = false;
        }

        private void groupBoxFecha_Enter(object sender, EventArgs e)
        {
            if (this.listView1.Visible)
                this.listView1.Visible = false;
        }

        private void textBoxTitulo_Click(object sender, EventArgs e)
        {
            if (this.listView1.Visible)
                this.listView1.Visible = false;
        }
        #endregion OcultarFuentes

        private void dateTimePickerInicio_ValueChanged(object sender, EventArgs e)
        {
            //Control para que la fecha de fin siempre sea mayor que la fecha de inicio
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

        private void dateTimePickerFin_ValueChanged(object sender, EventArgs e)
        {
            //Control para que la fecha de fin siempre sea mayor que la fecha de inicio
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
        /// Función auxiliar que controla que todos los textBoxs estén completados, lanzando una excepción si no fuese así
        /// </summary>
        protected void ValidarTodoCompleto()
        {
            foreach (Control oControls in this.Controls) // Buscamos en cada TextBox de nuestro Formulario. 
            {
                if (oControls is TextBox & oControls.Text == String.Empty) // Verificamos que no este vacio. 
                {
                    if (oControls!=this.textBoxFuente)
                        throw new ExcepcionCampoSinCompletar("Debe completar todos los campos");
                }
            }
        }
    }
}
