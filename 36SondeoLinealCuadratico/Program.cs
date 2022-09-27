namespace SondeoLinealCuadratico
{

  public class Program
  {
    private static Ccelda[] tabla;
    private static int cantidad;

    static void Main(string[] args)
    {
      int n = 0;
      //INICIALIZAMOS LA TABLA
      cantidad = 11;
      tabla = new Ccelda[cantidad];

      for (n = 0; n < cantidad; n++)
        tabla[n] = new Ccelda();

      //MOSTRAR
      Insertar(23, "HOLA");
      Insertar(51, "MANZANA");
      Insertar(40, "PERA");
      Insertar(62, "MANGO");

      Mostrar();
    }

    public static void Mostrar(){
      int n = 0;
      for (n = 0;n<cantidad;n++){
        Console.WriteLine("{0}, [{1},{2}]", n, tabla[n].Llave, tabla[n].Valor);
      }
    }

    public static int HashF(int pLlave, int pIntento){
      int indice = 0;
      //linealprobing
      // indice = (pLlave + pIntento) % cantidad;

      //Quadratic probing
      indice = (pLlave + pIntento * pIntento) % cantidad;
      return indice;
    }

    public static void Insertar(int pLlave , string pValor ){
      //contador de intentos
      int i = 0;
      int indice = 0;
      bool ocupado = false;

      while(ocupado == false){
        //calcuamos el indice
        indice = HashF(pLlave, i);
        //verificamos si esta vacia la celda
        if (tabla[indice].MiEstado ==estado.vacio)
        {
          ocupado = true;
          tabla[indice].Llave = pLlave;
          tabla[indice].Valor = pValor;
          tabla[indice].MiEstado = estado.ocupado;
        }
        else
        {
          //avanzamos al siguiente intento
          i++;
        }
      }

    }
  }
}