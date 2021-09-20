using System;

namespace Entidades
{
    public static class Calculadora
    {
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

        private static char ValidarOperador(char operador)
        {
            if (operador != '+' && operador != '-' && operador != '*' && operador != '/')
                return '+';

            return operador;
        }

    }
}
