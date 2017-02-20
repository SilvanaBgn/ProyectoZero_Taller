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
            this.dataGridViewMostrar.DataSource = pListaCampanias;
            this.dataGridViewMostrar.Columns["CampaniaId"].Visible = false;
            this.dataGridViewMostrar.Columns["Imagenes"].Visible = false;
            this.dataGridViewMostrar.Columns["DuracionImagen"].HeaderText = "Duración de imagenes";
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new VCrearCampania(ref iControladorDominio);
            form2.Show();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (this.campaniaAModificar() == null)
                MessageBox.Show("Seleccione una fuente");
            else
            {
                VModificarCampania vCampania = new VModificarCampania(ref this.iControladorDominio, this.campaniaAModificar());
                vCampania.Show();
            }
        }


        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(this.dataGridViewMostrar.SelectedRows[0].Cells[0].Value.ToString());
            this.iControladorDominio.BorrarCampania(codigo);
            this.iControladorDominio.GuardarCambios();
            this.CargarDataGridCampanias(this.iControladorDominio.ObtenerTodasLasCampanias());
        }

        private void VBaseCampania_Activated(object sender, EventArgs e)
        {
            CargarDataGridCampanias(this.iControladorDominio.ObtenerTodasLasCampanias());
        }
    }
}