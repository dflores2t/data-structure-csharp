namespace DataStructureQueue;

public class CQueue{
  // HACEMOS LA IMPLEMENTACION BASADA EN UNA LISTA LIGADA.
  //FINES EDUCATIVOS C# YA CONTIENE LA CLASE STACK
  CNodo? ancla;
  //ESTA VARIABLE DE REFERENCIA NOS AYUDA A TRABAJAR CON EL STACK
  CNodo? trabajo;

  public CQueue()
  {
    //instanciamos el ancla
    ancla = new CNodo();

    //como es un stack vacio su siguient es null
    ancla.Siguiente = null;
  }
  //ENQUEUE
  public void Enqueue(int pDato){
    //trabajo al inicio
    trabajo = ancla;
    //recorremos hasta encontrar el final
    while(trabajo.Siguiente !=null){
      //avanzamos trabajo
      trabajo = trabajo.Siguiente;
    }
    //creamos el nuevo nodo
    CNodo temp = new CNodo();
    //insertamos el dato
    temp.Dato = pDato;
    //finalizamos correctamente
    temp.Siguiente = null;

    //ligamos el ultimo nodo encontrado con el recien creado
    trabajo.Siguiente = temp;
  }

  //DEQUEUE
  public int Dequeue(){
    //esta version no contiene codigo de seguridad
    //colocar una excepcion cuando se intente hacer un dequeue a un queue vacio
    int valor = 0;
    //llevamos a cabo el trabajo solo si hay elementos en el queue
    if(ancla.Siguiente != null){
      //obtenemos el dato correspondiente
      trabajo = ancla.Siguiente;
      valor = trabajo.Dato;

      //lo sacamos del queue
      ancla.Siguiente = trabajo.Siguiente;
      trabajo.Siguiente = null;
    }
    return valor;
  }

  //Peek
  public int Peek(){
    //esta version no contiene codigo de seguridad.
    //colocar la excepicon cuando se intete hacer un pop a un queue vacio
    int valor = 0;
    //llevamos a cabo el trabao solo si hay elementos en el queue
    if(ancla.Siguiente !=null){
      //obtenemos el dato correspondiente.
      trabajo = ancla.Siguiente;
      valor = trabajo.Dato;
    }
    return valor;
  }

  //TRANSVERSA
  public void Transversa(){
    //trabajo al inicio
    trabajo = ancla;
    //recorremos hasta encontrar el final
    while(trabajo.Siguiente != null){
      //avanzamos trabajo
      trabajo = trabajo.Siguiente;
      //obtenemos el dato y lo mostramos
      int d = trabajo.Dato;
      Console.Write("<= {0} ", d);
    }
      Console.WriteLine();
  }




}