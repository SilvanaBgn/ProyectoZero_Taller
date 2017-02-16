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
    public partial class VBannerNuevo : VAbstractBanner
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="pControladorDominio">controlador de dominio</param>
        public VBannerNuevo(ref ControladorDominio pControladorDominio) : base(ref pControladorDominio)
        {
            InitializeComponent();

            this.radioButtonFuenteRss.Select();
            //Establecemos los valores por defecto de los comboBox de la hora
            this.comboBoxH1.SelectedIndex = 0;
            this.comboBoxH2.SelectedIndex = 0;
            this.comboBoxM1.SelectedIndex = 0;
            this.comboBoxM2.SelectedIndex = 0;
        }

        /// <summary>
        /// Evento que se activa cuando se hace click en el botón guardar nuevo banner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void buttonGuardar_Click(object sender, EventArgs e)
        {
            //EXCEPCIONES:
            try
            {
                this.ValidarTodoCompleto();

                this.iBanner = new Banner();
                this.iBanner.Descripcion = this.textBoxTitulo.Text;
                
                this.iBanner.FechaInicio = this.dateTimePickerInicio.Value.Date;
                this.iBanner.FechaFin = this.dateTimePickerFin.Value.Date;
                this.iBanner.HoraInicio = new TimeSpan(Convert.ToInt16(this.comboBoxH1.SelectedItem), Convert.ToInt16(this.comboBoxM1.SelectedItem), 0);
                if (Convert.ToInt16(this.comboBoxH2.SelectedItem) == 0 && Convert.ToInt16(this.comboBoxM2.SelectedItem) == 0)
                    this.iBanner.HoraFin = new TimeSpan(23, 59, 59);
                else
                    this.iBanner.HoraFin = new TimeSpan(Convert.ToInt16(this.comboBoxH2.SelectedItem), Convert.ToInt16(this.comboBoxM2.SelectedItem), 0);

                if (this.iBanner.HoraInicio >= this.iBanner.HoraFin)
                {
                    throw new ExcepcionHoraInicioMayorAHoraFin("La hora de inicio debe ser menor que la hora de fin");
                }


                if (this.radioButtonFuenteRss.Checked)
                {
                    this.iBanner.Tipo = TipoBanner.Rss;
                    if (this.listView1.SelectedItems.Count == 0)
                        throw new ExcepcionCampoSinCompletar("Debe completar con una fuente rss");
                    string urlABuscar = (this.listView1.SelectedItems[0].SubItems[1].Text).ToString();
                    FuenteRss fuente = this.iControladorDominio.ObtenerTodasLasFuentes().FirstOrDefault(x => x.Url == urlABuscar);
                    fuente.Banners.Add(this.iBanner);

                    this.iControladorDominio.ModificarFuente(fuente);
                }
                else  //this.radioButtonTextoPlano.Checked
                {
                    this.iBanner.Tipo = TipoBanner.TextoPlano;
                    if (this.listBoxPasosBanners.Items.Count == 0)
                    {
                        throw new ExcepcionCampoSinCompletar("Debe cargar al menos un Texto plano");
                    }
                    else
                    {
                        List<PasoBanner> listaPasosBanners = new List<PasoBanner>();
                        PasoBanner pasoBanner;
                        for (int i = 1; i <= this.listBoxPasosBanners.Items.Count; i++)
                        {
                            object item = this.listBoxPasosBanners.Items[i - 1];
                            pasoBanner = new PasoBanner();
                            pasoBanner.Texto = item.ToString();
                            pasoBanner.Orden = i;
                            listaPasosBanners.Add(pasoBanner);
                        }
                        this.iBanner.PasoBanners = listaPasosBanners;
                        this.iControladorDominio.AgregarBanner(this.iBanner);
                    }
                }
            
                this.iControladorDominio.GuardarCambios();
                this.Close();
            }
            catch(ExcepcionCampoSinCompletar ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ExcepcionHoraInicioMayorAHoraFin ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(ExcepcionErrorAlGuardar ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ExcepcionAlCargarPantalla ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
