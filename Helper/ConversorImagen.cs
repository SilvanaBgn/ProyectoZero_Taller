﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace Helper
{
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

        public static Bitmap ByteToImage(byte[] pBytes)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] data = pBytes;
            mStream.Write(data, 0, Convert.ToInt32(data.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;

        }
    }
}
