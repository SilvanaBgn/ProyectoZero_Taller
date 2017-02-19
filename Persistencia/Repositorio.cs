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
        protected IDbSet<T> dbSet;

        private Contexto iContexto;


        public Repositorio(Contexto pContexto)
        {
            this.iContexto = pContexto;
            this.dbSet = iContexto.Set<T>();
        }

        /// <summary>
        /// Método genérico para buscar entidades en la base de datos
        /// </summary>
        /// <param name="filter">filtro de búsqueda</param>
        /// <returns>devuelve una colección de objetos según los filtros de búsqueda</returns>
        public virtual IEnumerable<T> Obtener(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null)
        {
            IQueryable<T> query = dbSet;

            if (filter != null)
                query = query.Where(filter);

            if (orderBy != null)
                return orderBy(query).ToList();
            else
                return query.ToList();
        }

        /// <summary>
        /// Método genérico para filtrar entidades según sus fechas, horas, título o descripción
        /// </summary>
        /// <param name="filtroFechas">filtro por fechas</param>
        /// <param name="filtroHoras">filtro por horas</param>
        /// <param name="filtroTitulo">filtro por título</param>
        /// <param name="filtroDescripcion">filtro por descripción</param>
        /// <returns>devuelve una colección de objetos según los filtros de búsqueda</returns>
        public virtual IEnumerable<T> Filtrar(Expression<Func<T, bool>> filtroFechas,
                                Expression<Func<T, bool>> filtroHoras,
                                Expression<Func<T, bool>> filtroTitulo,
                                Expression<Func<T, bool>> filtroDescripcion)
        {
            IQueryable<T> query = dbSet;

            if (filtroFechas != null)
                query = query.Where(filtroFechas);

            if (filtroHoras != null)
            query = query.Where(filtroHoras);

            if (filtroTitulo != null)
                query = query.Where(filtroTitulo);

            if (filtroDescripcion != null)
                query = query.Where(filtroDescripcion);

            return query.ToList();
        }

        /// <summary>
        /// Método genérico para filtrar entidades según tipo de fuente o descripción
        /// </summary>
        /// <param name="filtroTipoFuente">filtro de tipo de fuente</param>
        /// <param name="filtroDescripcion">filtro de descripción</param>
        /// <returns>devuelve una colección de objetos según los filtros de búsqueda</returns>
        public virtual IEnumerable<T> Filtrar(Expression<Func<T, bool>> filtroTipoFuente,
                        Expression<Func<T, bool>> filtroDescripcion)
        {
            IQueryable<T> query = dbSet;

            if (filtroTipoFuente != null)
                query = query.Where(filtroTipoFuente);

            if (filtroDescripcion != null)
                query = query.Where(filtroDescripcion);

            return query.ToList();
        }

        /// <summary>
        /// Método genérico que obtiene una entidad por su ID
        /// </summary>
        /// <param name="id">ID del objeto a buscar</param>
        /// <returns>devuelve un objeto buscado por su ID</returns>
        public virtual T ObtenerPorId(int id)
        {
            return dbSet.Find(id);
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
        /// <param name="entidad">entidad a agregar</param>
        public void Agregar(T entidad)
        {
            dbSet.Add(entidad);
        }

        /// <summary>
        /// Método genérico que borra una entidad por su ID de la base de datos
        /// </summary>
        /// <param name="id">ID de la entidad a borrar</param>
        public void Borrar(int id)
        {
            T entidadABorrar = dbSet.Find(id);
            Borrar(entidadABorrar);
        }

        /// <summary>
        /// Método genérico que borra una entidad de la base de datos
        /// </summary>
        /// <param name="entidadABorrar">entidad a borrar</param>
        public virtual void Borrar(T entidadABorrar)
        {
            if (iContexto.Entry(entidadABorrar).State == EntityState.Detached)
            {
                dbSet.Attach(entidadABorrar);
            }
            dbSet.Remove(entidadABorrar);
        }

        /// <summary>
        /// Método genérico para modificar una entidad en la base de datos
        /// </summary>
        /// <param name="entidadAModificar">entidad a modificar</param>
        public void Modificar(T entidadAModificar)
        {
            dbSet.Attach(entidadAModificar);
            iContexto.Entry(entidadAModificar).State = EntityState.Modified;
        }

        //VER SI NOS SIRVE:
        //IEnumerable<TEntity> ExecuteQuery<TEntity>(string sqlQuery, params object[] parameters);

        //int ExecuteCommand(string sqlCommand, params object[] parameters);
    }
}