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
using Excepciones;


namespace UI
{
    public partial class VCampania : Form
    {
        ControladorDominio iControladorDominio;

        public VCampania(ref ControladorDominio pControladorDominio)
        {
            InitializeComponent();
            this.iControladorDominio = pControladorDominio;
        }


        #region EVENTOS
        /// <summary>
        /// Evento que se activa al cargar por primera vez esta ventana
        /// </summary>
        private void VCampania_Load(object sender, EventArgs e)
        {
            try
            {
                this.CambiarColorVentana();
                this.CargarDataGridViewCampania(this.iControladorDominio.ObtenerTodasLasCampanias().ToList());
            }
            catch (ExcepcionAlCargarPantalla ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        #region Eventos ToolStripMenuItem
        /// <summary>
        /// Evento que abre la ventana VCampaniaNueva, para crear una nueva campaña
        /// </summary>
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VCampaniaNueva vNuevaCampania = new VCampaniaNueva(ref this.iControladorDominio);
            vNuevaCampania.MdiParent = this;
            vNuevaCampania.Show();
        }

        /// <summary>
        /// Evento que abre la ventana VCampaniaModificar, para modificar la campaña seleccionada
        /// </summary>
        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewCampania.SelectedRows.Count == 1)
            {
                int cod= Convert.ToInt32(this.dataGridViewCampania.SelectedRows[0].Cells[0].Value.ToString());
                VCampaniaModificar vModificarCampania = new VCampaniaModificar(ref this.iControladorDominio, cod);
                vModificarCampania.MdiParent = this;
                vModificarCampania.Show();
            }
            else
                MessageBox.Show("Debe seleccionar la fila a modificar ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        /// <summary>
        /// Evento que borra las campañas seleccionadas
        /// </summary>
        private void borrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridViewCampania.MultiSelect)
                {
                    var result = MessageBox.Show("¿Está seguro de que desea borrar esta campaña?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes)
                    {
                        for (int i = 0; i < this.dataGridViewCampania.SelectedRows.Count; i++)
                        {
                            int codigo = Convert.ToInt32(this.dataGridViewCampania.SelectedRows[i].Cells[0].Value.ToString());
                            this.iControladorDominio.BorrarCampania(codigo);
                        }
                        this.iControladorDominio.GuardarCambios();
                        this.CargarDataGridViewCampania(this.iControladorDominio.ObtenerTodasLasCampanias().ToList());
                    }
                }
                else
                    MessageBox.Show("Debe seleccionar la fila a modificar ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (ExcepcionErrorEnLaBusqueda ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ExcepcionAlCargarPantalla ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            catch (ExcepcionErrorAlGuardar)
            {
                MessageBox.Show("Error al guardar: no se pudo borrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ExcepcionGeneral)
            {
                MessageBox.Show("Error: no se pudo borrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento para salir de la ventana VCampaña y volver a la ventana VPrincipal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #endregion


        #region Métodos auxiliares

        /// <summary>
        /// Establece el fondo de esta ventana del color establecido en la propiedad BackColor
        /// </summary>
        private void CambiarColorVentana()
        {
            MdiClient ctlMDI;

            // Hacemos un for entre todos los controles del Form buscando el control MdiClient
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    //Casteamos el control a un MdiClient
                    ctlMDI = (MdiClient)ctl; 

                    ctlMDI.BackColor = this.BackColor;
                }
                catch (InvalidCastException) { } //Agarramos e ignoramos el error si el Casting falla
            }
        }

        /// <summary>
        /// Carga el DataGridViewCampania con la pLista que se le pasa
        /// </summary>
        public void CargarDataGridViewCampania(List<Campania> pLista)
        {
            try
            {
                this.dataGridViewCampania.DataSource = null;
                this.dataGridViewCampania.DataSource = pLista;

                //Visibilidad de Columnas:
                this.dataGridViewCampania.Columns["Imagenes"].Visible = false;
            }
            catch (Exception ex)
            {
                throw new ExcepcionAlCargarPantalla("Error al cargar las campañas", ex);
            }
        }

        #endregion

       
    }
}
