namespace DataStructureRecursion01;

public class Program
{
  /// <summary>
  /// ENTENDIENDO LA RECURSION
  /// CASO INDUCTIVO.
  /// CASO BASE
  /// EJEMPLO DE FACTORIAL
  /// EJEMPLO DE FIBONACCI 
  /// </summary>
  /// 
  static void Main(string[] args)
  {
    //recursion resuelve un problema haciendo uso de una version mas  sencilla del mismo.
    //la recursividad tiene dos partes:
    //Parte Inductiva - Caso Base.
    int f = 0;

    //5! = 5*4*3*2*1
    f = Factorial(4);
    Console.WriteLine(f);


    int f1 = 0;
    f1 = Fib(14);
    Console.WriteLine(f1);

    Console.ReadKey();
  }

  public static int Factorial(int n)
  {
    int r = 0;
    //caso inductivo
    if (n > 0)
    {
      r = n * Factorial(n - 1);
    }

    //CASO BASE
    if (n == 1)
    {
      r = 1;
    }
    return r;
  }

  public static int Fib(int n){
    int r = 0;
    //CASO INDUCTIVO
    if(n > 1){
      r = Fib(n - 1) + Fib(n - 2);
    }

    //CASO BASE
    if(n <= 1){
      r = 1;
    }
    return r;
  }
}