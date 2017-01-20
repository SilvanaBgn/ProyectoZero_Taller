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
using UI;

namespace UI
{
    public partial class VNuevaCampania : VAbstractCampania
    {
        List<Imagen> iImagenes;

        public VNuevaCampania(ref ControladorDominio pControlador)
            : base(ref pControlador)
        {
            InitializeComponent();
            //this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            //this.timer1.Interval = 1000;
            this.iImagenes = new List<Imagen>();
            this.comboBoxH1.SelectedIndex = 0;
            this.comboBoxH2.SelectedIndex = 0;
            this.comboBoxM1.SelectedIndex = 0;
            this.comboBoxM2.SelectedIndex = 0;
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
                    this.pictureBox1.Load(this.iCampania[this.iIndice]);
                    this.iCount = 0;
                }
                else
                    this.iIndice = -1;
            }
        }

        protected override void buttonAgregar_Click(object sender, EventArgs e)
        {
            //EXCEPCIONES: si se produce un error al cargar las imagenes
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
                }
                this.listBox1.SelectedIndex = 0;
            }
        }


        protected override void buttonGuardar_Click(object sender, EventArgs e)
        {
            //EXCEPCIONES:
            //todos los campos commpletados
            //this.listBoxCampania con al menos un item
            //this.dateTimePickerInicio <= this.dateTimePickerFin
            //que los comboBox de la hora de inicio sean menores a los de la hora de fin
            //No debe existir otra campania en los horarios definidos por la nueva.
            //No debe existir una carpeta con el mismo nombre a crear
            Campania nuevaCampania = new Campania()
            {
                FechaInicio = this.dateTimePickerInicio.Value.Date,
                FechaFin = this.dateTimePickerFin.Value.Date,
                HoraInicio = new TimeSpan(Convert.ToInt32(this.comboBoxH1.SelectedItem),
                    Convert.ToInt32(this.comboBoxM1.SelectedItem), 0),
                HoraFin = new TimeSpan(Convert.ToInt32(this.comboBoxH2.SelectedItem),
                    Convert.ToInt32(this.comboBoxM2.SelectedItem), 0),
                Titulo = this.textBoxTitulo.Text,
                Descripcion = this.textBoxDescripcion.Text,
                DuracionImagen = Convert.ToInt16(this.textBoxSegundos.Text)
            };




            for (int i = 0; i < this.listBox1.Items.Count; i++)
            {
                byte[] bytes = this.iControlador.ImageToByte(this.listBox1.Items[i].ToString());

                Imagen imgAAgregar = new Imagen()
                {
                    CampaniaId = nuevaCampania.CampaniaId,
                    Bytes = bytes,
                    Orden=i
                    //Campania = nuevaCampania
                };
                imgAAgregar.Campania = nuevaCampania;
                this.iImagenes.Add(imgAAgregar);
            }




            //foreach (var imagen in this.listBox1.Items)
            //{
            //    byte[] bytes = this.iControlador.ImageToByte(imagen.ToString());

            //    Imagen imgAAgregar = new Imagen()
            //    {
            //        CampaniaId = nuevaCampania.CampaniaId,
            //        Bytes = bytes,
            //        //Campania = nuevaCampania
            //    };
            //    imgAAgregar.Campania = nuevaCampania;
            //    this.iImagenes.Add(imgAAgregar);
            //}

            nuevaCampania.Imagenes = this.iImagenes;

            this.iControlador.AgregarCampania(nuevaCampania);
            this.iControlador.GuardarCambios();
            ((VCampania)this.MdiParent).CargarDataGridViewCampania(this.iControlador.ObtenerTodasLasCampanias());
            this.Close();
        }

        protected override void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedItem != null)
            {
                string curItem = this.listBox1.SelectedItem.ToString();
                this.pictureBox1.Load(curItem);
            }
        }

        protected override void buttonArriba_Click(object sender, EventArgs e)
        {
            this.buttonArriba_Click(sender, e);
        }

        protected override void buttonAbajo_Click(object sender, EventArgs e)
        {
            this.buttonAbajo_Click(sender, e);
        }

        protected override void buttonBorrar_Click(object sender, EventArgs e)
        {
            this.buttonBorrar_Click(sender, e);
        }

        protected override void buttonVistaPrevia_Click(object sender, EventArgs e)
        {
            this.buttonVistaPrevia_Click(sender, e);
        }
    }
}

