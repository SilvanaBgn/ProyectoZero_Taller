﻿using System;
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
using HelperUI;

namespace UI.UserControls
{
    /// <summary>
    /// UserControl que establece una estructura y un comportamiento para gestionar las imágenes que se quieren
    /// seleccionar utilizar en una campania deslizante
    /// </summary>
    public partial class Galeria : UserControl
    {
        /// <summary>
        /// Atributo que mantiene actualizadas la lista de imágenes del listView
        /// </summary>
        private List<Imagen> iListaImagenes;


        //CONSTRUCTOR
        public Galeria()
        {
            InitializeComponent();
            //Inicializamos la lista de imágenes:
            this.ActualizarListaImagenes();
            this.comboBoxSegundos.DropDownStyle = ComboBoxStyle.DropDownList;
        }



        #region Eventos privados BOTONES
        /// <summary>
        /// Evento que se activa al presionar el botón this.buttonArriba, para cambiar el orden de las imágenes en el listView
        /// </summary>
        private void buttonArriba_Click(object sender, EventArgs e)
        {
            if (this.listView.SelectedItems.Count == 1)
            {
                ListViewItem item = this.listView.SelectedItems[0];

                //Si no es el primer item (ya que no se puede subir más):
                if (item.Index > 0)
                {
                    int pos = item.Index - 1;

                    //"Corremos" el item hacia arriba:
                    this.listView.Items.RemoveAt(item.Index);
                    this.listView.Items.Insert(pos, item);

                    //Cambiamos el campo "Numero" que indica el ordenamiento de los items
                    this.listView.Items[pos].SubItems[0].Text = (pos + 1).ToString();
                    this.listView.Items[pos + 1].SubItems[0].Text = (pos + 2).ToString();

                    this.listView.Focus();
                    this.listView.Items[pos].Selected = true;
                }
            }
        }

        /// <summary>
        /// Evento que se activa al presionar el botón this.buttonAbajo, para cambiar el orden de las imágenes en el listView
        /// </summary>
        private void buttonAbajo_Click(object sender, EventArgs e)
        {
            if (this.listView.SelectedItems.Count == 1)
            {
                ListViewItem item = this.listView.SelectedItems[0];

                //Si no es el último item (ya que no se puede bajar más):
                if (item.Index < (this.listView.Items.Count - 1))
                {
                    int pos = item.Index + 1;

                    //"Corremos" el item hacia abajo:
                    this.listView.Items.RemoveAt(item.Index);
                    this.listView.Items.Insert(pos, item);

                    //Cambiamos el campo "Numero" que indica el ordenamiento de los items
                    this.listView.Items[pos].SubItems[0].Text = (pos + 1).ToString();
                    this.listView.Items[pos - 1].SubItems[0].Text = (pos).ToString();

                    this.listView.Focus();
                    this.listView.Items[pos].Selected = true;
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
            op.Filter = "Archivos de imagen (*.jpg, *.png) | *.jpg; *.png";
            //op.Filter = "Extension .jpg (.jpg)| *.jpg|Extension .png (.png) | *.png" ;
            op.Multiselect = true;
            DialogResult result = op.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                string[] url = op.FileNames;
                for (int i = 0; i < url.Length; i++)
                {
                    ListViewItem fila = new ListViewItem((this.listView.Items.Count + 1).ToString());
                    fila.SubItems.Add(Path.GetFileName(url[i]));
                    fila.SubItems.Add(ConversorImagen.GetString(ConversorImagen.ImageToByte(url[i])));
                    this.listView.Items.Add(fila);
                }
                //Seleccionamos el primer elemento del ListView:
                this.listView.Focus();
                this.listView.Items[0].Selected = true;
            }
        }

        /// <summary>
        /// Evento que se activa al presionar el botón this.buttonEliminarImagen
        /// </summary>
        private void buttonEliminarImagen_Click(object sender, EventArgs e)
        {
            if (this.listView.SelectedItems.Count == 1)
            {
                int posBorrada = this.listView.SelectedItems[0].Index;
                this.listView.Items.RemoveAt(posBorrada);//(Borramos el item)

                //Si no es el último item (ya que no se puede bajar más):
                if ((this.listView.Items.Count) > 0) //(Hay más de un item en la lista)
                {
                    //Cambiamos el campo "Numero" que indica el ordenamiento de los items:
                    for (int i = posBorrada; i < (this.listView.Items.Count); i++)
                    {
                        this.listView.Items[i].SubItems[0].Text = (i + 1).ToString();
                    }
                    //Seleccionamos el primer elemento del ListView:
                    this.listView.Focus();
                    this.listView.Items[0].Selected = true;

                }
                else
                    this.campaniaDeslizante.Stop();
            }
        }

        /// <summary>
        /// Evento que se activa al presionar el botón this.buttonVistaPrevia
        /// </summary>
        private void buttonVistaPrevia_Click(object sender, EventArgs e)
        {
            //Cambiamos la habilitacion del listview y demás botones:
            this.listView.Enabled = !this.listView.Enabled;
            this.buttonAgregarImagenes.Enabled = !this.buttonAgregarImagenes.Enabled;
            this.buttonEliminarImagen.Enabled = !this.buttonEliminarImagen.Enabled;
            this.buttonArriba.Enabled = !this.buttonArriba.Enabled;
            this.buttonAbajo.Enabled = !this.buttonAbajo.Enabled;
            this.comboBoxSegundos.Enabled = !this.comboBoxSegundos.Enabled;

            //De acuerdo a si está funcionando o no, cambiamos la imagen del botón, y le damos Start o Stop
            if (!this.campaniaDeslizante.Funcionando)
            {
                //Actualizamos la lista de imágenes y la devolvemos:
                this.ActualizarListaImagenes();

                //Cambiamos la imagen del botón this.buttonVistaPrevia a "Pausa":
                this.buttonVistaPrevia.BackgroundImage = global::UI.Properties.Resources.Pausa1;

                if (Convert.ToInt32(this.comboBoxSegundos.SelectedItem) > -1)
                    this.campaniaDeslizante.Start(this.iListaImagenes, Convert.ToInt32(this.comboBoxSegundos.SelectedItem));
                else
                    this.campaniaDeslizante.Start(this.iListaImagenes, 0);
            }
            else
            {
                this.campaniaDeslizante.Stop();
                //Cambiamos la imagen del botón this.buttonVistaPrevia a "Play":
                this.buttonVistaPrevia.BackgroundImage = global::UI.Properties.Resources.Play1;
            }
        }

        /// <summary>
        /// Evento que se activa cuando se selecciona otra item de la lista
        /// </summary>
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listView.SelectedItems.Count == 1)
            {
                //Al seleccionar una nueva línea, se actualiza el pictureBox:
                this.campaniaDeslizante.Start(ConversorImagen.GetBytes(this.listView.SelectedItems[0].SubItems[2].Text));
            }
        }
        #endregion


        #region Funciones Auxiliares (privadas)
        /// <summary>
        /// Permite actualizar las imágenes del this.iListaImagenes, de manera que estén disponibles ante un Get
        /// </summary>
        private void ActualizarListaImagenes()
        {
            this.iListaImagenes = new List<Imagen>();
            for (int i = 0; i < this.listView.Items.Count; i++)
            {
                Imagen imagen = new Imagen();
                imagen.Orden = Convert.ToInt16(this.listView.Items[i].SubItems[0].Text); //SubItems[0]= Numero
                imagen.Descripcion = this.listView.Items[i].SubItems[1].Text; //SubItems[1]= Nombre
                imagen.Bytes = ConversorImagen.GetBytes(this.listView.Items[i].SubItems[2].Text); //SubItems[2]= Url
                this.iListaImagenes.Add(imagen);
            }
        }

        /// <summary>
        /// Permite cargar el listView con las imágenes actuales en el this.iListaImagenes
        /// </summary>
        private void CargarListView()
        {
            for (int i = 0; i < this.iListaImagenes.Count; i++)
            {
                ListViewItem fila = new ListViewItem((i + 1).ToString());                  
                fila.SubItems.Add(this.iListaImagenes[i].Descripcion);
                //ConversorImagen.ImageToByte(this.listView1.Items[i].SubItems[2].Text)
                fila.SubItems.Add(ConversorImagen.GetString(this.iListaImagenes[i].Bytes));
                this.listView.Items.Add(fila);
            }
            //Seleccionamos el primer elemento del ListView:
            this.listView.Focus();
            this.listView.Items[0].Selected = true;
        }
        #endregion


        #region PROPERTIES
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Imagen> ListaImagenes
        {
            get
            {
                //Actualizamos la lista de imágenes y la devolvemos:
                this.ActualizarListaImagenes();
                return this.iListaImagenes;
            }
            set
            {
                this.iListaImagenes = value;
                this.CargarListView();
            }
        }
        public int Segundos
        {

            get
            {
                return Convert.ToInt32(this.comboBoxSegundos.SelectedItem);
            }
            set { this.comboBoxSegundos.SelectedIndex = value - 1; }
        }
        #endregion
    }
}
