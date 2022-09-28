namespace rehash
{
  //hash tiene ciertas dimensiones, mencanismas para resolver colisiones al crecer tendremos colisicones constatemente.
  //rehash para mejor hacer crecer el tamano de nuestra tabla de hash y volver hacer el hash para cada uno de los elemestos que ya tenemos.
  //al 70% de crecimiento empezamos a tener este problema de desempeno. detectar cuando se ha llegado a ese porcetaje haremos crecer la tabla. el tamano es algo importante. en este ejemplo el nuevo tamano sera el numero primo mas cercnano y mas grande del tamano original.


  public class Program
  {
    static void Main(string[] args){
      HashTable miTabla = new HashTable(11);
      miTabla.Insertar(23, "HOLA");
      miTabla.Insertar(51, "MANZANA");
      miTabla.Insertar(40, "PERA");
      miTabla.Insertar(62, "MANGO");
      miTabla.Insertar(32, "PRUEBA");
      miTabla.Insertar(11, "DE");
      miTabla.Insertar(21, "REHASH");
      miTabla.Mostrar();
      miTabla.Insertar(4, "EN C#");
      miTabla.Mostrar();
    }

    
  }
}