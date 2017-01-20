using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Dominio;
using Helper;
using Excepciones;

namespace UI
{
    public partial class VCampaniaNueva : VAbstractCampania
    {
        private Campania iCampaniaNueva;

        public VCampaniaNueva(ref ControladorDominio pControlador)
            : base(ref pControlador)
        {
            InitializeComponent();
            
            this.comboBoxH1.SelectedIndex = 0;
            this.comboBoxH2.SelectedIndex = 0;
            this.comboBoxM1.SelectedIndex = 0;
            this.comboBoxM2.SelectedIndex = 0;
        }

        /// <summary>
        /// Evento que invoca el this.timer1, utilizado para emular cómo se verían las imágenes de la campania
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
                    this.pictureBoxCampania.Load(this.iListaCampanias[this.iIndice]);
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
            try
            {
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
                    }
                    this.listBoxImagenes.SelectedIndex = 0;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Se produjo un error al cargar las imagenes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento que se activa al guardar los cambios
        /// </summary>
        protected override void buttonGuardar_Click(object sender, EventArgs e)
        {
            //EXCEPCIONES:
            //todos los campos commpletados
            //this.listBoxCampania con al menos un item
            //this.dateTimePickerInicio <= this.dateTimePickerFin
            //que los comboBox de la hora de inicio sean menores a los de la hora de fin
            //No debe existir otra campania en los horarios definidos por la nueva.
            //No debe existir una carpeta con el mismo nombre a crear
            try
            {
                this.ValidarTodoCompleto();
                this.iCampaniaNueva = new Campania();

                this.iCampaniaNueva.Titulo = this.textBoxTitulo.Text;
                this.iCampaniaNueva.Descripcion = this.textBoxDescripcion.Text;
                this.iCampaniaNueva.DuracionImagen = Convert.ToInt16(this.textBoxSegundos.Text);

                this.iCampaniaNueva.FechaInicio = this.dateTimePickerInicio.Value.Date;
                this.iCampaniaNueva.FechaFin = this.dateTimePickerFin.Value.Date;

                this.iCampaniaNueva.HoraInicio = new TimeSpan(Convert.ToInt16(this.comboBoxH1.SelectedItem), Convert.ToInt16(this.comboBoxM1.SelectedItem), 0);
                if (Convert.ToInt16(this.comboBoxH2.SelectedItem) == 0 && Convert.ToInt16(this.comboBoxM2.SelectedItem) == 0)
                    this.iCampaniaNueva.HoraFin = new TimeSpan(23, 59, 59);
                else
                    this.iCampaniaNueva.HoraFin = new TimeSpan(Convert.ToInt16(this.comboBoxH2.SelectedItem), Convert.ToInt16(this.comboBoxM2.SelectedItem), 0);

                if (this.iCampaniaNueva.HoraInicio >= this.iCampaniaNueva.HoraFin)
                {
                    throw new ExcepcionHoraInicioMayorAHoraFin("La hora de inicio debe ser menor que la hora de fin");
                }

                List<Imagen> listaImagenes = new List<Imagen>();

                for (int i = 0; i < this.listBoxImagenes.Items.Count; i++)
                {
                    byte[] bytes = ConversorImagen.ImageToByte(this.listBoxImagenes.Items[i].ToString());

                    Imagen imgAAgregar = new Imagen()
                    {
                        Bytes = bytes,
                        Orden = i
                    };
                    listaImagenes.Add(imgAAgregar);
                }

                this.iCampaniaNueva.Imagenes = listaImagenes;

                this.iControladorDominio.AgregarCampania(this.iCampaniaNueva);
                this.iControladorDominio.GuardarCambios();
                this.Close();
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
                string curItem = this.listBoxImagenes.SelectedItem.ToString();
                this.pictureBoxCampania.Load(curItem);
            }
        }
    }
}

