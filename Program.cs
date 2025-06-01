using System;

class Program
{
    static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\n--- CALCULADORA MEJORADA ---");
            Console.WriteLine("1 - Sumar");
            Console.WriteLine("2 - Restar");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - Valor absoluto");
            Console.WriteLine("6 - Cuadrado");
            Console.WriteLine("7 - Raíz cuadrada");
            Console.WriteLine("8 - Seno");
            Console.WriteLine("9 - Coseno");
            Console.WriteLine("10 - Parte entera");
            Console.WriteLine("11 - Máximo entre dos números"); 
            Console.WriteLine("12 - Mínimo entre dos números"); 
            Console.WriteLine("13 - Resolver ecuación simple (ej: 1+1, 1-1, 1*1, 1/1)");
            Console.Write("Seleccione una opción: ");
            string? opcion = Console.ReadLine();

            double resultado = 0;
            bool operacionValida = true;

            if (opcion == "5") // Valor absoluto
            {
                Console.Write("Ingrese un número: ");
                bool valido = double.TryParse(Console.ReadLine(), out double num);

                if (!valido)
                {
                    Console.WriteLine("⚠️ Ingresó un valor inválido.");
                    continue;
                }

                resultado = Math.Abs(num);
                Console.WriteLine($"Valor absoluto de {num} es: {resultado}");
            }
            else if (opcion == "6") // Cuadrado
            {
                Console.Write("Ingrese un número: ");
                bool valido = double.TryParse(Console.ReadLine(), out double num);

                if (!valido)
                {
                    Console.WriteLine("⚠️ Ingresó un valor inválido.");
                    continue;
                }

                resultado = Math.Pow(num, 2);
                Console.WriteLine($"El cuadrado de {num} es: {resultado}");
            }
            else if (opcion == "7") // Raíz cuadrada
            {
                Console.Write("Ingrese un número: ");
                bool valido = double.TryParse(Console.ReadLine(), out double num);

                if (!valido)
                {
                    Console.WriteLine("⚠️ Ingresó un valor inválido.");
                    continue;
                }

                if (num < 0)
                {
                    Console.WriteLine("⚠️ No se puede calcular la raíz cuadrada de un número negativo.");
                    continue;
                }

                resultado = Math.Sqrt(num);
                Console.WriteLine($"La raíz cuadrada de {num} es: {resultado}");
            }
            else if (opcion == "8") // Seno
            {
                Console.Write("Ingrese un ángulo en grados: ");
                bool valido = double.TryParse(Console.ReadLine(), out double grados);

                if (!valido)
                {
                    Console.WriteLine("⚠️ Ingresó un valor inválido.");
                    continue;
                }

                double radianes = grados * Math.PI / 180;
                resultado = Math.Sin(radianes);
                Console.WriteLine($"El seno de {grados}° es: {resultado}");
            }
            else if (opcion == "9") // Coseno
            {
                Console.Write("Ingrese un ángulo en grados: ");
                bool valido = double.TryParse(Console.ReadLine(), out double grados);

                if (!valido)
                {
                    Console.WriteLine("⚠️ Ingresó un valor inválido.");
                    continue;
                }

                double radianes = grados * Math.PI / 180;
                resultado = Math.Cos(radianes);
                Console.WriteLine($"El coseno de {grados}° es: {resultado}");
            }
            else if (opcion == "10") // Parte entera
            {
                Console.Write("Ingrese un número decimal: ");
                bool valido = double.TryParse(Console.ReadLine(), out double num);

                if (!valido)
                {
                    Console.WriteLine("⚠️ Ingresó un valor inválido.");
                    continue;
                }

                resultado = Math.Truncate(num);
                Console.WriteLine($"La parte entera de {num} es: {resultado}");
            }
            else if (opcion == "11" || opcion == "12") // Máximo o Mínimo
            {
                Console.Write("Ingrese el primer número: ");
                bool valido1 = double.TryParse(Console.ReadLine(), out double num1);
                Console.Write("Ingrese el segundo número: ");
                bool valido2 = double.TryParse(Console.ReadLine(), out double num2);

                if (!valido1 || !valido2)
                {
                    Console.WriteLine("⚠️ Ingresó un valor inválido.");
                    continue;
                }

                if (opcion == "11")
                {
                    resultado = Math.Max(num1, num2);
                    Console.WriteLine($"El máximo entre {num1} y {num2} es: {resultado}");
                }
                else
                {
                    resultado = Math.Min(num1, num2);
                    Console.WriteLine($"El mínimo entre {num1} y {num2} es: {resultado}");
                }
            }
            else if (opcion == "13") // Resolver ecuación simple
            {
                ResolverEcuacionSimple();
            }
            else
            {
                Console.Write("Ingrese el primer número: ");
                bool valido1 = double.TryParse(Console.ReadLine(), out double num1);
                Console.Write("Ingrese el segundo número: ");
                bool valido2 = double.TryParse(Console.ReadLine(), out double num2);

                if (!valido1 || !valido2)
                {
                    Console.WriteLine("⚠️ Ingresó un valor inválido.");
                    continue;
                }

                switch (opcion)
                {
                    case "1":
                        resultado = num1 + num2;
                        Console.WriteLine($"La suma de {num1} y de {num2} es igual a: {resultado}");
                        break;
                    case "2":
                        resultado = num1 - num2;
                        Console.WriteLine($"La resta de {num1} y de {num2} es igual a: {resultado}");
                        break;
                    case "3":
                        resultado = num1 * num2;
                        Console.WriteLine($"La multiplicación de {num1} y de {num2} es igual a: {resultado}");
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
                            Console.WriteLine($"La división de {num1} y de {num2} es igual a: {resultado}");
                        }
                        break;
                    default:
                        Console.WriteLine("⚠️ Opción no válida.");
                        operacionValida = false;
                        break;
                }
            }

            Console.Write("¿Desea realizar otra operación? (s/n): ");
            string? seguir = Console.ReadLine();
            continuar = seguir?.ToLower() == "s";
        }

        Console.WriteLine("👋 Programa finalizado.");
    }

    static void ResolverEcuacionSimple()
    {
        Console.Write("Ingrese una ecuación simple (suma, resta, multiplicacion o division): ");
        string? ecuacion = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(ecuacion))
        {
            Console.WriteLine("No ingresó ninguna ecuación.");
            return;
        }

        // Buscar operador en la cadena:
        char[] operadores = { '+', '-', '*', '/' };
        char operadorEncontrado = '\0';
        int posOperador = -1;

        foreach (char op in operadores)
        {
            posOperador = ecuacion.IndexOf(op);
            if (posOperador > 0) // operador no puede estar en primera posición
            {
                operadorEncontrado = op;
                break;
            }
        }

        if (operadorEncontrado == '\0')
        {
            Console.WriteLine("No se encontró un operador válido en la ecuación.");
            return;
        }

        // Separar números:
        string parte1 = ecuacion.Substring(0, posOperador);
        string parte2 = ecuacion.Substring(posOperador + 1);

        bool esNum1 = double.TryParse(parte1, out double num1);
        bool esNum2 = double.TryParse(parte2, out double num2);

        if (!esNum1 || !esNum2)
        {
            Console.WriteLine("La ecuación contiene valores no numéricos.");
            return;
        }

        double resultado = 0;
        bool valido = true;

        switch (operadorEncontrado)
        {
            case '+':
                resultado = num1 + num2;
                break;
            case '-':
                resultado = num1 - num2;
                break;
            case '*':
                resultado = num1 * num2;
                break;
            case '/':
                if (num2 == 0)
                {
                    Console.WriteLine("No se puede dividir por cero.");
                    valido = false;
                }
                else
                {
                    resultado = num1 / num2;
                }
                break;
        }

        if (valido)
        {
            Console.WriteLine($"Resultado de {ecuacion} = {resultado}");
        }
    }
}
