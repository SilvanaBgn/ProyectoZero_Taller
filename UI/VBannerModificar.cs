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
using Excepciones;

namespace UI
{
    public partial class VBannerModificar : VAbstractBanner
    {
        /// <summary>
        /// Lista de paso banner de un banner
        /// </summary>
        List<PasoBanner> iPasoBannersABorrar;

        /// <summary>
        /// Fuente RSS de un banner
        /// </summary>
        Fuente iFuenteActual;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="pControladorDominio">controlador de dominio</param>
        /// <param name="pCodigoBanner">codigo de un banner</param>
        public VBannerModificar(ref ControladorDominio pControladorDominio, int pCodigoBanner) : base(ref pControladorDominio)
        {
            InitializeComponent();
            //try
            //{
            //    this.iBanner = this.iControladorDominio.BuscarBannerPorId(pCodigoBanner);
            //    this.textBoxTitulo.Text = this.iBanner.Descripcion;
            //    if (this.iBanner.Tipo == TipoBanner.Rss)
            //    {
            //        this.iFuenteActual = this.iControladorDominio.BuscarFuenteRssPorId((int)this.iBanner.FuenteId);
            //        this.textBoxFuente.Text = this.iFuenteActual.ToString();
            //        this.radioButtonFuenteRss.Select();
            //        List<FuenteRss> listaDeFuentes = this.iControladorDominio.ObtenerTodasLasFuentes();
            //        this.listView1.FocusedItem = this.listView1.Items.Find(this.iFuenteActual.Url, true).ToList()[0];
            //        this.radioButtonTextoPlano.Enabled = false;
            //    }
            //    else //this.iBanner.Tipo == TipoBanner.TextoPano
            //    {
            //        this.radioButtonTextoPlano.Select();
            //        this.radioButtonFuenteRss.Enabled = false;
            //        for (int i = 1; i <= this.iBanner.PasoBanners.ToList().Count; i++)
            //        {
            //            PasoBanner pB = this.iBanner.PasoBanners.First(x => x.Orden == i);
            //            this.listBoxPasosBanners.Items.Add(pB);
            //        }
            //    }
            //    this.iPasoBannersABorrar = new List<PasoBanner>();
            //}
            //catch (ExcepcionErrorEnLaBusqueda ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    this.Close();
            //}
        }

        /// <summary>
        /// Evento que se activa cuando se hace click en el botón borrar un paso banner,
        /// elimina un paso banner de el this.listBoxPasosBanners
        /// </summary>
        protected override void buttonBorrarPasoBanner_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    PasoBanner pB = this.iBanner.PasoBanners.FirstOrDefault(x => x.PasoBannerId==((PasoBanner)this.listBoxPasosBanners.SelectedItem).PasoBannerId 
            //                                                        && x.ToString() == this.listBoxPasosBanners.SelectedItem.ToString());
            //    this.iBanner.PasoBanners.Remove(pB);
            //    this.listBoxPasosBanners.Items.Remove(this.listBoxPasosBanners.SelectedItem);
            //    //Luego de borrado el item correspondiente, de quedar elementos en el this.listBoxImagenes,selecciona el primer elemento:
            //    this.listBoxPasosBanners.SelectedIndex = 0; //Si no hay más items, lanza una ArgumentOutOfRangeException
            //    this.iControladorDominio.ModificarBanner(this.iBanner);
            //}
            //catch (NullReferenceException) // if (this.listBoxImagenes.Items.Count == 0)
            //{
            //    MessageBox.Show("Debe seleccionarse un Texto para poder borrarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //catch (ArgumentOutOfRangeException) { } //No hacemos nada
        }

        /// <summary>
        /// Evento que se activa cuando se hace click en el botón guardar
        /// </summary>
        protected override void buttonGuardar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.ValidarTodoCompleto();

            //    this.iBanner.Descripcion = this.textBoxTitulo.Text;

            //    this.iBanner.FechaInicio = this.dateTimePickerInicio.Value.Date;
            //    this.iBanner.FechaFin = this.dateTimePickerFin.Value.Date;
            //    this.iBanner.HoraInicio = new TimeSpan(Convert.ToInt16(this.comboBoxH1.SelectedItem), Convert.ToInt16(this.comboBoxM1.SelectedItem), 0);
            //    if (Convert.ToInt16(this.comboBoxH2.SelectedItem) == 0 && Convert.ToInt16(this.comboBoxM2.SelectedItem) == 0)
            //        this.iBanner.HoraFin = new TimeSpan(23, 59, 59);
            //    else
            //        this.iBanner.HoraFin = new TimeSpan(Convert.ToInt16(this.comboBoxH2.SelectedItem), Convert.ToInt16(this.comboBoxM2.SelectedItem), 0);


            //    if (this.iBanner.HoraInicio >= this.iBanner.HoraFin)
            //    {
            //        throw new ExcepcionHoraInicioMayorAHoraFin("La hora de inicio debe ser menor que la hora de fin");
            //    }


            //    if (this.radioButtonTextoPlano.Checked)
            //    {
            //        if (this.iBanner.Tipo == TipoBanner.Rss)
            //        {
            //            this.iBanner.Tipo = TipoBanner.TextoPlano;
            //        }
            //        //AGREGACIONES Y MODIFICACIONES
            //        if (this.listBoxPasosBanners.Items.Count == 0)
            //        {
            //            throw new ExcepcionCampoSinCompletar("Debe cargar al menos un Texto plano");
            //        }
            //        else
            //        {
            //            for (int i = 1; i <= this.listBoxPasosBanners.Items.Count; i++)
            //            {
            //                object item = this.listBoxPasosBanners.Items[i - 1];
            //                PasoBanner pB = this.iBanner.PasoBanners.FirstOrDefault(x => x.ToString() == item.ToString());
            //                if (pB != null) //quiere decir que se trata de un pasoBanner que existía
            //                {
            //                    pB.Orden = i;
            //                }
            //                else //Se agregó un pasoBanner nuevo
            //                    this.iBanner.PasoBanners.Add(new PasoBanner() { Texto = item.ToString(), Orden = i });
            //                pB = null;
            //            }
            //        }
            //    }
            //    else //this.radioButtomFuenteRss.Checked
            //    {
            //        if (this.iBanner.Tipo == TipoBanner.TextoPlano)
            //        {
            //            this.iBanner.Tipo = TipoBanner.Rss;
            //        }
            //        if (this.textBoxFuente.Text != this.iFuenteActual.Descripcion) //si realmente se cambió la fuente
            //        {
            //            if (this.textBoxFuente.Text == null)
            //                throw new ExcepcionCampoSinCompletar("Debe completar con una fuente rss");
            //            this.iFuenteActual.Banners.Remove(this.iBanner);
            //            this.iControladorDominio.ModificarFuente(this.iFuenteActual);

            //            this.iBanner.FuenteId = this.iIdFuenteNuevaSeleccionada;
            //        }
            //    }

            //    this.iControladorDominio.ModificarBanner(this.iBanner);
            //    this.iControladorDominio.GuardarCambios();
            //    this.Close();
            //}
            //catch (ExcepcionCampoSinCompletar ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //catch (ExcepcionHoraInicioMayorAHoraFin ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //catch (ExcepcionErrorAlGuardar ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //catch (ExcepcionAlCargarPantalla ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        /// <summary>
        /// Este evento se activa cuando se carga VBannerModificar
        /// </summary>
        private void VBannerModificar_Load(object sender, EventArgs e)
        {
            this.dateTimePickerInicio.Text = this.iBanner.FechaInicio.ToString();
            this.dateTimePickerFin.Text = this.iBanner.FechaFin.ToString();

            this.comboBoxH1.Text = this.iBanner.HoraInicio.Hours.ToString();

            this.comboBoxM1.Text = this.iBanner.HoraInicio.Minutes.ToString();
            if (this.iBanner.HoraFin.Hours == 23 && this.iBanner.HoraFin.Minutes == 59)
            {
                this.comboBoxH2.Text = "00";
                this.comboBoxM2.Text = "00";
            }
            else
            {
                this.comboBoxH2.Text = this.iBanner.HoraFin.Hours.ToString();
                this.comboBoxM2.Text = this.iBanner.HoraFin.Minutes.ToString();
            }
        }

    }

}
