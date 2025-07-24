
    public class Program
    {
    public static void Main(string[] args)
    {
        Console.WriteLine("Comprueba si tu numero es par o impar");

        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine($"El numero {number} es par");
        }
        else
        {
            Console.WriteLine($"El numero {number} es impar");
        }

        Console.WriteLine("<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>");
        string resultado = (number % 2 == 0) ? "numero par" : "numero impar";

        Console.WriteLine($"El numero {number} es {resultado}");
        }
    }
