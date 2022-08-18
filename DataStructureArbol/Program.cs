namespace DataStructureArbol;
class Program
{
  static void Main(string[] args)
  {
    CArbol arbol = new CArbol();
    CNodo raiz = arbol.Insertar("A", null);
    arbol.Insertar("B", raiz);
    arbol.Insertar("C", raiz);

    // arbol.TransversaPreO(raiz);

    CNodo n = arbol.Insertar("d", raiz);
    arbol.Insertar("H", n);

    n = arbol.Insertar("e", raiz);
    arbol.Insertar("I", n);
    n = arbol.Insertar("J", n);
    arbol.Insertar("P", n);
    arbol.Insertar("Q", n);

    // arbol.TransversaPreO(raiz);

    n = arbol.Insertar("F", raiz);
    arbol.Insertar("K", n);
    arbol.Insertar("L", n);
    arbol.Insertar("M", n);

    n = arbol.Insertar("G", raiz);
    arbol.Insertar("N", n);

    arbol.TransversaPreO(raiz);
    Console.WriteLine("-----");

    // arbol.TransversaPostO(raiz);
    Console.WriteLine("-----");

    CNodo encontrado = arbol.Buscar("G", raiz);
    if(encontrado !=null)
      Console.WriteLine(encontrado.Dato);
    else
      Console.WriteLine("No Lo encontre");

    Console.WriteLine("----------");


    string donde = "";
    string que = "";
    Console.WriteLine("En donde desea insertar ");
    donde = Console.ReadLine();
    Console.WriteLine("Que deseas insertar");
    que = Console.ReadLine();

    encontrado = arbol.Buscar(donde, raiz);
    arbol.Insertar(que, encontrado);
    arbol.TransversaPreO(raiz);
  }
}