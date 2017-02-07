using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Dominio;
using Dominio.Lecturas;

namespace UI
{
    public partial class PruebaLectorRss : Form
    {
        public PruebaLectorRss()
        {
            InitializeComponent();

            this.dgRssItems.AutoGenerateColumns = false;
        }

        private void FrmMain_Load(Object pSender, EventArgs pEventArgs)
        {
            // Simplemente se hace para que visualmente se vea la implementación de IRssReader que se está utilizando.
            this.lblStatus.Text = String.Format("Implementación IRssReader: {0}", new LectorRss().GetType().FullName);
            
            //Explicación: IoCContainerLocator.Container.Resolve<IRssReader>() elige una implementación por defecto para la interfaz IRssReader
            //es decir, Get an instance of the default requested type from the container.
        }

        private void btnUpdate_Click(Object pSender, EventArgs pEventArgs)
        {
            try
            {
                if (!this.bwRssReader.IsBusy)
                {
                    this.btnUpdate.Enabled = false;

                    this.Cursor = Cursors.WaitCursor;

                    this.bwRssReader.RunWorkerAsync(this.cmbUrl.Text);
                }
            }
            catch (Exception bEx)
            {
                MessageBox.Show(bEx.Message, "Se ha producido un error al intentar actualizar los feeds", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bwRssReader_DoWork(Object pSender, DoWorkEventArgs pEventArgs)
        {
            LectorRss mRssReader = new LectorRss();
            
            pEventArgs.Result = mRssReader.Leer((string)pEventArgs.Argument);
        }

        private void bwRssReader_RunWorkerCompleted(Object pSender, RunWorkerCompletedEventArgs pEventArgs)
        {
            if (pEventArgs.Error != null)
            {
                MessageBox.Show(String.Format("No se han podido obtener datos de la fuente rss: {0}", pEventArgs.Error.Message),
                                              "Ha ocurrido un error",
                                              MessageBoxButtons.OK,
                                              MessageBoxIcon.Error);
            }
            else if (!pEventArgs.Cancelled)
            {
                IEnumerable<Item> mItems = (IEnumerable<Item>) pEventArgs.Result;

                this.dgRssItems.DataSource = mItems;

                this.lblStatus.Text = String.Format("Se ha(n) obtenido {0} elemento(s).", mItems.Count());
            }

            this.btnUpdate.Enabled = true;

            this.Cursor = Cursors.Default;
        }
    }
}
