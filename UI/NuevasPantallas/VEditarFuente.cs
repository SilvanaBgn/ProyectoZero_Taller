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
using Excepciones.ExcepcionesDominio;
using Excepciones;

namespace UI.NuevasPantallas
{
    public partial class VEditarFuente : VAbstractCrearModificarFuente
    {
        //CONSTRUCTOR
        public VEditarFuente(ref ControladorDominio pControladorDominio, Fuente pFuenteAModificar) : base(ref pControladorDominio)
        {
            InitializeComponent();
            this.iFuente = pFuenteAModificar;
            this.comboBoxTipoFuente.DropDownStyle = ComboBoxStyle.DropDownList;
        }



        #region Funciones privadas
        /// <summary>
        /// Carga en todos los componentes de la ventana VEditarFuente con los valores de this.iFuente
        /// </summary>
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
        #endregion

        #region EVENTOS
        /// <summary>
        /// Evento que se invoca cuando se hace click en el botón guardar. Guarda todos los datos de la
        /// fuente modificada
        /// </summary>
        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            this.buttonGuardar.Enabled = false;
            //Completamos la this.iFuente con los datos modificados:
            try //Intentamos agregarla al repositorio y luego guardarla en base de datos:
            {
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
                //Modificamos la fuente y guardamos los cambios:
                this.iControladorDominio.ModificarFuente(this.iFuente);
                this.iControladorDominio.GuardarCambios();
                //Luego de guardar, activamos la variable booleana que indica que se guardó correctamente:
                this.iGuardadoCorrecto = true;
                this.Close();
            }
            catch (ExcepcionFormatoURLIncorrecto ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.buttonGuardar.Enabled = true;
            }
            catch (ExcepcionCamposSinCompletar ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.buttonGuardar.Enabled = true;
            }
            catch (ExcepcionAlGuardarCambios ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.buttonGuardar.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error. Contacte con el administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.buttonGuardar.Enabled = true;
            }
        }

        /// <summary>
        /// Evento que se activa cuando la ventana ya se ha inicializado y se está cargando
        /// </summary>
        private void VEditarFuente_Load(object sender, EventArgs e)
        {
            this.CargarFuenteAModificar();
        }
        #endregion
    }
}