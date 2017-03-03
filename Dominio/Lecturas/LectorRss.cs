using System;
using System.Collections.Generic;
using Dominio;
using System.Xml;

namespace Dominio.Lecturas
{
    /// <summary>
    /// Lector de RSS, que procesa directamente el XML en bruto de la fuente.
    /// </summary>
    public class LectorRss : ILector
    {
        /// <summary>
        /// Lee una URL válida 
        /// </summary>
        /// <param name="pUrl">String de la URL a leer</param>
        /// <returns>devuelve una colección de los elementos que contiene la URL</returns>
        public IEnumerable<Item> Leer(String pUrl)
        {
            IEnumerable<Item> items = new List<Item>();

            Uri urlCorrecta;
            if(Uri.TryCreate(pUrl.Trim(), UriKind.Absolute, out urlCorrecta))
                items = this.ItemRss_a_Item(this.Leer(urlCorrecta));

            return items;
        }

        /// <summary>
        /// Pasa de Item RSS a Item
        /// </summary>
        /// <param name="pItemsRss">colección de Item RSS</param>
        /// <returns>devuelve una colección de items con la descripción del Item RSS</returns>
        private IEnumerable<Item> ItemRss_a_Item(IEnumerable<ItemRss> pItemsRss)
        {
            IList<Item> listaItems = new List<Item>();
            foreach (var itemRss in pItemsRss)
            {
                Item item = new Item(itemRss.ToString());
                listaItems.Add(item);
            }
            return listaItems;
        }

        /// <summary>
        /// Lee una URL
        /// </summary>
        /// <param name="pUrl">URL a leer</param>
        /// <returns>devuelve una colección de los elementos que contiene la URL</returns>
        private IEnumerable<ItemRss> Leer(Uri pUrl)
        {
            // Se recupera el XML desde la URL, y se parsea el mismo para obtener los diferentes ítems. El modelo de XML
            // utilizado es el siguiente (http://www.w3schools.com/xml/xml_rss.asp):
            //<?xml version="1.0" encoding="UTF-8"?>
            //<rss version = "2.0">
            //  <channel>
            //    <title> W3Schools Home Page</title>
            //    <link> http://www.w3schools.com</link>
            //    <description> Free web building tutorials </description>
            //    <item>
            //        <title>RSS Tutorial</title>
            //        <link>http://www.w3schools.com/xml/xml_rss.asp</link>
            //        <description> New RSS tutorial on W3Schools</ description >
            //    </item>
            //    <item>
            //    <title>XML Tutorial</title>
            //        <link>http://www.w3schools.com/xml</link>
            //        <description> New XML tutorial on W3Schools</description>
            //    </item>
            //  </channel>
            //</rss>

            XmlTextReader xmlReader = new XmlTextReader(pUrl.AbsoluteUri);
            XmlDocument xmlDocument = new XmlDocument();
            IList<ItemRss> items = new List<ItemRss>();
            xmlDocument.Load(xmlReader);

            foreach (XmlNode itemXml in xmlDocument.SelectNodes("//channel/item"))
            {
                items.Add(new ItemRss
                {
                    Titulo = LectorRss.GetXmlNodeValue<string>(itemXml, "title"),
                    Descripcion = LectorRss.GetXmlNodeValue<string>(itemXml, "description"),
                    Url = new Uri(LectorRss.GetXmlNodeValue<string>(itemXml, "link")).ToString()
                });
            }
            return items;
        }

        /// <summary>
        /// Mátodo genérico. Obtiene el valor XML de un nodo
        /// </summary>
        /// <param name="pNodoPadre">nodo padre</param>
        /// <param name="pNombreNodoHijo">nombre del nodo hijo</param>
        private static TResult GetXmlNodeValue<TResult>(XmlNode pNodoPadre, String pNombreNodoHijo)
        {
            if (pNodoPadre == null)
            {
                throw new ArgumentNullException("pNodoPadre");
            }

            if (String.IsNullOrWhiteSpace(pNombreNodoHijo))
            {
                throw new ArgumentException("pNombreNodoHijo");
            }

            // Inicialmente se devuelve el valor por defecto del tipo genérico. 
            // Si es un objeto, este valor es null, en caso contrario depende del tipo.
            TResult result = default(TResult);

            // Tipo utilizado para la conversión final. Por defecto va a ser 
            // el mismo tipo genérico indicado.
            Type tipo = typeof(TResult);

            XmlNode nodoHijo = pNodoPadre.SelectSingleNode(pNombreNodoHijo);

            // Si el nodo existe, entonces se obtiene el valor del texto del mismo 
            // para convertirlo al tipo genérico indicado.
            if (nodoHijo != null)
            {
                // Se comprueba si el tipo es Nullable, ya que en dicho caso se debe 
                // convertir al tipo subyacente y no directamente al Nullable.
                if (Nullable.GetUnderlyingType(tipo) != null)
                {
                    tipo = Nullable.GetUnderlyingType(tipo);
                }
                // Se realiza la conversión del texto del nodo al tipo adecuado, ya sea 
                // el tipo genérico indicado o bien al tipo subyacente del Nullable.
                result = (TResult)Convert.ChangeType(nodoHijo.InnerText.Trim(), tipo);
            }
            return result;
        }

    }
}
