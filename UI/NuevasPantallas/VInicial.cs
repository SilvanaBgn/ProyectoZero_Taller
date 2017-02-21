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
using System.Threading;

namespace UI.NuevasPantallas
{
    public partial class VInicial : Form
    {
        public VInicial()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// Evento que surge cuando la ventana se empieza a cargar
        /// </summary>
        /// <param name="sender">Objeto que  envía el evento</param>
        /// <param name="e">Argumentos del evento</param>
        private void VInicial_Load(object sender, EventArgs e)
        {
            // Start the BackgroundWorker.
            bgwCargarBD.RunWorkerAsync();
            //Se lanzarían backgroundWorker de cada uno de los elementos a cargar de la DB
        }
        
        /// <summary>
        /// Evento del bgwCargarBD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bgwCargarBD_DoWork(object sender, DoWorkEventArgs e)
        {
            while (!((VPrincipal)this.Owner).BDcreada)
            {
                Thread.Sleep(100);
            }
        }

        /// <summary>
        /// Evento que surge cuando el proceso en segundo plano termina la operación
        /// </summary>
        /// <param name="sender">Objeto que  envía el evento</param>
        /// <param name="e">Argumentos del evento</param>
        private void bgwCargarBD_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Hide();
            ((VPrincipal)this.Owner).Show();
        }
    }
}
