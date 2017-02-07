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
    /// Implementacion de un repositorio generico
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

        //public IEnumerable<T> Filtrar(Expression<Func<T, bool>> filtroFechas, 
        //                        Expression<Func<T, bool>> filtroHoras, 
        //                        Expression<Func<T, bool>> filtroTitulo,
        //                        Expression<Func<T, bool>> filtroDescripcion)
        //{
        //    IQueryable<T> query = dbSet;

        //    if (filtroFechas != null)
        //        query = query.Where(filtroFechas);

        //    if (filtroFechas != null)
        //        query = query.Where(filtroHoras);

        //    if (filtroFechas != null)
        //        query = query.Where(filtroTitulo);

        //    if (filtroFechas != null)
        //        query = query.Where(filtroDescripcion);
        //}


        
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


        public void Agregar(T entidad)
        {
            dbSet.Add(entidad);
        }

        public void Borrar(int id)
        {
            T entidadABorrar = dbSet.Find(id);
            Borrar(entidadABorrar);
        }

        public virtual void Borrar(T entidadABorrar)
        {
            if (iContexto.Entry(entidadABorrar).State == EntityState.Detached)
            {
                dbSet.Attach(entidadABorrar);
            }
            dbSet.Remove(entidadABorrar);
        }

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