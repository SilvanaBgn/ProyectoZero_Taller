﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionFechaFinMenorAFechaInicio: Exception
    {
        public ExcepcionFechaFinMenorAFechaInicio(string pMensaje, Exception pInnerException) : base(pMensaje,pInnerException)
        {
        }
        public ExcepcionFechaFinMenorAFechaInicio(string pMensaje) : base(pMensaje)
        {
        }

        //Aclaración: La propiedad predefinida desde Exception (Message) devuelve el iMensaje
    }
}
