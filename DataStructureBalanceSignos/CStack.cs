namespace DataStructureBalanceSignos;

public class CStack
{
  // HACEMOS LA IMPLEMENTACION BASADA EN UNA LISTA LIGADA.
  //FINES EDUCATIVOS C# YA CONTIENE LA CLASE STACK
  private CNodo? ancla;
  //ESTA VARIABLE DE REFERENCIA NOS AYUDA A TRABAJAR CON EL STACK
  private CNodo? trabajo;

  public CStack()
  {
    //instanciamos el ancla
    ancla = new CNodo();

    //como es un stack vacio su siguient es null
    ancla.Siguiente = null;
  }
  //push
  public void Push(char pDato)
  {
    //creamos el nodo temporal
    CNodo? temp = new CNodo();
    temp.Dato = pDato;

    //conectamos el temporal a la lista
    temp.Siguiente = ancla.Siguiente;

    //conectamos el ancla al temporal
    ancla.Siguiente = temp;
  }

  //POR
  public char Pop()
  {
    //esta version no contiene codigo de seguridad
    //colocar una excepcion cuando se intente hacer un pop a un stack vacio
    char valor = ' ';
    //llevamos a cabo el trabajo solo si hay elementos en el stack
    if (ancla.Siguiente != null)
    {
      //obtenemos el dato correspondiente
      trabajo = ancla.Siguiente;
      valor = trabajo.Dato;

      //lo sacamos del stack
      ancla.Siguiente = trabajo.Siguiente;
      trabajo.Siguiente = null;
    }
    return valor;
  }

  //PEEK
  public char Peek()
  {
    //esta version no contiene codigo de seguridad.
    //colocar la excepicon cuando se intete hacer un pop a un stack vacio
    char valor = ' ';
    //llevamos a cabo el trabao solo si hay elementos en el stakc
    if (ancla.Siguiente != null)
    {
      //obtenemos el dato correspondiente.
      trabajo = ancla.Siguiente;
      valor = trabajo.Dato;
    }
    return valor;
  }

  //TRANSVERSA
  public void Transversa()
  {
    //trabajo al inicio
    trabajo = ancla;
    //recorremos hasta encontrar el final
    while (trabajo.Siguiente != null)
    {
      //avanzamos trabajo
      trabajo = trabajo.Siguiente;
      //obtenemos el dato y lo mostramos
      char d = trabajo.Dato;
      Console.WriteLine("[{0}] ", d);
    }
  }
  //saber si el stack esta vacio
  public bool StackVacio()
  {
    return ancla.Siguiente == null ? true : false;
  }



}