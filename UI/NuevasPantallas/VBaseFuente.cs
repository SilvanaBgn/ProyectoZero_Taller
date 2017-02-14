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
    public partial class VBaseFuente : Form
    {

        private ControladorDominio iControladorDominio;

        public VBaseFuente(ref ControladorDominio pControladorDominio)
        {
            InitializeComponent();
            this.iControladorDominio = pControladorDominio;
            this.comboBoxTipo.Enabled = false;
            this.textBoxDescripcion.Enabled = false;
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            VCrearFuente vFuente = new VCrearFuente(ref this.iControladorDominio);
            vFuente.Show();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            VModificarFuente vFuente = new VModificarFuente(ref this.iControladorDominio);
            vFuente.Show();
        }

        public void CargarTodasLasFuentes()
        {
            this.dataGridViewMostrar.DataSource = this.iControladorDominio.ObtenerTodasLasFuentes();
            this.dataGridViewMostrar.Columns["Banners"].Visible = false;
            this.dataGridViewMostrar.Columns["Tipo"].Visible = false;
            this.dataGridViewMostrar.Columns["Items"].Visible = false;
            this.dataGridViewMostrar.Columns["FuenteId"].Visible = false;
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(this.dataGridViewMostrar.SelectedRows[0].Cells[0].Value.ToString());
            this.iControladorDominio.BorrarFuente(codigo);
            this.iControladorDominio.GuardarCambios();
            this.CargarTodasLasFuentes();
        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            string filtroTipoFuente = null;
            string filtroDescripcion = null;

            if (checkBoxTipo.Checked)
                filtroTipoFuente = this.comboBoxTipo.SelectedItem.ToString();
            if (checkBoxDescripcion.Checked)
                filtroDescripcion = this.textBoxDescripcion.Text;

            List<Fuente> listaFiltrada = this.iControladorDominio.FiltrarFuentes(filtroTipoFuente, filtroDescripcion);
            this.dataGridViewMostrar.DataSource = listaFiltrada;
        }

        private void checkBoxDescripcion_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxDescripcion.Checked)
                this.textBoxDescripcion.Enabled = true;
            else this.textBoxDescripcion.Enabled = false;
        }

        private void checkBoxTipo_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxTipo.Checked)
                this.comboBoxTipo.Enabled = true;
            else this.comboBoxTipo.Enabled = false;
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VBaseFuente_Activated(object sender, EventArgs e)
        {
            this.CargarTodasLasFuentes();
        }

        private void VBaseFuente_Load(object sender, EventArgs e)
        {
            this.CargarTodasLasFuentes();
        }
    }
}
