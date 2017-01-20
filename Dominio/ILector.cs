using System;
using System.Collections.Generic;

namespace Dominio
{
    /// <summary>
    /// Lector genérico
    /// </summary>
    public interface ILector
    {
        /// <summary>
        /// Obtiene los ítems de la lectura, donde <paramref name="pInfo"/> es un <see cref="System.String"/>.
        /// </summary>
        /// <returns>Ítems con la información</returns>
        IEnumerable<Item> Leer(String pInfo);

        IEnumerable<Item> Leer();

    }
}
