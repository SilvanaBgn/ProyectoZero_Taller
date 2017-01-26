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
        public Galeria()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = new List<Imagen>();
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
                List<Imagen> listaImagenes = (List<Imagen>)this.dataGridView1.DataSource;
                string[] url = op.FileNames;
                for (int i = 0; i < url.Length; i++)
                {
                    //if (!this.listViewImagenes.Items.Contains(item))
                    Imagen imagen = new Imagen();
                    imagen.Descripcion = Path.GetFileName(url[i]);
                    imagen.Bytes = ConversorImagen.ImageToByte(url[i]);
                    imagen.Orden = i+1;
                    listaImagenes.Add(imagen);
                }
                //Cargamos el datagrid:
                this.CargarDataGrid(listaImagenes);
                //this.listBoxImagenes.SelectedIndex = 0;
            }
        }

        private void CargarDataGrid(List<Imagen> pLista)
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = pLista;

            for (int i = 0; i < this.dataGridView1.Columns.Count; i++)
            {
                this.dataGridView1.Columns[i].Visible = false;
            }
            this.dataGridView1.Columns["Descripcion"].Visible = true;
        }

        /// <summary>
        /// Al seleccionar una nueva línea, se actualiza el pictureBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 1)
                this.campaniaDeslizante1.Image= ConversorImagen.ByteToImage((byte[])this.dataGridView1.SelectedRows[0].Cells["Bytes"].Value);
        }

        private void buttonVistaPrevia_Click(object sender, EventArgs e)
        {
            this.campaniaDeslizante1.Start(Convert.ToInt16(this.textBoxSegundos.Text),
                (List<Imagen>)this.dataGridView1.DataSource);
        }
    }
}
