using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Excepciones.ExcepcionesPantalla;
using Excepciones.ExcepcionesDominio;
using Excepciones;

namespace Dominio
{
    public class ControladorDominio
    {
        private IUnitOfWork iUoW;


        #region Generales
        // CONSTRUCTOR
        public ControladorDominio(IUnitOfWork pUoW)
        {
            this.iUoW = pUoW;
        }

        /// <summary>
        /// Guarda los cambios en la base de datos
        /// </summary>
        public void GuardarCambios()
        {
            try
            {
                this.iUoW.GuardarCambios();
            }
            catch (ExcepcionAlGuardarCambios ex)
            {
                throw new ExcepcionAlGuardarCambios(ex.Message, ex);
            }
        }

        /// <summary>
        /// Cancela los cambios del respositorio
        /// </summary>
        public void CancelarCambios()
        {
            this.iUoW.Rollback();
        }
        #endregion


        #region Banner
        /// <summary>
        /// Agrega un nuevo banner al repositorio
        /// </summary>
        /// <param name="pBanner">banner a agregar</param>
        public void AgregarBanner(Banner pBanner)
        {
            if (pBanner.Titulo == "")
            {
                throw new ExcepcionCamposSinCompletar("Se debe agregar un título.");
            }
            else
            {
                try
                {
                    this.iUoW.RepositorioBanners.Agregar(pBanner);
                }
                catch (ExcepcionGeneral ex)
                {
                    throw new ExcepcionAlAgregar("No fue posible agregar el banner.", ex);
                }
            }
        }

        /// <summary>
        /// Modifica un banner del repositorio
        /// </summary>
        /// <param name="pBanner">banner a modificar</param>
        public void ModificarBanner(Banner pBanner)
        {
            if (pBanner.Titulo == "")
            {
                throw new ExcepcionCamposSinCompletar("Se debe agregar un título.");
            }
            else
            {
                try
                {
                    this.iUoW.RepositorioBanners.Modificar(pBanner);
                }
                catch (ExcepcionGeneral ex)
                {
                    throw new ExcepcionAlModificar("No fue posible modificar el banner.", ex);
                }
            }
        }

        /// <summary>
        /// Borra un banner del repositorio
        /// </summary>
        /// <param name="pBanner">banner a borrar</param>
        public void BorrarBanner(Banner pBanner)
        {
            try
            {
                this.iUoW.RepositorioBanners.Borrar(pBanner);
            }
            catch (ExcepcionGeneral ex)
            {
                throw new ExcepcionAlEliminar("No fue posible eliminar el banner.", ex);
            }
        }

        /// <summary>
        /// Borra un banner del repositorio
        /// </summary>
        /// <param name="pCodigo">código del banner a borrar</param>
        public void BorrarBanner(int pCodigo)
        {
            try
            {
                this.iUoW.RepositorioBanners.Borrar(pCodigo);
            }
            catch (ExcepcionGeneral ex)
            {
                throw new ExcepcionAlEliminar("No fue posible eliminar el banner.", ex);
            }
        }

        /// <summary>
        /// Busca un banner por ID del banner
        /// </summary>
        /// <param name="pId">ID del banner a buscar</param>
        /// <returns>devuelve un banner de tipo banner</returns>
        public Banner BuscarBannerPorId(int pId)
        {
            try
            {
                return this.iUoW.RepositorioBanners.ObtenerPorId(pId);
            }
            catch (ExcepcionGeneral ex)
            {
                throw new ExcepcionAlObtenerBanners("No fue posible buscar el banner.", ex);
            }
        }

        /// <summary>
        /// Busca un banner por un atributo
        /// </summary>
        /// <param name="pFilter">filtro de busqueda</param>
        /// <returns>devuelve una lista de banner</returns>
        public List<Banner> BuscarBannerPorAtributo(Expression<Func<Banner, bool>> pFilter = null)
        {
            try
            {
                return this.iUoW.RepositorioBanners.Obtener(pFilter, null).ToList();
            }
            catch (ExcepcionGeneral ex)
            {
                throw new ExcepcionAlObtenerBanners("No fue posible buscar los banners.", ex);
            }
        }

        /// <summary>
        /// Obtiene una lista de banner según los filtros que se le pasen como parámetros
        /// </summary>
        /// <param name="pFiltroFechas">filtro de fechas</param>
        /// <param name="pFiltroHoras">filtro de horas</param>
        /// <param name="pFiltroTitulo">filtro por título</param>
        /// <param name="pFiltroDescripcion">filtro por descripción</param>
        /// <returns>devuelve lista de banners filtrados</returns>
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

            //filtra por fechas
            if (pFiltroFechas != null)
            {
                fechaInicio = pFiltroFechas[0];
                fechaFin = pFiltroFechas[1];
                filtroFechas = x => x.FechaInicio.CompareTo(fechaInicio) >= 0 && x.FechaFin.CompareTo(fechaFin) <= 0;
            }

            //filtra por horas
            if (pFiltroHoras != null)
            {
                horaInicio = pFiltroHoras[0];
                horaFin = pFiltroHoras[1];
                filtroHoras = x => x.HoraInicio.CompareTo(horaInicio) >= 0 && x.HoraFin.CompareTo(horaFin) <= 0;
            }

            //filtra por título
            if (pFiltroTitulo != null)
            {
                filtroTitulo = x => x.Titulo.Contains(pFiltroTitulo);
            }

            //filtra por descripción
            if (pFiltroDescripcion != null)
            {
                filtroDescripcion = x => x.Descripcion.Contains(pFiltroDescripcion);
            }
            try
            {
                return this.iUoW.RepositorioBanners.Filtrar(filtroFechas, filtroHoras, filtroTitulo, filtroDescripcion).ToList();
            }
            catch (ExcepcionGeneral ex)
            {
                throw new ExcepcionAlObtenerBanners("No fue posible filtrar los banners.", ex);
            }
        }

        /// <summary>
        /// Obtiene del repositorio banner todos los banners
        /// </summary>
        /// <returns>devuelve la lista de banners</returns>
        public List<Banner> ObtenerTodosLosBanners()
        {
            try
            {
                return this.iUoW.RepositorioBanners.Obtener(null, null).ToList();
            }
            catch (ExcepcionGeneral ex)
            {
                throw new ExcepcionAlObtenerBanners("No fue posible obtener los banners.", ex);
            }
        }
        #endregion

        #region Campania

        /// <summary>
        /// Agrega una nueva campaña al repositorio
        /// </summary>
        /// <param name="pCampania">campaña a agregar</param>
        public void AgregarCampania(Campania pCampania)
        {
            if (pCampania.Imagenes.Count == 0)
            {
                throw new ExcepcionCamposSinCompletar("Se deben agregar imágenes a la campaña.");
            }
            else if (pCampania.Titulo == "")
            {
                throw new ExcepcionCamposSinCompletar("Se debe agregar un título.");
            }
            else if (pCampania.DuracionImagen == 0)
            {
                throw new ExcepcionCamposSinCompletar("Se debe seleccionar la duración de las imágenes.");
            }
            else
            {
                try
                {
                    this.iUoW.RepositorioCampanias.Agregar(pCampania);
                }
                catch (ExcepcionGeneral ex)
                {
                    throw new ExcepcionAlAgregar("No fue posible agregar la campaña.", ex);
                }
            }
        }

        /// <summary>
        /// Modifica una campaña del repositorio
        /// </summary>
        /// <param name="pCampania">campaña a modificar</param>
        public void ModificarCampania(Campania pCampania)
        {
            if (pCampania.Imagenes.Count == 0)
            {
                throw new ExcepcionCamposSinCompletar("Se deben agregar imágenes a la campaña.");
            }
            else if (pCampania.Titulo == "")
            {
                throw new ExcepcionCamposSinCompletar("Se debe agregar un título.");
            }
            else if (pCampania.DuracionImagen == 0)
            {
                throw new ExcepcionCamposSinCompletar("Se debe seleccionar la duración de las imágenes.");
            }
            else
            {
                try
                {
                    this.iUoW.RepositorioCampanias.Modificar(pCampania);
                }
                catch (ExcepcionGeneral ex)
                {
                    throw new ExcepcionAlModificar("No fue posible modificar la campaña.", ex);
                }
            }
        }

        /// <summary>
        /// Borra una campaña del repositorio pasándole como parámetro una campaña
        /// </summary>
        /// <param name="pCampania">campaña a borrar</param>
        public void BorrarCampania(Campania pCampania)
        {
            try
            {
                this.iUoW.RepositorioCampanias.Borrar(pCampania);
            }
            catch (ExcepcionGeneral ex)
            {
                throw new ExcepcionAlEliminar("No fue posible eliminar la campaña.", ex);
            }
        }

        /// <summary>
        /// Borra una campaña del repositorio pasándole como parámetro el código de una campaña
        /// </summary>
        /// <param name="pCodigo">identificador de la campaña a borrar</param>
        public void BorrarCampania(int pCodigo)
        {
            try
            {
                this.iUoW.RepositorioCampanias.Borrar(pCodigo);
            }
            catch (ExcepcionGeneral ex)
            {
                throw new ExcepcionAlEliminar("No fue posible eliminar la campaña.", ex);
            }
        }

        /// <summary>
        /// Obtiene todas las campañas del repositorio campañas
        /// </summary>
        /// <returns>devuelve una lista de campañas</returns>
        public List<Campania> ObtenerTodasLasCampanias()
        {
            try
            {
                return iUoW.RepositorioCampanias.Obtener(null, null).ToList();
            }
            catch (ExcepcionGeneral ex)
            {
                throw new ExcepcionAlObtenerCampanias("No fue posible obtener las campañas.", ex);
            }
        }

        /// <summary>
        /// Busca una campaña pasandole como parámetro el ID de la campaña
        /// </summary>
        /// <param name="pId">ID de la campaña a buscar</param>
        /// <returns>devuelve la campaña buscada</returns>
        public Campania BuscarCampaniaPorId(int pId)
        {
            try
            {
                return this.iUoW.RepositorioCampanias.ObtenerPorId(pId);
            }
            catch (ExcepcionGeneral ex)
            {
                throw new ExcepcionAlObtenerCampanias("No fue posible buscar la campaña.", ex);
            }
        }

        /// <summary>
        /// Obtiene una lista de campañas según los filtros que se le pasen como parámetros
        /// </summary>
        /// <param name="pFiltroFechas">filtro de fechas</param>
        /// <param name="pFiltroHoras">filtro de horas</param>
        /// <param name="pFiltroTitulo">filtro por título</param>
        /// <param name="pFiltroDescripcion">filtro por descripción</param>
        /// <returns>devuelve lista de campañas filtradas</returns>
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

            //filtra por fechas
            if (pFiltroFechas != null)
            {
                fechaInicio = pFiltroFechas[0];
                fechaFin = pFiltroFechas[1];
                filtroFechas = x => x.FechaInicio.CompareTo(fechaInicio) >= 0 && x.FechaFin.CompareTo(fechaFin) <= 0;
            }

            //filtra por horas
            if (pFiltroHoras != null)
            {
                horaInicio = pFiltroHoras[0];
                horaFin = pFiltroHoras[1];
                filtroHoras = x => x.HoraInicio.CompareTo(horaInicio) >= 0 && x.HoraFin.CompareTo(horaFin) <= 0;
            }

            //filtra por titulo
            if (pFiltroTitulo != null)
            {
                filtroTitulo = x => x.Titulo.Contains(pFiltroTitulo);
            }

            //filtra por descripcion
            if (pFiltroDescripcion != null)
            {
                filtroDescripcion = x => x.Descripcion.Contains(pFiltroDescripcion);
            }

            try
            {
                return this.iUoW.RepositorioCampanias.Filtrar(filtroFechas, filtroHoras, filtroTitulo, filtroDescripcion).ToList();
            }
            catch (ExcepcionGeneral ex)
            {
                throw new ExcepcionAlObtenerCampanias("No fue posible filtrar las campañas.", ex);
            }
        }

        /// <summary>
        /// Busca las campañas según el atributo pasado como parámetro
        /// </summary>
        /// <param name="pFilter">filtro de busqueda para una campaña</param>
        /// <returns>devuelve la lista de campañas buscadas</returns>
        public List<Campania> BuscarCampaniaPorAtributo(Expression<Func<Campania, bool>> pFilter = null)
        {
            try
            {
                return this.iUoW.RepositorioCampanias.Obtener(pFilter, null).ToList();
            }
            catch (ExcepcionGeneral)
            {
                throw new ExcepcionAlObtenerCampanias("No fue posible obtener las campañas.");
            }
        }
        #endregion

        #region FuenteRss
        /// <summary>
        /// Agrega una nueva fuente al repositorio
        /// </summary>
        /// <param name="pFuente">fuente a agregar</param>
        public void AgregarFuente(Fuente pFuente)
        {
            if (pFuente.Tipo == TipoFuente.Rss && pFuente.OrigenItems == "")
            {
                throw new ExcepcionCamposSinCompletar("Se debe establecer el origen de la fuente.");
            }
            else if (pFuente.Tipo == TipoFuente.TextoFijo && pFuente.Items.Count == 0)
            {
                throw new ExcepcionCamposSinCompletar("Se debe establecer el texto a mostrar.");
            }
            else if (pFuente.Descripcion == "")
            {
                throw new ExcepcionCamposSinCompletar("Se debe establecer una descripción de la fuente.");
            }
            else
            {
                try
                {
                    this.iUoW.RepositorioFuentes.Agregar(pFuente);
                }
                catch (ExcepcionGeneral ex)
                {
                    throw new ExcepcionAlAgregar("No fue posible agregar la fuente.", ex);
                }
            }
        }

        /// <summary>
        /// Modifica una fuente del repositorio
        /// </summary>
        /// <param name="pFuente">fuente a agregar</param>
        public void ModificarFuente(Fuente pFuente)
        {

            if (pFuente.Tipo == TipoFuente.Rss && pFuente.OrigenItems == "")
            {
                throw new ExcepcionCamposSinCompletar("Se debe establecer el origen de la fuente.");
            }
            else if (pFuente.Tipo == TipoFuente.TextoFijo && pFuente.Items.Count == 0)
            {
                throw new ExcepcionCamposSinCompletar("Se debe establecer el texto a mostrar.");
            }
            else if (pFuente.Descripcion == "")
            {
                throw new ExcepcionCamposSinCompletar("Se debe establecer una descripción de la fuente.");
            }
            else
            {
                try
                {
                    this.iUoW.RepositorioFuentes.Modificar(pFuente);
                }
                catch (ExcepcionGeneral ex)
                {
                    throw new ExcepcionAlModificar("No fue posible modificar la fuente.", ex);
                }
            }
        }

        /// <summary>
        /// Borra una fuente del repositorio pasándole como parámetro su código
        /// </summary>
        /// <param name="pCodigo">identificador de la fuente a borrar</param>
        public void BorrarFuente(int pCodigo)
        {
            try
            {
                this.iUoW.RepositorioFuentes.Borrar(pCodigo);
            }
            catch (ExcepcionGeneral ex)
            {
                throw new ExcepcionAlEliminar("No fue posible eliminar la fuente.", ex);
            }
        }

        /// <summary>
        /// Busca una fuente por el ID de la fuente
        /// </summary>
        /// <param name="pId">ID de la fuente a buscar</param>
        /// <returns>devuelve la fuente buscada</returns>
        public Fuente BuscarFuentePorId(int pId)
        {
            try
            {
                return this.iUoW.RepositorioFuentes.ObtenerPorId(pId);
            }
            catch (ExcepcionGeneral ex)
            {
                throw new ExcepcionAlObtenerFuentes("No fue posible buscar la fuente.", ex);
            }
        }

        /// <summary>
        /// Busca una fuente según el atributo pasado como parámetro 
        /// </summary>
        /// <param name="pFilter">filtro de búsqueda para una fuente</param>
        /// <returns>devuelve el listado de fuentes buscadas</returns>
        public List<Fuente> BuscarFuentePorAtributo(Expression<Func<Fuente, bool>> pFilter = null)
        {
            try
            {
                return this.iUoW.RepositorioFuentes.Obtener(pFilter, null).ToList();
            }
            catch (ExcepcionGeneral ex)
            {
                throw new ExcepcionAlObtenerFuentes("No fue posible obtener las fuentes.", ex);
            }
        }

        /// <summary>
        /// Obtiene todas las fuentes del repositorio fuentes
        /// </summary>
        /// <returns>devuelve la lista de las fuentes existentes</returns>
        public List<Fuente> ObtenerTodasLasFuentes()
        {
            try
            {
                return iUoW.RepositorioFuentes.Obtener().ToList();
            }
            catch (ExcepcionGeneral ex)
            {
                throw new ExcepcionAlObtenerFuentes("No fue posible obtener las fuentes.", ex);
            }
        }

        /// <summary>
        /// Filtra las fuentes según el tipo de fuente y descripción
        /// </summary>
        /// <param name="pFiltroTipoFuente">tipo de fuente</param>
        /// <param name="pFiltroDescripcion">descripción de la fuente</param>
        /// <returns>devuelve una lista de fuentes filtradas</returns>
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

            //filtra por tipo de fuente
            if (pFiltroTipoFuente != null)
            {
                filtroTipoFuente = x => x.Tipo == tipoFuente;
            }

            //filtra por descripcion
            if (pFiltroDescripcion != null)
            {
                filtroDescripcion = x => x.Descripcion.Contains(pFiltroDescripcion);
            }

            try
            {
                return this.iUoW.RepositorioFuentes.Filtrar(filtroTipoFuente, filtroDescripcion).ToList();
            }
            catch (ExcepcionGeneral ex)
            {
                throw new ExcepcionAlObtenerFuentes("No fue posible filtrar las fuentes.", ex);
            }
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
            try
            {
                List<Banner> posiblesBanners = this.BuscarBannerPorAtributo
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
                Fuente fuenteDelBanner = this.BuscarFuentePorId(pBanner.FuenteId);
                //Asignamos su contenido a la variable texto:
                IList<Item> listaItems = (List<Item>)fuenteDelBanner.Items;
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
                Fuente fuenteDelBanner = this.BuscarFuentePorId(pBanner.FuenteId);
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
        public void LeerFuente(Fuente pFuente)
        {
            try
            {
                pFuente.Leer(); //Actualiza los items de la fuente del banner

                //Guardamos los cambios:
                this.ModificarFuente(pFuente);
                this.GuardarCambios();
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
                List<Campania> posiblesCampanias = this.BuscarCampaniaPorAtributo
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
        #endregion
    }
}
