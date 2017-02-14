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

namespace UI
{
    public partial class PruebaTextoPlano : Form
    {
        public PruebaTextoPlano()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Item> listaItems = new List<Item>();
            for (int i = 0; i < 6; i++)
            {
                Item item = new Item(i.ToString());
                listaItems.Add(item);
            }
            this.textoPlano1.ListaItems = listaItems;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Item> listaItems = new List<Item>();
            listaItems=this.textoPlano1.ListaItems;
        }
    }
}
