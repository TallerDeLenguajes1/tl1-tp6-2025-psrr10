using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("ingrese un número: ");
        string? entrada = Console.ReadLine();

        bool esNumero = int.TryParse(entrada, out int numero);

        if (!esNumero)
        {
            Console.Writeline("Numero inválido.");
        }
        else if (numero <= 0)
        {
            Console.WriteLine("El numero debe ser mayor a cero.");
        }
        else
        {
            //funcion invertir numero
        }
    }
}