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

namespace UI.NuevasPantallas
{
    public partial class VPrincipal : Form
    {
        private ControladorDominio iControladorDominio;

        public VPrincipal()
        {
            InitializeComponent();
            this.iControladorDominio = new ControladorDominio(Resolucionador<IUnitOfWork>.Resolver());

            //Inicializamos el timer
            this.timerChequeoCambioBanner.Interval = 1000; // 1000 milisegundos = 1 segundo
            this.timerChequeoCambioBanner.Enabled = true;
        }


        private void timerChequeoCambioBanner_Tick(object sender, EventArgs e)
        {
            this.timerChequeoCambioBanner.Enabled = false;
            this.bgwLeerBanner.RunWorkerAsync();
        }


        private void bannerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VBaseBanner vBanner = new VBaseBanner(ref this.iControladorDominio);
            vBanner.Show();
        }

        private void campañaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VBaseCampania vCampania = new VBaseCampania(ref this.iControladorDominio);
            //vCampania.Show();
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VBaseFuente vFuente = new VBaseFuente(ref this.iControladorDominio);
            vFuente.Show();
        }

        private void verPantallaCompletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.menuStrip1.Visible = false;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bgwLeerBanner_DoWork(object sender, DoWorkEventArgs e)
        {
            //Cambiar el texto del banner
            e.Result = this.iControladorDominio.LeerProximoBanner();
        }

        private void bgwLeerBanner_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            { 
                MessageBox.Show(String.Format("No se han podido obtener datos de la fuente rss: {0}", e.Error.Message),
                                                  "Ha ocurrido un error",
                                                  MessageBoxButtons.OK,
                                                  MessageBoxIcon.Error);
            }
            else if (!e.Cancelled)
            {
                this.bannerDeslizante.Stop(); 
                //Asignamos el valor del texto y el intervalo en el que debe reproducirlo
                this.bannerDeslizante.Start((string)((object[])e.Result)[1]); //arrayInformacion[0]=texto  
                this.timerChequeoCambioBanner.Interval = (int)((object[])e.Result)[1]; // arrayInformacion[1]=intervalo

                this.timerChequeoCambioBanner.Enabled = true;
            }
        }

        private void bgwLeerCampania_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void bgwLeerCampania_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

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
    }
}
