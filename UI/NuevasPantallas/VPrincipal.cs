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
        }


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

        private void VPrincipal_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.menuStrip1.Visible = true;
                //CAMBIAR TAMAÑO... Y REACOMODAR VENTANA
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                //CAMBIAR TAMAÑO... Y REACOMODAR VENTANA
            }
        }


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
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.menuStrip1.Visible = false;
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
    }
}

