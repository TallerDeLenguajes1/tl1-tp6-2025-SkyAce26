using System;

int opcionCalculadora;

Console.WriteLine("Ingrese cuál calculadora quiere usar:");
Console.WriteLine("1: Calculadora simple.");
Console.WriteLine("2: Calculadora avanzada.");

opcionCalculadora = int.Parse(Console.ReadLine());

if (opcionCalculadora == 1)
{
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
                    Console.WriteLine($"Resultado = {num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine($"Resultado = {num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine($"Resultado = {num1 * num2}");
                    break;
                case 4:
                    if (num2 != 0)
                        Console.WriteLine($"Resultado = {num1 / num2}");
                    else
                        Console.WriteLine("Error, no se puede dividir por cero");
                    break;
            }
        }
        else if (opcion != 5)
        {
            Console.WriteLine("Número inválido");
        }

        Console.WriteLine();

    } while (opcion != 5);
}
else if (opcionCalculadora == 2)
{
    double numero;

    Console.WriteLine("Ingrese un número:");

    while (!double.TryParse(Console.ReadLine(), out numero))
    {
        Console.WriteLine("Número inválido, ingrese uno nuevo.");
    }

    Console.WriteLine($"\nPropiedades del número {numero}:");
    Console.WriteLine($"- Valor absoluto: {Math.Abs(numero)}");
    Console.WriteLine($"- Cuadrado: {Math.Pow(numero, 2)}");
    if (numero >= 0)
    {
        Console.WriteLine($"-Raíz cuadrada: {Math.Sqrt(numero)}");
    }
    else
    {
        Console.WriteLine("-Raíz cuadrada: No definida.");
    }
    Console.WriteLine($"- Seno: {Math.Sin(numero)}");
    Console.WriteLine($"- Coseno: {Math.Cos(numero)}");
    Console.WriteLine($"- Parte entera: {Math.Truncate(numero)}");

    Console.WriteLine();
    //Ingresar número para comparar
    double num1, num2;

    //Ingresa primer número
    Console.WriteLine("Ingrese el primer número a comparar:");
    while (!double.TryParse(Console.ReadLine(), out num1))
    {
        Console.WriteLine("Número inválido, ingrese uno nuevo.");
    }

    //Ingresa segundo número
    Console.WriteLine("Ingrese el segundo número a comparar:");
    while (!double.TryParse(Console.ReadLine(), out num2))
    {
        Console.WriteLine("Número inválido, ingrese uno nuevo.");
    }
    Console.WriteLine();

    Console.WriteLine($"Máximo entre los dos: {Math.Max(num1, num2)}");
    Console.WriteLine($"Mínimo entre los dos: {Math.Min(num1, num2)}");
}
else
{
    Console.WriteLine("Número invalido.");
}