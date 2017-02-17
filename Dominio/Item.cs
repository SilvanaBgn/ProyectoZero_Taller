using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Item
    {
        /// <summary>
        /// Atributo ID del item
        /// </summary>
        public int ItemId { get; set; }

        /// <summary>
        /// Atributo descripción del item
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// Constructores
        /// </summary>
        public Item(): this("") {}
        public Item(string pDescripcion)
        {
            this.Descripcion = pDescripcion;
        }

        /// <summary>
        /// Sobreescribe el método ToString del objeto Item
        /// </summary>
        /// <returns>devuelve la descripción del item</returns>
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
