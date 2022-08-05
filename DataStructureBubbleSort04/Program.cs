﻿namespace DataStructureBubbleSort04;

public class Program
{
  private static CListaLigada miLista = new CListaLigada();
  static void Main(string[] args)
  {
    //Bubble Sort. Ordenamiento de la burbuja.
    miLista.Adicionar(3);
    miLista.Adicionar(15);
    miLista.Adicionar(7);
    miLista.Adicionar(19);
    miLista.Adicionar(11);
    miLista.Adicionar(1);

    miLista.Transversa();

    // Swap(1,2);
    // miLista.Transversa();

    int m = 0;
    int n = 0;
    int cantidad = miLista.cantidad();
    Console.WriteLine("Son {0} elementos", cantidad);

    //Hacemos los pases correspondientes.
    for (m = 1; m < cantidad; m++)
    {
      //recorremos la lista verificando si hay que hacer swap
      // los elementos hasta la derecha ya van quedando ordenados.
      for (n = 0; n < cantidad - m; n++)
      {
        if (miLista[n] > miLista[n + 1])
        {
          Swap(n, n + 1);
        }
      }
      // Console.WriteLine("Pase {0}", m);
      // miLista.Transversa();
    }
    miLista.Transversa();
  }
  private static void Swap(int i1, int i2)
  {
    int temp = miLista[i1];
    miLista[i1] = miLista[i2];
    miLista[i2] = temp;
  }
}