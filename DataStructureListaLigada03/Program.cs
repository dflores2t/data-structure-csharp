namespace DataStructureListaLigada03;

public class Program{

  static void Main(string[] args){
    CListaLigada miLista = new CListaLigada();


    miLista.Adicionar(3);
    miLista.Adicionar(5);
    miLista.Adicionar(7);
    miLista.Adicionar(9);
    miLista.Adicionar(11);
    miLista.Adicionar(15);

    //IMPRIMIR DATOS
    miLista.Transversa();
    // Console.WriteLine(miLista.EstaVacia());
    //VACIAR LISTA
    // miLista.Vaciar();
    // miLista.Transversa();
    
    //BUSCAR VALOR
   CNodo encontrado = miLista.Buscar(3);
    Console.WriteLine(encontrado);

    //BUSCAR INDICE
    Console.WriteLine("Buscar Indice:");
    Console.WriteLine(miLista.BuscarIndice(151));

    //BUSCAR ANTERIOR
    Console.WriteLine("Buscar Anterior:");
    Console.WriteLine(miLista.BuscarAnterior(152));
  
  
  
  //BORRAR
  Console.WriteLine("Borrar datos");
    miLista.Transversa();
    miLista.Borrar(72);
    miLista.Transversa();
    //INSERTAR
    Console.WriteLine("INSERTAR NUEVO VALOR");
    miLista.Insertar(7,20);
    miLista.Transversa();
  
  
  //INSERTAR AL INICIO
  Console.WriteLine("INSERTAR AL IINICIO");
    // miLista.InsertarInicio(4);
    miLista.Transversa();



    //BUSCAR POR INDICE
    Console.WriteLine(miLista.BuscarIndice(5));

    //INDIXER
    //gracia a esto podemos usar la lista como el arregol podemos acceder a los eslementos a traves de los corchetes e indice
    Console.WriteLine(miLista[3]);
    miLista[3] = 55;
    miLista.Transversa();
  }


}