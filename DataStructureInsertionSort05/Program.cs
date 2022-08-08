namespace DataStructureInsertionSort;

public class Program
{
  private static CListaLigada miLista = new CListaLigada();
  static void Main(string[] args){

    //INSERTION SORT
    miLista.Adicionar(3);
    miLista.Adicionar(15);
    miLista.Adicionar(37);
    miLista.Adicionar(19);
    miLista.Adicionar(11);
    miLista.Adicionar(1);

    miLista.Transversa();

    int cantidad = miLista.cantidad();
    int i = 0;
    int posAgujero = 0;
    int dato = 0;

    //recorremos los elementos.
    // for (i = 1; i < cantidad; i++){
    //   //Obtenemos el dato
    //   dato = miLista[i];
    //   //indicamos lo pasicion del agujero
    //   posAgujero = i;
    //   //recorremos los elementos hacia el agujero.
    //   while(posAgujero > 0 && miLista[posAgujero -1] > dato){
    //     miLista[posAgujero] = miLista[posAgujero - 1];
    //     posAgujero = posAgujero - 1;
    //   }
      //le colocamos al agujero el dato correspondiente
     // miLista[posAgujero] = dato;

    // otra forma de implementarlo es usando el sway para mejorar el algoritmo anterior
    for (i = 1; i < cantidad; i++){
      posAgujero = i;
      while(posAgujero > 0 && miLista[posAgujero] < miLista[posAgujero -1]){
        Swap(posAgujero, posAgujero - 1);
        posAgujero = posAgujero - 1;
      }
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
