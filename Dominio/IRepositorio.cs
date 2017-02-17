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
        /// Metodo genérico para recuperar una coleccion de entidades
        /// </summary>
        /// <param name="filter">Expresión para filtrar las entidades</param>
        /// <param name="orderBy">Orden en el que se quiere recuperar las entidades</param>
        /// <returns>un listado de objetos de la entidad génerica</returns>
        IEnumerable<T> Obtener(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null);

        /// <summary>
        /// Metodo genérico para recuperar una colección de entidades según los filtros pasados como parámetros
        /// </summary>
        /// <param name="filtroFechas">filtro por fechas</param>
        /// <param name="filtroHoras">filtro por horas</param>
        /// <param name="filtroTitulo">filtro por título</param>
        /// <param name="filtroDescripcion">filtro por descripción</param>
        /// <returns>devuelve un listado de objetos de la entidad génerica</returns>
        IEnumerable<T> Filtrar(Expression<Func<T, bool>> filtroFechas,
            Expression<Func<T, bool>> filtroHoras,
            Expression<Func<T, bool>> filtroTitulo,
            Expression<Func<T, bool>> filtroDescripcion);

        /// <summary>
        /// Método para recuperar una colección de fuentes según los filtros pasados como parámetros
        /// </summary>
        /// <param name="filtroTipoFuente">filtro por tipo de fuente</param>
        /// <param name="filtroDescripcion">filtro por descripción</param>
        /// <returns></returns>
        IEnumerable<T> Filtrar(Expression<Func<T, bool>> filtroTipoFuente,
            Expression<Func<T, bool>> filtroDescripcion);

        /// <summary>
        /// Metodo genérico para recuperar una entidad a partir de su identidad
        /// </summary>
        /// <param name="id">La identidad de la entidad</param>
        /// <returns>La entidad</returns>
        T ObtenerPorId(int id);

        //IEnumerable<T> ObtenerTodos(Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null);
        //IEnumerable<T> ObtenerPorAtributo(Expression<Func<T, bool>> filter = null);

        /// <summary>
        /// Método genérico para agregar una nueva entidad
        /// </summary>
        /// <param name="entidad">entidad a agregar</param>
        void Agregar(T entidad);

        /// <summary>
        /// Método genérico para borrar una entidad por su ID
        /// </summary>
        /// <param name="id">ID de la entidad a borrar</param>
        void Borrar(int id);

        /// <summary>
        /// Método genérico para borrar una entidad
        /// </summary>
        /// <param name="objetoABorrar">objeto a borrar</param>
        void Borrar(T objetoABorrar);

        /// <summary>
        /// Método genérico para modificar una entidad
        /// </summary>
        /// <param name="objetoAEliminar">objeto a modificar</param>
        void Modificar(T objetoAEliminar);
    }
}
