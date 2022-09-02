namespace DataStructurePrefixPostfix;
using System;


public class Program
{
  static void Main(string[] args)
  {
    //EVALUAMOS POSTFIX

    // CStack miStack = new CStack();
    // int n = 0;
    // int a = 0;
    // int b = 0;
    // int r = 0;

    // //-+3*52*73
    // //352*+73*-

    // string expresion = "-+3*52*73";
    // char caracter = ' ';
    // for (n = expresion.Length - 1; n >= 0; n--)//prefixCStack1
    // // for (n = 0; n < expresion.Length; n++)  //postfix
    // {
    //   //obtenemo el caracter
    //   caracter = expresion[n];

    //   //verificamos si es numero
    //   if (caracter >= '0' && caracter <= '9')
    //   {
    //     //lo colocamos en el stack
    //     miStack.Push(Convert.ToInt32(caracter.ToString()));
    //   }
    //   else
    //   { //es operador
    //     //hacemos dos pop, postfix b ->a
    //     //prefix a -> b
    //     // b = miStack.Pop();
    //     // a = miStack.Pop();
    //     a = miStack.Pop();
    //     b = miStack.Pop();
    //     // verificamos que operador es y aplicamos la operacion.
    //     if (caracter == '+')
    //     {
    //       r = a + b;
    //       miStack.Push(r);
    //     }
    //     if (caracter == '-')
    //     {
    //       r = a - b;
    //       miStack.Push(r);
    //     }
    //     if (caracter == '/')
    //     {
    //       r = a / b;
    //       miStack.Push(r);
    //     }
    //     if (caracter == '*')
    //     {
    //       r = a * b;
    //       miStack.Push(r);
    //     }
    //   }
    // }
    // miStack.Transversa();

    System.Console.WriteLine("CONVERSION DE INFIX A POSTFIX");
    //modificar la clase nodo para trabajar con char
    //EQUIVALE A 567*+89*
    string exp = "5+6*7-8*9"; //necesita expresiones validas de infix
    //stack
    //res
    string res = "";
    int n1 = 0;
    CStack s = new CStack();
    //recorremos caracter por caracter
    for (n1 = 0; n1 < exp.Length; n1++){
      //verificamos que sea un operando
      if(exp[n1] >='0' && exp[n1]<='9'){
        //lo adicionamos al resultado
        res += exp[n1];
      }
      //entonces es un operador
      else{
        while (!s.StackVacio() && MayorPrecedencia(s.Peek(), exp[n1]))
        {
          //res +=s.Peek();
          //s.Pop();
          res += s.Pop();
        }
        s.Push(exp[n1]);
      }
    }
    while (!s.StackVacio())
    {
      //res += s.Peek();
      //s.Pop();
      res += s.Pop();
    }
    System.Console.WriteLine("{0} en Postfix es: {1}", exp,res);
  }

  public static bool MayorPrecedencia(char a , char b){
    //ojo, es para demostrar como actuar ante diferentes precedencias
    //pero algunos de estos operadores tienen la misma precedencia
    //no estan todos.
    bool resultado = false;
    //es *
    if(a =='*'){
      resultado = true;
    }
    //es /
    if(a == '/'){
      if(b =='*'){
        resultado = false;
      }else{
        resultado = true;
      }
    }
    //es +
    if(a =='+'){
      if(b== '*' || b =='/'){
        resultado = false;
      }else{
        resultado = true;
      }
    }
    //es -
    if(a == '-'){
      resultado = false;
    }
    return resultado;
  }
}