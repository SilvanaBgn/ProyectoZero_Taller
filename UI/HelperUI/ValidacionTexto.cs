using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HelperUI
{
    /// <summary>
    /// Clase que pone a disposición los métodos para controlar carateres que sigan una determinada expresión regular.
    /// </summary>
    public static class ValidacionTexto
    {
        /// <summary>
        /// Valida que la entrada esté compuesta únicamente por caracteres válidos
        /// </summary>
        /// <param name="e">Evento de tipo KeyPressEventArgs</param>
        public static void InputValido(KeyPressEventArgs e)
        {
            //Declaramos la expresión regular de validación:
            var regex = new Regex(@"[^a-zA-Z0-9áéíóúÁÉÍÓÚñÑ\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }
    }
}
