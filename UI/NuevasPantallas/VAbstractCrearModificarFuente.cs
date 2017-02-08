using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.NuevasPantallas
{
    public abstract partial class VAbstractCrearModificarFuente : Form
    {
        public VAbstractCrearModificarFuente()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxTipoFuente.SelectedIndex == 0) //Texto Plano
            {
                this.textoPlano1.Visible = true;
                //this.panelRss.Visible = false;
            }
            else if (this.comboBoxTipoFuente.SelectedIndex == 1) //RSS
            {
                this.textoPlano1.Visible = false;
                //this.panelRss.Visible = true;
            }
        }
    }
}
