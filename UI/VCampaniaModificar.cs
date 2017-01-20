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
using Helper;
using Excepciones;

namespace UI
{
    public partial class VCampaniaModificar : VAbstractCampania
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

        public VCampaniaModificar(ref ControladorDominio pControlador, int pCodigoCampania)
            : base(ref pControlador)
        {
            InitializeComponent();
            this.iCampaniaModificar = this.iControladorDominio.BuscarCampaniaPorId(pCodigoCampania);
            this.iImagenes = new List<string>();
            this.listaAuxiliar = this.iListaOrdenada = new List<Imagen>();
            this.imagenesNuevasAAgregar = new Dictionary<string, Imagen>();

            foreach (var item in this.iCampaniaModificar.Imagenes)
            {
                this.listaAuxiliar.Add((Imagen)item);
            }
        }

        /// <summary>
        /// /// Evento que invoca el this.timer1, utilizado para emular cómo se verían las imágenes de la campania
        /// </summary>
        protected override void timer1_Tick(object sender, EventArgs e)
        {
            if (this.iCount < 1)
            {
                this.iCount++;
            }
            else
            {
                this.iIndice++;
                if (this.iIndice <= this.iListaCampanias.Count - 1)
                {
                    if (this.iListaCampanias[this.iIndice].ToString().Contains("*"))
                    //Si no contiene "*", significa que ese item es un path que refiere a una imagen recientemente agregada (nunca guardada)
                    {
                        int idImagen = Convert.ToInt32(this.iListaCampanias[this.iIndice].ToString().Substring(1));
                        byte[] bytesAConvertir = listaAuxiliar.Find(x => x.ImagenId == idImagen).Bytes;
                        this.pictureBoxCampania.Image =ConversorImagen.ByteToImage(bytesAConvertir);
                    }
                    else
                    {
                        this.pictureBoxCampania.Load(this.iListaCampanias[this.iIndice]);
                    }

                    this.iCount = 0;
                }
                else
                    this.iIndice = -1;
            }
        }

        /// <summary>
        /// Evento que se activa cuando se da click al botón de agregar imágenes al this.listBoxImagenes
        /// </summary>
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
                    if (!this.listBoxImagenes.Items.Contains(item))
                        this.listBoxImagenes.Items.Add(item);
                    this.imagenesNuevasAAgregar.Add(
                        item,
                        new Imagen()
                        {
                            Campania = this.iCampaniaModificar,
                            CampaniaId = this.iCampaniaModificar.CampaniaId,
                            Bytes = ConversorImagen.ImageToByte(item)
                        });

                }
                this.listBoxImagenes.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Evento que se activa al guardar los cambios
        /// </summary>
        protected override void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //Recuperamos de la pantalla, los datos a guardar de la campania
                this.iCampaniaModificar.Descripcion = this.textBoxDescripcion.Text;
                this.iCampaniaModificar.Titulo = this.textBoxTitulo.Text;
                this.iCampaniaModificar.DuracionImagen = Convert.ToInt32(this.textBoxSegundos.Text);
                
                this.iCampaniaModificar.FechaInicio = this.dateTimePickerInicio.Value.Date;
                this.iCampaniaModificar.FechaFin = this.dateTimePickerFin.Value.Date;
                this.iCampaniaModificar.HoraInicio = new TimeSpan(Convert.ToInt16(this.comboBoxH1.SelectedItem), Convert.ToInt16(this.comboBoxM1.SelectedItem), 0);
                if (Convert.ToInt16(this.comboBoxH2.SelectedItem) == 0 && Convert.ToInt16(this.comboBoxM2.SelectedItem) == 0)
                    this.iCampaniaModificar.HoraFin = new TimeSpan(23, 59, 59);
                else
                    this.iCampaniaModificar.HoraFin = new TimeSpan(Convert.ToInt16(this.comboBoxH2.SelectedItem), Convert.ToInt16(this.comboBoxM2.SelectedItem), 0);

                if (this.listBoxImagenes.Items.Count == 0)
                    throw new ExcepcionCampoSinCompletar("Debe cargar al menos una Imagen");
                else
                {

                    for (int i = 0; i < this.listBoxImagenes.Items.Count; i++)
                    {
                        if (this.listBoxImagenes.Items[i].ToString().Contains("*"))
                        {
                            int idImagen = Convert.ToInt32(this.listBoxImagenes.Items[i].ToString().Substring(1));
                            this.iCampaniaModificar.Imagenes.First(x => x.ImagenId == idImagen).Orden = i;
                        }
                        else
                        {
                            string clave = this.listBoxImagenes.Items[i].ToString();
                            this.imagenesNuevasAAgregar[this.listBoxImagenes.Items[i].ToString()].Orden = i;
                        }
                    }

                    foreach (var item in this.imagenesNuevasAAgregar.Values)
                    {
                        this.iCampaniaModificar.Imagenes.Add(item);
                    }

                    //Modificamos y guardamos los cambios
                    this.iControladorDominio.ModificarCampania(iCampaniaModificar);
                    this.iControladorDominio.GuardarCambios();
                    this.Close();
                }
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ExcepcionCampoSinCompletar ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ExcepcionHoraInicioMayorAHoraFin ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ExcepcionErrorAlGuardar ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ExcepcionAlCargarPantalla ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento que se activa cuando cambia el item seleccionado en el this.listBoxImagenes
        /// </summary>
        protected override void listBoxImagenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listBoxImagenes.SelectedItem != null)
            {
                if (!this.listBoxImagenes.SelectedItem.ToString().Contains("*"))
                {
                    string curItem = this.listBoxImagenes.SelectedItem.ToString();
                    this.pictureBoxCampania.Load(curItem);
                }
                else
                {
                    int idImagen = Convert.ToInt32(this.listBoxImagenes.SelectedItem.ToString().Substring(1));
                    byte[] bytesAConvertir = listaAuxiliar.Find(x => x.ImagenId == idImagen).Bytes;
                    this.pictureBoxCampania.Image = ConversorImagen.ByteToImage(bytesAConvertir);
                }
            }
        }

        /// <summary>
        /// Evento que se activa al presionar el botón buttonBorrarImagenes
        /// </summary>
        protected override void buttonBorrar_Click(object sender, EventArgs e)
        {
            if (this.listBoxImagenes.SelectedItem != null)
            {
                //Se hace la distinción de si el item contiene o no el "*", para la decisión de la forma correcta de borrado del mismo
                if (!this.listBoxImagenes.SelectedItem.ToString().Contains("*"))
                {
                    this.imagenesNuevasAAgregar.Remove(this.listBoxImagenes.SelectedItem.ToString());
                    base.buttonBorrar_Click(sender, e);
                }
                else
                {
                    int idImagen = Convert.ToInt32(this.listBoxImagenes.SelectedItem.ToString().Substring(1));
                    base.buttonBorrar_Click(sender, e);

                    var imagen = this.iCampaniaModificar.Imagenes.First(x=>x.ImagenId==idImagen);

                    this.iCampaniaModificar.Imagenes.Remove(imagen);
                }
            }
        }

        /// <summary>
        /// Evento que se activa cuando se carga por primera vez esta ventana
        /// </summary>
        private void VModificarCampania_Load(object sender, EventArgs e)
        {
            //Cargamos los datos en la pantalla
            this.textBoxDescripcion.Text = this.iCampaniaModificar.Descripcion;
            this.textBoxSegundos.Text = this.iCampaniaModificar.DuracionImagen.ToString();
            this.dateTimePickerInicio.Text = this.iCampaniaModificar.FechaInicio.ToString();
            this.dateTimePickerFin.Text = this.iCampaniaModificar.FechaFin.ToString();
            this.textBoxTitulo.Text = this.iCampaniaModificar.Titulo;
            this.comboBoxH1.Text = this.iCampaniaModificar.HoraInicio.Hours.ToString();
            this.comboBoxM1.Text = this.iCampaniaModificar.HoraInicio.Minutes.ToString();
            if (this.iCampaniaModificar.HoraFin.Hours == 23 && this.iCampaniaModificar.HoraFin.Minutes == 59)
            {
                this.comboBoxH2.Text = "00";
                this.comboBoxM2.Text = "00";
            }
            else
            {
                this.comboBoxH2.Text = this.iCampaniaModificar.HoraFin.Hours.ToString();
                this.comboBoxM2.Text = this.iCampaniaModificar.HoraFin.Minutes.ToString();
            }

            //Ordenamos las imágnenes para que se muestren ordenadas en la pantalla
            this.iListaOrdenada =  this.iCampaniaModificar.Imagenes.OrderBy(x=>x.Orden).ToList();

            foreach (Imagen item in this.iListaOrdenada)
            {
                this.listBoxImagenes.Items.Add("*" + item.ImagenId);
            }

            if (this.listBoxImagenes.Items.Count > 0)
                this.listBoxImagenes.SelectedIndex = 0;
        }

    }
}