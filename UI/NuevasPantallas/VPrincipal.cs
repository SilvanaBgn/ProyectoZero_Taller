using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Contenedor;
using System.Threading;

namespace UI.NuevasPantallas
{
    public partial class VPrincipal : Form
    {
        private VBaseBanner iVentanaBanners;
        private VBaseCampania iVentanaCampanias;
        private VBaseFuente iVentanaFuentes;

        private ControladorDominio iControladorDominio;

        /// <summary>
        /// Guarda la fecha actual, para la actualización de los banners y las campanias
        /// </summary>
        private DateTime iFechaActual;
        /// <summary>
        /// Guarda la hora actual, para la actualización de los banners y las campanias
        /// </summary>
        private TimeSpan iHoraActual;

        /// <summary>
        /// Guarda el texto del banner actual, para evitar parar el funcionamiento del banner
        /// deslizante innecesariamente
        /// </summary>
        private string iInfoBannerActual;

        /// <summary>
        /// Guarda la informacion de la campania actual, para evitar parar el funcionamiento de la campania
        /// deslizante innecesariamente
        /// </summary>
        private object[] iInfoCampaniaActual;

        /// <summary>
        /// Contiene al banner a pasar en el banner deslizante
        /// </summary>
        private Banner iBannerAPasar;
        /// <summary>
        /// Contiene a la campaña a pasar en la campania deslizante
        /// </summary>
        private Campania iCampaniaAPasar;

        /// <summary>
        /// Variable booleana que indica cuando la BD está lista para usarse
        /// </summary>
        public bool BDcreada=false;

        public VPrincipal()
        {
            InitializeComponent();
            this.iControladorDominio = new ControladorDominio(Resolucionador<IUnitOfWork>.Resolver());
            this.iCampaniaAPasar = new Campania();

            //Y ejecutamos el próximo método que da formato a la pantalla principal
            this.IniciarFormatoPantallaPrincipal(new object(),new EventArgs());
        }



        #region EVENTOS
        #region BackgroundWorkers y Timers

        /// <summary>
        /// Actualiza la información en pantalla del banner deslizante
        /// </summary>
        private void ActualizarBannerDeslizante()
        {
            string infoBannerNuevo = this.iControladorDominio.InfoBanner(this.iBannerAPasar);

            if (this.iInfoBannerActual != infoBannerNuevo)//En el caso de una Lectura Externa, serían distintos
                                                          //Entonces, preguntamos para que en el caso, el bannerDesl no se recargue
            {
                this.iInfoBannerActual = infoBannerNuevo;
                this.bannerDeslizante.Stop();
                //Asignamos el valor del texto y el intervalo en el que debe reproducirlo
                this.bannerDeslizante.Start(this.iInfoBannerActual);
            }
        }

        /// <summary>
        /// Actualiza la información en pantalla de la campania deslizante
        /// </summary>
        private void ActualizarCampaniaDeslizante()
        {
            object[] infoCampaniaNueva = this.iControladorDominio.InfoCampania(this.iCampaniaAPasar);
            if (this.iInfoCampaniaActual != infoCampaniaNueva) 
            {
                this.iInfoCampaniaActual = infoCampaniaNueva;
                this.campaniaDeslizante1.Stop();
                //Asignamos el valor de y el intervalo en el que debe reproducirlo
                this.campaniaDeslizante1.Start((List<Imagen>)(infoCampaniaNueva)[0], (int)(infoCampaniaNueva)[1]);
                this.timerChequeoCambioCampania.Interval = (int)(infoCampaniaNueva)[2]; // arrayInformacion[1]=intervalo
            }
        }







        private void timerChequeoCambioCampania_Tick(object sender, EventArgs e)
        {
            this.timerChequeoCambioCampania.Stop();
            try
            {
                if (!this.bgwObtenerCampania.IsBusy)
                {
                    this.bgwObtenerCampania.RunWorkerAsync();
                }
                else //Esperamos 1 seg y volvemos a intentar
                {
                    this.timerChequeoCambioCampania.Interval = 1000;
                    this.timerChequeoCambioCampania.Start();
                }
            }
            catch (Exception bEx)
            {
            }
        }


        private void bgwObtenerCampania_DoWork(object sender, DoWorkEventArgs e)
        {
            this.iFechaActual = DateTime.Now;
            this.iHoraActual = new TimeSpan(this.iFechaActual.Hour, this.iFechaActual.Minute, this.iFechaActual.Second);

            this.iCampaniaAPasar = this.iControladorDominio.ProximaCampaniaAPasar(this.iFechaActual, this.iHoraActual);
        }

        private void bgwObtenerCampania_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (e.Error != null)
                {
                    throw new Exception("Error al buscar la Campaña a pasar", e.Error);
                }
                this.timerChequeoCambioBanner.Start();
            }
            catch (Exception ex)
            {
            }
        }






        private void timerChequeoCambioBanner_Tick(object sender, EventArgs e)
        {
            this.timerChequeoCambioBanner.Stop();
            try
            {
                if (!this.bgwObtenerBanner.IsBusy)
                {
                    this.bgwObtenerBanner.RunWorkerAsync();
                }
                else //Esperamos 1 seg y volvemos a intentar
                {
                    this.timerChequeoCambioBanner.Interval = 1000;
                    this.timerChequeoCambioBanner.Start();
                }
            }
            catch (Exception bEx)
            {
                MessageBox.Show(bEx.Message, "Se ha producido un error al intentar actualizar el banner", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bgwObtenerBanner_DoWork(object sender, DoWorkEventArgs e)
        {
            this.iFechaActual = DateTime.Now;
            this.iHoraActual = new TimeSpan(this.iFechaActual.Hour, this.iFechaActual.Minute, this.iFechaActual.Second);
            //Buscamos el banner a pasar ahora
            this.iBannerAPasar = this.iControladorDominio.ProximoBannerAPasar(this.iFechaActual,this.iHoraActual);
            this.timerChequeoCambioBanner.Interval = this.iControladorDominio.IntervaloAlProxCuartoDeHora(this.iHoraActual);
        }

        private void bgwObtenerBanner_ActualizarPantalla_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (e.Error != null)
                {
                    throw new Exception("Error al buscar el Banner a pasar", e.Error);
                }
                else
                {
                    BDcreada = true;
                    //Actualiza el contenido de la campania deslizante
                    this.ActualizarCampaniaDeslizante();

                    //Obtenemos la info del this.iBannerAPasar formateada y la utilizamos para mostrarlo en pantalla:
                    this.ActualizarBannerDeslizante();

                    if (this.iBannerAPasar != null)
                    { //Entonces invocamos a que vaya a leer para actualizar los items:
                        this.bgwLeerBanner.RunWorkerAsync();
                    }
                    else
                        this.timerChequeoCambioCampania.Start();
                }
            }
            catch(Exception ex)
            { }
        }


        private void bgwLeerBanner_DoWork(object sender, DoWorkEventArgs e)
        {
            this.iControladorDominio.LeerBanner(this.iBannerAPasar);
        }


        private void bgwLeerBanner_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (e.Error != null)
                {
                    throw new Exception("Error al realizar la Lectura Externa de Banner", e.Error);
                }
                else if (!e.Cancelled)
                {
                    //Actualizamos el contenido del banner deslizante por si la Lectura cambió los items del banner
                    this.ActualizarBannerDeslizante();
                }
                this.timerChequeoCambioCampania.Start();
            }
            catch (Exception ex)
            {
            }
        }
        #endregion


        #region ToolStripMenu
        private void bannerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.iVentanaBanners = new VBaseBanner(ref this.iControladorDominio);
            this.iVentanaBanners.Owner = this;
            this.iVentanaBanners.ShowDialog();
            this.iVentanaBanners = null;
        }

        private void campañaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.iVentanaCampanias = new VBaseCampania(ref this.iControladorDominio);
            this.iVentanaCampanias.Owner = this;
            this.iVentanaCampanias.ShowDialog();
            this.iVentanaCampanias = null;
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.iVentanaFuentes = new VBaseFuente(ref this.iControladorDominio);
            this.iVentanaFuentes.Owner = this;
            this.iVentanaFuentes.ShowDialog();
            this.iVentanaFuentes = null;
        }

        private void verPantallaCompletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ventana:
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = true;
            this.WindowState = FormWindowState.Maximized;

            //Objetos visibles:
            this.menuStrip1.Visible = false;
            this.buttonSalirPantallaCompleta.Visible = true;

            //Ubicación y tamaño de objetos:
            
            this.groupBoxCampania.Location = new System.Drawing.Point(312, 5);
            this.groupBoxCampania.Size = new System.Drawing.Size(734, 650);
            this.groupBoxBanner.Location = new System.Drawing.Point(29, 660);
            this.groupBoxBanner.Size = new System.Drawing.Size(1300, 100);
            this.bannerDeslizante.Size = new System.Drawing.Size(1263, 55);
            this.campaniaDeslizante1.Size = new System.Drawing.Size(700, 568);
            this.bannerDeslizante.Font = new System.Drawing.Font("Microsoft Sans Serif", 37F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalirPantallaCompleta.Focus();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


        #region Otros Ventana
        private void VPrincipal_Load(object sender, EventArgs e)
        {
            //VPresentacion ventanaPresentacion = new VPresentacion();
            //ventanaPresentacion.Owner = this;
            //this.Hide();
            //ventanaPresentacion.ShowDialog();
            VInicial ventanaInicial = new VInicial();
            ventanaInicial.Owner = this;
            this.ActualizarPantalla();
            this.Hide();
            ventanaInicial.ShowDialog();
            
        }

        private void VPrincipal_Activated(object sender, EventArgs e)
        {
            this.ActualizarPantalla();

            //Preguntamos si las ventanas hijas son nulas, sino significa que están abiertas
            //y les dejamos el foco 
            if (this.iVentanaBanners != null)
                this.iVentanaBanners.Activate();
            else if (this.iVentanaCampanias != null)
                this.iVentanaCampanias.Activate();
            else if (this.iVentanaFuentes != null)
                this.iVentanaFuentes.Activate();
        }

        /// <summary>
        /// Pone a correr los timers para que se actualicen el banner y la campania deslizantes
        /// </summary>
        private void ActualizarPantalla()
        {
            this.timerChequeoCambioCampania.Stop();
            this.timerChequeoCambioBanner.Stop();

            this.timerChequeoCambioBanner.Interval = 1000;
            //this.timerChequeoCambioCampania.Start();
            this.timerChequeoCambioCampania_Tick(1000, new EventArgs());
        }

        private void IniciarFormatoPantallaPrincipal(object sender, EventArgs e)
        {
            //Ventana:
            this.Size = new System.Drawing.Size(851, 680);
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink; //Que no permita redimensionar la ventana
            this.MaximizeBox = false; //Que no permita maximizar
            this.FormBorderStyle = FormBorderStyle.Fixed3D; //Barra de estado
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;

            //Objetos visibles
            this.menuStrip1.Visible = true; //Menú ppal
            this.buttonSalirPantallaCompleta.Visible = false; //Botón salir de pantalla completa

            //Ubicación y tamaño de objetos:
            this.groupBoxCampania.Location = new System.Drawing.Point(27, 31);
            this.groupBoxCampania.Size = new System.Drawing.Size(781, 503);
            this.groupBoxBanner.Location = new System.Drawing.Point(27, 541);
            this.groupBoxBanner.Size = new System.Drawing.Size(781, 91);
            this.bannerDeslizante.Location = new System.Drawing.Point(22, 25);
            this.bannerDeslizante.Size = new System.Drawing.Size(735, 46);
            this.campaniaDeslizante1.Location = new System.Drawing.Point(22, 28);
            this.campaniaDeslizante1.Size = new System.Drawing.Size(735, 459);
            this.bannerDeslizante.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void buttonSalirPantallaCompleta_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.IniciarFormatoPantallaPrincipal(sender, new EventArgs());
        }


        #endregion

        #endregion
    }
}

