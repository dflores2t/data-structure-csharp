using System.Diagnostics;
using System.Collections;

namespace data_structure_01_intro_seconpart
{
  class Program
  {
    static void Main(string[] args)
    {
      /*IMPORTA LA FORMA COMO SE SUMINSTRAN LOS DATOS*/
      
      Random rnd = new Random();
      int n = 0;
      int cantidad = 10000;

      //arreglo aleatorio
      int[] aleatorio = new int[cantidad];

      for (n = 0; n < aleatorio.Length; n++)
      {
        aleatorio[n] = rnd.Next(cantidad);
        //Console.Write("{0}, ", aleatorio);
      }
      Stopwatch sw = new Stopwatch();

      sw.Start();
      Array.Sort(aleatorio);
      sw.Stop();
      Console.WriteLine("Para Aleatorio tomo {0:N0} ", sw.ElapsedTicks);
      sw.Reset();

      //ARREGLO ORDENADO PREVIAMENTE
      int[] ordenado = new int[cantidad];
      for (n = 0; n < ordenado.Length; n++)
      {
        ordenado[n] = n;
        //Console.Write("{0} , ", aleatorio[n]);
      }
      sw.Start();
      Array.Sort(ordenado);
      sw.Stop();
      Console.WriteLine("Para ordenado tomo {0:N0} ", sw.ElapsedTicks);
      sw.Reset();

      //ARREGLO ORDENADO DESCENDENTE PREVIAMENTE
      int[] descendente = new int[cantidad];
      for (n = 0; n < ordenado.Length; n++)
      {
        ordenado[n] = cantidad - n;
        //Console.WriteLine("0", aleatorio[n]);
      }
      sw.Start();
      Array.Sort(descendente);
      sw.Stop();
      Console.WriteLine("Para Descendente tomo {0:N0}", sw.ElapsedTicks);
      sw.Reset();

      //ARREGLO CON TODOS IGUALES
      int[] iguales = new int[cantidad];

      for (n = 0; n < ordenado.Length; n++)
      {
        ordenado[n] = 100;
        // Console.Write("{0} ,", aleatorio[n]);
      }
      sw.Start();
      Array.Sort(iguales);
      sw.Stop();
      Console.WriteLine("Para Iguales tomo {0:N0} ", sw.ElapsedTicks);
      sw.Reset();

      Console.ReadKey();
    }
  }
}