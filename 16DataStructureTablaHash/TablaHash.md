# TABLA HASH
* Nos permite guardar informacion de tablas de forma mas eficiente que los arreglos y las listas
* Usamos un esquema de llame y valor(es)
* si utilizamos la misma informacion en un Arregol y Lista ligada
  - la Busqueda O(n) en el mejor de los casos o(log n)
* si utilizamos Arbol binario de Busqueda
  - insercion, busqueda y borrar O(log n)
* lo que buscamos en la tabla de hash, las insercion, busqueda y borrar en tiempo constante ese decir que tome el mismo tienmpo ya sea con poco elementos o muchos elementos.

* con hashing tenemos la facilidad de crear algo similar a un acceso directo insercion o(1) busqueda o(1) Borrar o(1)

hash function. 
> cuando tenemos una tabla vamos a tener diferentes celdas y cada celda un indice, cada elemento que se guarda, busca o > elimina de la tbala tendra un indice, y se crea a partir de una llave.
> La funcion de hash mapea la llave a un numero entero que puede ser usado como indice para acceder a la tabla.
> h(x)= x % n
> caracteristicas
> - Eficiente al calcular
> - Distribuir de manera eficiente las llaves

Colision
cuando tenemos dos o mas elementos cuando la funcion de hash asigna el mismo indice
> h(x) = x % 10
> h(57)= 7 ->
> h(233)= 3
> h(56)= 6
> h(277)= 7 ->

Encadenamiento
> las celdas de la lista ligada en realidad son los inicios a la listas ligadas.
> si hay colision, se agrega a la lisa de ese indice.

Direccionamiento Abierto
> todo se guarda en la tabla
> - sondeo lineal - lienar probing
> - sondeo cuadratico - Quadratic probing
> - Double Hashing
