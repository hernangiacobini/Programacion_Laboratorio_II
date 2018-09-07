using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora

    {
        public static double Operar(string numero1, string numero2, string operador)
        {
            ValidarOperador(operador);

            double resultado = 0;
            if (operador == "+")
            {
                resultado = int.Parse(numero1) + int.Parse(numero2);
            }
            else if (operador == "-")
            {
                resultado = int.Parse(numero1) - int.Parse(numero2);
            }
            else if (operador == "*")
            {
                resultado = int.Parse(numero1) * int.Parse(numero2);
            }
            else if (operador == "/")
            {
                resultado = int.Parse(numero1) / int.Parse(numero2);
            }
            return resultado;
        }

        private static string ValidarOperador(string operador)
        {
            if (operador != "+" && operador != "-" && operador != "*" && operador != "/")
            {
                return "+";
            }
            else return operador;
        }
    }
}
