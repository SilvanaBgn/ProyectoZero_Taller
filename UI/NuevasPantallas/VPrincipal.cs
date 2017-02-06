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
//            this.InicializacionTimers();

            //Inicializamos el timer
            this.timerChequeoCambioBanner.Interval = 1000; // 1000 milisegundos = 1 segundo
            this.timerChequeoCambioBanner.Enabled = true;
        }


        private void InicializacionTimers()
        {
            
        }

        private void FinalizacionTimers()
        {
            this.timerChequeoCambioBanner.Enabled = false;
        }


        private void timerChequeoCambioBanner_Tick(object sender, EventArgs e)
        {
            this.timerChequeoCambioBanner.Enabled = false;
            //Cambiar el texto del banner
            //HACER QUE SE ACOMODE EL TICK para que HAGA UN TICK CADA el intervalo que corresponda
            this.timerChequeoCambioBanner.Enabled = true;
        }










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
            this.WindowState = FormWindowState.Maximized;
            this.menuStrip1.Visible = false;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bgwLeerBanner_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void bgwLeerBanner_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

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

        private void bgwInicializacionTimer_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void bgwInicializacionTimer_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

       
    }
}
