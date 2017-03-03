using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace Helper
{
    /// <summary>
    /// Clase que pone a disposición los métodos para hacer conversiones de tipos de imágenes
    /// </summary>
    public static class ConversorImagen
    {
        /// <summary>
        /// Convierte una imagen de una ruta de archivo en una cadena de bytes
        /// </summary>
        /// <param name="pImagenUrl">Path (ruta de archivo) de la imagen</param>
        /// <returns>Devuelve la cadena de bytes que representa a esa imagen</returns>
        public static byte[] ImageToByte(string pImagenUrl)
        {
            FileStream stream = new FileStream(pImagenUrl, FileMode.Open, FileAccess.Read);
            //Se inicailiza un flujo de archivo con la imagen seleccionada desde el disco.
            BinaryReader br = new BinaryReader(stream);
            FileInfo fi = new FileInfo(pImagenUrl);

            //Se inicializa un arreglo de Bytes del tamaño de la imagen
            byte[] binData = new byte[stream.Length];
            //Se almacena en el arreglo de bytes la informacion que se obtiene del flujo de archivos(foto)
            //Lee el bloque de bytes del flujo y escribe los datos en el buffer dado.
            stream.Read(binData, 0, Convert.ToInt32(stream.Length));
            return binData;
        }

        /// <summary>
        /// Convierte una imagen de tipo BitMap en una cadena de bytes
        /// </summary>
        /// <param name="pBitMap">imagen de tipo BitMap a convertir</param>
        /// <returns>Devuelve la cadena de bytes que representa a esa imagen</returns>
        public static byte[] ImageToByte(Bitmap pBitMap)
        {
            ImageConverter imagenConv = new ImageConverter();
            return (byte[])imagenConv.ConvertTo(pBitMap, typeof(byte[]));
        }

        /// <summary>
        /// Convierte la cadena de bytes de una imagen en un Bitmap, para mostrar en un Picturebox
        /// </summary>
        /// <param name="pBytes">Array de bytes de la imagen</param>
        /// <returns>Devuelve el Bitmap de esa cadena de bytes (de la imagen)</returns>
        public static Bitmap ByteToImage(byte[] pBytes)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] data = pBytes;
            mStream.Write(data, 0, Convert.ToInt32(data.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        /// <summary>
        /// Convierte la cadena de bytes (de una imagen) en un string
        /// </summary>
        /// <param name="pBytes">Cadena de bytes proveniente de una imagen</param>
        public static string GetString(byte[] pBytes)
        {
            bool even = (pBytes.Length % 2 == 0);
            char[] chars = new char[1 + pBytes.Length / sizeof(char) + (even ? 0 : 1)];
            chars[0] = (even ? '0' : '1');
            System.Buffer.BlockCopy(pBytes, 0, chars, 2, pBytes.Length);
            return new string(chars);
        }

        /// <summary>
        /// Convierte el string (de una imagen) en una cadena de bytes
        /// </summary>
        /// <param name="pStr">string que representa a una cadena de bytes de una imagen</param>
        /// <returns>Devuelve la cadena de bytes propiamente dicha</returns>
        public static byte[] GetBytes(string pStr)
        {
            bool even = pStr[0] == '0';
            byte[] bytes = new byte[(pStr.Length - 1) * sizeof(char) + (even ? 0 : -1)];
            char[] chars = pStr.ToCharArray();
            System.Buffer.BlockCopy(chars, 2, bytes, 0, bytes.Length);
            return bytes;
        }

    }
}
