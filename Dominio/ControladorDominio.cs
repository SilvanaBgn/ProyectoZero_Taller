using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;


namespace Dominio
{
    public class ControladorDominio
    {
        private IUnitOfWork iUoW;


        #region Generales
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="pUoW"></param>
        public ControladorDominio(IUnitOfWork pUoW)
        {
            this.iUoW = pUoW;
        }

        /// <summary>
        /// Guarda los cambios en la base de datos
        /// </summary>
        public void GuardarCambios()
        {
            this.iUoW.GuardarCambios();
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
        /// Agrega un nuevo banner al respositorio
        /// </summary>
        /// <param name="pBanner">banner a agregar</param>
        public void AgregarBanner(Banner pBanner)
        {
            this.iUoW.RepositorioBanners.Agregar(pBanner);
        }

        /// <summary>
        /// Modifica un banner del respositorio
        /// </summary>
        /// <param name="pBanner">banner a modificar</param>
        public void ModificarBanner(Banner pBanner)
        {
            this.iUoW.RepositorioBanners.Modificar(pBanner);
        }

        /// <summary>
        /// Borra un banner del respositorio
        /// </summary>
        /// <param name="pBanner">banner a borrar</param>
        public void BorrarBanner(Banner pBanner)
        {
            this.iUoW.RepositorioBanners.Borrar(pBanner);
        }

        /// <summary>
        /// Borra un banner del respositorio
        /// </summary>
        /// <param name="pCodigo">código del banner a borrar</param>
        public void BorrarBanner(int pCodigo)
        {
            this.iUoW.RepositorioBanners.Borrar(pCodigo);
        }

        /// <summary>
        /// Busca un banner por ID del banner
        /// </summary>
        /// <param name="pId">ID del banner a buscar</param>
        /// <returns>devuelve un banner de tipo banner</returns>
        public Banner BuscarBannerPorId(int pId)
        {
            return this.iUoW.RepositorioBanners.ObtenerPorId(pId); 
        }

        /// <summary>
        /// Busca un banner por un atributo
        /// </summary>
        /// <param name="filter">filtro de busqueda</param>
        /// <returns>devuelve una lista de banner</returns>
        public List<Banner> BuscarBannerPorAtributo(Expression<Func<Banner, bool>> filter = null)
        {
            return this.iUoW.RepositorioBanners.Obtener(filter,null).ToList();
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

            Expression<Func<Banner, bool>> filtroFechas=null;
            Expression<Func<Banner, bool>> filtroHoras=null;
            Expression<Func<Banner, bool>> filtroTitulo = null;
            Expression<Func<Banner, bool>> filtroDescripcion=null;

            //filtra por fechas
            if (pFiltroFechas!=null)
            {
                fechaInicio = pFiltroFechas[0];
                fechaFin = pFiltroFechas[1];
                filtroFechas = x => x.FechaInicio.CompareTo(fechaInicio) >= 0 && x.FechaFin.CompareTo(fechaFin) <= 0;
            }

            //filtra por horas
            if (pFiltroHoras!=null)
            {
                horaInicio = pFiltroHoras[0];
                horaFin = pFiltroHoras[1];
                filtroHoras = x => x.HoraInicio.CompareTo(horaInicio) >= 0 && x.HoraFin.CompareTo(horaFin) <= 0;
            }

            //filtra por título
            if (pFiltroTitulo!=null)
            {
                filtroTitulo = x => x.Titulo.Contains(pFiltroTitulo);
            }

            //filtra por descripción
            if (pFiltroDescripcion!=null)
            {
                filtroDescripcion = x => x.Descripcion.Contains(pFiltroDescripcion);
            }

            return this.iUoW.RepositorioBanners.Filtrar(filtroFechas, filtroHoras, filtroTitulo, filtroDescripcion).ToList();
        }

        /// <summary>
        /// Obtiene del repositorio todos los banners
        /// </summary>
        /// <returns>devuelve la lista de banners</returns>
        public List<Banner> ObtenerTodosLosBanners()
        {
            return this.iUoW.RepositorioBanners.Obtener(null, null).ToList();
        }

        /// <summary>
        /// Busca cuál es el próximo banner a pasar en el siguiente cuarto de hora
        /// </summary>
        /// <returns>Devuelve el banner a pasar en el siguiente cuarto de hora, sino devuelve null</returns>
        private Banner ProximoBannerAPasar(DateTime pFechaActual)
        {
            TimeSpan horaActual = new TimeSpan(pFechaActual.Hour, pFechaActual.Minute, pFechaActual.Second);
            //Buscamos el próximo banner a pasar:
            // que fechaActual sea mayor o igual a FechaInicio y menor o igual a FechaFin --> FechaInicio<=fechaActual<=FechaFin
            //HoraInicio <= horaActual < HoraFin
            //Debería devolver un solo banner
            List<Banner> posiblesBanners = this.BuscarBannerPorAtributo
                 (x => x.FechaInicio.CompareTo(pFechaActual) <= 0 && x.FechaFin.CompareTo(pFechaActual) >= 0
                      && x.HoraInicio.CompareTo(horaActual) <= 0 && x.HoraFin.CompareTo(horaActual) > 0
                 );

            if (posiblesBanners.Count > 0) //Si encontró algún banner para el próximo cuarto de hora
                return posiblesBanners[0]; //Tomamos el primer banner que encontró
            else
                return null;
        }

        /// <summary>
        /// Obtiene la información que compone al objeto banner
        /// </summary>
        /// <param name="pBanner">un banner</param>
        /// <returns>devuelve un string con la inforación del banner</returns>
        private string InfoLeidaBanner(Banner pBanner)
        {
            string texto = "";
            Fuente fuenteDelBanner = this.BuscarFuentePorId(pBanner.FuenteId);
            texto = pBanner.Descripcion;
            texto += ": ";
            IList<Item> listaItems = (List<Item>)fuenteDelBanner.Leer();
            //Asignamos su contenido a la variable texto:
            for (int i = 0; i < listaItems.Count; i++)
            {
                texto += listaItems[i].ToString() + " • | • ";
            }
            return texto;
        }

        /// <summary>
        /// Calcula cuántos milisegundos faltan al próximo cuarto de hora
        /// </summary>
        /// <param name="pHoraActual">Hora actual de tipo TimeSpan a partir de la que se quiere calcular el próximo cuarto de hora</param>
        /// <returns>Devuelve un double que representa los milisegundos al próximo cuarto de hora</returns>
        private double IntervaloAlProxCuartoDeHora(TimeSpan pHoraActual)
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
            return (new TimeSpan(hora, minutos, segundos)).Subtract(pHoraActual).TotalMilliseconds;
        }

        /// <summary>
        /// Averigua el texto y el intervalo de tiempo del próximo banner a pasar
        /// </summary>
        /// <returns>Devuelve un array, donde el primer argumento es el texto y el segundo es el intervalo
        /// Si no encuentra un banner para pasar en el próximo cuarto de hora, devuelve un texto vacío
        /// y el intervalo con la cantidad de milisegundos hasta el próximo</returns>
        public object[] LeerProximoBanner()
        {
            string texto = "";
            int intervalo = 0;
            object[] array = new object[2];

            DateTime fechaActual = DateTime.Now;
            TimeSpan horaActual = new TimeSpan(fechaActual.Hour, fechaActual.Minute, fechaActual.Second);
            
            //Obtenemos el próximo banner:
            Banner bannerAPasar = this.ProximoBannerAPasar(fechaActual);

            if (bannerAPasar != null)
            {
                //*texto* Lo leemos, de acuerdo a la fuente que corresponde al bannerAPasar:
   //             texto = this.InfoLeidaBanner(bannerAPasar);

                //*intervalo*:
                //Cambia el intervalo al tiempo del nuevo banner a pasar:
                intervalo = Convert.ToInt32(bannerAPasar.HoraFin.Subtract(horaActual).TotalMilliseconds);
            }
            else {
                // *texto es vacío.
                //*intervalo*:
                intervalo = Convert.ToInt32(this.IntervaloAlProxCuartoDeHora(horaActual));
            }
            array[0] = texto;
            array[1] = intervalo;
            return array;
        }

        /// <summary>
        /// Busca cuál es la próximo campania a pasar en el siguiente cuarto de hora
        /// </summary>
        /// <returns>Devuelve la campania a pasar en el siguiente cuarto de hora, sino devuelve null</returns>
        private Campania ProximaCampaniaAPasar(DateTime pFechaActual)
        {
            TimeSpan horaActual = new TimeSpan(pFechaActual.Hour, pFechaActual.Minute, pFechaActual.Second);
            //Buscamos la próximo campania a pasar:
            // que fechaActual sea mayor o igual a FechaInicio y menor o igual a FechaFin --> FechaInicio<=fechaActual<=FechaFin
            //HoraInicio <= horaActual < HoraFin
            //Debería devolver una sola campania
            List<Campania> posiblesCampanias = this.BuscarCampaniaPorAtributo
                 (x => x.FechaInicio.CompareTo(pFechaActual) <= 0 && x.FechaFin.CompareTo(pFechaActual) >= 0
                      && x.HoraInicio.CompareTo(horaActual) <= 0 && x.HoraFin.CompareTo(horaActual) > 0
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
        public object[] LeerProximaCampania()
        {
            IList<Imagen> listaImagenes = new List<Imagen>();
            int duracion = 0;
            int intervalo = 0;
            object[] array = new object[3];

            DateTime fechaActual = DateTime.Now;
            TimeSpan horaActual = new TimeSpan(fechaActual.Hour, fechaActual.Minute, fechaActual.Second);

            //Obtenemos el próximo banner:
            Campania campaniaAPasar = this.ProximaCampaniaAPasar(fechaActual);

            if (campaniaAPasar != null)
            {
                //*imágenes* Lo leemos, de acuerdo a la fuente que corresponde al bannerAPasar:
                listaImagenes = (IList<Imagen>)campaniaAPasar.Imagenes;
                duracion = campaniaAPasar.DuracionImagen;
                //*intervalo*:
                //Cambia el intervalo al tiempo del nuevo banner a pasar:
                intervalo = Convert.ToInt32(campaniaAPasar.HoraFin.Subtract(horaActual).TotalMilliseconds);
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

        #region Campania

        /// <summary>
        /// Agrega una nueva campaña al repositorio
        /// </summary>
        /// <param name="pCampania">campaña a agregar</param>
        public void AgregarCampania(Campania pCampania)
        {
            this.iUoW.RepositorioCampanias.Agregar(pCampania);
        }

        /// <summary>
        /// Modifica una campaña del repositorio
        /// </summary>
        /// <param name="pCampania">campaña a modificar</param>
        public void ModificarCampania(Campania pCampania)
        {
            this.iUoW.RepositorioCampanias.Modificar(pCampania);
        }

        /// <summary>
        /// Borra una campaña del repositorio pasándole como parámetro una campaña
        /// </summary>
        /// <param name="pCampania">campaña a borrar</param>
        public void BorrarCampania(Campania pCampania)
        {
            this.iUoW.RepositorioCampanias.Borrar(pCampania);
        }

        /// <summary>
        /// Borra una campaña del repositorio pasándole como parámetro una campaña
        /// </summary>
        /// <param name="pCodigo"></param>
        public void BorrarCampania(int pCodigo)
        {
            this.iUoW.RepositorioCampanias.Borrar(pCodigo);
        }

        /// <summary>
        /// Obtiene todas las campañas del repositorio
        /// </summary>
        /// <returns>devuelve una lista de campañas</returns>
        public List<Campania> ObtenerTodasLasCampanias()
        {
            return iUoW.RepositorioCampanias.Obtener(null,null).ToList(); 
        }

        /// <summary>
        /// Busca una campaña pasandole como parámetro el ID de la campaña
        /// </summary>
        /// <param name="pId">ID de la campaña a buscar</param>
        /// <returns>devuelve la campaña buscada</returns>
        public Campania BuscarCampaniaPorId(int pId)
        {
            return this.iUoW.RepositorioCampanias.ObtenerPorId(pId); 
        }

        /// <summary>
        /// Busca las campañas según el atributo pasados como parámetro
        /// </summary>
        /// <param name="filter">filtro de busqueda para una campaña</param>
        /// <returns>devuelve la lista de campañas buscadas</returns>
        public List<Campania> BuscarCampaniaPorAtributo(Expression<Func<Campania, bool>> filter = null)
        {
            return this.iUoW.RepositorioCampanias.Obtener(filter,null).ToList(); 
        }
        #endregion

        #region FuenteRss
        /// <summary>
        /// Agrega una nueva fuente al repositorio
        /// </summary>
        /// <param name="pFuente">fuente a agregar</param>
        public void AgregarFuente(Fuente pFuente)
        {
            this.iUoW.RepositorioFuentes.Agregar(pFuente);
        }

        /// <summary>
        /// Modifica una fuente del repositorio
        /// </summary>
        /// <param name="pFuente">fuente a agregar</param>
        public void ModificarFuente(Fuente pFuente)
        {
            this.iUoW.RepositorioFuentes.Modificar(pFuente);
        }

        /// <summary>
        /// Borra una fuente del repositorio pasándole como parámetro su código
        /// </summary>
        /// <param name="pCodigo">código de la fuente a borrar</param>
        public void BorrarFuente(int pCodigo)
        {
            this.iUoW.RepositorioFuentes.Borrar(pCodigo);
        }

        /// <summary>
        /// Busca una fuente por el ID de la fuente
        /// </summary>
        /// <param name="pId">ID de la fuente a buscar</param>
        /// <returns>devuelve la fuente buscada</returns>
        public Fuente BuscarFuentePorId(int pId) 
        {
            return this.iUoW.RepositorioFuentes.ObtenerPorId(pId);
        }

        /// <summary>
        /// Busca una fuente según el atributo pasado como parámetro 
        /// </summary>
        /// <param name="filter">filtro de búsqueda para una fuente</param>
        /// <returns>devuelve el listado de fuentes buscadas</returns>
        public List<Fuente> BuscarFuentePorAtributo(Expression<Func<Fuente, bool>> filter = null)
        {
            return this.iUoW.RepositorioFuentes.Obtener(filter,null).ToList();
        }

        /// <summary>
        /// Obtiene todas las fuentes del repositorio
        /// </summary>
        /// <returns>devuelve la lista de las fuentes</returns>
        public List<Fuente> ObtenerTodasLasFuentes()
        {
            return iUoW.RepositorioFuentes.Obtener().ToList();
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

            if (pFiltroTipoFuente!=null)
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
    }
}
