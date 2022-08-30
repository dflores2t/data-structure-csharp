namespace DataStructureArbolBinario;

public class CArbolBB
{
  private CNodo? raiz;
  private CNodo? trabajo;

  private int i = 0;
  public CArbolBB()
  {
    raiz = null;
  }

  internal CNodo? Raiz { get => raiz; set => raiz = value; }

  //INSERTAR
  public CNodo Insertar(int pDato, CNodo? pNodo)
  {
    CNodo? temp = null;
    //si no hay a quien insertar entonces reamos el nodo
    if (pNodo == null)
    {
      temp = new CNodo();
      temp.Dato = pDato;
      return temp;
    }
    if (pDato < pNodo.Dato)
    {
      pNodo.Izq = Insertar(pDato, pNodo.Izq);
    }
    if (pDato > pNodo.Dato)
    {
      pNodo.Der = Insertar(pDato, pNodo.Der);
    }
    return pNodo;
  }

  //TRANSVERSA
  public void Transversa(CNodo pNodo){
    if(pNodo == null){
      return;
    }
    // me proceso a mi
    for (int n = 0; n < i; n++){
      Console.Write(" ");
    }
      Console.WriteLine(pNodo.Dato);
    //si tengo izquierda , proceso a la izquierda
    if(pNodo.Izq !=null){
      i++;
      Console.Write("I ");
      Transversa(pNodo.Izq);
      i--;
    }
    //si tengo derecha , proceso a la derecha
    if(pNodo.Der !=null){
      i++;
      Console.Write("D ");
      Transversa(pNodo.Der);
      i--;
    }
  }

  //ENCONTRADR MINIMO
  public int EncuentraMinimo(CNodo pNodo){
    if(pNodo ==null){
      return 0;
    }
    trabajo = pNodo;
    int minimo = trabajo.Dato;

    while(trabajo.Izq !=null){
      trabajo = trabajo.Izq;
      minimo = trabajo.Dato;
    }
    return minimo;
  }

  //ENCONTRAR DATO MAYOR
public int  EncuentraMaximo(CNodo pNodo){
    if (pNodo == null)
    {
      return 0;
    }
    trabajo = pNodo;
    int minimo = trabajo.Dato;

    while (trabajo.Der != null)
    {
      trabajo = trabajo.Der;
      minimo = trabajo.Dato;
    }
    return minimo;
}

  //TRANSVERSA INORDER
  public void TransversaOrdenada(CNodo pNodo){
    if(pNodo == null){
      return;
    }
    if(pNodo.Izq !=null){
      i++;
      TransversaOrdenada(pNodo.Izq);
      i--;
    }
    Console.Write("{0} ", pNodo.Dato);

    //si tengo derecha , proceso a la derecha
    if(pNodo.Der != null){
      i++;
      TransversaOrdenada(pNodo.Der);
      i--;
    }
  }

  //ENCONTRAR NODO MINIMO
  public CNodo EncuentraNodoMinimo(CNodo pNodo){
    if(pNodo == null){
      return null;
    }
    trabajo = pNodo;
    int minimo = trabajo.Dato;

    while(trabajo.Izq !=null){
      trabajo = trabajo.Izq;
      minimo = trabajo.Dato;
    }
    return trabajo;
  }
}