namespace TablaHash;
public class CNodo
{
  //ESTA CLASE REPRESENTARA AL NODO
  //variable para el dato o datos que guardara el node
 
  private int llave;
  private string valor="";

  //variable de referencia que se usara como referencia para apuntar al nodo.
  private CNodo? siguiente = null;

  //PROPIEDADES A UTILIZAR
  public int  Llave { get => llave; set => llave = value; }
  public string  Valor { get => valor; set => valor = value; }
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
    return string.Format("[{0}, {1}]", llave, valor);
  }

}