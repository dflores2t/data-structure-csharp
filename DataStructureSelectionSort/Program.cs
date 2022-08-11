namespace DataStructureSelectionSort;

class Program{

  private static CListaLigada miLista = new CListaLigada();
  static void Main(string[] args){
    //selection sort
    miLista.Adicionar(3);
    miLista.Adicionar(15);
    miLista.Adicionar(7);
    miLista.Adicionar(19);
    miLista.Adicionar(11);
    miLista.Adicionar(1);

    int i = 0;
    int j = 0;
    int iMin = 0;
    int n = miLista.cantidad();
    miLista.Transversa();
    //Recorremos los elementos.
    for (i = 0; i < n - 1; i++){
      //el indice menor es la posicion actual desde donde comenzamos
      iMin = i;

      //encontramos el nuevo indice del menor
      for (j = i + 1; j < n; j++){
        if(miLista[j] < miLista[iMin]){
          iMin = j;
        }
      }
      //intercambiamos la posicion actual con el menor
      Swap(i, iMin);
    }
    miLista.Transversa();


  }

  private static void Swap(int i1, int i2)
  {
    int temp = miLista[i1];
    miLista[i1] = miLista[i2];
    miLista[i2] = temp;
  }

}
