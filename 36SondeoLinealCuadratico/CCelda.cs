namespace SondeoLinealCuadratico
{
  enum estado
  {
    vacio, ocupado, borrado
  }

  public class Ccelda{
    private int llave;
    private string valor;

    private estado miEstado;

    public int Llave { get=> llave; set=>llave = value; }
    public string Valor { get=> valor; set=> valor = value; }
    internal estado MiEstado { get => miEstado; set => miEstado = value; }

    public Ccelda(){
      llave = 0;
      valor = "";
      miEstado = estado.vacio;
    }
  }
}