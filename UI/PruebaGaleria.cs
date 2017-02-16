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
using Helper;
using System.IO;

namespace UI
{
    public partial class PruebaGaleria : Form
    {
        public PruebaGaleria()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Imagen> listaImagenes = new List<Imagen>();

            OpenFileDialog op = new OpenFileDialog();
            op.Multiselect = true;
            DialogResult result = op.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                string[] url = op.FileNames;
                for (int i = 0; i < url.Length; i++)
                {
                    Imagen imagen = new Imagen();
                    imagen.Orden = Convert.ToInt16((i + 1).ToString()); //Orden
                    imagen.Descripcion = Path.GetFileName(url[i]); //Nombre
                    imagen.Bytes = ConversorImagen.ImageToByte(url[i]); //Bytes
                    listaImagenes.Add(imagen);
                }
            }

            this.galeria1.ListaImagenes = listaImagenes;
        }
    }
}
