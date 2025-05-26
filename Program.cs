// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int a;
int b;
a = 10;
b = a;

string mensaje = "Hola mundo!";
string nombre = "Lionel Messi";


Console.WriteLine("valor de a: "+a);
Console.WriteLine("valor de b: " + b);
Console.WriteLine(mensaje);


string mensaje2 = $"{mensaje}{nombre}!";
Console.WriteLine(mensaje2);
