
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Dominio.Lecturas;
using System.ComponentModel.DataAnnotations.Schema;
using Excepciones.ExcepcionesDominio;

namespace Dominio
{
    public class FuenteInformacion
    {
        /// <summary>
        /// Esta clase representa la información que tiene el objeto fuente del banner
        /// </summary>
        public int FuenteId { get; set; }

        /// <summary>
        /// Denominación o explicación específica de la fuente
        /// </summary>
        //[DataType(DataType.Text),Required/*(ErrorMessage = "Debe completarse Descripción")*/]
        [Required]
        [StringLength(100)]
        public string Descripcion { get; set; }



        public virtual ICollection<Banner> Banners { get; set; }

        public virtual ICollection<ItemFuenteInformacion> Items { get; set; }



        /// <summary>
        /// Indica el método de lectura de esta fuente, según su Tipo
        /// </summary>
        [NotMapped]
        private ILectorFuenteInformacion iLector { get; set; }

        private TipoFuente iTipo;

        public TipoFuente Tipo
        {
            get { return this.iTipo; }

            set
            {

                if (value == TipoFuente.Rss)
                {
                    this.iLector = new LectorRss();
                }
                else //(value == TipoFuente.TextoFijo)
                {
                    this.iLector = null; //Porque el texto fijo no tiene comportamiento adicional
                }
                this.iTipo = value;
            }
        }


        private string iOrigenItems;

        /// <summary>
        /// Información especifica de la Fuente en cuestión
        /// </summary>
        //[RegularExpression(@"^http(s)?://([\w-]+.)+[\w-]+(/[\w- ./?%&=])?$", ErrorMessage = "You can not have that")]
        [StringLength(100)]
        [Required]
        public string OrigenItems //{ get; set; }
        {
            get { return this.iOrigenItems; }
            set
            {
                try
                {
                    if (this.iTipo == TipoFuente.Rss)
                    {
                        Uri urlCorrecta;

                        if (!Uri.TryCreate(value.Trim(), UriKind.Absolute, out urlCorrecta))
                        {
                            throw new UriFormatException();
                        }
                        else
                            this.iOrigenItems = value.Trim();
                    }
                    else // this.iTipo == TipoFuente.TextoFijo
                        this.iOrigenItems = "Sin fuente";
                }
                catch (UriFormatException)
                { throw new ExcepcionFormatoURLIncorrecto("La URL ingresada no es válida. El formato correcto es http://www.ejemplo.com/"); }
            }
        }


        /// <summary>
        /// Constructor para el caso del texto fijo, donde no hay origen de items
        /// </summary>
        public FuenteInformacion() : this("", "Sin fuente", TipoFuente.TextoFijo)
        { }

        /// <summary>
        /// Constructor de una fuente para el caso que tenga un origen de items
        /// </summary>
        public FuenteInformacion(string pDescripcion, string pOrigenItems, TipoFuente pTipo)
        {
            this.Banners = new List<Banner>();
            this.Items = new List<ItemFuenteInformacion>();
            this.iTipo = pTipo;
            this.Descripcion = pDescripcion;
            this.iOrigenItems = pOrigenItems;
        }

        /// <summary>
        /// Sobreescribe el método ToString de fuente
        /// </summary>
        /// <returns>devuelve la descripción de la fuente</returns>
        public override string ToString()
        {
            return this.Descripcion;
        }

        /// <summary>
        /// Lee los datos y actualiza el atributo Items
        /// </summary>
        public void Leer()
        {
            try
            {
                //Con la siguiente sentencia, lee y asigna los items:
                if (this.iLector != null)
                {
                    List<ItemFuenteInformacion> listaLeida = new List<ItemFuenteInformacion>();
                    listaLeida = (List<ItemFuenteInformacion>)this.iLector.Leer(this.iOrigenItems);
                    if (listaLeida.Count > 0)
                        this.Items = listaLeida;
                }
            }
            catch (Exception ex) //excepcion cuando no hay internet u otra.. entendible para el usuario..=> No leyó
            {
                throw new ExcepcionErrorDeLectura("No se pudo leer la fuente",ex);
            }
        }
    }
}
