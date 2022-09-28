namespace rehash
{ 
 public class HashTable{
    private CCelda[] tabla;
    private int cantidad;
    private int insertados;

    public HashTable(int pTamano)
    {
      int n = 0;
      cantidad = pTamano;
      tabla = new CCelda[cantidad];
      for (n = 0; n< cantidad; n++)
      {
        tabla[n] = new CCelda();
      }
    }

    public int HashF(int pLlave, int pIntento)
    {
      int indice = 0;
      //LINEAL PROBING
      // indice = (pLlave + pIntento) % cantidad;
      //QUADRATIC PROBING
      indice = (pLlave + pIntento * pIntento) % cantidad;
      return indice;
    }

    public void Mostrar(){
      int n = 0;
      for (n = 0; n < cantidad;n++){
        Console.WriteLine("{0} [{1},{2}]",n, tabla[n].Llave, tabla[n].Valor);
      }
    }

    public void Insertar(int pLlave, string pValor){
      //CONTADOR DE INTENTOS
      int i = 0;
      int indice = 0;
      bool ocupado = false;
      while (ocupado == false)
      {
        //calculamos el indice
        indice = HashF(pLlave, i);
        //verificamos si esta vacia la celda;
        if(tabla[indice].MiEstado == estado.vacio)
        {
          ocupado = true;
          tabla[indice].Llave = pLlave;
          tabla[indice].Valor = pValor;
          tabla[indice].MiEstado = estado.ocupado;
          insertados++;
        }
        else
        {
          //avanzamos al siguiente inteno
          i++;
        }
      }
      //VERIFICAMOS SI ES NECESARIO HACER UN REHASH
      if(insertados >=((double)cantidad *0.7)){
        Console.WriteLine("--ES NECESARIO HACER REHASH, {0} DE {1} OCUPADOS", insertados,cantidad);
        ReHash();
      }
    }
    public static int PrimoCercano(int pValor){
     //ENCUENTRA UN NUMERO PRIMO QUE SEA MAYOR QUE EL VALOR PASADO, ESE VALOR ES EL DOBLE DEL TAMANO DE LA TABLA ORIGINAL
      int primo = 0;
      bool divide = false;
      int n = 0;
      while(primo ==0)
      {
        divide = false;
        for (n = 2; n < pValor; n++)
        {
          if(pValor % n ==0){
            divide = true;
            pValor++;
            break;
          }
        }
        if(divide == false){
          primo = pValor;
        }
      }
      return primo;
    }

    public void ReHash(){
      //CALCULAMOS EL NUEMO TAMANO
      int nCantidad = PrimoCercano(cantidad * 2);
      int cantAnterior = cantidad;
      int n = 0;
      int llave = 0;
      string valor = "";

      int i = 0;
      int indice = 0;
      bool ocupado = false;
      Console.WriteLine("AHROA LA TABLA SERA DE {0} ESPACIOS", nCantidad);
      //CREAMOS LA NUEVA TABLA
      CCelda[] temp = new CCelda[nCantidad];
      for (n = 0; n < nCantidad; n++){
        temp[n] = new CCelda();
      }
      //ACTUALIZAMOS CANTIDAD PARA QUE LA FUNCION DE HASH FUNCIEONE BIEN.
      cantidad = nCantidad;
      //RECORREMOS LA TABLA Y VAMOS INSERTANDO EN LA NUEVA
      for (n = 0; n < cantAnterior; n++){
        //VERIFICAMOS SI HAY UN ELEMENTO A INSERTAR
        if(tabla[n].MiEstado == estado.ocupado){
          llave = tabla[n].Llave;
          valor = tabla[n].Valor;

          ocupado = false;
          //hacemos la insercion en la nueva tabla
          while (ocupado ==false)
          {
            //calculamos el indice
            indice = HashF(llave, i);

            //verificamos si esta vacia lacelda.
            if(temp[indice].MiEstado == estado.vacio){
              ocupado = true;
              temp[indice].Llave = llave;
              temp[indice].Valor = valor;
              temp[indice].MiEstado = estado.ocupado;
              insertados++;
            }else{
              //avonzamos al siguient intento
              i++;
            }
          }
        }
      }
      tabla = (CCelda[])temp.Clone();
    }
    
  } 
}