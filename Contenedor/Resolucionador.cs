using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace Contenedor
{
    public static class Resolucionador<T> where T:class
    {
        public static T Resolver() { return IoCContainerLocator.Container.Resolve<T>(); }

        public static T Resolver(string pNombre) { return IoCContainerLocator.Container.Resolve<T>(pNombre); }
    }
}
