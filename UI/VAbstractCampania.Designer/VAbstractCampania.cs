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

namespace UI
{
    public partial class VAbstractCampania : Form
    {
        protected ControladorDominio iControlador;
        protected List<String> iCampania;
        protected int iIndice, iCount;

        //public int Indice { get {return this.iIndice;} set {} }
        //public int Count { get { return this.iCount; } set {} }
        //public List<String> Campania { get { return this.iCampania; } set{} }

        public VAbstractCampania()
        {
            InitializeComponent();
        }

        public VAbstractCampania(ref ControladorDominio pControlador) :this()
        {
            this.iControlador = pControlador;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.iIndice = this.iCount = 0;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            this.timer1.Interval = 1000;
            this.iCampania = new List<string>();
        }

        protected virtual void timer1_Tick(object sender, EventArgs e)
        {
            //nuevacampania overridea mostrando solo imagenes nuevas desde el path
            //modificarcampania muestra del path y desde los bytes
        }

        protected virtual void buttonAgregar_Click(object sender, EventArgs e)
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

        protected virtual void buttonGuardar_Click(object sender, EventArgs e)
        {
            //VNuevaCampania overridea esto guardando una campania de cero, NModificarCampania lo overridea guardando el obj modificado
        }

        protected virtual void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected virtual void buttonArriba_Click(object sender, EventArgs e)
        {
            object item = listBox1.SelectedItem;
            if (listBox1.SelectedIndex > 0)
            {
                string curItem = item.ToString();
                listBox1.Items[listBox1.SelectedIndex] = listBox1.Items[listBox1.SelectedIndex - 1];
                listBox1.Items[listBox1.SelectedIndex - 1] = curItem;
                listBox1.SelectedItem = item;
            }
        }

        protected virtual void buttonAbajo_Click(object sender, EventArgs e)
        {
            object item = listBox1.SelectedItem;
            if (listBox1.SelectedIndex < listBox1.Items.Count - 1)
            {
                string curItem = item.ToString();
                listBox1.Items[listBox1.SelectedIndex] = listBox1.Items[listBox1.SelectedIndex + 1];
                listBox1.Items[listBox1.SelectedIndex + 1] = curItem;
                listBox1.SelectedItem = item;
            }
        }

        protected virtual void buttonBorrar_Click(object sender, EventArgs e)
        {
            //posibles excepciones:
            //que haya mas de un item seleccionado, o ninguno.
            if (this.listBox1.SelectedItems.Count == 1)
                this.listBox1.Items.Remove(this.listBox1.SelectedItem);

            if (this.listBox1.Items.Count > 0)
                this.listBox1.SelectedIndex = 0;

            else
                this.pictureBox1.Load(Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())) + "/icono/NoImage.png");
        }

        protected virtual void buttonVistaPrevia_Click(object sender, EventArgs e)
        {
            //EXCEPCION!: que los segundos del intervalo sean mayores a 5 y menores a 30 (por ejemplo)

            if (listBox1.Items.Count > 0)
            {
                if (!timer1.Enabled)
                {
                    this.buttonVistaPrevia.Name="Detener";
                    this.iCampania.Clear();
                    foreach (var item in this.listBox1.Items)
                    {
                        this.iCampania.Add(item.ToString());
                    }
                    if (textBoxSegundos.Text != "")
                        timer1.Interval = Convert.ToInt32(this.textBoxSegundos.Text) * 1000;
                    listBox1.Enabled = false;
                    timer1.Start();
                }
                else
                {
                    this.buttonVistaPrevia.Name = "Vista previa";
                    timer1.Stop();
                    listBox1.Enabled = true;
                }
            }

        }

        private void VAbstractCampania_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((VCampania)this.MdiParent).CargarDataGridViewCampania(this.iControlador.ObtenerTodasLasCampanias());
        }
    }
}
