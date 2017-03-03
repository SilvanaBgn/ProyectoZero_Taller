using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Excepciones.ExcepcionesPantalla;
using Excepciones.ExcepcionesDominio;

namespace UI.HelperUI
{
    /// <summary>
    /// Clase que pone a disposición los métodos para hacer la actualización de la Pantalla publicitaria
    /// </summary>
    public class InfoActualPantallaPublicitaria
    {
        private ControladorDominio iControladorDominio;

        public InfoActualPantallaPublicitaria(ref ControladorDominio pControlador)
        {
            this.iControladorDominio = pControlador;
        }

        /// <summary>
        /// Calcula cuántos milisegundos faltan al próximo cuarto de hora
        /// </summary>
        /// <param name="horaActual">Hora de tipo TimeSpan a partir de la que se quiere calcular el próximo cuarto de hora</param>
        /// <returns>Devuelve un int que representa los milisegundos al próximo cuarto de hora</returns>
        public int IntervaloAlProxCuartoDeHora(TimeSpan pHoraActual)
        {
            int segundos = 60 - pHoraActual.Seconds;
            int minutos;
            int hora = pHoraActual.Hours;
            if (pHoraActual.Minutes >= 0 && pHoraActual.Minutes < 15)
                minutos = 15;
            else if (pHoraActual.Minutes >= 15 && pHoraActual.Minutes < 30)
                minutos = 30;
            else if (pHoraActual.Minutes >= 30 && pHoraActual.Minutes < 45)
                minutos = 45;
            else //(horaActual.Minutes >= 45 && horaActual.Minutes < 60)
            {
                minutos = 0;
                hora++;
            }
            return Convert.ToInt32(Math.Truncate((new TimeSpan(hora, minutos, segundos)).Subtract(pHoraActual).TotalMilliseconds));
        }


        #region Lectura Banner
        /// <summary>
        /// Busca cuál es el próximo banner a pasar en el siguiente cuarto de hora
        /// </summary>
        /// <returns>Devuelve el banner a pasar en el siguiente cuarto de hora, sino devuelve null</returns>
        public Banner ProximoBannerAPasar(DateTime pFechaActual, TimeSpan pHoraActual)
        {
            //Buscamos el próximo banner a pasar:
            // que pFechaActual sea mayor o igual a FechaInicio y menor o igual a FechaFin --> FechaInicio<=pFechaActual<=FechaFin
            //HoraInicio <= pHoraActual < HoraFin
            //Debería devolver un solo banner
            try
            {
                List<Banner> posiblesBanners = this.iControladorDominio.BuscarBannerPorAtributo
                     (x => x.FechaInicio.CompareTo(pFechaActual) <= 0 && x.FechaFin.CompareTo(pFechaActual) >= 0
                          && x.HoraInicio.CompareTo(pHoraActual) <= 0 && x.HoraFin.CompareTo(pHoraActual) > 0
                     );

                if (posiblesBanners.Count > 0) //Si encontró algún banner para el próximo cuarto de hora
                    return posiblesBanners[0]; //Tomamos el primer banner que encontró
                else
                    return null;
            }
            catch (ExcepcionAlObtenerBanners ex)
            { throw new ExcepcionAlObtenerBanners(ex.Message, ex); }
        }

        /// <summary>
        /// Concatena todos los items de un banner en un string seprando cada uno por un punto
        /// </summary>
        /// <param name="pBanner">banner a dar formato</param>
        /// <returns>devuelve un string con los items del banner concatenados</returns>
        private string FormatearTextoBanner(Banner pBanner)
        {
            string texto = "";
            try
            {
                FuenteInformacion fuenteDelBanner = this.iControladorDominio.BuscarFuentePorId(pBanner.FuenteId);
                //Asignamos su contenido a la variable texto:
                IList<ItemFuenteInformacion> listaItems = (List<ItemFuenteInformacion>)fuenteDelBanner.Items;
                for (int i = 0; i < listaItems.Count; i++)
                {
                    texto += listaItems[i].ToString() + " • ";
                }
            }
            catch (Exception) { } //Si tira algún error, devolverá un *texto* vacío:
            return texto;
        }

        /// <summary>
        /// Invocar al método Leer() de la fuente del banner, para que actualice sus items
        /// </summary>
        /// <param name="pBanner">Banner a leer</param>
        public void LeerBanner(Banner pBanner)
        {
            try
            {
                FuenteInformacion fuenteDelBanner = this.iControladorDominio.BuscarFuentePorId(pBanner.FuenteId);
                this.LeerFuente(fuenteDelBanner);
            }
            catch (ExcepcionAlLeerFuenteExternaDelBanner ex)
            {
                throw new ExcepcionAlLeerFuenteExternaDelBanner(ex.Message, ex);
            }
        }

        /// <summary>
        /// Invocar al método Leer() de la fuente, para que actualice sus items
        /// </summary>
        /// <param name="pFuente">Fuente a leer</param>
        public void LeerFuente(FuenteInformacion pFuente)
        {
            try
            {
                pFuente.Leer(); //Actualiza los items de la fuente del banner

                //Guardamos los cambios:
                this.iControladorDominio.ModificarFuente(pFuente);
                this.iControladorDominio.GuardarCambios();
            }

            catch (ExcepcionErrorDeLectura ex)
            {
                throw new ExcepcionAlLeerFuenteExternaDelBanner(ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new ExcepcionAlLeerFuenteExternaDelBanner("No se pudo completar la lectura", ex);
            }
        }

        /// <summary>
        /// Averigua el texto del banner indicado
        /// </summary>
        /// <returns>Devuelve un string, con el texto del pBanner. Si el banner es null, devuelve un texto por defecto</returns>
        public string InfoBanner(Banner pBanner)
        {
            //*texto* con valor por defecto:
            string texto = "EASY NEWS. El lugar para su espacio publicitario. Publicite aquí.";

            if (pBanner != null)
            {
                if (FormatearTextoBanner(pBanner) != "") //*texto* con el valor del pBanner
                    texto = FormatearTextoBanner(pBanner);
            }
            return texto;
        }

        #endregion

        #region Lectura Campania
        /// <summary>
        /// Busca cuál es la próximo campania a pasar en el siguiente cuarto de hora
        /// </summary>
        /// <returns>Devuelve la campania a pasar en el siguiente cuarto de hora, sino devuelve null</returns>
        public Campania ProximaCampaniaAPasar(DateTime pFechaActual, TimeSpan pHoraActual)
        {
            //Buscamos la próximo campania a pasar:
            // que pFechaActual sea mayor o igual a FechaInicio y menor o igual a FechaFin --> FechaInicio<=pFechaActual<=FechaFin
            //HoraInicio <= pHoraActual < HoraFin
            //Debería devolver una sola campania
            try
            {
                List<Campania> posiblesCampanias = this.iControladorDominio.BuscarCampaniaPorAtributo
                     (x => x.FechaInicio.CompareTo(pFechaActual) <= 0 && x.FechaFin.CompareTo(pFechaActual) >= 0
                          && x.HoraInicio.CompareTo(pHoraActual) <= 0 && x.HoraFin.CompareTo(pHoraActual) > 0
                     );

                if (posiblesCampanias.Count > 0) //Si encontró alguna campania para el próximo cuarto de hora
                    return posiblesCampanias[0]; //Tomamos la primera campania que encontró
                else
                    return null;
            }
            catch (ExcepcionAlObtenerCampanias ex)
            { throw new ExcepcionAlObtenerCampanias(ex.Message, ex); }
        }

        /// <summary>
        /// Averigua las imágenes y el intervalo de tiempo de la próxima campania a pasar
        /// </summary>
        /// <returns>Devuelve un array, donde el primer argumento es la lista de imágenes y el segundo 
        /// es la duracion. Si no encuentra una campania para pasar en el próximo cuarto de hora, 
        /// devuelve una lista vacía y una duración igual a cero</returns>
        public object[] InfoCampania(Campania pCampaniaAPasar)
        {
            IList<Imagen> listaImagenes = new List<Imagen>();
            int duracion = 0;
            object[] array = new object[3];

            DateTime fechaActual = DateTime.Now;
            TimeSpan horaActual = new TimeSpan(fechaActual.Hour, fechaActual.Minute, fechaActual.Second);

            if (pCampaniaAPasar != null)
            {
                //*imágenes* Lo leemos, de acuerdo a la fuente que corresponde al bannerAPasar:
                listaImagenes = (IList<Imagen>)pCampaniaAPasar.Imagenes;
                duracion = pCampaniaAPasar.DuracionImagen;
            }
            array[0] = listaImagenes;
            array[1] = duracion;
            return array;
        }
        #endregion

    }
}
