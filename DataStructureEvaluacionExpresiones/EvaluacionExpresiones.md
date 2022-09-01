# EVALUACION DE EXPRESIONES.
>  5 + 3 * 2 = 8 * 2 = 16
> 5 + 3 * 2 = 5 + 6 = 11
> A + B * C
hay una forma correcto como se evalua una expresion, esta ambiguedad surge porque las personas no saben a que operador esta asociado.

## PROBLEMAS CON LAS EXPRESIONES.

## INFIX.
Conocer diferentes formas por medio de las cuales podemos ubicar una expresion.
infix significa que tendremos un operado y un operando a la izquierda y un operando a la derecha
> 5 + 3
> 6 * 2
> a + 7
el operando puede ser una constante, una variable o una expresion.
> (3 + 2) - 5
## PRECEDENCIA DE OPERADORES.
Ciertos operadores tienen mas pesos o deben llevarse antes que otros.
> operador de mas peso agrupacion () [] {}
> a exponente x derecha a izquierda 2^3^2 = 2^9 = 512
> * / izquierda a derecha 120 / 4 * 2 = 30 * 2 = 60
> + - izquierda a derecha 5 + 3 - 2 = 6

## PREFIX.
Con prefix no hay ambiguedad.
> Opeador -> operando -> operando.
> 2 + 3 => +23
> a * 5 => * a5
> 2 - c => - 2c
> a + b * c => + a * bc

## POSTFIX.
en el caso de postfix el operador ira al final
> Operando -Operando - operador
> 5 + 3 => 53+
> 2 -a => 2a-
> b * C => bc *
> d / 2 => d2 /
> a + b * c => abc *+