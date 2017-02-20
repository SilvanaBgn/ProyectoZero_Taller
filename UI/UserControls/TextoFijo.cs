using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace UI.UserControls
{
    public partial class TextoFijo : UserControl
    {
        /// <summary>
        /// Atributo que mantiene actualizadas la lista de items del comboBoxItems
        /// </summary>
        private List<Item> iListaItems;

        public string Descripcion
        {
            get { return this.textBoxDescripcion.Text; }
            set { this.textBoxDescripcion.Text = value; }
        }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        // Property
        public List<Item> ListaItems
        {
            get //Actualiza la lista de items (this.iListaItems) y la devuelve
            {
                this.iListaItems = new List<Item>();
                foreach (var itemComboBox in this.comboBoxItems.Items)
                {
                    Item item = new Item(itemComboBox.ToString());
                    this.iListaItems.Add(item);
                }

                return this.iListaItems;
            }
            set //Obtiene una lista de items, y la muestra en el comboBoxItems
            {
                this.iListaItems = value;
                foreach (var item in this.iListaItems)
                {
                    this.comboBoxItems.Items.Add(item.Descripcion);
                }
            }
        }

        //CONSTRUCTOR
        public TextoFijo()
        {
            InitializeComponent();
            this.iListaItems = new List<Item>();
        }

        #region Eventos BOTONES (privados)
        /// <summary>
        /// Evento que se activa al presionar el botón this.buttonArriba, para cambiar el orden de los items en el combobox
        /// </summary>
        private void buttonArriba_Click(object sender, EventArgs e)
        {
            if (this.comboBoxItems.SelectedIndex != -1)
            {
                int pos = this.comboBoxItems.SelectedIndex;
                string texto = this.comboBoxItems.SelectedItem.ToString();

                //Si no es el primer item (ya que no se puede subir más):
                if (pos > 0)
                {
                    this.comboBoxItems.Items.RemoveAt(pos);
                    this.comboBoxItems.Items.Insert(pos - 1, texto);
                    this.comboBoxItems.SelectedIndex = pos - 1;
                }
            }
        }

        /// <summary>
        /// Evento que se activa al presionar el botón this.buttonAbajo, para cambiar el orden de los items en el comboBox
        /// </summary>
        private void buttonAbajo_Click(object sender, EventArgs e)
        {
            if (this.comboBoxItems.SelectedIndex != -1)
            {
                int pos = this.comboBoxItems.SelectedIndex;
                string texto = this.comboBoxItems.SelectedItem.ToString();

                //Si no es el ultimo item (ya que no se puede subir más):
                if (pos < this.comboBoxItems.Items.Count - 1)
                {
                    this.comboBoxItems.Items.RemoveAt(pos);
                    this.comboBoxItems.Items.Insert(pos + 1, texto);
                    this.comboBoxItems.SelectedIndex = pos + 1;
                }
            }
        }

        /// <summary>
        /// Botón que permite agregar un item
        /// </summary>
        private void buttonAgregarItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBoxItems.Text))
                comboBoxItems.Items.Add(comboBoxItems.Text);
        }

        /// <summary>
        /// Botón que permite eliminar un item
        /// </summary>
        private void buttonEliminarItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBoxItems.Text))
            {
                this.comboBoxItems.Items.Remove(comboBoxItems.SelectedItem);
            }
        }

        /// <summary>
        /// Botón que permite visulizar una vista previa del banner
        /// </summary>
        private void buttonVistaPrevia_Click(object sender, EventArgs e)
        {
            //Cambiamos la habilitacion del listview y demás botones:
            this.buttonAgregarItem.Enabled = !this.buttonAgregarItem.Enabled;
            this.buttonEliminarItem.Enabled = !this.buttonEliminarItem.Enabled;
            this.buttonArriba.Enabled = !this.buttonArriba.Enabled;
            this.buttonAbajo.Enabled = !this.buttonAbajo.Enabled;
            this.comboBoxItems.Enabled = !this.comboBoxItems.Enabled;

            if (!this.bannerDeslizante1.Funcionando)
            {
                //Cambiamos la imagen del botón this.buttonVistaPrevia a "Pausa"
                this.buttonVistaPrevia.BackgroundImage = global::UI.Properties.Resources.Pausa1;
                this.bannerDeslizante1.Start(ConvertirItemsATexto(this.comboBoxItems));
            }
            else
            {
                this.bannerDeslizante1.Stop();
                //Cambiamos la imagen del botón this.buttonVistaPrevia a "Play"
                this.buttonVistaPrevia.BackgroundImage = global::UI.Properties.Resources.Play1;
            }
        }
        #endregion

        #region Eventos (privados)
        /// <summary>
        /// Evento del comboBox que se invoca previo al presionar una tecla
        /// </summary>
        private void comboBoxItems_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBoxItems.Text) && e.KeyCode == Keys.Delete)
                this.comboBoxItems.Items.Remove(comboBoxItems.SelectedItem);
        }

        /// <summary>
        /// Evento del comboBox que se invoca cuando se presiona una tecla
        /// </summary>
        private void comboBoxItems_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBoxItems.Text) && e.KeyChar == (Char)Keys.Enter)
                this.comboBoxItems.Items.Add(comboBoxItems.Text);
        }
        #endregion

        #region Otras funciones auxiliares
        /// <summary>
        /// Convierte los items del ComboBox a un String
        /// </summary>
        private string ConvertirItemsATexto(ComboBox pComboBox)
        {
            string banner = "";
            for (int i = 0; i < pComboBox.Items.Count; i++)
                banner += pComboBox.Items[i].ToString() + " • | • ";
            return banner;
        }
        #endregion
    }
}
