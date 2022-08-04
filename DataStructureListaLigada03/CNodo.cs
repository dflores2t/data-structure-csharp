namespace DataStructureListaLigada03;
public class CNodo
{
  //ESTA CLASE REPRESENTARA AL NODO
  //variable para el dato o datos que guardara el node
  private int dato;

  //variable de referencia que se usara como referencia para apuntar al nodo.
  private CNodo siguiente = null!;

  //PROPIEDADES A UTILIZAR
  public int Dato { get => dato; set => dato = value; }
  // public CNodo Siguiente { get {
  //     return siguiente;
  //   } set {
  //     siguiente = value;
  //    }
  // }
  public CNodo Siguiente { get => siguiente; set => siguiente = value; }

  //IMPRESION
  public override string ToString()
  {
    return string.Format("[{0}]", dato);
  }

}