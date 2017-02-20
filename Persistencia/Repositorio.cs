using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Dominio;

namespace Persistencia
{
    /// <summary>
    /// Implementación de un repositorio genérico
    /// </summary>
    public class Repositorio<T>: IRepositorio<T> where T : class
    {
        protected IDbSet<T> iDbSet;

        private Contexto iContexto;


        public Repositorio(Contexto pContexto)
        {
            this.iContexto = pContexto;
            this.iDbSet = iContexto.Set<T>();
        }

        /// <summary>
        /// Método genérico para buscar entidades en la base de datos
        /// </summary>
        /// <param name="pFilter">filtro de búsqueda</param>
        /// <returns>devuelve una colección de objetos según los filtros de búsqueda</returns>
        public virtual IEnumerable<T> Obtener(Expression<Func<T, bool>> pFilter = null, Func<IQueryable<T>, IOrderedQueryable<T>> pOrderBy = null)
        {
            IQueryable<T> query = this.iDbSet;

            if (pFilter != null)
                query = query.Where(pFilter);

            if (pOrderBy != null)
                return pOrderBy(query).ToList();
            else
                return query.ToList();
        }

        /// <summary>
        /// Método genérico para filtrar entidades según sus fechas, horas, título o descripción
        /// </summary>
        /// <param name="pFiltroFechas">filtro por fechas</param>
        /// <param name="pFiltroHoras">filtro por horas</param>
        /// <param name="pFiltroTitulo">filtro por título</param>
        /// <param name="pFiltroDescripcion">filtro por descripción</param>
        /// <returns>devuelve una colección de objetos según los filtros de búsqueda</returns>
        public virtual IEnumerable<T> Filtrar(Expression<Func<T, bool>> pFiltroFechas,
                                Expression<Func<T, bool>> pFiltroHoras,
                                Expression<Func<T, bool>> pFiltroTitulo,
                                Expression<Func<T, bool>> pFiltroDescripcion)
        {
            IQueryable<T> query = this.iDbSet;

            if (pFiltroFechas != null)
                query = query.Where(pFiltroFechas);

            if (pFiltroHoras != null)
            query = query.Where(pFiltroHoras);

            if (pFiltroTitulo != null)
                query = query.Where(pFiltroTitulo);

            if (pFiltroDescripcion != null)
                query = query.Where(pFiltroDescripcion);

            return query.ToList();
        }

        /// <summary>
        /// Método genérico para filtrar entidades según tipo de fuente o descripción
        /// </summary>
        /// <param name="pFiltroTipoFuente">filtro de tipo de fuente</param>
        /// <param name="pFiltroDescripcion">filtro de descripción</param>
        /// <returns>devuelve una colección de objetos según los filtros de búsqueda</returns>
        public virtual IEnumerable<T> Filtrar(Expression<Func<T, bool>> pFiltroTipoFuente,
                        Expression<Func<T, bool>> pFiltroDescripcion)
        {
            IQueryable<T> query = iDbSet;

            if (pFiltroTipoFuente != null)
                query = query.Where(pFiltroTipoFuente);

            if (pFiltroDescripcion != null)
                query = query.Where(pFiltroDescripcion);

            return query.ToList();
        }

        /// <summary>
        /// Método genérico que obtiene una entidad por su ID
        /// </summary>
        /// <param name="pId">ID del objeto a buscar</param>
        /// <returns>devuelve un objeto buscado por su ID</returns>
        public virtual T ObtenerPorId(int pId)
        {
            return this.iDbSet.Find(pId);
        }

        //public virtual IEnumerable<T> ObtenerTodos(Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null)
        //{
        //    if (orderBy == null)
        //        return this.Obtener(null, null);
        //    else
        //        return this.Obtener(null, orderBy);
        //}


        //public IEnumerable<Campania> ObtenerTodos()
        //{
        //    return iContexto.Campania.ToList();
        //}


        //public virtual IEnumerable<T> ObtenerPorAtributo(Expression<Func<T, bool>> filter = null)
        //{
        //    IQueryable<T> query = dbSet;

        //    if (filter != null)
        //    {
        //        query = query.Where(filter);
        //    }

        //    return query.ToList();
        //}

        /// <summary>
        /// Método genérico que agrega una entidad a la base de datos
        /// </summary>
        /// <param name="pEntidad">entidad a agregar</param>
        public void Agregar(T pEntidad)
        {
            this.iDbSet.Add(pEntidad);
        }

        /// <summary>
        /// Método genérico que borra una entidad por su ID de la base de datos
        /// </summary>
        /// <param name="pId">ID de la entidad a borrar</param>
        public void Borrar(int pId)
        {
            T entidadABorrar = this.iDbSet.Find(pId);
            Borrar(entidadABorrar);
        }

        /// <summary>
        /// Método genérico que borra una entidad de la base de datos
        /// </summary>
        /// <param name="pEntidadABorrar">entidad a borrar</param>
        public virtual void Borrar(T pEntidadABorrar)
        {
            if (this.iContexto.Entry(pEntidadABorrar).State == EntityState.Detached)
            {
                this.iDbSet.Attach(pEntidadABorrar);
            }
            this.iDbSet.Remove(pEntidadABorrar);
        }

        /// <summary>
        /// Método genérico para modificar una entidad en la base de datos
        /// </summary>
        /// <param name="entidadAModificar">entidad a modificar</param>
        public void Modificar(T pEntidadAModificar)
        {
            this.iDbSet.Attach(pEntidadAModificar);
            this.iContexto.Entry(pEntidadAModificar).State = EntityState.Modified;
        }

        //VER SI NOS SIRVE:
        //IEnumerable<TEntity> ExecuteQuery<TEntity>(string sqlQuery, params object[] parameters);

        //int ExecuteCommand(string sqlCommand, params object[] parameters);
    }
}