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
using Excepciones.ExcepcionesPantalla;
using Excepciones.ExcepcionesDominio;

namespace UI.NuevasPantallas
{
    public partial class VPrincipal : Form
    {
        /// <summary>
        /// Atributo que almacena la Ventana de "Configuración BANNERS"
        /// </summary>
        private VBaseBanner iVentanaBanners;
        /// <summary>
        /// Atributo que almacena la Ventana de "Configuración CAMPAÑAS"
        /// </summary>
        private VBaseCampania iVentanaCampanias;
        /// <summary>
        /// Atributo que almacena la Ventana de "Configuración FUENTES"
        /// </summary>
        private VBaseFuente iVentanaFuentes;

        /// <summary>
        /// Atributo que almacena el Controlador de Dominio
        /// </summary>
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
        /// Contiene al banner a pasar en el banner deslizante
        /// </summary>
        private Banner iBannerAPasar;
        /// <summary>
        /// Contiene a la campaña a pasar en la campania deslizante
        /// </summary>
        private Campania iCampaniaAPasar;

        /// <summary>
        /// Variable booleana de control que indica si en el cuarto de hora actual ya se buscó (obtuvo) el banner
        /// </summary>
        private bool iObtenidoBanner;
        /// <summary>
        /// Variable booleana de control que indica si en el cuarto de hora actual ya se buscó (obtuvo) la campania
        /// </summary>
        private bool iObtenidoCampania;
        /// <summary>
        /// Variable booleana de control que indica si en el cuarto de hora actual ya se leyó el banner (rss)
        /// </summary>
        private bool iLeidoBanner;

        /// <summary>
        /// Variable booleana de control que se activa cuando la BD está lista para usarse
        /// </summary>
        public bool BDcreada = false;



        //CONSTRUCTOR
        public VPrincipal()
        {
            InitializeComponent();
            this.iControladorDominio = new ControladorDominio(Resolucionador<IUnitOfWork>.Resolver());

            //Se ubica la ventana en el centro de la pantalla:
            this.StartPosition = FormStartPosition.CenterScreen;
        }



        #region BackgroundWorkers y Timers

        /// <summary>
        /// Actualiza la información en pantalla del banner deslizante
        /// </summary>
        private void ActualizarBannerDeslizante()
        {
            string infoBannerNuevo = this.iControladorDominio.InfoBanner(this.iBannerAPasar);
            //En el caso de una Lectura Externa o de que el banner cambie a los 15 min, serían distintos,
            //entonces preguntamos para que en el caso el bannerDeslizante no se recargue:
            if (this.iInfoBannerActual != infoBannerNuevo)
            {
                this.iInfoBannerActual = infoBannerNuevo;
                this.bannerDeslizante.Stop();
                //Asignamos el valor del texto que debe reproducir:
                this.bannerDeslizante.Start(this.iInfoBannerActual);
            }
        }

        /// <summary>
        /// Actualiza la información en pantalla de la campania deslizante
        /// </summary>
        private void ActualizarCampaniaDeslizante()
        {
            object[] infoCampaniaNueva = this.iControladorDominio.InfoCampania(this.iCampaniaAPasar);
            this.campaniaDeslizante.Stop();
            //Asignamos el valor y la duración de c/imagen, que debe reproducir:
            this.campaniaDeslizante.Start((List<Imagen>)(infoCampaniaNueva)[0], (int)(infoCampaniaNueva)[1]);
        }




        /// <summary>
        /// Evento tick del this.timerChequeoCambio, que indica que estamos en un cuarto de hora, 
        /// y con el cual da la orden de comenzar la actualización de la campania deslizante.
        /// </summary>
        private void timerChequeoCambio_Tick(object sender, EventArgs e)
        {
            this.timerChequeoCambio.Stop();

            //Colocamos todas las variables booleanas de control en false:
            this.iObtenidoBanner = false;
            this.iObtenidoCampania = false;
            this.iLeidoBanner = false;

            try
            {
                this.bgwObtenerCampania.RunWorkerAsync();
            }
            catch (Exception bEx)
            {
            }
        }

        /// <summary>
        /// Evento Do_Work del this.bgwObtenerCampania, que obtiene la próxima campania a pasar
        /// </summary>
        private void bgwObtenerCampania_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (!this.iObtenidoCampania)
                {
                    //Actualizamos la fecha y hora actuales:
                    DateTime fechaHora = DateTime.Now;
                    this.iFechaActual = DateTime.Today;
                    this.iHoraActual = new TimeSpan(fechaHora.Hour, fechaHora.Minute, fechaHora.Second);

                    this.iCampaniaAPasar = this.iControladorDominio.ProximaCampaniaAPasar(this.iFechaActual, this.iHoraActual);

                    //Si pasó es porque se completó la campania (this.iObtenidoCampania==true):
                    this.iObtenidoCampania = true;
                }
            }
            catch (ExcepcionAlObtenerCampanias ex) { }
            }

        /// <summary>
        /// Evento Do_Work del this.bgwObtenerBanner, que obtiene el próximo banner a pasar
        /// </summary>
        private void bgwObtenerBanner_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                //Buscamos el banner a pasar ahora
                if (!this.iObtenidoBanner)
                {
                    //Actualizamos la fecha y hora actuales:
                    DateTime fechaHora = DateTime.Now;
                    this.iFechaActual = DateTime.Today;
                    this.iHoraActual = new TimeSpan(fechaHora.Hour, fechaHora.Minute, fechaHora.Second);

                    this.iBannerAPasar = this.iControladorDominio.ProximoBannerAPasar(this.iFechaActual, this.iHoraActual);

                    //Si pasó es porque se completó el banner (this.iObtenidoBanner==true):
                    this.iObtenidoBanner = true;
                }
            }
            catch (ExcepcionAlObtenerBanners ex) { }
            }

        /// <summary>
        /// Evento RunWorkerCompleted, que pone a correr ya sea el bgwObtenerBanner y/o bgwObtenerCampania.
        /// Si ambos han sido leidos, actualiza la pantalla.
        /// Finalmente, busca actualizar los items del banner con el Lector
        /// </summary>
        private void bgwObtener_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //En este momento, ni el bgwObtenerBanner ni bgwObtenerCampania deberían estar ocupados:
            if (!this.iObtenidoBanner && !this.iObtenidoCampania)
            {
                if (!this.bgwObtenerBanner.IsBusy)
                    this.bgwObtenerBanner.RunWorkerAsync();
                else //(!this.bgwObtenerCampania.IsBusy)
                    this.bgwObtenerCampania.RunWorkerAsync();
            }
            else if (!this.iObtenidoBanner)
            {
                this.bgwObtenerBanner.RunWorkerAsync();
            }
            else if (!this.iObtenidoCampania)
            {
                this.bgwObtenerCampania.RunWorkerAsync();
            }
            else //this.iObtenidoBanner==this.iObtenidoCampania == true --> Actualizar pantalla:
            {
                BDcreada = true;

                //Actualiza el contenido de la campania deslizante
                this.ActualizarCampaniaDeslizante();
                
                //Obtenemos la info del this.iBannerAPasar formateada y la utilizamos para mostrarlo en pantalla:
                this.ActualizarBannerDeslizante();
                
                //Actualizamos la fecha y hora actuales:
                DateTime fechaHora = DateTime.Now;
                this.iFechaActual = DateTime.Today;
                this.iHoraActual = new TimeSpan(fechaHora.Hour, fechaHora.Minute, fechaHora.Second);
                this.timerChequeoCambio.Interval = this.iControladorDominio.IntervaloAlProxCuartoDeHora(this.iHoraActual);

                //Ponemos a correr el timer:
                this.timerChequeoCambio.Start();

                if (this.iBannerAPasar != null && !this.bgwLeerBanner.IsBusy)
                { //Finalmente, invocamos a que vaya a leer para actualizar los items:
                    try {
                        this.bgwLeerBanner.RunWorkerAsync();
                    }
                    catch(ExcepcionAlLeerFuenteExternaDelBanner ex)
                    { }
                }
            }
        }


        /// <summary>
        /// Evento Do_Work del this.bgwLeerBanner, que realiza la lectura de items en segundo plano del 
        /// this.iBanner 
        /// </summary>
        private void bgwLeerBanner_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                this.iControladorDominio.LeerBanner(this.iBannerAPasar);
                this.iLeidoBanner = true;
            }
            catch (ExcepcionAlLeerFuenteExternaDelBanner ex)
            { this.iLeidoBanner = false; }
        }

        /// <summary>
        /// Evento RunWorkerCompleted del this.bgwLeerBanner, con el que se actualiza la pantalla y finalmente
        /// pone a correr el timer this.timerChequeoCambioCampania
        /// </summary>
        private void bgwLeerBanner_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (this.iLeidoBanner)
            {
                //Actualizamos el contenido del banner deslizante por si la Lectura cambió los items del banner
                this.ActualizarBannerDeslizante();
                this.iToolStripStatusLabel.Text = "";
                //    //this.labelLeido.Text = "Leyó";
            }
            else
                this.iToolStripStatusLabel.Text = "No se pudo establecer la conexion o la url no existe";
            //else
            //{
            //    int cantIntentos = ((int)e.Result);
            //    cantIntentos += 1;
            //    //this.labelLeido.Text += cantIntentos.ToString()+ " int";

            //    //Intentamos actualizar la lectura rss hasta 5 veces, sino se se volverá a intentar la 
            //    //próxima vez que se active la ventana, o bien sino dentro de 15 min
            //    if (cantIntentos <= 5) 
            //        this.bgwLeerBanner.RunWorkerAsync(cantIntentos);
            //}
        }
        #endregion


        #region Eventos Botones (ToolStripMenu)
        /// <summary>
        /// Evento que se activa con el botón toolStripMenu "Banners"
        /// </summary>
        private void bannerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.iVentanaBanners = new VBaseBanner(ref this.iControladorDominio);
            this.iVentanaBanners.Owner = this;
            this.iVentanaBanners.ShowDialog();
            this.iVentanaBanners = null;
        }

        /// <summary>
        /// Evento que se activa con el botón toolStripMenu "Campañas"
        /// </summary>
        private void campañaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.iVentanaCampanias = new VBaseCampania(ref this.iControladorDominio);
            this.iVentanaCampanias.Owner = this;
            this.iVentanaCampanias.ShowDialog();
            this.iVentanaCampanias = null;
            this.ActualizarPantalla();
        }

        /// <summary>
        /// Evento que se activa con el botón toolStripMenu "Fuentes"
        /// </summary>
        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.iVentanaFuentes = new VBaseFuente(ref this.iControladorDominio);
            this.iVentanaFuentes.Owner = this;
            this.iVentanaFuentes.ShowDialog();
            this.iVentanaFuentes = null;
            this.ActualizarPantalla();
        }

        /// <summary>
        /// Evento que se activa con el botón toolStripMenu "Pantalla Completa"
        /// </summary>
        private void verPantallaCompletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ventana:
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = true;
            this.WindowState = FormWindowState.Maximized;

            //Objetos visibles:
            this.menuStrip.Visible = false;
            this.buttonSalirPantallaCompleta.Visible = true;

            //Ubicación y tamaño de objetos:

            this.groupBoxCampania.Location = new System.Drawing.Point(312, 5);
            //this.groupBoxCampania.Size = new System.Drawing.Size(734, 650);
            this.groupBoxBanner.Location = new System.Drawing.Point(29, 660);
            this.groupBoxBanner.Size = new System.Drawing.Size(1300, 100);
            this.bannerDeslizante.Size = new System.Drawing.Size(1263, 55);
            //this.campaniaDeslizante1.Size = new System.Drawing.Size(700, 568);
            this.bannerDeslizante.Font = new System.Drawing.Font("Microsoft Sans Serif", 37F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalirPantallaCompleta.Focus();
        }

        /// <summary>
        /// Evento que se activa con el botón toolStripMenu "Salir"
        /// </summary>
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


        #region Otros Ventana
        /// <summary>
        /// Evento que se activa despúes de la inicialización, cuando el form se está cargando
        /// </summary>
        private void VPrincipal_Load(object sender, EventArgs e)
        {
            //Pantalla de Presentación:
            VPresentacion ventanaPresentacion = new VPresentacion();
            ventanaPresentacion.Owner = this;
            this.Hide();
            ventanaPresentacion.ShowDialog();

            //Pantalla de Pre-carga:
            VInicial ventanaInicial = new VInicial();
            ventanaInicial.Owner = this;
            this.ActualizarPantalla();
            this.Hide();
            ventanaInicial.ShowDialog();

            //Damos formato a la pantalla principal:
            this.IniciarFormatoPantallaPrincipal(new object(), new EventArgs());

        }

        /// <summary>
        /// Evento que se ejecuta cuando la ventana se activa
        /// Pone a correr los timers para que se actualice el pasaje de banner y campania deslizantes:
        /// </summary>
        private void VPrincipal_Activated(object sender, EventArgs e)
        {
            //Ponemos a correr los timers para que se muestren las campanias y banners deslizantes:
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
            this.timerChequeoCambio.Stop();
            this.timerChequeoCambio_Tick(1000, new EventArgs());
        }

        /// <summary>
        /// Evento que formatea la VPantallaPrincipal a su forma "normal"
        /// </summary>
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
            this.menuStrip.Visible = true; //Menú ppal
            this.buttonSalirPantallaCompleta.Visible = false; //Botón salir de pantalla completa

            //Ubicación y tamaño de objetos:
            this.groupBoxCampania.Location = new System.Drawing.Point(27, 37);
            this.groupBoxCampania.Size = new System.Drawing.Size(781, 503);
            this.groupBoxBanner.Location = new System.Drawing.Point(27, 547);
            this.groupBoxBanner.Size = new System.Drawing.Size(781, 91);
            this.bannerDeslizante.Size = new System.Drawing.Size(735, 46);
            this.campaniaDeslizante.Size = new System.Drawing.Size(735, 459);
            this.bannerDeslizante.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        /// <summary>
        /// Evento que se activa al salir de la vista de Pantalla Completa
        /// </summary>
        private void buttonSalirPantallaCompleta_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.IniciarFormatoPantallaPrincipal(sender, new EventArgs());
        }
        #endregion
    }
}

