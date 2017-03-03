using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Contenedor;
using System.Threading;
using System.IO;

namespace UI.Pantallas
{
    public partial class VPresentacion : Form
    {
        public VPresentacion()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void VPresentacion_Activated(object sender, EventArgs e)
        {
            this.bgw.RunWorkerAsync();
            
        }

        private void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(3000);
        }

        private void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Close();
        }
    }
}
