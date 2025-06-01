using System;

class Program
{
    static void Main(string[] args)
    {
        ValidarEmail.VerificarEmail();
        ValidarUrl.VerificarUrl();

        Saludar();

        InvertirNumeroEjercicio();

        OperarConCadenas();

        BuscarPalabraEnCadena();

        DividirCadenaPorSeparador();
    }

    static void Saludar()
    {
        Console.WriteLine("Hello, World!");

        int a = 10;
        int b = a;

        string mensaje = "Hola mundo!";
        string nombre = "Lionel Messi";

        Console.WriteLine("valor de a: " + a);
        Console.WriteLine("valor de b: " + b);
        Console.WriteLine(mensaje);

        string mensaje2 = $"{mensaje}{nombre}!";
        Console.WriteLine(mensaje2);
    }

    static void InvertirNumeroEjercicio()
    {
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

    static void OperarConCadenas()
    {
        Console.WriteLine("Ingrese una cadena de texto: ");
        string? texto = Console.ReadLine();

        if (string.IsNullOrEmpty(texto))
        {
            Console.WriteLine("No ingresó ninguna cadena");
            return;
        }

        int longitud = texto.Length;
        Console.WriteLine($"La longitud de la cadena es: {longitud}");

        Console.WriteLine("Recorriendo la cadena caracter por caracter:");
        foreach (char c in texto)
        {
            Console.WriteLine(c);
        }

        string mayusculas = texto.ToUpper();
        Console.WriteLine($"En mayusculas: {mayusculas}");

        string minusculas = texto.ToLower();
        Console.WriteLine($"En minusculas: {minusculas}");

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

    static void BuscarPalabraEnCadena()
    {
        Console.Write("Ingrese la palabra que desea buscar en el primer texto: ");
        string? palabraBuscar = Console.ReadLine();

        if (!string.IsNullOrEmpty(palabraBuscar))
        {
            // Para buscar, necesito el texto original. Lo ideal es pasarlo como parámetro, pero aquí simplifico.
            // Mejor pedir el texto acá también:
            Console.Write("Ingrese la cadena donde buscar la palabra: ");
            string? texto = Console.ReadLine();

            if (string.IsNullOrEmpty(texto))
            {
                Console.WriteLine("No ingresó ninguna cadena para buscar.");
                return;
            }

            string[] palabras = texto.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int contador = 0;

            foreach (string palabra in palabras)
            {
                if (palabra.Equals(palabraBuscar, StringComparison.OrdinalIgnoreCase))
                {
                    contador++;
                }
            }

            Console.WriteLine($"La palabra \"{palabraBuscar}\" aparece {contador} veces en la cadena.");
        }
        else
        {
            Console.WriteLine("No ingresó una palabra válida para buscar.");
        }
    }

    static void DividirCadenaPorSeparador()
    {
        Console.WriteLine("Ingrese una cadena separada por un carácter: ");
        string? cadenaSeparada = Console.ReadLine();

        Console.Write("Ingrese el carácter separador (ej: ,): ");
        string? separadorStr = Console.ReadLine();

        if (!string.IsNullOrEmpty(cadenaSeparada) && !string.IsNullOrEmpty(separadorStr) && separadorStr.Length == 1)
        {
            char separador = separadorStr[0];
            string[] partes = cadenaSeparada.Split(separador, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("Partes separadas:");
            foreach (string parte in partes)
            {
                Console.WriteLine(parte);
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida para dividir la cadena.");
        }
    }
}
