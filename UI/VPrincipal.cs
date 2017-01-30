using System;
using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Dominio;
using Contenedor;
using System.Timers;
using System.Transactions;
using UI.NuevasPantallas;

namespace UI
{
    public partial class VPrincipal : Form
    {
        private ControladorDominio iControladorDominio;
        private ControladorContenedor iControladorContenedor;
        private System.Timers.Timer iTimerBanner;
        private System.Timers.Timer iTimerCampania;
        

        public VPrincipal()
        {
            InitializeComponent();
            this.iControladorContenedor = new ControladorContenedor();
            this.iControladorDominio = new ControladorDominio(Resolucionador<IUnitOfWork>.Resolver());
            //this.InicializacionTimers();
        }

//#region TIMERS
//        private void InicializacionTimers()
//        {
//            using (var tran = new TransactionScope())
//            {
//                this.iTimerBanner = new System.Timers.Timer();
//            this.iTimerBanner.AutoReset = false;
//            this.iTimerBanner.Elapsed += new ElapsedEventHandler(timerBanner_Elapsed);
//            this.iTimerBanner.Interval = 1;
//            this.iTimerBanner.Enabled = true;

//                //this.iTimerCampania = new System.Timers.Timer();
//                //this.iTimerCampania.AutoReset = false;
//                //this.iTimerCampania.Elapsed += new ElapsedEventHandler(timerCampania_Elapsed);
//                //this.iTimerCampania.Interval = 1;
//                //this.iTimerCampania.Enabled = true;
//                tran.Complete();
//            }
//        }

//        private void FinalizacionTimers()
//        {
//            this.iTimerBanner.Stop();
//            this.iTimerBanner.Dispose();
//            this.BannerDeslizanteStop();

//            //this.iTimerCampania.Stop();
//            //this.iTimerCampania.Dispose();
//            //this.campaniaDeslizanteStop();
//        }

//        /// <summary> 
//        /// Evento que ejecuta el this.iTimerBanner para ir cambiando los BannersDeslizantes
//        /// </summary>
//        private void timerBanner_Elapsed(Object source, ElapsedEventArgs e)
//        {
            
//                ////Detenemos el timer
//                //double intervalo;
//                //this.iTimerBanner.Stop();
//                //this.BannerDeslizanteStop();
//                //string texto = "";
//                //DateTime fechaActual = DateTime.Now;
//                //TimeSpan horaActual = new TimeSpan(fechaActual.Hour, fechaActual.Minute, fechaActual.Second);

//                ////Buscamos el próximo banner a pasar:

//                //// que fechaActual sea mayor o igual a FechaInicio y menor o igual a FechaFin --> FechaInicio<=fechaActual<=FechaFin
//                ////HoraInicio <= horaActual < HoraFin
//                ////Debería devolver un solo banner
//                //List<Banner> posiblesBanners = this.iControladorDominio.BuscarBannerPorAtributo

//                //     (x => x.FechaInicio.CompareTo(fechaActual) <= 0 && x.FechaFin.CompareTo(fechaActual) >= 0
//                //          && x.HoraInicio.CompareTo(horaActual) <= 0 && x.HoraFin.CompareTo(horaActual) > 0
//                //     );
//                ////List<Banner> todosLosBanners = this.iControladorDominio.ObtenerTodosLosBanners();
//                ////List<Banner> posiblesBanners = todosLosBanners.Where

//                ////     (x => x.FechaInicio.CompareTo(fechaActual) <= 0 && x.FechaFin.CompareTo(fechaActual) >= 0
//                ////          && x.HoraInicio.CompareTo(horaActual) <= 0 && x.HoraFin.CompareTo(horaActual) > 0
//                ////     ).ToList();

//                //if (posiblesBanners.Count != 0) //Encontró un elemento
//                //{
//                //    Banner bannerAPasar = posiblesBanners[0];

//                //    //Cambia el intervalo al tiempo del nuevo banner a pasar:
//                //    intervalo = bannerAPasar.HoraFin.Subtract(horaActual).TotalMilliseconds;

//                //    //ASIGNACION DEL BANNER A LA VENTANA PARA QUE SE PASE SOLO:
//                //    texto = bannerAPasar.Descripcion;
//                //    texto += ": ";
//                //    List<string> listaInformacion = bannerAPasar.Leer().ToList();
//                //    for (int i = 0; i < listaInformacion.Count; i++)
//                //    {
//                //        texto += listaInformacion[i] + " | ";
//                //    }
//                //}
//                //else //No encontró nigun banner, no pasa nada, y espera 15 minutos hasta el proximo banner
//                //    intervalo = IntervaloAlProxCuartoDeHora(horaActual);

//                ////Comienza el conteo para el próximo banner
//                //this.iTimerBanner.Interval = intervalo;
//                //while (texto.Length < this.bannerDeslizante.CaracteresAMostrar)
//                //{
//                //    texto += "     " + texto;
//                //}
//                //this.BannerDeslizanteSetTexto(texto);
//                //this.BannerDeslizanteStart();
                
//        }

//        /// <summary> 
//        /// Evento que ejecuta el this.iTimerCampania para ir cambiando las CampaniasDeslizantes
//        /// </summary>
//        private void timerCampania_Elapsed(object sender, EventArgs e)
//        {
//            //Detenemos el timer
//            double intervalo;
//            //int intervaloImagen = 1000;
//            string texto = string.Empty;
//            this.iTimerCampania.Stop();
//            this.campaniaDeslizanteStop();

//            DateTime fechaActual = DateTime.Now;
//            TimeSpan horaActual = new TimeSpan(fechaActual.Hour, fechaActual.Minute, fechaActual.Second);

//            //Buscamos la próxima campaña a pasar:

//            // que fechaActual sea mayor o igual a FechaInicio y menor o igual a FechaFin --> FechaInicio<=fechaActual<=FechaFin
//            //HoraInicio <= horaActual < HoraFin
//            //Debería devolver una sola campaña
//            List<Campania> posiblesCampanias = this.iControladorDominio.BuscarCampaniaPorAtributo

//                 (x => x.FechaInicio.CompareTo(fechaActual) <= 0 && x.FechaFin.CompareTo(fechaActual) >= 0
//                      && x.HoraInicio.CompareTo(horaActual) <= 0 && x.HoraFin.CompareTo(horaActual) > 0
//                 );

//            if (posiblesCampanias.Count != 0) //Encontró un elemento
//            {
//                Campania campaniaAPasar = posiblesCampanias[0];

//                //Cambia el intervalo al tiempo de la nueva campaña a pasar:
//                intervalo = campaniaAPasar.HoraFin.Subtract(horaActual).TotalMilliseconds;

//                //ASIGNACION DEL CAMPAÑA A LA VENTANA PARA QUE SE PASE SOLA:
//                texto = campaniaAPasar.Titulo + ": " + campaniaAPasar.Descripcion;
//                //this.iListaOrdenada = campaniaAPasar.Imagenes.OrderBy(x => x.Orden).ToList();
//                //intervaloImagen = campaniaAPasar.DuracionImagen * 1000;
//                //this.CampaniaDeslizanteSetIntervalo(Convert.ToString(campaniaAPasar.DuracionImagen * 1000));
//                this.campaniaDeslizanteSetCampania(campaniaAPasar);
//                this.LabelCampaniaSetTexto(texto);

//                this.campaniaDeslizanteStart();
//            }
//            else //No encontró niguna campaña, no pasa nada, y espera 15 minutos hasta la proxima campaña
//                intervalo = IntervaloAlProxCuartoDeHora(horaActual);

//            //Comienza el conteo para la proxima campaña
//            this.iTimerCampania.Interval = intervalo;
//        }


//        /// <summary>
//        /// Calcula cuántos milisegundos faltan al próximo cuarto de hora
//        /// </summary>
//        /// <param name="pHoraActual">Hora de tipo TimeSpan a partir de la que se quiere calcular el próximo cuarto de hora</param>
//        /// <returns>Devuelve un double que representa los milisegundos al próximo cuarto de hora</returns>
//        private double IntervaloAlProxCuartoDeHora(TimeSpan pHoraActual)
//        {
//            int segundos = 60 - pHoraActual.Seconds;
//            int minutos;
//            int hora = pHoraActual.Hours;
//            if (pHoraActual.Minutes >= 0 && pHoraActual.Minutes < 15)
//                minutos = 15;
//            else if (pHoraActual.Minutes >= 15 && pHoraActual.Minutes < 30)
//                minutos = 30;
//            else if (pHoraActual.Minutes >= 30 && pHoraActual.Minutes < 45)
//                minutos = 45;
//            else //(horaActual.Minutes >= 45 && horaActual.Minutes < 60)
//            {
//                minutos = 0;
//                hora++;
//            }
//            return (new TimeSpan(hora, minutos, segundos)).Subtract(pHoraActual).TotalMilliseconds;
//        }



//        #region Delegaciones BannerDeslizante, CampaniaDeslizante y Label
//        delegate void SetTextCallback(string texto);

//        private void BannerDeslizanteSetTexto(string texto)
//        {
//            // InvokeRequired required compares the thread ID of the
//            // calling thread to the thread ID of the creating thread.
//            // If these threads are different, it returns true.
//            if (this.bannerDeslizante.InvokeRequired)
//            {
//                SetTextCallback d = new SetTextCallback(BannerDeslizanteSetTexto);
//                this.Invoke(d, new object[] { texto });
//            }
//            else
//            {
//                this.bannerDeslizante.TextoCompleto = texto;
//            }
//        }

//        delegate void Start();
//        private void BannerDeslizanteStart()
//        {
//            // InvokeRequired required compares the thread ID of the
//            // calling thread to the thread ID of the creating thread.
//            // If these threads are different, it returns true.
//            if (this.bannerDeslizante.InvokeRequired)
//            {
//                Start d = new Start(BannerDeslizanteStart);
//                this.Invoke(d, new object[] { });
//            }
//            else
//            {
//                this.bannerDeslizante.Start();
//            }
//        }

//        delegate void Stop();
//        private void BannerDeslizanteStop()
//        {
//            // InvokeRequired required compares the thread ID of the
//            // calling thread to the thread ID of the creating thread.
//            // If these threads are different, it returns true.
//            if (this.bannerDeslizante.InvokeRequired)
//            {
//                Start d = new Start(BannerDeslizanteStop);
//                this.Invoke(d, new object[] { });
//            }
//            else
//            {
//                this.bannerDeslizante.Stop();
//            }
//        }

//        private void LabelCampaniaSetTexto(string texto)
//        {
//            // InvokeRequired required compares the thread ID of the
//            // calling thread to the thread ID of the creating thread.
//            // If these threads are different, it returns true.
//            if (this.label5.InvokeRequired)
//            {
//                SetTextCallback d = new SetTextCallback(LabelCampaniaSetTexto);
//                this.Invoke(d, new object[] { texto });
//            }
//            else
//            {
//                this.label5.Text = texto;
//            }
//        }

//        //delegate void SetPropertyCallback(Campania pCampania);

//        delegate void SetCampania(Campania pCampania);
//        private void campaniaDeslizanteSetCampania(Campania pCampania)
//        {
//            // InvokeRequired required compares the thread ID of the
//            // calling thread to the thread ID of the creating thread.
//            // If these threads are different, it returns true.
//            if (this.campaniaDeslizante.InvokeRequired)
//            {
//                SetCampania d = new SetCampania(campaniaDeslizanteSetCampania);
//                this.Invoke(d, new object[] { pCampania });
//            }
//            else
//            {
//                this.campaniaDeslizante.Campania = pCampania;
//            }
//        }

//        private void campaniaDeslizanteStop()
//        {
//            // InvokeRequired required compares the thread ID of the
//            // calling thread to the thread ID of the creating thread.
//            // If these threads are different, it returns true.
//            if (this.campaniaDeslizante.InvokeRequired)
//            {
//                Stop d = new Stop(campaniaDeslizanteStop);
//                this.Invoke(d, new object[] { });
//            }
//            else
//            {
//                this.campaniaDeslizante.Stop();
//            }
//        }

//        private void campaniaDeslizanteStart()
//        {
//            // InvokeRequired required compares the thread ID of the
//            // calling thread to the thread ID of the creating thread.
//            // If these threads are different, it returns true.
//            if (this.campaniaDeslizante.InvokeRequired)
//            {
//                Start d = new Start(campaniaDeslizanteStart);
//                this.Invoke(d, new object[] { });
//            }
//            else
//            {
//                this.campaniaDeslizante.Start();
//            }
//        }

//        #endregion

//        #endregion

        #region EVENTOS

        #region ToolStripMenuItem
        private void bannerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VBaseBanner vBanner = new VBaseBanner(ref this.iControladorDominio, ref this.iControladorContenedor);
            vBanner.Show();
        }

        private void campaniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VCampania vCampania = new VCampania(ref this.iControladorDominio);
            vCampania.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void verPantallaCompletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.menuStrip1.Visible = false;

            //AGRANDAR EL TAMAÑO DE LOS OBJETOS DE VPrincipal
        }
        #endregion

        #region Otros del Form
        private void VPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.FinalizacionTimers();
        }

        private void VPrincipal_Activated(object sender, EventArgs e)
        {
            //this.FinalizacionTimers();
            //this.InicializacionTimers();
        }

        private void VPrincipal_Resize(object sender, EventArgs e)
        {
            if  (this.WindowState == FormWindowState.Normal)
            {
                this.menuStrip1.Visible = true;
                this.groupBoxCampania.Location = new System.Drawing.Point(this.groupBoxCampania.Location.X - 30, this.groupBoxCampania.Location.Y);
                this.groupBoxBanner.Location = new System.Drawing.Point(this.groupBoxBanner.Location.X-30, this.groupBoxBanner.Location.Y - 30);
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.groupBoxCampania.Location = new System.Drawing.Point(this.groupBoxCampania.Location.X + 30, this.groupBoxCampania.Location.Y);
                this.groupBoxBanner.Location = new System.Drawing.Point(this.groupBoxBanner.Location.X+30, this.groupBoxBanner.Location.Y + 30);
            }
        }
        #endregion
        #endregion

    }
}
