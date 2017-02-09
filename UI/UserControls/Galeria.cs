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
    public partial class Galeria : UserControl
    {
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Imagen> ListaImagenes { get; set; }

        public Galeria()
        {
            InitializeComponent();
            //Inicializamos la lista de imágenes:
            this.ActualizarListaImagenes();
        }

        

        #region Eventos privados BOTONES
        /// <summary>
        /// Evento que se activa al presionar el botón this.buttonArriba, para cambiar el orden de las imágenes en el listView
        /// </summary>
        private void buttonArriba_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count == 1)
            {
                ListViewItem item = this.listView1.SelectedItems[0];

                //Si no es el primer item (ya que no se puede subir más):
                if (item.Index > 0)
                {
                    int pos = item.Index - 1;
                    
                    //"Corremos" el item hacia arriba:
                    this.listView1.Items.RemoveAt(item.Index);
                    this.listView1.Items.Insert(pos, item);

                    //Cambiamos el campo "Numero" que indica el ordenamiento de los items
                    this.listView1.Items[pos].SubItems[0].Text = (pos + 1).ToString();
                    this.listView1.Items[pos + 1].SubItems[0].Text = (pos + 2).ToString();

                    this.listView1.Focus();
                    this.listView1.Items[pos].Selected = true;

                    //Actualizamos la lista de imágenes:
                    this.ActualizarListaImagenes();
                }
            }
        }

        /// <summary>
        /// Evento que se activa al presionar el botón this.buttonAbajo, para cambiar el orden de las imágenes en el listView
        /// </summary>
        private void buttonAbajo_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count == 1)
            {
                ListViewItem item = this.listView1.SelectedItems[0];

                //Si no es el último item (ya que no se puede bajar más):
                if (item.Index < (this.listView1.Items.Count - 1))
                {
                    int pos = item.Index + 1;

                    //"Corremos" el item hacia abajo:
                    this.listView1.Items.RemoveAt(item.Index);
                    this.listView1.Items.Insert(pos, item);

                    //Cambiamos el campo "Numero" que indica el ordenamiento de los items
                    this.listView1.Items[pos].SubItems[0].Text = (pos + 1).ToString();
                    this.listView1.Items[pos - 1].SubItems[0].Text = (pos).ToString();

                    this.listView1.Focus();
                    this.listView1.Items[pos].Selected = true;

                    //Actualizamos la lista de imágenes:
                    this.ActualizarListaImagenes();
                }
            }
        }

        /// <summary>
        /// Botón que permite agregar una o más imágenes
        /// </summary>
        private void buttonAgregarImagenes_Click(object sender, EventArgs e)
        {
            //Abrimos la ventana de diálogo para cargar las imágenes
            OpenFileDialog op = new OpenFileDialog();
            op.Multiselect = true;
            DialogResult result = op.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                string[] url = op.FileNames;
                for (int i = 0; i < url.Length; i++)
                {
                    ListViewItem fila = new ListViewItem((this.listView1.Items.Count + 1).ToString());
                    fila.SubItems.Add(Path.GetFileName(url[i]));
                    fila.SubItems.Add(url[i]);
                    this.listView1.Items.Add(fila);
                }
                //Seleccionamos el primer elemento del ListView:
                this.listView1.Focus();
                this.listView1.Items[0].Selected = true;

                //Actualizamos la lista de imágenes:
                this.ActualizarListaImagenes();
            }
        }

        /// <summary>
        /// Evento que se activa al presionar el botón this.buttonEliminarImagen
        /// </summary>
        private void buttonEliminarImagen_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count == 1)
            {
                int posBorrada = this.listView1.SelectedItems[0].Index;
                this.listView1.Items.RemoveAt(posBorrada);//(Borramos el item)

                //Si no es el último item (ya que no se puede bajar más):
                if ((this.listView1.Items.Count) > 0) //(Hay más de un item en la lista)
                {
                    //Cambiamos el campo "Numero" que indica el ordenamiento de los items:
                    for (int i = posBorrada; i < (this.listView1.Items.Count); i++)
                    {
                        this.listView1.Items[i].SubItems[0].Text = (i + 1).ToString();
                    }
                    //Seleccionamos el primer elemento del ListView:
                    this.listView1.Focus();
                    this.listView1.Items[0].Selected = true;

                }
                else
                    this.campaniaDeslizante1.Stop();

                //Actualizamos la lista de imágenes:
                this.ActualizarListaImagenes();
            }
        }

        /// <summary>
        /// Evento que se activa al presionar el botón this.buttonVistaPrevia
        /// </summary>
        private void buttonVistaPrevia_Click(object sender, EventArgs e)
        {
            //Cambiamos la habilitacion del listview y demás botones:
            this.listView1.Enabled = !this.listView1.Enabled;
            this.buttonAgregarImagenes.Enabled = !this.buttonAgregarImagenes.Enabled;
            this.buttonEliminarImagen.Enabled = !this.buttonEliminarImagen.Enabled;
            this.buttonArriba.Enabled = !this.buttonArriba.Enabled;
            this.buttonAbajo.Enabled = !this.buttonAbajo.Enabled;
            this.textBoxSegundos.Enabled = !this.textBoxSegundos.Enabled;

            //De acuerdo a si está funcionando o no, cambiamos la imagen del botón, y le damos Start o Stop
            if (!this.campaniaDeslizante1.Funcionando)
            {
                //Cambiamos la imagen del botón this.buttonVistaPrevia a "Pausa":
                //this.buttonVistaPrevia.BackgroundImage = global::UI.Properties.Resources.Pausa1;

                if (this.textBoxSegundos.Text.Length > 0)
                    this.campaniaDeslizante1.Start(this.ListaImagenes, Convert.ToInt32(this.textBoxSegundos.Text));
                else
                    this.campaniaDeslizante1.Start(this.ListaImagenes, 0);
            }
            else
            {
                this.campaniaDeslizante1.Stop();
                //Cambiamos la imagen del botón this.buttonVistaPrevia a "Play":
                //this.buttonVistaPrevia.BackgroundImage = global::UI.Properties.Resources.Play1;
            }
        }
        #endregion


        
        /// <summary>
        /// Permite actualizar el atributo que contiene la lista de imágenes (this.ListaImagenes)
        /// </summary>
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

        /// <summary>
        /// Evento que se activa cuando se selecciona otra item de la lista
        /// </summary>
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count == 1)
            {
                //Al seleccionar una nueva línea, se actualiza el pictureBox:
                this.campaniaDeslizante1.Start(ConversorImagen.ImageToByte(this.listView1.SelectedItems[0].SubItems[2].Text));
            }
        }

       
    }
}
