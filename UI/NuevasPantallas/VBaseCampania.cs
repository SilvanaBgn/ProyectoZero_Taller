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

        /// <summary>
        /// banner que se va a modificar (ver si sacar esto)
        /// </summary>
        private Campania campania = new Campania();

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

            //List<Campania> listaFiltrada = this.iControladorDominio.FiltrarCampanias(filtroFechas, filtroHoras, filtroTitulo, filtroDescripcion);
            //this.CargarDataGridCampanias(listaFiltrada);
        }

        /// <summary>
        /// Devuelve el banner seleccionado en el datagrid
        /// </summary>
        /// <returns>Banner a modificar</returns>
        private Campania campaniaAModificar()
        {
            Campania campania = new Campania();
            try
            {
                campania=(Campania)this.dataGridViewMostrar.SelectedRows[0].DataBoundItem;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Debe seleccionar una campaña para continuar","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return campania;
        }

        /// <summary>
        /// Muestra en el datagrid los banners que se encuentran en la base de datos
        /// </summary>
        public void CargarDataGridCampanias(List<Campania> pListaCampanias)
        {
            this.dataGridViewMostrar.DataSource = pListaCampanias;
        }

        /// <summary>
        /// Evento que se invoca cuando se hace click sobre el botón nuevo, creando una nueva campaña
        /// </summary>
        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new VCrearCampania(ref iControladorDominio);
            form2.Show();
        }

        /// <summary>
        /// Evento que se invoca cuando se hace click sobre el botón modificar, modificando una campaña
        /// </summary>
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            this.campania = this.campaniaAModificar();
            this.Hide();
            var nuevoForm = new VModificarCampania(ref iControladorDominio, this.campaniaAModificar());
            nuevoForm.Show();
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
        }

        /// <summary>
        /// Evento que se invoca cuando VBaseCampania se carga
        /// </summary>
        private void VBaseCampania_Load(object sender, EventArgs e)
        {
            CargarDataGridCampanias(this.iControladorDominio.ObtenerTodasLasCampanias());
        }
    }
}
