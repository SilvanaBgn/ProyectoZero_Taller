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
        /// <param name="pFilter">Expresión para filtrar las entidades</param>
        /// <param name="pOrderBy">Orden en el que se quiere recuperar las entidades</param>
        /// <returns>un listado de objetos de la entidad génerica</returns>
        IEnumerable<T> Obtener(Expression<Func<T, bool>> pFilter = null, Func<IQueryable<T>, IOrderedQueryable<T>> pOrderBy = null);

        /// <summary>
        /// Metodo genérico para recuperar una colección de entidades según los filtros pasados como parámetros
        /// </summary>
        /// <param name="pFiltroFechas">filtro por fechas</param>
        /// <param name="pFiltroHoras">filtro por horas</param>
        /// <param name="pFiltroTitulo">filtro por título</param>
        /// <param name="filtroDescripcion">filtro por descripción</param>
        /// <returns>devuelve un listado de objetos de la entidad génerica</returns>
        IEnumerable<T> Filtrar(Expression<Func<T, bool>> pFiltroFechas,
            Expression<Func<T, bool>> pFiltroHoras,
            Expression<Func<T, bool>> pFiltroTitulo,
            Expression<Func<T, bool>> filtroDescripcion);

        /// <summary>
        /// Método para recuperar una colección de fuentes según los filtros pasados como parámetros
        /// </summary>
        /// <param name="pFiltroTipoFuente">filtro por tipo de fuente</param>
        /// <param name="pFiltroDescripcion">filtro por descripción</param>
        /// <returns></returns>
        IEnumerable<T> Filtrar(Expression<Func<T, bool>> pFiltroTipoFuente,
            Expression<Func<T, bool>> pFiltroDescripcion);

        /// <summary>
        /// Metodo genérico para recuperar una entidad a partir de su identidad
        /// </summary>
        /// <param name="pId">La identidad de la entidad</param>
        /// <returns>La entidad</returns>
        T ObtenerPorId(int pId);

        //IEnumerable<T> ObtenerTodos(Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null);
        //IEnumerable<T> ObtenerPorAtributo(Expression<Func<T, bool>> filter = null);

        /// <summary>
        /// Método genérico para agregar una nueva entidad
        /// </summary>
        /// <param name="pEntidad">entidad a agregar</param>
        void Agregar(T pEntidad);

        /// <summary>
        /// Método genérico para borrar una entidad por su ID
        /// </summary>
        /// <param name="pId">ID de la entidad a borrar</param>
        void Borrar(int pId);

        /// <summary>
        /// Método genérico para borrar una entidad
        /// </summary>
        /// <param name="pObjetoABorrar">objeto a borrar</param>
        void Borrar(T pObjetoABorrar);

        /// <summary>
        /// Método genérico para modificar una entidad
        /// </summary>
        /// <param name="pObjetoAEliminar">objeto a modificar</param>
        void Modificar(T pObjetoAEliminar);
    }
}
