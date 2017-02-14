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

        public VPrincipal()
        {
            InitializeComponent();
            this.iControladorDominio = new ControladorDominio(Resolucionador<IUnitOfWork>.Resolver());
            this.buttonSalirPantallaCompleta_Click(new object(),new EventArgs());
        }

        #region BackgroundWorkers y Timers
        private void timerChequeoCambioBanner_Tick(object sender, EventArgs e)
        {
            this.timerChequeoCambioBanner.Stop();
            try
            {
                if (!this.bgwLeerBanner.IsBusy)
                {
                    this.bgwLeerBanner.RunWorkerAsync();
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


        private void bgwLeerBanner_DoWork(object sender, DoWorkEventArgs e)
        {
            //Cambiar el texto del banner
            e.Result = this.iControladorDominio.LeerProximoBanner();
        }

        private void bgwLeerBanner_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (e.Error != null)
                {
                    MessageBox.Show(String.Format("No se han podido obtener los datos del banner: {0}", e.Error.Message),
                                                      "Ha ocurrido un error",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Error);
                    throw new Exception("", e.Error);
                }
                else if (!e.Cancelled)
                {
                    this.bannerDeslizante.Stop();
                    //Asignamos el valor del texto y el intervalo en el que debe reproducirlo
                    this.bannerDeslizante.Start((string)((object[])e.Result)[0]); //arrayInformacion[0]=texto  
                    this.timerChequeoCambioBanner.Interval = (int)((object[])e.Result)[1]; // arrayInformacion[1]=intervalo

                    this.timerChequeoCambioBanner.Start();
                }
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
                if (!this.bgwLeerCampania.IsBusy)
                {
                    this.bgwLeerCampania.RunWorkerAsync();
                }
                else //Esperamos 1 seg y volvemos a intentar
                {
                    this.timerChequeoCambioCampania.Interval = 1000;
                    this.timerChequeoCambioCampania.Start();
                }
            }
            catch (Exception bEx)
            {
                MessageBox.Show(bEx.Message, "Se ha producido un error al intentar actualizar el banner", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bgwLeerCampania_DoWork(object sender, DoWorkEventArgs e)
        {
            //Actualiza el contenido de la campania
            e.Result = this.iControladorDominio.LeerProximaCampania();
        }

        private void bgwLeerCampania_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (e.Error != null)
                {
                    MessageBox.Show(String.Format("No se han podido obtener los datos de la campaña: {0}", e.Error.Message),
                                                      "Ha ocurrido un error",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Error);
                    throw new Exception("", e.Error);
                }
                else if (!e.Cancelled)
                {
                    this.campaniaDeslizante1.Stop();
                    //Asignamos las imagenes y el intervalo en el que debe reproducirlo
                    this.campaniaDeslizante1.Start((List<Imagen>)((object[])e.Result)[0], (int)((object[])e.Result)[1]);
                    this.timerChequeoCambioBanner.Interval = (int)((object[])e.Result)[2]; // arrayInformacion[1]=intervalo

                    this.timerChequeoCambioBanner.Start();
                }
                this.timerChequeoCambioCampania.Start();
            }
            catch (Exception ex)
            {
            }
        }
        #endregion


#region EVENTOS
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

        private void VPrincipal_Activated(object sender, EventArgs e)
        {
            this.timerChequeoCambioBanner.Start();
            //this.timerChequeoCambioCampania.Start();
        }

        private void buttonSalirPantallaCompleta_Click(object sender, EventArgs e)
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
            this.buttonSalirPantallaCompleta_Click(sender, new EventArgs());
        }
    }
}

