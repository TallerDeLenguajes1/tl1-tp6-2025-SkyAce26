// See https://aka.ms/new-console-template for more information
int opcion;

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
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo numero:");
        double num2 = double.Parse(Console.ReadLine());

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