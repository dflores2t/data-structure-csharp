namespace DataStructurePrefixPostfix;
public class CNodo
{
  //ESTA CLASE REPRESENTARA AL NODO
  //variable para el dato o datos que guardara el node
  private char dato;

  //variable de referencia que se usara como referencia para apuntar al nodo.
  private CNodo? siguiente = null;

  //PROPIEDADES A UTILIZAR
  public char Dato { get => dato; set => dato = value; }
  // public CNodo Siguiente { get {
  //     return siguiente;
  //   } set {
  //     siguiente = value;
  //    }
  // }
  internal CNodo? Siguiente { get => siguiente; set => siguiente = value; }

  //IMPRESION
  public override string ToString()
  {
    return string.Format("[{0}]", dato);
  }

}