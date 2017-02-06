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
            return this.iUoW.RepositorioBanners.Obtener(filter,null).ToList(); 
        }

        public List<Banner> ObtenerTodosLosBanners()
        {
            return this.iUoW.RepositorioBanners.Obtener(null, null).ToList();
        }

        /// <summary>
        /// Busca cuál es el próximo banner a pasar en el siguiente cuarto de hora
        /// </summary>
        /// <returns>Devuelve el banner a pasar en el siguiente cuarto de hora, sino devuelve null</returns>
        private Banner ProximoBannerAPasar()
        {
            DateTime fechaActual = DateTime.Now;
            TimeSpan horaActual = new TimeSpan(fechaActual.Hour, fechaActual.Minute, fechaActual.Second);

            //Buscamos el próximo banner a pasar:
                // que fechaActual sea mayor o igual a FechaInicio y menor o igual a FechaFin --> FechaInicio<=fechaActual<=FechaFin
                //HoraInicio <= horaActual < HoraFin
                //Debería devolver un solo banner
                List<Banner> posiblesBanners = this.BuscarBannerPorAtributo
                 (x => x.FechaInicio.CompareTo(fechaActual) <= 0 && x.FechaFin.CompareTo(fechaActual) >= 0
                      && x.HoraInicio.CompareTo(horaActual) <= 0 && x.HoraFin.CompareTo(horaActual) > 0
                 );

            if (posiblesBanners.Count > 0) //Si encontró algún banner para el próximo cuarto de hora
                return posiblesBanners[0]; //Tomamos el primer banner que encontró
            else
                return null;
        }

        /// <summary>
        /// Busca cuál es la Fuente que corresponde a <paramref name="pBanner"/>
        /// </summary>
        /// <param name="pBanner">Banner del que se quiere conocer la Fuente</param>
        /// <returns>Devuelve la fuente asociada a ese banner</returns>
        private Fuente FuenteDeUnBanner(Banner pBanner)
        {
            return this.BuscarFuentePorId(pBanner.FuenteId);
        }

        /// <summary>
        /// Averigua qué texto contiene el banner a pasar en el próximo cuarto de hora
        /// </summary>
        /// <returns>Devuelve un string con el texto a pasar</returns>
        public string LeerProximoBanner()
        {
            string texto = "";
            //Obtenemos el próximo banner:
            Banner bannerAPasar = this.ProximoBannerAPasar();
            if (bannerAPasar != null)
            {
                //Lo leemos:
                Fuente fuenteDelBanner = this.FuenteDeUnBanner(bannerAPasar);
                texto = bannerAPasar.Descripcion;
                texto += ": ";
                IList<Item> listaItems = (List<Item>)fuenteDelBanner.Leer();
                //Asignamos su contenido a la variable texto:
                for (int i = 0; i < listaItems.Count; i++)
                {
                    texto += listaItems[i].ToString() + " • | • ";
                }
            }
            return texto;
        }
        #endregion

        #region Campania

        public void AgregarCampania(Campania pCampania)
        {
            this.iUoW.RepositorioCampanias.Agregar(pCampania);
        }

        public void ModificarCampania(Campania pCampania)
        {
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
            return iUoW.RepositorioCampanias.Obtener(null,null).ToList(); 
        }

        public Campania BuscarCampaniaPorId(int pId)
        {
            return this.iUoW.RepositorioCampanias.ObtenerPorId(pId); 
        }

        public List<Campania> BuscarCampaniaPorAtributo(Expression<Func<Campania, bool>> filter = null)
        {
            return this.iUoW.RepositorioCampanias.Obtener(filter,null).ToList(); 
        }
        #endregion

        #region FuenteRss
        public void AgregarFuente(Fuente pFuente)
        {
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
            return this.iUoW.RepositorioFuentes.Obtener(filter,null).ToList();
        }

        public List<Fuente> ObtenerTodasLasFuentes()
        {
            return iUoW.RepositorioFuentes.Obtener().ToList();
        }
        #endregion
    }
}
