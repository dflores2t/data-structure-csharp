namespace TablaHash;

public class Program
{
  // CANTIDAD DE CELDAS EN LA TABLA
  private static int tamano = 7;
  private static CListaLigada[] tabla;

  static void Main(string[] args)
  {
    //implementacion de tabla de hash con uso de encadenamiento para resolver colisiones

    ///SEPARATE CHAINNING -> ENCADENAMIENTO POR SEPARADO
    ///VENTAJAS - SENCILLO - TABLA NUNCA SE LLENA - POCO SENSIBLE A UNA FUNCION HE HASH MALA
    ///SE PUEDE USAR CUANDO NO SABEMOS CUANTOS ELEMENTOS SE TENDRAN.
    ///DESVENTAJAS: el desempeno no es tan bueno debiod a las listas ligadas 
    ///se desperdicia memeroia si hay celdas que no se usan, ademas de lo necesario para mantener las listas ligadas
    ///si la cadena se hace muy larga el tiempo de acceso se vuelve o(n).
    ///
    int n = 0;

    //necesitamos  un arreglo de listas ligadas para crear la tabla
    tabla = new CListaLigada[tamano];
    //inicializamos la tabla
    for (n = 0; n < tamano; n++){
      tabla[n] = new CListaLigada();
    }

    Mostrar();
    System.Console.WriteLine("-----------------");

    Insertar(57, "Hola");
    Insertar(45, "Manzana");
    Insertar(42, "Pera");
    Insertar(83, "Azul");
    Insertar(30, "Rojo");
    Insertar(94, "C#");
    Insertar(73, "C++");
    Insertar(97, "Saludos");

    Mostrar();
    System.Console.WriteLine("--------------------");

  }

  public static void Mostrar(){
    int n = 0;
    for (n = 0; n < tamano; n++){
      System.Console.Write("({0})",n);
      tabla[n].Transversa();
      System.Console.WriteLine();
    }
  }
  public static int HashF(int pLLave){
    int indice = 0;
    //function muy sencilla, no usar en el mundo real
    indice = pLLave % tamano;
    return indice;
  }

  public static void Insertar(int pLLave, string pValor){
    int indice = HashF(pLLave);
    tabla[indice].Adicionar(pLLave, pValor);
  }


}

