namespace DataStructureSelectionSort;

public class CListaLigada
{
  //Es el ancla o encabezado de la lista
  private CNodo ancla;

  //esta variable de referencia nos ayuda a trabajar con la lista
  private CNodo? trabajo;

  //esta variabale de referencia apoya en ciertas operaciones de la lista
  private CNodo? trabajo2;

  //constructuro
  public CListaLigada()
  {
    //instanciamos el ancla
    ancla = new CNodo();
    //como es una lista vacia su siguient es null
    ancla.Siguiente = null!;
  }

  //recorre toda la lista
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
      int d = trabajo.Dato;
      Console.Write("{0}, ", d);
    }
    //Bajamos la linea
    Console.WriteLine();
  }

  //ADICIONAR ELEMENTOS  A LA LISTO
  //SIEMPRE VA AL FINAL
  public void Adicionar(int pDato)
  {
    //trabajo al inicio.
    trabajo = ancla;

    //recorremos hasta encontrar el final.
    while (trabajo.Siguiente != null)
    {
      //avanzamos trabajo.
      trabajo = trabajo.Siguiente;
    }
    //creamos el nuevo nodo
    CNodo temp = new CNodo();
    //insertamos el dato
    temp.Dato = pDato;

    //finalizamos correctamente.
    temp.Siguiente = null!;

    //ligamos el ultimo nodo encontrado con el recien creado.
    trabajo.Siguiente = temp;
  }

  //VACIAR LA LISTA
  public void Vaciar()
  {
    ancla.Siguiente = null!;
    //en lenguajes no administrodas hay que liberar la memoria adecuadamente
    //aqui aprovechamos el recolector de basura de c$
  }

  //indica si la lista esta vacia o no
  public bool EstaVacia()
  {
    // if(ancla.Siguiente ==null){
    //   return true;
    // }else{
    //   return false.
    // }
    return ancla.Siguiente == null ? true : false;
  }

  //Regresa el nodo con la primera ocurrencia del dato
  public CNodo Buscar(int pDato)
  {
    if (EstaVacia() == true)
    {
      return null!;
    }
    trabajo2 = ancla;

    //recorremos para ver si lo encontramos.
    while (trabajo2.Siguiente != null)
    {
      trabajo2 = trabajo2.Siguiente;
      //al encontrarlo lo regresamos
      if (trabajo2.Dato == pDato)
        return trabajo2;
    }
    //no se encontro, regresamos null
    return null!;
  }

  //Buscar Indice.
  //donde se encuentra la primera ocurrencia del dato
  public int BuscarIndice(int pDato)
  {
    int n = -1;
    trabajo = ancla;
    while (trabajo.Siguiente != null)
    {
      trabajo = trabajo.Siguiente;
      n++;
      if (trabajo.Dato == pDato)
      {
        return n;
      }
    }
    return -1;
  }

  //Buscar Anterior
  //encuentra el nodo anterior, si esta en el primer nodo se regresa el ancla
  //si el dato no existe se regresa el ultimo nodo
  public CNodo BuscarAnterior(int pDato)
  {
    trabajo2 = ancla;
    while (trabajo2.Siguiente != null && trabajo2.Siguiente.Dato != pDato)
    {
      trabajo2 = trabajo2.Siguiente;
    }
    return trabajo2;
  }

  //BORRA LA PRIMERA OCURRENCIA DEL DATO
  public void Borrar(int pDato)
  {
    //verificamos que se tengan datos
    if (EstaVacia() == true)
    {
      return;

    }

    //buscamos los nodos con los que trabajamos
    CNodo anterior = BuscarAnterior(pDato);

    CNodo encontrado = Buscar(pDato);

    //si no hay nodo a borrar, salimos
    if (encontrado == null)
    {
      return;
    }
    //Brincamos el nodo
    anterior.Siguiente = encontrado.Siguiente;

    //quitamos el actual de la lista
    encontrado.Siguiente = null!;
  }

  //INSERTAR, COLOCAR EL NODO EN CUALQUIER PUNTO
  public void Insertar(int pDonde, int pValor)
  {
    //encontramos la posicion donde vamos a insertar
    trabajo = Buscar(pDonde);

    //verificamos que exista donde vamos a insertar
    if (trabajo == null)
    {
      return;
    }
    //creamos el nodo temporal a insertar
    CNodo temp = new CNodo();
    temp.Dato = pValor;

    //conectamos el temporal a la lista
    temp.Siguiente = trabajo.Siguiente;

    //conectamos trabajo a temporal
    trabajo.Siguiente = temp;
  }

  //INSERTAR AL INICIO
  public void InsertarInicio(int pDato)
  {
    //creamos el nodo temporal
    CNodo temp = new CNodo();
    temp.Dato = pDato;

    //conectamos el temporal a la lista
    temp.Siguiente = ancla.Siguiente;
    //conectamos el ancla al temporal
    ancla.Siguiente = temp;
  }

  //OBTENER POR INDICE
  public CNodo ObtenerPorIndice(int pIndice)
  {
    CNodo? trabajo2 = null;
    int indice = -1;

    trabajo = ancla;
    while (trabajo.Siguiente != null)
    {
      trabajo = trabajo.Siguiente;
      indice++;
      if (indice == pIndice)
      {
        trabajo2 = trabajo;
      }
    }
    return trabajo2!;
  }

  //CREAR UN INDEXER PARA LA LISTA LIGADA - nivel intermedio indexer -> especie de propiedad para acceder a datos de una clase
  public int this[int pIndice]
  {
    get
    {
      //esto puede crear una excepcion si trabajo es igual a null
      //colocar codigo de seguridad o usar int?
      trabajo = ObtenerPorIndice(pIndice);
      return trabajo.Dato;
    }
    set
    {
      trabajo = ObtenerPorIndice(pIndice);
      if (trabajo != null) { trabajo.Dato = value; }
    }
  }

  // cuenta la cantidad de elementos en la lista
  public int cantidad()
  {
    trabajo = ancla;
    int n = 0;

    while (trabajo.Siguiente != null)
    {
      trabajo = trabajo.Siguiente;
      n++;
    }
    return n;
  }
}