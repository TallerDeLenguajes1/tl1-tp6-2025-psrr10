using System;

class Program
{
    static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\n--- CALCULADORA BÁSICA ---");
            Console.WriteLine("1 - Sumar");
            Console.WriteLine("2 - Restar");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.Write("Seleccione una opción: ");
            string? opcion = Console.ReadLine();

            Console.Write("Ingrese el primer número: ");
            bool valido1 = double.TryParse(Console.ReadLine(), out double num1);
            Console.Write("Ingrese el segundo número: ");
            bool valido2 = double.TryParse(Console.ReadLine(), out double num2);

            if (!valido1 || !valido2)
            {
                Console.WriteLine("⚠️ Ingresó un valor inválido.");
                continue;
            }

            double resultado = 0;
            bool operacionValida = true;

            switch (opcion)
            {
                case "1":
                    resultado = num1 + num2;
                    break;
                case "2":
                    resultado = num1 - num2;
                    break;
                case "3":
                    resultado = num1 * num2;
                    break;
                case "4":
                    if (num2 == 0)
                    {
                        Console.WriteLine("⚠️ No se puede dividir por cero.");
                        operacionValida = false;
                    }
                    else
                    {
                        resultado = num1 / num2;
                    }
                    break;
                default:
                    Console.WriteLine("⚠️ Opción no válida.");
                    operacionValida = false;
                    break;
            }

            if (operacionValida)
            {
                Console.WriteLine($"Resultado: {resultado}");
            }

            Console.Write("¿Desea realizar otra operación? (s/n): ");
            string? seguir = Console.ReadLine();
            continuar = seguir?.ToLower() == "s";
        }

        Console.WriteLine("👋 Programa finalizado.");
    }
}
