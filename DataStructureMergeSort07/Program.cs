namespace DataStructureMergeSort;

class Program{
  private static CListaLigada miLista = new CListaLigada();
  static void Main(string[] args)
  {

//segunda parte.
    miLista.Adicionar(3);
    miLista.Adicionar(15);
    miLista.Adicionar(7);
    miLista.Adicionar(19);
    miLista.Adicionar(11);
    miLista.Adicionar(1);

    miLista.Transversa();

    CListaLigada ordenada = MergeSort(miLista);
    ordenada.Transversa();


    //1 solo uso de merge
    // CListaLigada l = new CListaLigada();
    // l.Adicionar(6);
    // l.Adicionar(7);
    // l.Adicionar(9);
    // l.Adicionar(11);

    // CListaLigada r = new CListaLigada();
    // r.Adicionar(8);
    // r.Adicionar(10);
    // r.Adicionar(12);
    // r.Adicionar(13);

    // CListaLigada merged = Merge(l, r);
    // merged.Transversa();

  }
  public static CListaLigada Merge(CListaLigada listaIzq, CListaLigada listaDer)
  {
    //recordar que para que el merge funcione ambas listas ya deben estar ordenadas.
    //lista donde se unen.
    CListaLigada unida = new CListaLigada();

    //indices en cada lista.
    int indiceI = 0;
    int indiceD = 0;

    //cantida  de elementos en cada lista
    int cantI = listaIzq.cantidad();
    int cantD = listaDer.cantidad();

    //recorremos mientras las dos listas tengan elementos si procesar
    while (indiceI < cantI && indiceD < cantD)
    {
      //si el de la izquierda es menor o igual adicionamos el de la izquierda
      if (listaIzq[indiceI] <= listaDer[indiceD])
      {
        unida.Adicionar(listaIzq[indiceI]);
        indiceI++;
      }
      else
      {
        //si el de la derecha es menor adicionamos el de la derecha
        unida.Adicionar(listaDer[indiceD]);
        //avanzamos el indice
        indiceD++;
      }
    }
    // si sobraron elementos en la lista izquierda los ponemos todoso
    while(indiceI < cantI){
      unida.Adicionar(listaIzq[indiceI]);
      indiceI++;
    }
    //si sobraron elementos en la lista derecha los ponemos todos
    while (indiceD < cantD){
      unida.Adicionar(listaDer[indiceD]);
      indiceD++;
    }
    return unida;
  }
  public static CListaLigada MergeSort(CListaLigada pLista)
  {
    //cantidadad de elementos en la lista.
    int cantidad = pLista.cantidad();
    int n = 0;
    //caso base, una lista de un solo elemento ya esta ordenada
    if (cantidad < 2)
    {
      return pLista;
    }
    //obtenemos el punto medio de la lista
    int mitad = cantidad / 2;
    CListaLigada izquierda = new CListaLigada();
    CListaLigada derecha = new CListaLigada();

    //adicionamos a la izquierda desde el inicio hasta antes de la mitad
    for (n = 0; n < mitad; n++)
    {
      izquierda.Adicionar(pLista[n]);
    }
    //adicionamos a la derecha desde la mitad hasta el final de la lista
    for (n = mitad; n < cantidad; n++)
    {
      derecha.Adicionar(pLista[n]);
    }

    // casos inductivos
    // hacemos el MergeSorte de las listas izquierda y derecho
    CListaLigada tempI = MergeSort(izquierda);
    CListaLigada tempD = MergeSort(derecha);

    //hamecos el merge de lo que nos regresa el caso inductivo.
    CListaLigada ordenada = Merge(tempI, tempD);
    //regresamo la lista ordenada;
    return ordenada;
  }

}