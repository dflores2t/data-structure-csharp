using System.Collections;
using System.Diagnostics;

namespace data_structure_01_intro
{
  //PROBLEMA: MAXIMA SUBSUMA, tenemos una serie de numeros y hay que encontrar
  //el subconjunto de numeros contiguos que al sumarlos nos den el maximo valo posible
  // 4,-3,5,-2,-1,2,6,-2: 
  class program
  {
    private static ArrayList a = new ArrayList();
    private static Random rnd = new Random();
    // private static int[] a = { 4, -3, 5, -2, -1, 2, 6, -2 };
    static void Main(string[] args)
    {
      Stopwatch sw = new Stopwatch();
      creaLista(5000);

      //variables
      int sumaActual = 0;
      int maximaSuma = 0;
      int n = 0;
      int m = 0;
      int o = 0;

      // int cantidad = a.Length;
      int cantidad = a.Count;
      //Algoricmo uno, 7 lineas 
      maximaSuma = 0;
      #region Algoritmo numero 1

      sw.Start();
      for (n = 0; n < cantidad; n++)
      {
        for (m = 0; m < cantidad; m++)
        {
          sumaActual = 0;
          for (o = n; o <= m; o++)
          {
            sumaActual += (int)a[o];
            if (sumaActual > maximaSuma)
            {
              maximaSuma = sumaActual;
            }
          }
        }
      }
      sw.Stop();
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("Algoritmo uno; la sumo es {0}", maximaSuma);
      Console.WriteLine("Para {0} tomo {1:N0}", cantidad, sw.ElapsedTicks);
      Console.WriteLine("---");
      sw.Reset();
      #endregion

      #region Algoritom Numero dos
      //algoritmo numero dos: 6 lineas
      sumaActual = 0;
      maximaSuma = 0;
      sw.Start();
      for (n = 0; n < cantidad; n++)
      {
        sumaActual = 0;
        for (m = n; m < cantidad; m++)
        {
          sumaActual += (int)a[m];
          if (sumaActual > maximaSuma)
          {
            maximaSuma = sumaActual;
          }
        }
      }
      sw.Stop();
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Algoritmo numero dos: la suma es {0}", maximaSuma);
      Console.WriteLine("para {0} elementos tomo {1:N0}", cantidad, sw.ElapsedTicks);
      Console.WriteLine("---");
      sw.Reset();
      #endregion

      #region Algoritmo Numero 3
      //algoritmo numero 3: 34 lineas en las funciones.
      maximaSuma = 0;
      sw.Start();
      maximaSuma = maxsubsum(0, cantidad - 1);
      sw.Stop();
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("Algoritmo tres, la suma es {0}", maximaSuma);
      Console.WriteLine("Para {0} elementos tomo {1:N0}", cantidad, sw.ElapsedTicks);
      Console.WriteLine("---");
      sw.Reset();
      #endregion

      #region  Algoritmo numero 4
      //algoritmo numer 4: 6 lineas.
      sumaActual = 0;
      maximaSuma = 0;
      m = 0;
      sw.Start();
      for (m = 0; m < cantidad; m++)
      {
        sumaActual += (int)a[m];
        if (sumaActual > maximaSuma)
          maximaSuma = sumaActual;
        else if (sumaActual < 0)
          sumaActual = 0;
      }
      sw.Stop();
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("algoritmo cuatro, la suma es {0}", maximaSuma);
      Console.WriteLine("para {0} elementos tomo {1:N0}", cantidad, sw.ElapsedTicks);
      Console.WriteLine("---");
      sw.Reset();
      #endregion

    }

    public static int maxsubsum(int left, int right)
    {
      int maxleftsum = 0;
      int maxrightsum = 0;
      int maxleftbordersum = 0;
      int maxrightbordersum = 0;
      int leftboredersum = 0;
      int rightbordersum = 0;
      int center = 0;
      int i = 0;
      if (left == right)
      {
        if (((int)a[left]) > 0)
        {
          return (int)a[left];
        }
        else
        {
          return 0;
        }
      }
      center = (left + right) / 2;
      maxleftsum = maxsubsum(left, center);
      maxrightsum = maxsubsum(center + 1, right);
      maxleftbordersum = 0;
      leftboredersum = 0;
      for (i = center; i >= left; i--)
      {
        leftboredersum += (int)a[i];
        if (leftboredersum > maxleftbordersum)
        {
          maxleftbordersum = leftboredersum;
        }
      }
      maxrightbordersum = 0;
      rightbordersum = 0;
      for (i = center + 1; i <= right; i++)
      {
        rightbordersum += (int)a[i];
        if (rightbordersum > maxrightbordersum)
        {
          maxrightbordersum = rightbordersum;
        }
      }
      return max3(maxleftsum, maxrightsum, maxleftbordersum + maxrightsum);
    }

    public static int max3(int a, int b, int c)
    {
      if (a >= b && a >= c)
        return a;
      if (b >= a && b >= c)
        return b;
      if (c >= a && c >= b)
        return c;

      return a;
    }

    public static void creaLista(int cantidad)
    {
      a = new ArrayList();
      for (int i = 0; i < cantidad; i++)
      {
        a.Add(rnd.Next(100));
      }
      // Console.WriteLine("Listado de numeros a sumar");
      // foreach (var item in a)
      // {
      //   Console.Write("{0:N0}, ", item);
      // }
      // Console.WriteLine();
      // Console.ReadKey();
    }

  }
}
