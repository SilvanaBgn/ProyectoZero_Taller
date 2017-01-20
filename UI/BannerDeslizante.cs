using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public class BannerDeslizante : TextBox
    {
    //VARIABLES       
        /// <summary>
        /// Timer para mover las letras en el TextBox
        /// </summary>
        private Timer iTimerTexto;

        /// <summary>
        /// Indica cuál es el primer caracter a mostrar
        /// </summary>
        private int iCaracterInicial;

        /// <summary>
        /// Contiene el texto completo a mostrar
        /// </summary>
        [DefaultValue("")]
        private string iTexto;
        
               
    //CONSTRUCTOR
        public BannerDeslizante()
        {
            this.iCaracterInicial = 0;
            this.iTimerTexto = new Timer();
            this.iTimerTexto.Interval = 250;
            this.iTimerTexto.Tick += new EventHandler(timerTexto_Tick);
        }


#region FUNCIONES PRIVADAS
        /// <summary>
        /// Evento Tick del this.iTimerTexto, que indica qué hacer cada un tick
        /// </summary>
        private void timerTexto_Tick(object sender, EventArgs e)
        {
            //Si el texto a mostrar (iTexto) "entra" en el TextBox:
            if (this.iTexto.Length <= this.Width)
            {
                this.Text = this.iTexto; 
                this.iTexto = this.CorrerCaracterIzquierda(this.iTexto); 
            }
            else //Si no entra completo, hacemos el cálculo de qué porción de este Texto debe ser mostrado
            {
                int limite = this.iTexto.Length - (this.iCaracterInicial + this.Width);
                string valor = null;

                if (limite >= 0)
                    valor = this.iTexto.Substring(this.iCaracterInicial, this.Width);
                else
                {
                    valor = string.Concat(this.iTexto.Substring(this.iCaracterInicial),
                        this.iTexto.Substring(0, Math.Abs(limite)));
                }
                iCaracterInicial++;

                if (iCaracterInicial == this.iTexto.Length)
                    iCaracterInicial = 0;

                this.Text = valor;
            }
        }

        /// <summary>
        /// Corre todo el texto, un caracter a la izquierda
        /// </summary>
        /// <param name="pTexto">Texto a correr a la izquierda</param>
        /// <returns>Devuelve el texto corrido</returns>
        private string CorrerCaracterIzquierda(string pTexto)
        {
            string textoNuevo = "";

            for (int i = 0; i < pTexto.Length - 1; i++)
                textoNuevo = textoNuevo + pTexto[i + 1];

            return textoNuevo;
        }
        #endregion

#region FUNCIONES PÚBLICAS
        /// <summary>
        /// Da comienzo al banner deslizante
        /// </summary>
        public void Start() { this.Start("");}
        /// <summary>
        /// Da comienzo al banner deslizante
        /// </summary>
        /// <param name="pTexto">Texto a mostrar en el banner</param>
        public void Start(string pTexto)
        {
            this.iTexto = pTexto;
            
            while (iTexto.Length < this.Width) //Si la longitud del texto es menor al tamaño del control bannerDeslizante
                iTexto += "     " + iTexto; //Se repite el texto varias veces para completar el tamaño total

            this.iTimerTexto.Start();//Se da comienzo al deslizamiento del banner
        }

        /// <summary>
        /// Detiene el funcionamiento del banner deslizante
        /// </summary>
        public void Stop()
        {
            if (this.iTimerTexto.Enabled)
                this.iTimerTexto.Stop(); //Se da fin al deslizamiento del banner
        }
        #endregion

#region PROPERTIES
        /// <summary>
        /// Property que permite obtener el valor del texto del banner
        /// </summary>
        public string TextoCompleto { get { return this.iTexto; } }
        #endregion
    }
}