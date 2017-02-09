using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Dominio
{
    /// <summary>
    /// Métodos genéricos para todos los repositorios
    /// </summary>
    public interface IRepositorio<T>
    {
        /// <summary>
        /// Metodo generico para recuperar una coleccion de entidades
        /// </summary>
        /// <param name="filter">Expresion para filtrar las entidades</param>
        /// <param name="orderBy">Orden en el que se quiere recuperar las entidades</param>
        /// <returns>Un listado de objetos de la entidadgenerica</returns>
        IEnumerable<T> Obtener(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null);

        IEnumerable<T> Filtrar(Expression<Func<T, bool>> filtroFechas,
            Expression<Func<T, bool>> filtroHoras,
            Expression<Func<T, bool>> filtroTitulo,
            Expression<Func<T, bool>> filtroDescripcion);

        /// <summary>
        /// Metodo generico para recuperar una entidad a partir de su identidad
        /// </summary>
        /// <param name="id">La identidad de la entidad</param>
        /// <returns>La entidad</returns>
        T ObtenerPorId(int id);

        //IEnumerable<T> ObtenerTodos(Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null);
        //IEnumerable<T> ObtenerPorAtributo(Expression<Func<T, bool>> filter = null);

        void Agregar(T entidad);
        void Borrar(int id);
        void Borrar(T objetoABorrar);
        void Modificar(T objetoAEliminar);
    }
}
