using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Item
    {
        public int ItemId { get; set; }
        public string Descripcion { get; set; }

        public Item(): this("") {}
        public Item(string pDescripcion)
        {
            this.Descripcion = pDescripcion;
        }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
