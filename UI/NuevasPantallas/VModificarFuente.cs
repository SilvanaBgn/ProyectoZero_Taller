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
using Excepciones.ExcepcionesPantalla;

namespace UI.NuevasPantallas
{
    public partial class VModificarFuente : VAbstractCrearModificarFuente
    {
        public VModificarFuente(ref ControladorDominio pControladorDominio, Fuente pFuenteAModificar) : base(ref pControladorDominio)
        {
            InitializeComponent();
            this.iFuente = pFuenteAModificar;
            this.CargarFuenteAModificar();
        }

        private void CargarFuenteAModificar()
        {
            this.comboBoxTipoFuente.Enabled = false;

            switch (this.iFuente.Tipo.ToString())
            {
                case "Rss":
                    this.comboBoxTipoFuente.Text = "Rss";
                    this.panelTextoFijo.Visible = false;
                    this.panelRss.Visible = true;
                    this.textBoxFuenteRss.Text = this.iFuente.OrigenItems;
                    this.textBoxDescripcionRss.Text = this.iFuente.Descripcion;
                    break;
                case "TextoFijo":
                    this.comboBoxTipoFuente.Text = "Texto Fijo";
                    this.panelRss.Visible = false;
                    this.panelTextoFijo.Visible = true;
                    this.textoFijo.Descripcion = this.iFuente.Descripcion;
                    this.textoFijo.ListaItems = (List<Item>)this.iFuente.Items;
                    break;
            }
        }

        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            //Completamos la this.iFuente con los datos modificados:
            switch (this.comboBoxTipoFuente.SelectedItem.ToString())
            {
                case "Rss":
                    this.iFuente.OrigenItems = this.textBoxFuenteRss.Text;
                    this.iFuente.Descripcion = this.textBoxDescripcionRss.Text;
                    break;
                case "Texto Fijo":
                    this.iFuente.Descripcion = this.textoFijo.Descripcion;
                    this.iFuente.Items = this.textoFijo.ListaItems;
                    break;
            }
            try //Intentamos agregarla al repositorio y luego guardarla en base de datos:
            {
                //Modificamos la fuente y guardamos los cambios:
                this.iControladorDominio.ModificarFuente(this.iFuente);
                this.iControladorDominio.GuardarCambios();

                //Luego de guardar, activamos la variable booleana que indica que se guardó correctamente:
                this.iGuardadoCorrecto = true;

                this.Close();
            }
            catch (ExcepcionCamposSinCompletar ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}