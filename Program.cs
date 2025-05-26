using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        int a;
        int b;
        a = 10;
        b = a;

        string mensaje = "Hola mundo!";
        string nombre = "Lionel Messi";

        Console.WriteLine("valor de a: " + a);
        Console.WriteLine("valor de b: " + b);
        Console.WriteLine(mensaje);

        string mensaje2 = $"{mensaje}{nombre}!";
        Console.WriteLine(mensaje2);

        // EJERCICIO 1: Invertir un número
        Console.Write("Ingrese un número: ");
        string? entrada = Console.ReadLine();

        bool esNumero = int.TryParse(entrada, out int numero);

        if (!esNumero)
        {
            Console.WriteLine("Número inválido.");
        }
        else if (numero <= 0)
        {
            Console.WriteLine("El número debe ser mayor a cero.");
        }
        else
        {
            int numeroInvertido = InvertirNumero(numero);
            Console.WriteLine($"El número invertido es: {numeroInvertido}");
        }
    }

    // FUNCIÓN
    static int InvertirNumero(int num)
    {
        int invertido = 0;
        while (num > 0)
        {
            int digito = num % 10;
            invertido = invertido * 10 + digito;
            num /= 10;
        }
        return invertido;
    }
}
