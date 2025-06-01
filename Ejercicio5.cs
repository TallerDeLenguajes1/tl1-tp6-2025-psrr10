using System;
using System.Text.RegularExpressions;


class ValidarEmail
{
    public static void VerificarEmail()
    {
        Console.WriteLine("Ingrese un correo electronico:");
        string email = Console.ReadLine();

        string regexEmail= @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

        if (Regex.IsMatch(email, regexEmail))
        {
            Console.WriteLine("El correo es válido");
        }
        else
        {
            Console.WriteLine("El correo no es válido");
        }
    }
}

class ValidarUrl
{
    public static void VerificarUrl()
    {
        Console.WriteLine("Ingrese una direccion web:");
        string url = Console.ReadLine();

        string regexUrl = @"^(https?:\/\/)?(www\.)?[a-zA-Z0-9\-]+\.[a-zA-Z]{2,}(\.[a-zA-Z]{2,})?(/.*)?$";

        if (Regex.IsMatch(url, regexUrl))
        {
            Console.WriteLine("La direccion web es valida");
        }
        else
        {
            Console.WriteLine("La direccion web es invalida");
        }


    }
}