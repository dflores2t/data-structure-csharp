namespace DataStructureArbol;

public class CArbol
{
  private CNodo raiz;
  private CNodo trabajo;

  private int i = 0;

  public CArbol()
  {
    raiz = new CNodo();
  }
  public CNodo Insertar(string pDato, CNodo pNodo)
  {
    //si no hay noo donde insertar, tomamos como si fguera en la raiz,
    if (pNodo == null)
    {
      raiz = new CNodo();
      raiz.Dato = pDato;

      //na hay hijo
      raiz.Hijo = null;

      //no hay hermano 
      raiz.Hermano = null;
      return raiz;
    }
    //verificamos si no tiene hijo
    //insertamos el dato como hijo
    if (pNodo.Hijo == null)
    {
      CNodo temp = new CNodo();
      temp.Dato = pDato;

      //conectamos el nuevo nodo como hijo
      pNodo.Hijo = temp;
      return temp;
    }
    else
    {
      //ya tiene un hijo tenemos que insertarlo como hermano.
      trabajo = pNodo.Hijo;
      //avanzamos hasta el ultimo hermano
      while (trabajo.Hermano != null)
      {
        trabajo = trabajo.Hermano;
      }

      //creamos nodo temporal
      CNodo temp = new CNodo();
      temp.Dato = pDato;

      //unimos el temp al ultimo hermano
      trabajo.Hermano = temp;

      return temp;
    }
  }
  //trnasversa preorer
  public void TransversaPreO(CNodo pNodo)
  {
    if (pNodo == null)
    {
      return;
    }
    //me proceso primero a mi
    for (int n = 0; n < i; n++)
    {
      Console.Write("L.... ");
    }
    Console.WriteLine(pNodo.Dato);

    //luego proceso a mi hijo
    if (pNodo.Hijo != null)
    {
      i++;
      TransversaPreO(pNodo.Hijo);
      i--;
    }
    //si tengo hermano lo proceso
    if (pNodo.Hermano != null)
    {
      TransversaPreO(pNodo.Hermano);
    }
  }
  public void TransversaPostO(CNodo pNodo)
  {
    if (pNodo == null)
    {
      return;
    }
    //primero proceso a mi hijo
    if (pNodo.Hijo != null)
    {
      i++;
      TransversaPostO(pNodo.Hijo);
      i--;
    }
    //si tengo hermanos los proceso
    if (pNodo.Hermano != null)
    {
      TransversaPostO(pNodo.Hermano);
    }
    //luego me proceso a mi
    for (int n = 0; n < i; n++)
    {
      Console.Write("L___ ");
    }
    Console.WriteLine(pNodo.Dato);

  }

  public CNodo Buscar(string pDato, CNodo pNodo)
  {
    CNodo encontrado = null;

    if (pNodo == null)
    {
      return encontrado;
    }

    if (pNodo.Dato.CompareTo(pDato) == 0)
    {
      encontrado = pNodo;
      return encontrado;
    }
    //luego proceso a mi hijo
    if (pNodo.Hijo != null)
    {
      encontrado = Buscar(pDato, pNodo.Hijo);
      if (encontrado != null)
      {
        return encontrado;
      }
    }
    //si tengo hermanos los proceso
    if (pNodo.Hermano != null)
    {
      encontrado = Buscar(pDato, pNodo.Hermano);
      if (encontrado != null)
      {
        return encontrado;
      }
    }
    return encontrado;
  }

}