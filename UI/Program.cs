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
            Application.Run(new VPrincipal());
            //Application.Run(new PruebaTimerThreading());
            //Application.Run(new PruebaTimerTimers());
            //Application.Run(new PruebaTimerTimersSafeThread());
            //Application.Run(new PruebaCampaniaDeslizante());
            //Application.Run(new PruebaBannerDeslizante());
        }
    }
}
