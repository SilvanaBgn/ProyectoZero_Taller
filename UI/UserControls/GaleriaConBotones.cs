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
using System.IO;
using Helper;

namespace UI.UserControls
{
    public partial class GaleriaConBotones : UserControl
    {
        public List<Imagen> ListaImagenes { get; set; }

        public GaleriaConBotones()
        {
            InitializeComponent();
            //Inicializamos la lista de imágenes:
            this.ActualizarListaImagenes();
        }

        private void buttonArriba_Click(object sender, EventArgs e)
        {
            //object item = listBoxImagenes.SelectedItem;
            //if (listBoxImagenes.SelectedIndex > 0)
            //{
            //    string curItem = item.ToString();
            //    listBoxImagenes.Items[listBoxImagenes.SelectedIndex] = listBoxImagenes.Items[listBoxImagenes.SelectedIndex - 1];
            //    listBoxImagenes.Items[listBoxImagenes.SelectedIndex - 1] = curItem;
            //    listBoxImagenes.SelectedItem = item;
            //}
        }

        private void buttonAgregarImagenes_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Multiselect = true;
            DialogResult result = op.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                string[] url = op.FileNames;
                for (int i = 0; i < url.Length; i++)
                {
                    ListViewItem fila = new ListViewItem((this.listView1.Items.Count+1).ToString());
                    fila.SubItems.Add(Path.GetFileName(url[i]));
                    fila.SubItems.Add(url[i]);
                    this.listView1.Items.Add(fila);
                }
                //Seleccionamos el primer elemento del ListView:
                this.listView1.Items[0].Focused = true;
                this.listView1.Items[0].Selected = true;
                //Actualizamos la lista de imágenes:
                this.ActualizarListaImagenes();
            }
        }

        private void ActualizarListaImagenes()
        {
            this.ListaImagenes = new List<Imagen>();
            for (int i = 0; i < this.listView1.Items.Count; i++)
            {
                Imagen imagen = new Imagen();
                imagen.Orden = Convert.ToInt16(this.listView1.Items[i].SubItems[0].Text); //SubItems[0]= Numero
                imagen.Descripcion = this.listView1.Items[i].SubItems[1].Text; //SubItems[1]= Nombre
                imagen.Bytes = ConversorImagen.ImageToByte(this.listView1.Items[i].SubItems[2].Text); //SubItems[2]= Url
                this.ListaImagenes.Add(imagen);
            }

        }


        private void buttonVistaPrevia_Click(object sender, EventArgs e)
        {
            if (!this.campaniaDeslizante1.Funcionando)
            {
                if (this.textBoxSegundos.Text.Length>0)
                    this.campaniaDeslizante1.Start(this.ListaImagenes, Convert.ToInt16(this.textBoxSegundos.Text));
                else
                    this.campaniaDeslizante1.Start(this.ListaImagenes, 0);
            }
            else
                this.campaniaDeslizante1.Stop();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count==1)
            {
                //Al seleccionar una nueva línea, se actualiza el pictureBox:
                this.campaniaDeslizante1.Start(ConversorImagen.ImageToByte(this.listView1.SelectedItems[0].SubItems[2].Text));
            }
        }
    }
}
