using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class PasoBanner
    {
        public int PasoBannerId { get; set; }
        public string Texto { get; set; }
        public int Orden { get; set; }

        public int BannerId { get; set; }
        public virtual Banner Banner { get; set; }


        public override string ToString()
        {
            return Texto;
        }
    }
}
