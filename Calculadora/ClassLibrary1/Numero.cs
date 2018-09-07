using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
  class Numero
  {
    private double numero;

    public string DecimalBinario(double numero)
    {
        double resto = numero % 2;
        double resultado = numero / 2;
        string acumuladorBinario = resto.ToString();

        do
        {
          resto = resultado % 2;
          resultado = resultado / 2;
          acumuladorBinario = acumuladorBinario + resto.ToString();
        } while (resultado >= 1);

        string auxiliar = "";
        int i;
        int tamano = acumuladorBinario.Length;
        for (i = tamano; i >= 1; i--)
        {
          auxiliar = auxiliar + acumuladorBinario.ElementAt(i - 1);
        }
        Console.WriteLine("{0}", acumuladorBinario);
        Console.WriteLine("{0}", auxiliar);
        Console.ReadKey();

        return acumuladorBinario;
    }

    //public static double operator +(Numero n1, Numero n2)
    //{

    //}

    public void Method()
    {
      throw new System.NotImplementedException();
    }

    //private double ValidarNumero(string strNumero)
    //{
      
    //}
  }
}
