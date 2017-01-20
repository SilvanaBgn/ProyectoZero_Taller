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

namespace UI
{
    public partial class PruebaCampaniaDeslizante : Form
    {
        private List<string> rutas;
        private Campania iCampania;

        public PruebaCampaniaDeslizante()
        {
            InitializeComponent();
            this.rutas = new List<string>();
            this.rutas.Add("gato.jpg");
            this.rutas.Add("Innovación.png");
            this.iCampania = new Campania()
            {
                CampaniaId=1,
                FechaInicio = DateTime.Today,
                FechaFin = DateTime.Today,
                HoraInicio = new TimeSpan(2, 0, 0),
                HoraFin = new TimeSpan(9, 0, 0),
                Titulo = "Campania1",
                Descripcion = "desc1",
                DuracionImagen = 2
            };
            
            for (int i = 0; i < this.rutas.Count; i++)
            {
                byte[] bytes = this.ImageToByte(this.rutas[i].ToString());

                Imagen imgAAgregar = new Imagen()
                {
                    CampaniaId = this.iCampania.CampaniaId,
                    Bytes = bytes,
                    Orden = i,
                    Campania = this.iCampania
                };

                this.iCampania.Imagenes.Add(imgAAgregar);
            }
            
            this.campaniaDeslizante1.Enabled = false;
        }

        public byte[] ImageToByte(string pImagen)
        {
            FileStream stream = new FileStream(pImagen, FileMode.Open, FileAccess.Read);
            //Se inicailiza un flujo de archivo con la imagen seleccionada desde el disco.
            BinaryReader br = new BinaryReader(stream);
            FileInfo fi = new FileInfo(pImagen);

            //Se inicializa un arreglo de Bytes del tamaño de la imagen
            byte[] binData = new byte[stream.Length];
            //Se almacena en el arreglo de bytes la informacion que se obtiene del flujo de archivos(foto)
            //Lee el bloque de bytes del flujo y escribe los datos en un búfer dado.
            stream.Read(binData, 0, Convert.ToInt32(stream.Length));
            return binData;
        }

        private void buttonComenzar_Click(object sender, EventArgs e)
        {
            this.campaniaDeslizante1.Campania = this.iCampania;
            this.campaniaDeslizante1.Start();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            this.campaniaDeslizante1.Stop();
        }
    }
}
