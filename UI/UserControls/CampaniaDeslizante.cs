using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Dominio;
using Helper;

namespace UI.UserControls
{
    public class CampaniaDeslizante : PictureBox
    {
    //VARIABLES
        /// <summary>
        /// Timer para cambiar las imágenes en el PictureBox
        /// </summary>
        private Timer iTimerImagenes;
        /// <summary>
        /// Variables para controles internos del funcionamiento del timer
        /// </summary>
        private int iIndice, iCount;

        private Image iSinImagen;

        /// <summary>
        /// Indica si la campaña deslizante está actualmente en funcionamiento
        /// </summary>
        private bool iFuncionando;
        public bool Funcionando
        {
            get { return this.iFuncionando; }
        }

        /// <summary>
        /// Lista de las imágenes a pasar ordenadas
        /// </summary>
        private List<Imagen> iListaImagenesOrdenada;
        

    //CONSTRUCTOR
        public CampaniaDeslizante()
        {
            this.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iTimerImagenes = new Timer();
            this.iTimerImagenes.Tick += new EventHandler(timerImagen_Tick);

            this.iIndice = this.iCount = 0;
            this.iListaImagenesOrdenada = new List<Imagen>();
            this.iFuncionando = false;

            //this.Image=this.iSinImagen= global::UI.Properties.Resources.Sin_imagen;
        }

        /// <summary>
        /// Evento Tick del this.iTimerImagenes, que indica qué hacer cada un tick
        /// </summary>
        public void timerImagen_Tick(object sender, EventArgs e)
        {
            if (this.iCount < 1)
                this.iCount++;
            else
            {
                this.iIndice++;
                if (this.iIndice <= this.iListaImagenesOrdenada.Count - 1)
                {
                    this.Image = ConversorImagen.ByteToImage(this.iListaImagenesOrdenada[this.iIndice].Bytes);
                    this.iCount = 0;
                }
                else
                    this.iIndice = -1;
            }
        }


        /// <summary>
        /// Sólo se utiliza el pictureBox de la campaña deslizante
        /// </summary>
        /// <param name="pImagen">Imagen en formato Bitmap, que se desea mostrar</param>
        public void Start(byte[] pImagen)
        {
            this.Image = ConversorImagen.ByteToImage(pImagen);
        }
        /// <summary>
        /// Da comienzo a la campania deslizante
        /// </summary>
        /// <param name="pDuracion">Duracion en segundos de cada imagen</param>
        /// <param name="pLista">Lista de imágenes a pasar en la campaña</param>
        public void Start(List<Imagen> pLista, int pDuracion)
        {
            if (pLista != null)
            {
                if (pDuracion* 1000 > 0)
                    this.iTimerImagenes.Interval = pDuracion * 1000/2; //duración en segundos
                else
                    this.iTimerImagenes.Interval = 1000/2; //1 segundo

                //Ordenamos la lista de imágenes según el orden que tienen guardado:
                this.iListaImagenesOrdenada = pLista.OrderBy(x => x.Orden).ToList();

                this.iTimerImagenes.Start();//Se da comienzo al deslizamiento de la campaña
                this.iFuncionando = true;
            }
        }

        /// <summary>
        /// Detiene el funcionamiento de la campaña deslizante
        /// </summary>
        public void Stop()
        {
            if (this.iTimerImagenes.Enabled)
            {
                this.iTimerImagenes.Stop(); //Se da fin al deslizamiento de la campaña
                this.iFuncionando = false;
                this.Image = this.iSinImagen;
            }
        }
    }
}