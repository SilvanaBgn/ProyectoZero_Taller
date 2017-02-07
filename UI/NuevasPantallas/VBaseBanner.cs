using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.NuevasPantallas;
using Dominio;

namespace UI.NuevasPantallas
{
    public partial class VBaseBanner : VAbstractBase
    {
        private Banner banner = new Banner();

        public VBaseBanner(ref ControladorDominio pControladorDominio) : base(ref pControladorDominio)
        {
            InitializeComponent();
            this.iControladorDominio = pControladorDominio;
            this.buttonNuevo.Click += buttonNuevo_Click;
            this.buttonModificar.Click += buttonModificar_Click;
            this.buttonEliminar.Click += buttonEliminar_Click;
            this.buttonFiltrar.Click += buttonFiltrar_Click;
            this.checkBoxDescripcion.CheckedChanged += checkBoxDescripcion_CheckedChanged;
            CargarBanners();
        }

        private void checkBoxDescripcion_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxDescripcion.Checked)
                this.textBoxDescripcion.Enabled = true;
            else this.textBoxDescripcion.Enabled = false;
        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {

          //  List<Banner> listaAuxiliar = new List<Banner>();

           // if (this.checkBoxRangoFechas.Checked &&)
            //{
            //    listaAuxiliar.AddRange(this.iControladorDominio.BuscarBannerPorAtributo
            //        (x => x.FechaInicio.CompareTo(this.rangoFecha.FechaInicio) >= 0 &&
            //    x.FechaFin.CompareTo(this.rangoFecha.FechaFin) <= 0));
            //}

            //if (this.checkBoxRangoHoras.Checked)
            //{

            //}
        }

        /// <summary>
        /// Devuelve el banner seleccionado en el datagrid
        /// </summary>
        /// <returns>Banner a modificar</returns>
        private Banner bannerAModificar()
        {
            return (Banner)this.dataGridViewMostrar.SelectedRows[0].DataBoundItem;
        }
        /// <summary>
        /// Muestra en el datagrid los banners que se encuentran en la base de datos
        /// </summary>
        public void CargarBanners()
        {
            this.dataGridViewMostrar.DataSource = this.iControladorDominio.ObtenerTodosLosBanners();
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new VCrearBanner(ref iControladorDominio);
            form2.Show();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            this.banner = this.bannerAModificar();
            this.Hide();
            var nuevoForm = new VModificarBanner(ref iControladorDominio,this.bannerAModificar());
            nuevoForm.Show();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(this.dataGridViewMostrar.SelectedRows[0].Cells[0].Value.ToString());
            this.iControladorDominio.BorrarBanner(codigo);
            this.iControladorDominio.GuardarCambios();
            this.CargarBanners();
        }
    }
}
