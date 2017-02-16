using System;
using System.Collections.Generic;
using Dominio;
using System.Xml;

namespace Dominio.Lecturas
{
    /// <summary>
    /// Lector de RSS, que procesa directamente el XML en bruto de la fuente.
    /// </summary>
    public class LectorRss:ILector
    {
        public IEnumerable<Item> Leer(String pUrl)
        {
            IEnumerable<Item> items = new List<Item>();
            try
            {
                if (String.IsNullOrWhiteSpace(pUrl)) //Comprobarlo con una expresión regular
                    if (String.IsNullOrWhiteSpace(pUrl))
                    {
                        throw new ArgumentNullException("Debe ingresar una URL");
                    }

                Uri urlCorrecta;

                if (!Uri.TryCreate(pUrl.Trim(), UriKind.Absolute, out urlCorrecta))
                {
                    throw new UriFormatException("La URL ingresada no es válida.");
                }

                items = this.ItemRss_a_Item(this.Leer(urlCorrecta));
        }
            catch (ArgumentNullException) { } //Si pUrl es un string nulo
            catch (UriFormatException) { } //Si pUrl no cumple con l formato de una URL
            catch (Exception) { }
            //Si todo salió bien:
            return items;
        }






        private IEnumerable<Item> ItemRss_a_Item(IEnumerable<ItemRss> pItemsRss)
        {
            IList<Item> listaItems= new List<Item>();
            foreach (var itemRss in pItemsRss)
            {
                Item item = new Item(itemRss.ToString());
                listaItems.Add(item);
            }
            return listaItems;
        }
        
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
            //try
            //{
                xmlDocument.Load(xmlReader);

                foreach (XmlNode itemXml in xmlDocument.SelectNodes("//channel/item"))
                {
                    items.Add(new ItemRss
                    {
                        Titulo = LectorRss.GetXmlNodeValue<string>(itemXml, "title"),
                        Descripcion = LectorRss.GetXmlNodeValue<string>(itemXml, "description"),
                        Url = new Uri(LectorRss.GetXmlNodeValue<string>(itemXml, "link")).ToString(),
                        FechaDePublicacion = LectorRss.GetXmlNodeValue<DateTime?>(itemXml, "pubDate")
                    });
                //}
            }
            //catch (Exception) //Averiguar cómo se llama la excepcion cuando no hay internet
            //                  //y otras excepciones
            //{
            //    //Lanzar excepcion entendible para usuario
            //}
            return items;
        }

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
