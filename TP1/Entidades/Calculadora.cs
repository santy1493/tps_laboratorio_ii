using System;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Valida el operador y realiza la operacion entre los dos numeros
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns>El resultado de la operacion</returns>
        public static double Operar(Operando numero1, Operando numero2, char operador)
        {
            char opcion = ValidarOperador(operador);
            double resultado = 0;

            switch (opcion)
            {
                case '+':
                    resultado = numero1 + numero2;
                    break;
                case '-':
                    resultado = numero1 - numero2;
                    break;
                case '*':
                    resultado = numero1 * numero2;
                    break;
                case '/':
                    resultado = numero1 / numero2;
                    break;
            }

            return resultado;
        }

        /// <summary>
        /// Valida el operador sea '+', '-', '/' o '*'. De lo contrario retorna '+'
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns>
        private static char ValidarOperador(char operador)
        {
            if (operador != '+' && operador != '-' && operador != '*' && operador != '/')
                return '+';

            return operador;
        }

    }
}
