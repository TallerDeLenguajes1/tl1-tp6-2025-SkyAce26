// See https://aka.ms/new-console-template for more information
using System;
/*
//EJERCICIO 1:
Console.WriteLine("Ingrese una palabra:");
string palabra1 = Console.ReadLine();

int longitud = palabra1.Length;

Console.WriteLine($"La longitud de la palabra es: {longitud}");

//EJERCICIO 2:
Console.WriteLine("Ingrese otra palabra:");
string palabra2 = Console.ReadLine();

Console.WriteLine("Las dos palabras concatenadas son: " + palabra1 + palabra2);

//EJERCICIO 3:
string parte = palabra2.Substring(3);

Console.WriteLine("Una subcadena de la segunda palabra ingresada es: " + parte);

//EJERCICIO 4:
int opcion;
    double num1, num2;
    do
    {
        Console.WriteLine("Ingrese qué operación quiere hacer:");
        Console.WriteLine("1. Sumar");
        Console.WriteLine("2. Restar");
        Console.WriteLine("3. Multiplicar");
        Console.WriteLine("4. Dividir");
        Console.WriteLine("5. Salir");

        opcion = int.Parse(Console.ReadLine());

        if (opcion >= 1 && opcion < 5)
        {
            Console.WriteLine("Ingrese el primer numero:");

            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Número inválido, ingrese uno nuevo.");
            }

            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Número inválido, ingrese uno nuevo.");
            }

            switch (opcion)
            {
                case 1:
                    double suma = num1 + num2;
                    Console.WriteLine("La suma de " + num1.ToString() + " y " + num2.ToString() + " es: " + suma.ToString());
                    break;
                case 2:
                    double resta = num1 - num2;
                    Console.WriteLine("La resta de " + num1.ToString() + " y " + num2.ToString() + " es: " + resta.ToString());
                    break;
                case 3:
                    double multi = num1 * num2;
                    Console.WriteLine("La multiplicación de " + num1.ToString() + " y " + num2.ToString() + " es: " + multi.ToString());
                    break;
                case 4:
                    if (num2 != 0)
                    {
                    double div = num1 / num2;
                    Console.WriteLine("La división de " + num1.ToString() + " y " + num2.ToString() + " es: " + div.ToString());
                    }
                    else
                    {
                        Console.WriteLine("Error, no se puede dividir por cero");
                    }
                    break;
            }
        }
        else if (opcion != 5)
        {
            Console.WriteLine("Número inválido");
        }

        Console.WriteLine();

    } while (opcion != 5);

//EJERCICIO 5:
Console.WriteLine("Los elementos de la primera palabra ingresada son:");

foreach (char letra in palabra1)
{
    Console.WriteLine(letra);
}

//EJERCICIO 6:
Console.WriteLine("Ingrese un texto:");
string texto = Console.ReadLine();

Console.WriteLine("Ingrese la palabra que quiere buscar en el texto ingresado:");
string palabra = Console.ReadLine();

if (texto.Contains(palabra)) {
    Console.WriteLine("La palabra " + palabra + " si se encuentra en el texto ingresado");
} else {
    Console.WriteLine("La palabra " + palabra + " no se encuentra en el texto ingresado");
}

//EJERCICIO 7:
Console.WriteLine("El texto a minuscula es: " + texto.ToLower() + " Y a mayúscula es: " + texto.ToUpper());

//EJERCICIO 8:
Console.WriteLine("Ingrese un texto separado por comas:");
string separar = Console.ReadLine();

string[] partes = separar.Split(',');

Console.WriteLine("El texto ingresado separa por las comas es:");

foreach (string elemento in partes)
{
    Console.WriteLine(elemento);
}
*/
//EJERCICIO 9:
Console.WriteLine("Ingrese una ecuación simple:");
string ecuacion = Console.ReadLine();

ecuacion = ecuacion.Replace(" ", "");

int posicion = -1;

if (ecuacion.Contains("+"))
{
    posicion = ecuacion.IndexOf("+");
} 
else if (ecuacion.Contains("-"))
{
    posicion = ecuacion.IndexOf("-");
}
else if (ecuacion.Contains("*"))
{
    posicion = ecuacion.IndexOf("*");
}
else if (ecuacion.Contains("/"))
{
    posicion = ecuacion.IndexOf("/");
}
else
{
    Console.WriteLine("Ecuación inválida, no es simple.");
}


double parte1 = double.Parse(ecuacion.Substring(0, posicion));
double parte2 = double.Parse(ecuacion.Substring(posicion + 1));

char signo = ecuacion[posicion];

if (signo == '+')
{
    double suma = parte1 + parte2;
    Console.WriteLine($"La suma de {parte1} y {parte2} es: {suma}");
}
else if (signo == '-')
{
    double resta = parte1 - parte2;
    Console.WriteLine($"La resta de {parte1} y {parte2} es: {resta}");
}
else if (signo == '*')
{
    double mult = parte1 * parte2;
    Console.WriteLine($"La multiplicación de {parte1} y {parte2} es: {mult}");
}
else if (signo == '/') 
{
    double division = parte1 / parte2;
    Console.WriteLine($"La división de {parte1} y {parte2} es: {division}");
}

