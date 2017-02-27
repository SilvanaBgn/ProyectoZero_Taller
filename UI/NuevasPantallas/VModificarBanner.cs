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

namespace UI.NuevasPantallas
{
    public partial class VModificarBanner : VAbstractCrearModificarBanner
    {
        //CONSTRUCTOR
        public VModificarBanner(ref ControladorDominio pControladorDominio, Banner pBannerAModificar) : base(ref pControladorDominio)
        {
            InitializeComponent();
            //Asignamos el banner que se desea modificar:
            this.iBanner = pBannerAModificar;
        }



        #region Funciones privadas
        /// <summary>
        /// Este método selecciona la fuente que le corresponda al banner
        /// </summary>
        private void SeleccionarFuenteDelBanner()
        {
            int indiceFila = -1;

            DataGridViewRow row = this.dataGridViewMostrarFuentes.Rows
                .Cast<DataGridViewRow>()
                .Where(r => r.Cells["FuenteId"].Value.ToString().Equals(this.iBanner.FuenteId.ToString()))
                .First();

            indiceFila = row.Index;

            base.dataGridViewMostrarFuentes.Rows[0].Selected = false;
            base.dataGridViewMostrarFuentes.Rows[indiceFila].Selected = true;
            base.dataGridViewMostrarFuentes.Columns["FuenteId"].Visible = false;
        }

        /// <summary>
        /// Carga en todos los componentes de la ventana VModificarBanner los valores de pBannerAModificar
        /// </summary>
        /// <param name="pBannerAModificar">banner a modificar</param>
        private void CargarBannerAModificar(Banner pBannerAModificar)
        {
            this.textBoxTitulo.Text = pBannerAModificar.Titulo;
            this.textBoxDescripcion.Text = pBannerAModificar.Descripcion;
            this.rangoFecha.FechaInicio = pBannerAModificar.FechaInicio;
            this.rangoFecha.FechaFin = pBannerAModificar.FechaFin;
            this.rangoHorario.HoraInicio = pBannerAModificar.HoraInicio;
            this.rangoHorario.HoraFin = pBannerAModificar.HoraFin;
        }
        #endregion


        #region EVENTOS
        #region Botones

        /// <summary>
        /// Evento que se invoca cuando se hace click en el botón guardar. Guarda todos los datos del banner
        /// </summary>
        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            //Completamos el this.iBanner con los datos modificados:
            this.iBanner.Titulo = this.textBoxTitulo.Text;
            this.iBanner.Descripcion = this.textBoxDescripcion.Text;
            this.iBanner.FechaInicio = this.rangoFecha.FechaInicio;
            this.iBanner.FechaFin = this.rangoFecha.FechaFin;
            this.iBanner.HoraInicio = this.rangoHorario.HoraInicio;
            this.iBanner.HoraFin = this.rangoHorario.HoraFin;

            if (!this.rangoHorario.HorarioValido())
            {
                MessageBox.Show("La hora de fin debe ser posterior a la hora de inicio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Modificamos el banner y guardamos los cambios:
                this.iControladorDominio.ModificarBanner(this.iBanner);
                this.iControladorDominio.GuardarCambios();

                this.Close();
            }
        }
        #endregion

        #region Ventana y Otros Componentes
        /// <summary>
        /// Este evento se activa cuando VModificarBanner se encuentra activada
        /// </summary>
        private void VModificarBanner_Activated(object sender, EventArgs e)
        {
            List<Fuente> fuenteAMostrar = new List<Fuente>();
            fuenteAMostrar.Add(this.iControladorDominio.BuscarFuentePorId(this.iBanner.FuenteId));
            base.CargarDataGridViewFuentes(fuenteAMostrar);
            base.dataGridViewMostrarFuentes.Size= new System.Drawing.Size(436, this.dataGridViewMostrarFuentes.ColumnHeadersHeight +
                this.dataGridViewMostrarFuentes.Rows[0].Height);
        }

        /// <summary>
        /// Evento que se activa cuando la ventana ya se ha inicializado y se está cargando
        /// </summary>
        private void VModificarBanner_Load(object sender, EventArgs e)
        {
            this.CargarBannerAModificar(this.iBanner);
        }
    }
    #endregion

    #endregion
}
