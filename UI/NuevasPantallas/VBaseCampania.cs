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
    public partial class VBaseCampania : VAbstractBase
    {
        public VBaseCampania()
        {
            InitializeComponent();
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {

        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(this.dataGridViewMostrar.SelectedRows[0].Cells[0].Value.ToString());
            this.iControladorDominio.BorrarBanner(codigo);
        }

    }
}
