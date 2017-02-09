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
            this.buttonNuevo.Click += buttonNuevo_Click;
            this.buttonModificar.Click += buttonModificar_Click;
            this.buttonEliminar.Click += buttonEliminar_Click;
            this.buttonFiltrar.Click += buttonFiltrar_Click;
            CargarTodasLasCampanias();
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

            List<Banner> listaFiltrada = this.iControladorDominio.FiltrarBanners(filtroFechas, filtroHoras, filtroTitulo, filtroDescripcion);
            this.dataGridViewMostrar.DataSource = listaFiltrada;

        }

        /// <summary>
        /// Devuelve el banner seleccionado en el datagrid
        /// </summary>
        /// <returns>Banner a modificar</returns>
        private Campania campaniaAModificar()
        {
            return (Campania)this.dataGridViewMostrar.SelectedRows[0].DataBoundItem;
        }

        /// <summary>
        /// Muestra en el datagrid los banners que se encuentran en la base de datos
        /// </summary>
        public void CargarTodasLasCampanias()
        {
            this.dataGridViewMostrar.DataSource = this.iControladorDominio.ObtenerTodasLasCampanias();
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new VCrearCampania(ref iControladorDominio);
            form2.Show();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            this.campania = this.campaniaAModificar();
            this.Hide();
            var nuevoForm = new VModificarCampania(ref iControladorDominio, this.campaniaAModificar());
            nuevoForm.Show();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(this.dataGridViewMostrar.SelectedRows[0].Cells[0].Value.ToString());
            this.iControladorDominio.BorrarCampania(codigo);
            this.iControladorDominio.GuardarCambios();
            this.CargarTodasLasCampanias();
        }

    }
}
