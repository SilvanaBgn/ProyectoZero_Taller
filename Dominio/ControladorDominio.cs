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
        public void AgregarFuente(FuenteInformacion pFuente)
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
        public void ModificarFuente(FuenteInformacion pFuente)
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
        public FuenteInformacion BuscarFuentePorId(int pId)
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
        public List<FuenteInformacion> BuscarFuentePorAtributo(Expression<Func<FuenteInformacion, bool>> pFilter = null)
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
        public List<FuenteInformacion> ObtenerTodasLasFuentes()
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
        public List<FuenteInformacion> FiltrarFuentes(string pFiltroTipoFuente, string pFiltroDescripcion)
        {

            TipoFuente tipoFuente;

            //Se parsea el string que representa el Enum, devuelve el TipoFuente correspondiente
            if (Enum.TryParse(pFiltroTipoFuente, out tipoFuente))
            {
                tipoFuente = (TipoFuente)Enum.Parse(typeof(TipoFuente), pFiltroTipoFuente);
            }


            Expression<Func<FuenteInformacion, bool>> filtroTipoFuente = null;
            Expression<Func<FuenteInformacion, bool>> filtroDescripcion = null;

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
       
        #endregion
    }
}
