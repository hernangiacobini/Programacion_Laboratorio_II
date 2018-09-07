using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase2
{
  class Conversor
  {
    public static string enteroBinario(int entero)
    {
      
      int resto = entero % 2;
      int resultado = entero/2;
      string acumuladorBinario = resto.ToString();

      do
      {
        resto = resultado % 2;
        resultado = resultado / 2;
        acumuladorBinario = acumuladorBinario + resto.ToString();
      } while (resultado >= 1);

      string auxiliar="";
      int i;
      int tamano = acumuladorBinario.Length;
      for(i=tamano; i >= 1; i--)
      {
        auxiliar = auxiliar + acumuladorBinario.ElementAt(i-1);
      }
      Console.WriteLine("{0}", acumuladorBinario);
      Console.WriteLine("{0}", auxiliar);
      Console.ReadKey();

      return acumuladorBinario;
    }
  }
}
