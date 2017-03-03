using System;
using System.Runtime.Serialization;

namespace UI.NuevasPantallas
{
    [Serializable]
    internal class ExcepcionAlEliminar : Exception
    {
        public ExcepcionAlEliminar()
        {
        }

        public ExcepcionAlEliminar(string message) : base(message)
        {
        }

        public ExcepcionAlEliminar(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ExcepcionAlEliminar(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}