﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones.ExcepcionesPantalla
{
    public class ExcepcionCamposSinCompletar : Exception
    {
        public ExcepcionCamposSinCompletar (string pMensaje) : base(pMensaje)
        {
        }


    }
}
