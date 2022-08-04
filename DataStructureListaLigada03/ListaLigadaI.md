# Lista Ligada 
- Concepto de Lista Ligada.
- Que es un Nodo
- Ancla o encabezado.
- Transversa.
- Adicionar.

### Lista Ligada
La lista ligada es la primera estructura de datos que se necesita conocer porque con ella acentamos las bases para que podamos entender otras estructuras de datos posteriormente.

En que consiste. cuando solo existian los arreglos para guardar la informacion estos mostraban ciertas deficiencias, como el tamano fijo establecido a la hora de declararlo y no era posible hacerlo crecer dinamicamente, mucho menos llevar a cabo una reduccion de tamano. 

A partir de eso surge la Lista Ligada, va ser un pariente o evolucion del arreglo, ya que nos permite tener una serie de elementos de forma secuencial pero con la ventaja que esta sea dinamica, se podra aumentar su tamano segun lo necesitemos o reducir el tamano. Ademas de que podremos llevar a cabo otras operaciones que no nos permite los arreglos como insertar o eliminar un elemento.

La lista ligada esta compuesta por nodos, estos nodos podemos guardar informacion. y estos nodos estaran conectados entre si. cada vez que se necesite un elemento nuevo se adicionara otra nodo.

### NODO

Es el elemento a partir del cual se construye la lista y otras estructuras. Este nodo guarda uno o varios datos en su interior dependiendo de que nosotros necesitemos, como flotantes, cadenas, booleanos, interos etc.

El nodo tiene algo importante como lo es la referencias a uno o varios nodos, para poder saber en donde se encuentra el siguiente nodo, conectarnos a el y poder llevar a cabo el proceso.

### TRANSVERSA.

La Transversa es una operacion que nos permite ir recorriendo cada elemento de la estructura de datos y llevar a cabo algun tipo de proceso. como imprimir la informacion de la estructura de data u otras cosas.

En la Transversa recorremos cada uno de los elementos de esa estructura de datos y cada estructura de datos tiene sus propias reglas para llevar acabo la transversa. En esta Lista Ligada la transversa es recorrer de forma secuencial cada uno de los nodos que nosotros tenemos.

Como colocar la transversa, se coloca trabajo (variable) en ancla y luego se va moviendo trabajo(var) de nodo en nodo hasta encontrar el null para finalizar.

### ADICIONAR

Es agregar elementos a la lista, siempre va al final.