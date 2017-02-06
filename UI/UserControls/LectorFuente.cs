using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace UI.UserControls
{
    /// <summary>
    /// Componente de la UI que permite leer una fuente, guardando en BD y devolviendo los Items
    /// para mostrarlos en pantalla
    /// </summary>
    public partial class LectorFuente : UserControl
    {
        private IEnumerable<Item> itemsLeidos;

        public LectorFuente()
        {
            InitializeComponent();
            this.itemsLeidos = new List<Item>();
        }

        /// <summary>
        /// Lee una fuente, guardando en BD y devolviendo los Items para mostrarlos en pantalla
        /// </summary>
        /// <param name="pFuente">Fuente que se quiere leer</param>
        public IEnumerable<Item> ObtenerItems(Fuente pFuente)
        {
            try
            {
                if (this.bgwLector.IsBusy) //Si el backGroundWork no está ocupado
                {
                    throw new Exception("El lector está ocupado");
                }
                else
                {
                    this.bgwLector.RunWorkerAsync(pFuente);
                }
            }
            catch (Exception bEx)
            {
                MessageBox.Show(bEx.Message, "Se ha producido un error al intentar realizar la Lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return this.itemsLeidos;
        }

        private void bgwLector_DoWork(object sender, DoWorkEventArgs pEventArgs)
        {
            pEventArgs.Result = ((Fuente)pEventArgs.Argument).Leer();
        }

        private void bgwLector_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs pEventArgs)
        {
            if (pEventArgs.Error != null)
                MessageBox.Show(String.Format("No se han podido obtener datos de la Fuente: {0}", pEventArgs.Error.Message),
                                              "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!pEventArgs.Cancelled)
                this.itemsLeidos = (IEnumerable<Item>)pEventArgs.Result;
        }
    }
}
