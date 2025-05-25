// See https://aka.ms/new-console-template for more information

Console.WriteLine("Ingrese un número a invertir");
string respuesta = Console.ReadLine();

int num;

if (int.TryParse(respuesta, out num))
{
    if (num > 9)
    {
        Console.WriteLine("El número invertido es:");
        while (num > 0)
        {
            int dig = num % 10;
            Console.Write(dig);
            num = num / 10;
        }
    }
    else
    {   if (num > 0 && num < 10)
        {
            Console.WriteLine("El número invertido es:");
            Console.Write(num);
        }
        else
        {
            Console.WriteLine("El número tiene que ser mayor a 0.");
        }
    }
}
else
{
    Console.WriteLine("Número inválido.");
}

