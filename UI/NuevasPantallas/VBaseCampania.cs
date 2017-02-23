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
    public partial class VBaseCampania : VAbstractBase
    {
        private VCrearCampania iVentanaNueva;
        private VModificarCampania iVentanaEditar;


        public VBaseCampania(ref ControladorDominio pControladorDominio) : base(ref pControladorDominio)
        {
            InitializeComponent();
            this.iControladorDominio = pControladorDominio;
        }

        /// <summary>
        /// Evento que se invoca cuando se hace click en el botón filtrar
        /// </summary>
        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            DateTime[] filtroFechas = null;
            TimeSpan[] filtroHoras = null;
            string filtroTitulo = null;
            string filtroDescripcion = null;

            if (checkBoxRangoFechas.Checked)
                filtroFechas = new DateTime[] { this.rangoFecha.FechaInicio, this.rangoFecha.FechaFin };
            if (checkBoxRangoHoras.Checked)
                filtroHoras = new TimeSpan[] { this.rangoHorario.HoraInicio, this.rangoHorario.HoraFin };
            if (checkBoxTitulo.Checked)
                filtroTitulo = this.textBoxTitulo.Text;
            if (checkBoxDescripcion.Checked)
                filtroDescripcion = this.textBoxDescripcion.Text;

            List<Campania> listaFiltrada = this.iControladorDominio.FiltrarCampanias(filtroFechas, filtroHoras, filtroTitulo, filtroDescripcion);
            this.CargarDataGridCampanias(listaFiltrada);
        }

        /// <summary>
        /// Busca la campania que se va a modificar
        /// </summary>
        /// <returns>Devuelve la campania encontrada, null si no se selecciona ninguna</returns>
        private Campania campaniaAModificar()
        {
                return (Campania)this.dataGridViewMostrar.SelectedRows[0].DataBoundItem;
            }

        /// <summary>
        /// Muestra en el datagrid los banners que se encuentran en la base de datos
        /// </summary>
        public void CargarDataGridCampanias(List<Campania> pListaCampanias)
        {
            //Cargamos el Datagrid:
            this.dataGridViewMostrar.DataSource = pListaCampanias;

            //Dejamos invisibles las columnas que no deben verse:
            this.dataGridViewMostrar.Columns["CampaniaId"].Visible = false;
            this.dataGridViewMostrar.Columns["Imagenes"].Visible = false;
            
            //Cambiamos el orden de las columnas:
            this.dataGridViewMostrar.Columns["Titulo"].DisplayIndex = 0;
            this.dataGridViewMostrar.Columns["FechaInicio"].DisplayIndex = 2;
            this.dataGridViewMostrar.Columns["FechaFin"].DisplayIndex = 3;
            this.dataGridViewMostrar.Columns["HoraInicio"].DisplayIndex = 4;
            this.dataGridViewMostrar.Columns["HoraFin"].DisplayIndex = 5;
            this.dataGridViewMostrar.Columns["DuracionImagen"].DisplayIndex = 1;
            this.dataGridViewMostrar.Columns["Descripcion"].DisplayIndex = 6;

            //Cambiamos el nombre de las columnas:
            this.dataGridViewMostrar.Columns["DuracionImagen"].HeaderText = "Duración imágenes";
        }

        /// <summary>
        /// Evento que se invoca cuando se hace click sobre el botón nuevo, creando una nueva campaña
        /// </summary>
        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            this.iVentanaNueva = new VCrearCampania(ref iControladorDominio);
            this.iVentanaNueva.Owner = this;
            this.iVentanaNueva.ShowDialog();
            this.iVentanaNueva = null;
        }

        /// <summary>
        /// Evento que se invoca cuando se hace click sobre el botón modificar, modificando una campaña
        /// </summary>
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (this.campaniaAModificar() == null)
                MessageBox.Show("Seleccione una Campaña");
            else
            {
                this.iVentanaEditar = new VModificarCampania(ref this.iControladorDominio, this.campaniaAModificar());
                this.iVentanaEditar.Owner = this;
                this.iVentanaEditar.ShowDialog();
                this.iVentanaEditar = null;
            }
        }

        /// <summary>
        /// Evento que se invoca cuando se hace click sobre el botón eliminar, eliminando una campaña.
        /// Actualiza el DataGrid
        /// </summary>
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(this.dataGridViewMostrar.SelectedRows[0].Cells[0].Value.ToString());
            this.iControladorDominio.BorrarCampania(codigo);
            this.iControladorDominio.GuardarCambios();
            this.CargarDataGridCampanias(this.iControladorDominio.ObtenerTodasLasCampanias());
        }

        /// <summary>
        /// Evento que se invoca cuando VBaseCampania se activa
        /// </summary>
        private void VBaseCampania_Activated(object sender, EventArgs e)
        {
            CargarDataGridCampanias(this.iControladorDominio.ObtenerTodasLasCampanias());
            //Preguntamos si las ventanas hijas son nulas, sino significa que están abiertas
            //y les dejamos el foco 
            if (this.iVentanaNueva != null)
                this.iVentanaNueva.Activate();
            else if (this.iVentanaEditar != null)
                this.iVentanaEditar.Activate();
        }
    }
}
