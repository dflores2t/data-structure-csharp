namespace DataStructureQuickSort;

class Program
{
  static CListaLigada miLista = new CListaLigada();
  static void Main(string[] args)
  {
    miLista.Adicionar(3);
    miLista.Adicionar(15);
    miLista.Adicionar(7);
    miLista.Adicionar(19);
    miLista.Adicionar(11);
    miLista.Adicionar(1);

    miLista.Transversa();

    QuickSort(0, miLista.cantidad() - 1);

    miLista.Transversa();
  }

  //metodo de apoyo
  private static void Swap(int i1, int i2)
  {
    int temp = miLista[i1];
    miLista[i1] = miLista[i2];
    miLista[i2] = temp;
  }

  //metodo de apoyo
  public static int Particion(int pInicio, int piFin)
  {
    int pivote = 0;
    int iPivote = 0;
    int n = 0;

    //selececcionamo el ultimo como pivote
    pivote = miLista[piFin];
    //ponemos el indice de  pivote con el indice del inicio
    iPivote = pInicio;

    //recorremos la lista en el fragmento indicado
    for (n = pInicio; n < piFin; n++)
    {
      //si el elemento en el indice n es menor o igual al pivote
      if (miLista[n] <= pivote)
      {
        //intercambiamos el elemento en n con el que se encuentre en el indice de pivote 
        Swap(n, iPivote);

        //incrementamos el indice del pivote
        iPivote++;
      }
    }
    //hacemos el swap final para colocar el pivote donde corresponde
    Swap(iPivote, piFin);
    //regresamos el indice del pivote
    return iPivote;
  }

  //metodo de apoyo.
  public static void QuickSort(int pInicio, int pFin)
  {
    int iPivote = 0;
    //caso base, un elemento o fragmento invalido
    if (pInicio >= pFin)
    {
      return;
    }
    //obtenemos el indice del pivote para el fragmento con el que trabajamos 
    iPivote = Particion(pInicio, pFin);

    //casos inductivos
    QuickSort(pInicio, iPivote - 1); //fragmento a la izquierda del pivote.
    QuickSort(iPivote + 1, pFin); //fragmento a la derecha del pivote.
  }
}