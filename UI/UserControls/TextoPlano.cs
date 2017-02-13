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
    public partial class TextoPlano : UserControl
    {

        private List<Item> iListaItems;

        // Propertie
        public List<Item> ListaItems
        {
            get //Actualiza la lista de items (this.iListaItems) y la devuelve
            {
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

        public TextoPlano()
        {
            InitializeComponent();
            this.iListaItems = new List<Item>();
        }

        #region Eventos BOTONES (privados)
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

        private void buttonAgregarItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBoxItems.Text))
                comboBoxItems.Items.Add(comboBoxItems.Text);
        }

        private void buttonEliminarItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBoxItems.Text))
                this.comboBoxItems.Items.Remove(comboBoxItems.SelectedItem);
        }

        private void buttonVistaPrevia_Click(object sender, EventArgs e)
        {
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
        private void comboBoxItems_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBoxItems.Text) && e.KeyCode == Keys.Delete)
                this.comboBoxItems.Items.Remove(comboBoxItems.SelectedItem);
        }

        private void comboBoxItems_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBoxItems.Text) && e.KeyChar == (Char)Keys.Enter)
                this.comboBoxItems.Items.Add(comboBoxItems.Text);
        }
        #endregion

        #region Otras funciones auxiliares
        private string ConvertirItemsATexto(ComboBox pComboBox)
        {
            string banner = " ";
            for (int i = 0; i < pComboBox.Items.Count; i++)
                banner += pComboBox.Items[i].ToString() + " ";
            return banner;
        }
        #endregion
    }
}
