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
        private IEnumerable<ItemRss> ItemsRss;

        public IEnumerable<Item> ItemRss_a_Item()
        {
            //foreach (var item in this.ItemsRss)
            //{
            //    //Hacer la conversión
            //    new Item();
            //}

            return new List<Item>();
        }

        public IEnumerable<Item> Leer(String pUrl)
        {
                    this.ItemsRss = this.Leer(new Uri(pUrl));
            //if (String.IsNullOrWhiteSpace(pUrl)) //Comprobarlo con una expresión regular!!

            return this.ItemRss_a_Item();
        }

        private IEnumerable<ItemRss> Leer(Uri pUrl)
        {
            if (pUrl == null)
            {
                throw new ArgumentNullException("pUrl");
            }

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

            XmlTextReader mXmlReader = new XmlTextReader(pUrl.AbsoluteUri);

            XmlDocument mRssXmlDocument = new XmlDocument();

            mRssXmlDocument.Load(mXmlReader);

            IList<ItemRss> mRssItems = new List<ItemRss>();

            foreach (XmlNode bRssXmlItem in mRssXmlDocument.SelectNodes("//channel/item"))
            {
                mRssItems.Add(new ItemRss
                {
                    Titulo = LectorRss.GetXmlNodeValue<String>(bRssXmlItem, "title"),
                    Descripcion = LectorRss.GetXmlNodeValue<String>(bRssXmlItem, "description"),
                    Url = new Uri(LectorRss.GetXmlNodeValue<String>(bRssXmlItem, "link")).ToString(),
                    FechaDePublicacion = LectorRss.GetXmlNodeValue<DateTime?>(bRssXmlItem, "pubDate")
                });
            }

            return mRssItems;
        }

        private static TResult GetXmlNodeValue<TResult>(XmlNode pParentNode, String pChildNodeName)
        {
            if (pParentNode == null)
            {
                throw new ArgumentNullException("pParentNode");
            }

            if (String.IsNullOrWhiteSpace(pChildNodeName))
            {
                throw new ArgumentException("pChildNodeName");
            }

            // Inicialmente se devuelve el valor por defecto del tipo genérico. 
            // Si es un objeto, este valor es null, en caso contrario depende del tipo.
            TResult mResult = default(TResult);

            // Tipo utilizado para la conversión final. Por defecto va a ser 
            // el mismo tipo genérico indicado.
            Type mConvertToType = typeof(TResult);

            XmlNode mChildNode = pParentNode.SelectSingleNode(pChildNodeName);

            // Si el nodo existe, entonces se obtiene el valor del texto del mismo 
            // para convertirlo al tipo genérico indicado.
            if (mChildNode != null)
            {
                // Se comprueba si el tipo es Nullable, ya que en dicho caso se debe 
                // convertir al tipo subyacente y no directamente al Nullable.
                if (Nullable.GetUnderlyingType(mConvertToType) != null)
                {
                    mConvertToType = Nullable.GetUnderlyingType(mConvertToType);
                }

                // Se realiza la conversión del texto del nodo al tipo adecuado, ya sea 
                // el tipo genérico indicado o bien al tipo subyacente del Nullable.
                mResult = (TResult)Convert.ChangeType(mChildNode.InnerText.Trim(), mConvertToType);
            }

            return mResult;
        }

    }
}
