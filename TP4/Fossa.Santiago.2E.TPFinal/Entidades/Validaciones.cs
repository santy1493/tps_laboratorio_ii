using System.Text.RegularExpressions;

namespace Entidades
{
    public static class Validaciones
    {
        /// <summary>
        /// Metodo de extension para los tipos string. Convierte todas las letras en mayuscula
        /// </summary>
        /// <param name="str">string al que se le quiere dar formato</param>
        /// <returns>Retorna el string con todas sus letras en mayuscula</returns>
        public static string DarFormatoNombre(this string str)
        {
            string nombre = str.ToUpper();
            return nombre;
        }

        /// <summary>
        /// Valida que un string contenga solo letras
        /// </summary>
        /// <param name="palabra">string que se quiere validar</param>
        /// <returns>Retorna true si tiene solo letras, false si contiene otro caracter</returns>
        public static bool ValidarSoloLetras(string palabra)
        {
            //Regex Val = new Regex(@"^[a-zA-Z\s}]+$");
            Regex Val = new Regex(@"^[a-zA-ZñÑ\s}]+$");

            return Val.IsMatch(palabra);
        }

        /// <summary>
        /// Valida que un string pueda ser convertido a long
        /// </summary>
        /// <param name="numero">string que se quiere validar</param>
        /// <returns>Devuelve true si se pudo convertir a long, false si no se pudo convertir</returns>
        public static bool ValidarLong(string numero)
        {
            return long.TryParse(numero, out long resultado);
        }
    }
}
