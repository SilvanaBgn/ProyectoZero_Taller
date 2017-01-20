using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Persistencia
{
    public class DateConvention : Convention
    {
        public DateConvention()
        {
            this.Properties<DateTime>().Configure(c => c.HasColumnType("Date"));
        }
    }
}
