﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Excepciones.ExcepcionesPantalla;

namespace Dominio
{
    public class ControladorDominio
    {
        private IUnitOfWork iUoW;


        #region Generales

        public ControladorDominio(IUnitOfWork pUoW)
        {
            this.iUoW = pUoW;
        }

        public void GuardarCambios()
        {
            this.iUoW.GuardarCambios();
        }

        public void CancelarCambios()
        {
            this.iUoW.Rollback();
        }
        #endregion


        #region Banner
        public void AgregarBanner(Banner pBanner)
        {
            if (pBanner.Titulo == "")
            {
                throw new ExcepcionCamposSinCompletar("Se debe agregar un título");
            }
            //if (pBanner.FuenteId == 0)
            //{
            //throw new ExcepcionCamposSinCompletar("Se debe seleccionar una fuente");
            //}

            this.iUoW.RepositorioBanners.Agregar(pBanner);
        }

        public void ModificarBanner(Banner pBanner)
        {
            this.iUoW.RepositorioBanners.Modificar(pBanner);
        }

        public void BorrarBanner(Banner pBanner)
        {
            this.iUoW.RepositorioBanners.Borrar(pBanner);
        }

        public void BorrarBanner(int pCodigo)
        {
            this.iUoW.RepositorioBanners.Borrar(pCodigo);
        }

        public Banner BuscarBannerPorId(int pId)
        {
            return this.iUoW.RepositorioBanners.ObtenerPorId(pId);
        }

        public List<Banner> BuscarBannerPorAtributo(Expression<Func<Banner, bool>> filter = null)
        {
            try {
                return this.iUoW.RepositorioBanners.Obtener(filter, null).ToList();
            }
            catch(Exception)
            { return null; }
        }

        public List<Banner> FiltrarBanners(
            DateTime[] pFiltroFechas, TimeSpan[] pFiltroHoras, string pFiltroTitulo, string pFiltroDescripcion)
        {
            DateTime fechaInicio;
            DateTime fechaFin;
            TimeSpan horaInicio;
            TimeSpan horaFin;

            Expression<Func<Banner, bool>> filtroFechas = null;
            Expression<Func<Banner, bool>> filtroHoras = null;
            Expression<Func<Banner, bool>> filtroTitulo = null;
            Expression<Func<Banner, bool>> filtroDescripcion = null;

            if (pFiltroFechas != null)
            {
                fechaInicio = pFiltroFechas[0];
                fechaFin = pFiltroFechas[1];
                filtroFechas = x => x.FechaInicio.CompareTo(fechaInicio) >= 0 && x.FechaFin.CompareTo(fechaFin) <= 0;
            }

            if (pFiltroHoras != null)
            {
                horaInicio = pFiltroHoras[0];
                horaFin = pFiltroHoras[1];
                filtroHoras = x => x.HoraInicio.CompareTo(horaInicio) >= 0 && x.HoraFin.CompareTo(horaFin) <= 0;
            }

            if (pFiltroTitulo != null)
            {
                filtroTitulo = x => x.Titulo.Contains(pFiltroTitulo);
            }

            if (pFiltroDescripcion != null)
            {
                filtroDescripcion = x => x.Descripcion.Contains(pFiltroDescripcion);
            }


            return this.iUoW.RepositorioBanners.Filtrar(filtroFechas, filtroHoras, filtroTitulo, filtroDescripcion).ToList();
        }

        public List<Banner> ObtenerTodosLosBanners()
        {
            return this.iUoW.RepositorioBanners.Obtener(null, null).ToList();
        }
        #endregion

        #region Campania

        public void AgregarCampania(Campania pCampania)
        {
            if (pCampania.Imagenes.Count == 0)
            {
                throw new ExcepcionCamposSinCompletar("Se deben agregar imágenes a la campaña");
            }
            if (pCampania.Titulo == "")
            {
                throw new ExcepcionCamposSinCompletar("Se debe agregar un título");
            }
            if (pCampania.DuracionImagen == 0)
            {
                throw new ExcepcionCamposSinCompletar("Se debe seleccionar la duración de las imágenes");
            }

            this.iUoW.RepositorioCampanias.Agregar(pCampania);
        }

        public void ModificarCampania(Campania pCampania)
        {
            if (pCampania.Imagenes.Count == 0)
            {
                throw new ExcepcionCamposSinCompletar("Se deben agregar imágenes a la campaña");
            }
            if (pCampania.Titulo == "")
            {
                throw new ExcepcionCamposSinCompletar("Se debe agregar un título");
            }
            if (pCampania.DuracionImagen == 0)
            {
                throw new ExcepcionCamposSinCompletar("Se debe seleccionar la duración de las imágenes");
            }

            this.iUoW.RepositorioCampanias.Modificar(pCampania);
        }

        public void BorrarCampania(Campania pCampania)
        {
            this.iUoW.RepositorioCampanias.Borrar(pCampania);
        }

        public void BorrarCampania(int pCodigo)
        {
            this.iUoW.RepositorioCampanias.Borrar(pCodigo);
        }

        public List<Campania> ObtenerTodasLasCampanias()
        {
            return iUoW.RepositorioCampanias.Obtener(null, null).ToList();
        }

        public Campania BuscarCampaniaPorId(int pId)
        {
            return this.iUoW.RepositorioCampanias.ObtenerPorId(pId);
        }

        public List<Campania> FiltrarCampanias(DateTime[] pFiltroFechas, TimeSpan[] pFiltroHoras, string pFiltroTitulo, string pFiltroDescripcion)
        {
            DateTime fechaInicio;
            DateTime fechaFin;
            TimeSpan horaInicio;
            TimeSpan horaFin;

            Expression<Func<Campania, bool>> filtroFechas = null;
            Expression<Func<Campania, bool>> filtroHoras = null;
            Expression<Func<Campania, bool>> filtroTitulo = null;
            Expression<Func<Campania, bool>> filtroDescripcion = null;

            if (pFiltroFechas != null)
            {
                fechaInicio = pFiltroFechas[0];
                fechaFin = pFiltroFechas[1];
                filtroFechas = x => x.FechaInicio.CompareTo(fechaInicio) >= 0 && x.FechaFin.CompareTo(fechaFin) <= 0;
            }

            if (pFiltroHoras != null)
            {
                horaInicio = pFiltroHoras[0];
                horaFin = pFiltroHoras[1];
                filtroHoras = x => x.HoraInicio.CompareTo(horaInicio) >= 0 && x.HoraFin.CompareTo(horaFin) <= 0;
            }

            if (pFiltroTitulo != null)
            {
                filtroTitulo = x => x.Titulo.Contains(pFiltroTitulo);
            }

            if (pFiltroDescripcion != null)
            {
                filtroDescripcion = x => x.Descripcion.Contains(pFiltroDescripcion);
            }


            return this.iUoW.RepositorioCampanias.Filtrar(filtroFechas, filtroHoras, filtroTitulo, filtroDescripcion).ToList();
        }

        public List<Campania> BuscarCampaniaPorAtributo(Expression<Func<Campania, bool>> filter = null)
        {
            try {
                return this.iUoW.RepositorioCampanias.Obtener(filter, null).ToList();
            }
            catch(Exception)
            { return null; }
        }
        #endregion

        #region FuenteRss
        public void AgregarFuente(Fuente pFuente)
        {
            if (pFuente.Tipo == TipoFuente.Rss && pFuente.OrigenItems == "")
            {
                throw new ExcepcionCamposSinCompletar("Se debe establecer el origen de la fuente");
            }
            if (pFuente.Tipo == TipoFuente.TextoFijo && pFuente.Items.Count == 0)
            {
                throw new ExcepcionCamposSinCompletar("Se debe establecer el texto a mostrar");
            }
            if (pFuente.Descripcion == "")
            {
                throw new ExcepcionCamposSinCompletar("Se debe establecer una descripción de la fuente");
            }

            this.iUoW.RepositorioFuentes.Agregar(pFuente);

        }

        public void ModificarFuente(Fuente pFuente)
        {
            this.iUoW.RepositorioFuentes.Modificar(pFuente);
        }

        public void BorrarFuente(int pCodigo)
        {
            this.iUoW.RepositorioFuentes.Borrar(pCodigo);
        }

        public Fuente BuscarFuentePorId(int pId)
        {
            return this.iUoW.RepositorioFuentes.ObtenerPorId(pId);
        }

        public List<Fuente> BuscarFuentePorAtributo(Expression<Func<Fuente, bool>> filter = null)
        {
            try {
                return this.iUoW.RepositorioFuentes.Obtener(filter, null).ToList();
            }
            catch(Exception)
            { return null; }
        }

        public List<Fuente> ObtenerTodasLasFuentes()
        {
            return iUoW.RepositorioFuentes.Obtener().ToList();
        }

        public List<Fuente> FiltrarFuentes(string pFiltroTipoFuente, string pFiltroDescripcion)
        {

            TipoFuente tipoFuente;

            //Se parsea el string que representa el Enum, devuelve el TipoFuente correspondiente
            if (Enum.TryParse(pFiltroTipoFuente, out tipoFuente))
            {
                tipoFuente = (TipoFuente)Enum.Parse(typeof(TipoFuente), pFiltroTipoFuente);
            }


            Expression<Func<Fuente, bool>> filtroTipoFuente = null;
            Expression<Func<Fuente, bool>> filtroDescripcion = null;

            if (pFiltroTipoFuente != null)
            {
                filtroTipoFuente = x => x.Tipo == tipoFuente;
            }

            if (pFiltroDescripcion != null)
            {
                filtroDescripcion = x => x.Descripcion.Contains(pFiltroDescripcion);
            }


            return this.iUoW.RepositorioFuentes.Filtrar(filtroTipoFuente, filtroDescripcion).ToList();
        }

        #endregion


        #region LECTURAS
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
            List<Banner> posiblesBanners = this.BuscarBannerPorAtributo
                 (x => x.FechaInicio.CompareTo(pFechaActual) <= 0 && x.FechaFin.CompareTo(pFechaActual) >= 0
                      && x.HoraInicio.CompareTo(pHoraActual) <= 0 && x.HoraFin.CompareTo(pHoraActual) > 0
                 );

            if (posiblesBanners.Count > 0) //Si encontró algún banner para el próximo cuarto de hora
                return posiblesBanners[0]; //Tomamos el primer banner que encontró
            else
                return null;
        }

        private string FormatearTextoBanner(Banner pBanner)
        {
            string texto = "";
            Fuente fuenteDelBanner = this.BuscarFuentePorId(pBanner.FuenteId);
            //Asignamos su contenido a la variable texto:
            IList<Item> listaItems = (List<Item>)fuenteDelBanner.Items;
            for (int i = 0; i < listaItems.Count; i++)
            {
                texto += listaItems[i].ToString() + " • ";
            }
            return texto;
        }

        /// <summary>
        /// Invocar al método Leer() de la fuente del banner, para que actualice sus items
        /// </summary>
        /// <param name="pBanner">Banner a leer</param>
        public void LeerBanner(Banner pBanner)
        {
            Fuente fuenteDelBanner = this.BuscarFuentePorId(pBanner.FuenteId);
            fuenteDelBanner.Leer(); //Actualiza los items de la fuente del banner
            //Guardamos los cambios:
            this.ModificarFuente(this.BuscarFuentePorId(pBanner.FuenteId));
            this.GuardarCambios();
        }

        /// <summary>
        /// Averigua el texto del banner indicado
        /// </summary>
        /// <returns>Devuelve un string, con el texto del pBanner. Si el banner es null, devuelve un texto por defecto</returns>
        public string InfoBanner(Banner pBanner)
        {
            string texto = "";
            if (pBanner != null)
            {
                texto = FormatearTextoBanner(pBanner); //*texto* con el valor del pBanner
                if (texto == "")   //porque la fuente del pBanner no tiene items todavia
                    texto = "EASY NEWS. El lugar para su espacio publicitario. Publicite aquí. Obteniendo Items RSS"; //*texto* con valor por defecto
            }
            else   //Ya sea porque pBanner==null o porque la fuente del pBanner no tiene items todavia
                texto = "EASY NEWS. El lugar para su espacio publicitario. Publicite aquí."; //*texto* con valor por defecto

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
            List<Campania> posiblesCampanias = this.BuscarCampaniaPorAtributo
                 (x => x.FechaInicio.CompareTo(pFechaActual) <= 0 && x.FechaFin.CompareTo(pFechaActual) >= 0
                      && x.HoraInicio.CompareTo(pHoraActual) <= 0 && x.HoraFin.CompareTo(pHoraActual) > 0
                 );

            if (posiblesCampanias.Count > 0) //Si encontró alguna campania para el próximo cuarto de hora
                return posiblesCampanias[0]; //Tomamos la primera campania que encontró
            else
                return null;
        }

        /// <summary>
        /// Averigua las imágenes y el intervalo de tiempo de la próxima campania a pasar
        /// </summary>
        /// <returns>Devuelve un array, donde el primer argumento es la lista de imágenes y el segundo 
        /// es la duracion y el tercero es el intervalo. Si no encuentra una campania para pasar en el 
        /// próximo cuarto de hora, devuelve una lista vacía y el intervalo con la cantidad de 
        /// milisegundos hasta el próximo</returns>
        public object[] InfoCampania(Campania pCampaniaAPasar)
        {
            IList<Imagen> listaImagenes = new List<Imagen>();
            int duracion = 0;
            int intervalo = 0;
            object[] array = new object[3];

            DateTime fechaActual = DateTime.Now;
            TimeSpan horaActual = new TimeSpan(fechaActual.Hour, fechaActual.Minute, fechaActual.Second);

            if (pCampaniaAPasar != null)
            {
                //*imágenes* Lo leemos, de acuerdo a la fuente que corresponde al bannerAPasar:
                listaImagenes = (IList<Imagen>)pCampaniaAPasar.Imagenes;
                duracion = pCampaniaAPasar.DuracionImagen;
                //*intervalo*:
                //Cambia el intervalo al tiempo del nuevo banner a pasar:
                intervalo = Convert.ToInt32(pCampaniaAPasar.HoraFin.Subtract(horaActual).TotalMilliseconds);
            }
            else
            {
                // *imágenes* es una lista vacío.
                //*intervalo*:
                intervalo = Convert.ToInt32(this.IntervaloAlProxCuartoDeHora(horaActual));
            }
            array[0] = listaImagenes;
            array[1] = duracion;
            array[2] = intervalo;
            return array;
        }
        #endregion
        #endregion
    }
}
