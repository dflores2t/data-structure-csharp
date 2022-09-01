namespace DataStructurePrefixPostfix;
using System;


public class Program
{
  static void Main(string[] args)
  {
    //EVALUAMOS POSTFIX

    CStack miStack = new CStack();
    int n = 0;
    int a = 0;
    int b = 0;
    int r = 0;

    //-+3*52*73
    //352*+73*-

    string expresion = "-+3*52*73";
    char caracter = ' ';
    for (n = expresion.Length - 1; n >= 0; n--)//prefixCStack1
    // for (n = 0; n < expresion.Length; n++)  //postfix
    {
      //obtenemo el caracter
      caracter = expresion[n];

      //verificamos si es numero
      if (caracter >= '0' && caracter <= '9')
      {
        //lo colocamos en el stack
        miStack.Push(Convert.ToInt32(caracter.ToString()));
      }
      else
      { //es operador
        //hacemos dos pop, postfix b ->a
        //prefix a -> b
        // b = miStack.Pop();
        // a = miStack.Pop();
        a = miStack.Pop();
        b = miStack.Pop();
        // verificamos que operador es y aplicamos la operacion.
        if (caracter == '+')
        {
          r = a + b;
          miStack.Push(r);
        }
        if (caracter == '-')
        {
          r = a - b;
          miStack.Push(r);
        }
        if (caracter == '/')
        {
          r = a / b;
          miStack.Push(r);
        }
        if (caracter == '*')
        {
          r = a * b;
          miStack.Push(r);
        }
      }
    }
    miStack.Transversa();
  }
}