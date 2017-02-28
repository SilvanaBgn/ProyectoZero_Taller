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
using System.IO;
using Helper;

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
            //Da inicio a que el bgw corra en segundo plano:
            bgwCargarBD.RunWorkerAsync();

            List<Imagen> listaImagenes = new List<Imagen>();

            listaImagenes.AddRange(new List<Imagen>
            {
                new Imagen() { Bytes = ConversorImagen.ImageToByte(Properties.Resources.arboles)},
                new Imagen() { Bytes = ConversorImagen.ImageToByte(Properties.Resources.peces)},
                new Imagen() { Bytes = ConversorImagen.ImageToByte(Properties.Resources.frutos_rojos)},
                new Imagen() { Bytes = ConversorImagen.ImageToByte(Properties.Resources.ave)},
                new Imagen() { Bytes = ConversorImagen.ImageToByte(Properties.Resources.flores)},
                new Imagen() { Bytes = ConversorImagen.ImageToByte(Properties.Resources.monumento)},
                new Imagen() { Bytes = ConversorImagen.ImageToByte(Properties.Resources.melones)}
            });

            this.campaniaDeslizante1.Start(listaImagenes,1);
        }
        
        /// <summary>
        /// Evento Do_Work del bgwCargarBD, que comprueba cuándo estará lista la VPantallaPrincipal para ser
        /// mostrada
        /// </summary>
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
        private void bgwCargarBD_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //Se muestra la pantalla VPrincipal:
            this.Hide();
            ((VPrincipal)this.Owner).Show();

        }
    }
}
