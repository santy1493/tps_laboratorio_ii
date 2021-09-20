using System;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        #region Constructores

        public Operando()
        {
            this.numero = 0;
        }

        private string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }

        public Operando(double numero)
        {
            this.numero = numero;
        }

        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }

        #endregion

        /// <summary>
        /// Valida que el string ingresado se pueda convertir en double
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns>
        private double ValidarOperando(string strNumero)
        {
            double numero = 0;
            double.TryParse(strNumero, out numero);

            return numero;
        }


        #region Sobrecarga de operadores

        public static double operator +(Operando numero1, Operando numero2)
        {
            return numero1.numero + numero2.numero;
        }

        public static double operator -(Operando numero1, Operando numero2)
        {
            return numero1.numero - numero2.numero;
        }

        public static double operator *(Operando numero1, Operando numero2)
        {
            return numero1.numero * numero2.numero;
        }

        public static double operator /(Operando numero1, Operando numero2)
        {
            if (numero2.numero == 0)
                return double.MinValue;

            return numero1.numero / numero2.numero;

        }

        #endregion


        #region Operaciones con Binarios

        /// <summary>
        /// Valida que el numero es binario
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>true si es binario, de lo contrario false</returns>
        private bool EsBinario(string binario)
        {
            char letra;
            int contador = 0;

            for (int i = 0; i < binario.Length; i++)
            {
                letra = binario[i];

                if (binario[i] == '0' || binario[i] == '1')
                    contador++;
            }

            return binario.Length == contador;
        }

        /// <summary>
        /// Convierte el numero binario en decimal
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>El numero decimal, de lo contrario "Valor invalido"</returns>
        public string BinarioDecimal(string binario)
        {
            double sumaDecimal = 0;
            char[] arrayBinario = binario.ToCharArray();
            Array.Reverse(arrayBinario);

            if (EsBinario(binario))
            {
                for (int i = 0; i < arrayBinario.Length; i++)
                {
                    if (arrayBinario[i] == '1')
                    {
                        sumaDecimal += Math.Pow(2, i);
                    }
                }

                return sumaDecimal.ToString();
            }

            return "Valor invalido";
        }

        /// <summary>
        /// Convierte el numero decimal en binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>El numero binario, de lo contrario "Valor invalido"</returns>
        public string DecimalBinario(double numero)
        {

            if (numero > 0)
            {
                string binario = "";
                while (numero > 0)
                {
                    if (numero % 2 == 0)
                    {
                        binario = "0" + binario;
                    }
                    else
                    {
                        binario = "1" + binario;
                    }
                    numero = (int)(numero / 2);
                }

                return binario;
            }
            else
            {
                if (numero == 0)
                {
                    return "0";
                }
                else
                {
                    return "Valor invalido";
                }
            }
        }

        public string DecimalBinario(string numero)
        {
            this.Numero = numero;

            return DecimalBinario(this.numero);
        }

        #endregion
    }
}
