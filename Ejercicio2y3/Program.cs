using System;

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
    Console.WriteLine($"-Raíz cuadrada: {math.Sqrt(numero)}");
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

