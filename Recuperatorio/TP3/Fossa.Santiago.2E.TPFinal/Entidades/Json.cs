using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;


namespace Entidades
{
    public static class Json
    {
        /// <summary>
        /// Serializa una lista de tipo generica y la guarda en un archivo de tipo json
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lista"></param>
        /// <param name="nombreArchivo"></param>
        public static void Serializar<T>(List<T> lista, string nombreArchivo)
        {

            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                    + @"\Archivos TP3\JSON\";

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                path += $@"{nombreArchivo}_" + DateTime.Now.ToString("HH_mm_ss") + ".json";

                JsonSerializerOptions opciones = new JsonSerializerOptions();
                opciones.WriteIndented = true;

                string jsonString = JsonSerializer.Serialize(lista, opciones);

                File.WriteAllText(path, jsonString);

            }
            catch (ArgumentOutOfRangeException)
            {
                throw new ArgumentOutOfRangeException();
            }


        }
        public static void Deserializar()
        {

        }

    }
}
