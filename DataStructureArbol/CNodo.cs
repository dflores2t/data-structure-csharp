namespace DataStructureArbol;

public class CNodo {
  private string dato;

  private CNodo hijo;
  private CNodo hermano;

  public string Dato { get; set; }
  public CNodo Hijo { get; set; }
  public CNodo Hermano { get; set; }

  public CNodo()
  {
    dato = "";
    hijo = null;
    hermano = null;
  }
  

}