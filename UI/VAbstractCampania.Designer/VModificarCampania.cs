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
using System.IO;
using UI;

namespace UI
{
    public partial class VModificarCampania : VAbstractCampania
    {
        private Campania iCampaniaModificar;

        /// <summary>
        /// Lista que posee las imagenes en el orden en que se van a mostrar en el listbox
        /// </summary>
        private List<Imagen> iListaOrdenada;

        private List<string> iImagenes;
        /// <summary>
        /// Lista de las imagenes actuales de la campania (actuales al momento de abrir esta ventana)
        /// Se usa cuando se debe mostrar una imagen en el pictureBox, ya sea en el evento 
        /// listBox1_SelectedIndexChanged o cuando hay que hacer una vista previa de las imagenes.
        /// Las imagenes de esta lista que necesiten ser mostradas, se cargarán en el pictureBox mediante
        /// sus bytes y no mediante el path (como si lo hacen las nuevas imagenes agregadas).
        /// Se hace uso de ésta lista para no tener que buscar en tiempo real la imagen a mostrar,
        /// lo que, al tener muchas imagenes, puede aumentar el tiempo de espera.
        /// </summary>
        private List<Imagen> listaAuxiliar;

        /// <summary>
        /// En este diccionario se guardan las imagenes nuevas a agregar a la campania. 
        /// Las claves son los path que se indican para buscar la imagen, y el valor es el objeto Imagen
        /// La idea de tener un diccionario es la facilidad para buscar la imagen aun no guardada para borrarla del listbox
        /// Estas imagenes se guardan en la campania una vez que se hace clic en guardar
        /// </summary>
        private Dictionary<string, Imagen> imagenesNuevasAAgregar;

        public VModificarCampania(ref ControladorDominio pControlador, ref Campania pCampania)
            : base(ref pControlador)
        {
            InitializeComponent();
            this.iCampaniaModificar = pCampania;
            this.iImagenes = new List<string>();
            this.listaAuxiliar = this.iListaOrdenada = new List<Imagen>();
            this.imagenesNuevasAAgregar = new Dictionary<string, Imagen>();
            this.comboBoxH1.SelectedIndex = 0;
            this.comboBoxH2.SelectedIndex = 0;
            this.comboBoxM1.SelectedIndex = 0;
            this.comboBoxM2.SelectedIndex = 0;
            foreach (var item in this.iCampaniaModificar.Imagenes)
            {
                this.listaAuxiliar.Add((Imagen)item);
            }
        }

        protected override void timer1_Tick(object sender, EventArgs e)
        {
            if (this.iCount < 1)
            {
                this.iCount++;
            }
            else
            {
                this.iIndice++;
                if (this.iIndice <= this.iCampania.Count - 1)
                {
                    if (this.iCampania[this.iIndice].ToString().Contains("*"))
                    {
                        int idImagen = Convert.ToInt32(this.iCampania[this.iIndice].ToString().Substring(1));
                        byte[] bytesAConvertir = listaAuxiliar.Find(x => x.ImagenId == idImagen).Bytes;
                        this.pictureBox1.Image = this.iControlador.ByteToImage(bytesAConvertir);
                    }
                    else
                    {
                        this.pictureBox1.Load(this.iCampania[this.iIndice]);
                    }

                    this.iCount = 0;
                }
                else
                    this.iIndice = -1;
            }
        }

        protected override void buttonAgregar_Click(object sender, EventArgs e)
        {
            //EXCEPCIONES: si se produce un error al cargar las imagenes
            //si se selecciona una imagen que ya se encuentra en el listbox
            OpenFileDialog op = new OpenFileDialog();
            op.Multiselect = true;
            DialogResult result = op.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                string[] url = op.FileNames;
                foreach (string item in url)
                {
                    if (!this.listBox1.Items.Contains(item))
                        this.listBox1.Items.Add(item);
                    this.imagenesNuevasAAgregar.Add(
                        item,
                        new Imagen()
                        {
                            Campania = this.iCampaniaModificar,
                            CampaniaId = this.iCampaniaModificar.CampaniaId,
                            Bytes = this.iControlador.ImageToByte(item)
                        });

                }
                this.listBox1.SelectedIndex = 0;
            }
        }

        protected override void buttonGuardar_Click(object sender, EventArgs e)
        {
            iCampaniaModificar.FechaInicio = this.dateTimePickerInicio.Value.Date;
            iCampaniaModificar.FechaFin = this.dateTimePickerFin.Value.Date;
            iCampaniaModificar.HoraInicio = new TimeSpan(Convert.ToInt16(this.comboBoxH1.SelectedItem), Convert.ToInt16(this.comboBoxM1.SelectedItem), 0);
            iCampaniaModificar.HoraFin = new TimeSpan(Convert.ToInt16(this.comboBoxH2.SelectedItem), Convert.ToInt16(this.comboBoxM2.SelectedItem), 0);
            iCampaniaModificar.Descripcion = this.textBoxDescripcion.Text;
            iCampaniaModificar.Titulo = this.textBoxTitulo.Text;
            iCampaniaModificar.DuracionImagen = Convert.ToInt32(this.textBoxSegundos.Text);

            for (int i = 0; i < this.listBox1.Items.Count; i++)
            {
                if (this.listBox1.Items[i].ToString().Contains("*"))
                {
                    int idImagen = Convert.ToInt32(this.listBox1.Items[i].ToString().Substring(1));
                    this.iCampaniaModificar.Imagenes.First(x => x.ImagenId == idImagen).Orden = i;
                }
                else
                {
                    string clave = this.listBox1.Items[i].ToString();
                    this.imagenesNuevasAAgregar[this.listBox1.Items[i].ToString()].Orden = i;
                }
            }

            foreach (var item in this.imagenesNuevasAAgregar.Values)
            {
                this.iCampaniaModificar.Imagenes.Add(item);
            }

            this.iControlador.ModificarCampania(iCampaniaModificar);
            this.iControlador.GuardarCambios();
            this.Close();

            //EXCEPCIONES:
            //todos los campos completados
            //this.listBoxCampania con al menos un item
            //this.dateTimePickerInicio <= this.dateTimePickerFin
            //que los comboBox de la hora de inicio sean menores a los de la hora de fin
        }

        protected override void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedItem != null)
            {
                if (!this.listBox1.SelectedItem.ToString().Contains("*"))
                {
                    string curItem = this.listBox1.SelectedItem.ToString();
                    this.pictureBox1.Load(curItem);
                }
                else
                {
                    int idImagen = Convert.ToInt32(this.listBox1.SelectedItem.ToString().Substring(1));
                    byte[] bytesAConvertir = listaAuxiliar.Find(x => x.ImagenId == idImagen).Bytes;
                    this.pictureBox1.Image = this.iControlador.ByteToImage(bytesAConvertir);
                }
            }
        }

        protected override void buttonBorrar_Click(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedItem != null)
            {
                if (!this.listBox1.SelectedItem.ToString().Contains("*"))
                {
                    this.imagenesNuevasAAgregar.Remove(this.listBox1.SelectedItem.ToString());
                    base.buttonBorrar_Click(sender, e);
                }
                else
                {
                    int idImagen = Convert.ToInt32(this.listBox1.SelectedItem.ToString().Substring(1));
                    base.buttonBorrar_Click(sender, e);

                    var imagen = this.iCampaniaModificar.Imagenes.First(x=>x.ImagenId==idImagen);

                    this.iCampaniaModificar.Imagenes.Remove(imagen);
                }
            }
        }

        private void VModificarCampania_Load(object sender, EventArgs e)
        {
            this.textBoxDescripcion.Text = this.iCampaniaModificar.Descripcion;
            this.textBoxSegundos.Text = this.iCampaniaModificar.DuracionImagen.ToString();
            this.dateTimePickerInicio.Text = this.iCampaniaModificar.FechaInicio.ToString();
            this.dateTimePickerFin.Text = this.iCampaniaModificar.FechaFin.ToString();
            this.textBoxTitulo.Text = this.iCampaniaModificar.Titulo;
            this.comboBoxH1.Text = this.iCampaniaModificar.HoraInicio.Hours.ToString();
            this.comboBoxM1.Text = this.iCampaniaModificar.HoraInicio.Minutes.ToString();
            this.comboBoxH2.Text = this.iCampaniaModificar.HoraFin.Hours.ToString();
            this.comboBoxM2.Text = this.iCampaniaModificar.HoraFin.Minutes.ToString();

            this.iListaOrdenada =  this.iCampaniaModificar.Imagenes.OrderBy(x=>x.Orden).ToList();

            foreach (Imagen item in this.iListaOrdenada)
            {
                this.listBox1.Items.Add("*" + item.ImagenId);
            }

            if (this.listBox1.Items.Count > 0)
                this.listBox1.SelectedIndex = 0;
        }

    }
}