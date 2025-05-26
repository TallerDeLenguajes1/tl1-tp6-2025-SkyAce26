[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/24pP-Pw_)

# Respuestas:

## ¿String es una tipo por valor o un tipo por referencia? 
string es un tipo por referencia, sin embargo, se comporta como si fuera por valor porque es inmutable, es decir, no se puede modificar una vez creado. Cada vez que se cambia una cadena, en realidad se está creando una nueva.

## ¿Qué secuencias de escape tiene el tipo string? 
| Secuencia | Significado           |
| --------- | --------------------- |
| `\n`      | Nueva línea           |
| `\r`      | Retorno de carro      |
| `\t`      | Tabulación            |
| `\\`      | Barra invertida `\`   |
| `\"`      | Comilla doble `"`     |
| `\'`      | Comilla simple `'`    |
| `\0`      | Nulo (null character) |
| `\a`      | Alerta (beep)         |
| `\b`      | Retroceso             |
| `\f`      | Avance de página      |
| `\v`      | Tab vertical          |

## ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto? 
El '@' ignora las secuencias de escape, lo que lo hace ideal para rutas de archivos.
El '$' permite insertar variables directamente dentro del string usando llaves {} del siguiente modo:

```csharp
string nombre = "Luis";
Console.WriteLine($"Hola, {nombre}!");
```


