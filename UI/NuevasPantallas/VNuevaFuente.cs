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

namespace UI.NuevasPantallas
{
    public partial class VNuevaFuente : VAbstractCrearModificarFuente
    {
        //CONSTRUCTOR
        public VNuevaFuente(ref ControladorDominio pControladorDominio) : base(ref pControladorDominio)
        {
            InitializeComponent();
        }


        #region EVENTOS Botones
        /// <summary>
        /// Evento que se invoca cuando se hace click en el botón guardar, agregando una nueva fuente
        /// </summary>
        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            this.buttonGuardar.Enabled = false;
            try
            {
                if (this.comboBoxTipoFuente.SelectedItem == null)
                    MessageBox.Show("Se debe seleccionar un tipo de fuente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    //Creamos la fuente:
                    this.iFuente = new Fuente();

                    try
                    {
                        //Vemos el tipo, a partir de lo que completamos:
                        switch (this.comboBoxTipoFuente.SelectedItem.ToString())
                        {
                            case "Rss":
                                this.iFuente.Tipo = TipoFuente.Rss;
                                this.iFuente.OrigenItems = this.textBoxFuenteRss.Text;
                                this.iFuente.Descripcion = this.textBoxDescripcionRss.Text;
                                break;
                            case "Texto Fijo":
                                this.iFuente.Tipo = TipoFuente.TextoFijo;
                                this.iFuente.Descripcion = this.textoFijo.Descripcion;
                                this.iFuente.Items = this.textoFijo.ListaItems;
                                break;
                        }

                        //Agregamos la fuente y guardamos los cambios:
                        this.iControladorDominio.AgregarFuente(this.iFuente);
                        this.iControladorDominio.GuardarCambios();

                        //Luego de guardar, activamos la variable booleana que indica que se guardó correctamente:
                        this.iGuardadoCorrecto = true;
                        this.Close();
                    }
                    catch (ExcepcionFormatoURLIncorrecto ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (ExcepcionCamposSinCompletar ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch(Exception)
                    { throw new Exception(); }
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Se debe seleccionar un tipo de fuente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.buttonGuardar.Enabled = true;
        }
        #endregion
    }
}
