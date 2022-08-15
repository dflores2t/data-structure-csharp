namespace DataStructureBalanceSignos;


class Program
{
  static void Main()
  {
    int a = (5 + (3 * 2));
    string expresion = "";
    char s = ' ';
    CStack pila = new CStack();

    //pedimos la expresion a evaluar
    Console.WriteLine("Dame la expresion a evaluar");
    expresion = Console.ReadLine();
    foreach (char c in expresion)
    {
      //verificamos que sea simobolo de apertura
      if (c == '(' || c == '{' || c == '[')
      {
        //lo colocamos en es stack
        pila.Push(c);
      }
      //verificamos que sea simbolo de cierre
      if (c == ')' || c == '}' || c == ']')
      {
        if (pila.StackVacio())
        {
          Console.WriteLine("===Exceso de simbolos de cierre===");
        }
        else
        {
          //obtenemos el caracter correspondiente
          s = pila.Pop();
          //verificamos que se tenga coincidencia
          if (s == '(' && c != ')')
          {
            Console.WriteLine("Se Esperaba )");
          }
          if (s == '{' && c != '}')
          {
            Console.WriteLine("Se Esperaba }");
          }
          if (s == '[' && c != ']')
          {
            Console.WriteLine("Se Esperaba ]");
          }
        }
      }
    }
    if (pila.StackVacio() == false)
    {
      Console.WriteLine("===Exceso de simbolos de apertura ===");
    }
  }
}