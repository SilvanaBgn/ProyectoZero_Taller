using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace Contenedor
{
    /// <summary>
    /// Clase estática encargada de interactuar con el contenedor
    /// </summary>
    public static class Resolucionador<T> where T:class
    {
        /// <summary>
        /// Devuelve una instancia de tipo T declarada en el contenedor
        /// </summary>
        public static T Resolver() { return IoCContainerLocator.Container.Resolve<T>(); }

        /// <summary>
        /// Devuelve una instancia de tipo T declarada con un nombre en el contenedor
        /// </summary>
        public static T Resolver(string pNombre) { return IoCContainerLocator.Container.Resolve<T>(pNombre); }
    }
}
