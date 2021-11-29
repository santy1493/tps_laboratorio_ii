using System;
using System.IO;
using System.Xml.Serialization;

namespace Entidades
{
    public static class Xml
    {
        /// <summary>
        /// Serializa un objetop de tipo generico en XML y lo guarda en la carpeta "Archivos TP3" en el escritorio.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="objeto">objeto a guardar</param>
        /// <param name="nombreArchivo">nombre que va a recibir el archivo</param>
        public static void Serializar<T>(T objeto, string nombreArchivo)
        {

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            + @"\Archivos TP4\XML\";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            path += $@"{nombreArchivo}_" + DateTime.Now.ToString("HH_mm_ss") + ".xml";

            using (StreamWriter sw = new StreamWriter(path))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                xmlSerializer.Serialize(sw, objeto);
            }

        }

        /// <summary>
        /// Deserializa "archivo.xml" ubicado en la carpeta de la solucion
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>Devuelve un objeto de tipo generico</returns>
        public static T Deserializar<T>()
            where T : class
        {
            //string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            //+ @"\Archivos TP3\archivo.xml";


            string path = @"../../../../archivo.xml";


            using (StreamReader sr = new StreamReader(path))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                T objeto = xmlSerializer.Deserialize(sr) as T;
                return objeto;
            }


        }
    }
}
