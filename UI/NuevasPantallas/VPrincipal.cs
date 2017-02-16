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
        private ControladorDominio iControladorDominio;
        private Banner iBannerAPasar;
        private Campania iCampaniaAPasar;

        public VPrincipal()
        {
            InitializeComponent();
            this.iControladorDominio = new ControladorDominio(Resolucionador<IUnitOfWork>.Resolver());
            this.iBannerAPasar = new Banner();
            this.iCampaniaAPasar = new Campania();

            //Y ejecutamos el próximo método que da formato a la pantalla principal
            this.IniciarFormatoPantallaPrincipal(new object(),new EventArgs());
        }



#region EVENTOS
        #region BackgroundWorkers y Timers
        private void timerChequeoCambioBanner_Tick(object sender, EventArgs e)
        {
            this.timerChequeoCambioBanner.Stop();
            try
            {
                if (!this.bgwActualizarBannerPantalla.IsBusy)
                {
                    this.bgwActualizarBannerPantalla.RunWorkerAsync();
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

        /// <summary>
        /// Actualiza la información en pantalla del banner deslizante
        /// </summary>
        private void ActualizarBannerDeslizante()
        {
            object[] infoBanner = this.iControladorDominio.InfoBanner(this.iBannerAPasar);
            this.bannerDeslizante.Stop();
            //Asignamos el valor del texto y el intervalo en el que debe reproducirlo
            this.bannerDeslizante.Start((string)((object[])infoBanner)[0]); 
            this.timerChequeoCambioBanner.Interval = (int)((object[])infoBanner)[1];
        }

        private void bgwActualizarBannerPantalla_DoWork(object sender, DoWorkEventArgs e)
        {
            //Buscamos el banner a pasar ahora
            this.iBannerAPasar = this.iControladorDominio.ProximoBannerAPasar();
            this.iControladorDominio.ModificarFuente(this.iControladorDominio.BuscarFuentePorId(iBannerAPasar.FuenteId));
            this.iControladorDominio.GuardarCambios();
        }

        private void bgwActualizarBannerPantalla_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (e.Error != null)
                {
                    throw new Exception("", e.Error);
                }
                else
                {
                    //Obtenemos la info del this.iBannerAPasar formateada y la utilizamos para mostrarlo en pantalla:
                    this.ActualizarBannerDeslizante();

                    //Entonces invocamos a que vaya a leer para actualizar los items:
                    this.bgwLeerBanner.RunWorkerAsync();
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




        private void timerChequeoCambioCampania_Tick(object sender, EventArgs e)
        {
            this.timerChequeoCambioCampania.Stop();
            try
            {
                if (!this.bgwActualizarCampaniaPantalla.IsBusy)
                {
                    this.bgwActualizarCampaniaPantalla.RunWorkerAsync();
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

        /// <summary>
        /// Actualiza la información en pantalla de la campania deslizante
        /// </summary>
        private void ActualizarCampaniaDeslizante()
        {
            object[] infoCampania = this.iControladorDominio.InfoCampania(this.iCampaniaAPasar);
            this.campaniaDeslizante1.Stop();
            //Asignamos el valor de y el intervalo en el que debe reproducirlo
            this.campaniaDeslizante1.Start((List<Imagen>)((object[])infoCampania)[0], (int)((object[])infoCampania)[1]);
            this.timerChequeoCambioCampania.Interval = (int)((object[])infoCampania)[2]; // arrayInformacion[1]=intervalo
        }

        private void bgwActualizarCampaniaPantalla_DoWork(object sender, DoWorkEventArgs e)
        {
            this.iCampaniaAPasar = this.iControladorDominio.ProximaCampaniaAPasar();
        }

        private void bgwActualizarCampaniaPantalla_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (e.Error != null)
                {
                    throw new Exception("", e.Error);
                }
                else if (!e.Cancelled)
                {
                    //Actualiza el contenido de la campania deslizante
                    this.ActualizarCampaniaDeslizante();
                }
                this.timerChequeoCambioBanner.Start();
            }
            catch (Exception ex)
            {
            }
        }
        #endregion


        #region ToolStripMenu
        private void bannerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VBaseBanner vBanner = new VBaseBanner(ref this.iControladorDominio);
            vBanner.Show();
        }

        private void campañaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VBaseCampania vCampania = new VBaseCampania(ref this.iControladorDominio);
            vCampania.Show();
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VBaseFuente vFuente = new VBaseFuente(ref this.iControladorDominio);
            vFuente.Show();
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
        private void VPrincipal_Activated(object sender, EventArgs e)
        {
            this.timerChequeoCambioCampania_Tick(new object(), new EventArgs());
            //ActualizarCampaniaDeslizante();
            //this.timerChequeoCambioCampania.Stop();
            ////this.timerChequeoCambioBanner.Stop();

            //this.timerChequeoCambioCampania.Start();
        }

        private void IniciarFormatoPantallaPrincipal(object sender, EventArgs e)
        {
            //Ventana:
            this.Size = new System.Drawing.Size(656, 702);
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
            this.groupBoxCampania.Size = new System.Drawing.Size(587, 503);
            this.groupBoxBanner.Location = new System.Drawing.Point(27, 555);
            this.groupBoxBanner.Size = new System.Drawing.Size(587, 91);
            this.bannerDeslizante.Location = new System.Drawing.Point(18, 25);
            this.bannerDeslizante.Size = new System.Drawing.Size(550, 46);
            this.campaniaDeslizante1.Location = new System.Drawing.Point(18, 68);
            this.campaniaDeslizante1.Size = new System.Drawing.Size(550, 418);
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

