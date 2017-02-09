using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new VPrincipal());
            //Application.Run(new PruebaRangoFecha());
            //Application.Run(new PruebaRangoHora());
            //Application.Run(new PruebaGaleria());
            //Application.Run(new PruebaLectorRss());
            //Application.Run(new PruebaLecturaFuente()); 
           
            Application.Run(new VPrincipal());
        }
    }
}
