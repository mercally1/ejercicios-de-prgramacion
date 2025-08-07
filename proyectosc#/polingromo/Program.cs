using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        string bienvenida = "las palabras polindromos";
        Console.WriteLine(bienvenida.ToUpper());
        string palabra = Console.ReadLine();
        string palabra1 = new string(palabra.Reverse().ToArray());

        string polindromo = palabra == palabra1 ? $" Palabra original {palabra.ToUpper()}\n Palabra invertida {palabra1.ToUpper()} es una palabra polidromo" 
                                                : $" Palabra original {palabra.ToUpper()}\n Palabra invertida {palabra1.ToUpper()} no es una palabra polindromo";

        Console.WriteLine(polindromo); 
        
    }
}
