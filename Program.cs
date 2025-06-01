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



        //EJERCICIO 4
        Console.WriteLine("Ingrese una cadena de texto: ");
        string? texto = Console.ReadLine();
        if (string.IsNullOrEmpty(texto))
        {
            Console.WriteLine("No ingresó ninguna cadena");
            return;
        }

        int longitud = texto.Length;
        Console.WriteLine($"La longitud de la cadena es: {longitud}");

        Console.WriteLine("Ingrese otra cadena: ");
        string? texto2 = Console.ReadLine();
        if (string.IsNullOrEmpty(texto2))
        {
            Console.WriteLine("No ingresó ninguna cadena");
            return;
        }

        Console.WriteLine($"Concatenación: {texto} {texto2}");

        // Subcadena
        Console.Write("Ingrese la posición de inicio para extraer subcadena (0 a " + (texto.Length - 1) + "): ");
        bool okInicio = int.TryParse(Console.ReadLine(), out int inicio);

        Console.Write("Ingrese la cantidad de caracteres a extraer: ");
        bool okCantidad = int.TryParse(Console.ReadLine(), out int cantidad);

        if (!okInicio || !okCantidad || inicio < 0 || cantidad < 0 || inicio + cantidad > texto.Length)
        {
            Console.WriteLine("Los valores ingresados no son válidos para extraer subcadena.");
        }
        else
        {
            string subcadena = texto.Substring(inicio, cantidad);
            Console.WriteLine($"Subcadena extraída: {subcadena}");
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
