using static System.Console;
namespace DataStructureArbolBinario;

public class Program
{
  static void Main(string[] args)
  {
    CArbolBB arbol = new CArbolBB();

    CNodo raiz = arbol.Insertar(6, null);

    arbol.Insertar(2, raiz);
    arbol.Insertar(8, raiz);
    arbol.Insertar(1, raiz);
    arbol.Insertar(4, raiz);
    arbol.Insertar(3, raiz);
    arbol.Insertar(5, raiz);
    arbol.Insertar(7, raiz);
    arbol.Insertar(11, raiz);
    arbol.Insertar(9, raiz);
    arbol.Insertar(10, raiz);
    arbol.Insertar(0, raiz);
    arbol.Insertar(-1, raiz);
    arbol.Insertar(12, raiz);
    arbol.Insertar(14, raiz);

    arbol.Transversa(raiz);

    // Console.WriteLine("EL MENOS ES {0} ", arbol.EncuentraMinimo(raiz));
    // Console.WriteLine("EL MENOS ES {0} ", arbol.EncuentraMaximo(raiz));

    // arbol.TransversaOrdenada(raiz);
    // Console.WriteLine();
    // CNodo temp = arbol.EncuentraNodoMinimo(raiz);
    // Console.WriteLine(temp.Dato);
    // Console.WriteLine();
    // Console.WriteLine("-------------");
    // Console.WriteLine();
    // System.Console.WriteLine();

    System.Console.WriteLine("----------------------");
    System.Console.WriteLine("Buscar al padre");
    CNodo padre = arbol.BuscarPadre(11, raiz);
    System.Console.WriteLine("padre encontrado: {0} ", padre.Dato);
  }
}