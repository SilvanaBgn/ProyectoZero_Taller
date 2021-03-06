﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System.Configuration;
using System.Windows;
using Persistencia;
using Excepciones;
using Dominio;

namespace Contenedor
{
    /// <summary>
    /// Acceso al contenedor de IoC (Contenedor de Inversión de Control).
    /// </summary>
    public static class IoCContainerLocator
    {

        /// <summary>
        /// Instancia lazy del contenedor de IoC.
        /// </summary>
        private static readonly Lazy<IUnityContainer> cInstance = new Lazy<IUnityContainer>(() =>
        {
            IUnityContainer mUnityContainer = new UnityContainer();
            
            //mUnityContainer.RegisterType<IUnitOfWork, UnitOfWork>(new ContainerControlledLifetimeManager());
            mUnityContainer.RegisterType<IUnitOfWork, UnitOfWork>();

            return mUnityContainer;
        });

        public static IUnityContainer Container
        {
            get { return cInstance.Value; }
        }
    }
}
