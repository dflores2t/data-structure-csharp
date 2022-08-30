namespace DataStructureArbolBinario;

public class CNodo
{

  private int dato;

  private CNodo? izq;
  private CNodo? der;

  public int Dato { get => dato; set => dato = value; }
  public CNodo? Izq { get => izq; set => izq = value; }
  public CNodo? Der { get => der; set => der = value; }

  public CNodo()
  {
    dato = 0;
    izq = null;
    der = null;
  }
  

}