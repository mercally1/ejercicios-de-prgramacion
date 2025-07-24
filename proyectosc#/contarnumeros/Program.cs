
using System.ComponentModel;
using System.Diagnostics.Contracts;

class Program
{
    public static void Main(string[] args)
    {
        //forma uno 
        Console.WriteLine("<<<<<Una forma>>>>>");

        for (int i = 0; i <= 100; i++)
        {
            Console.WriteLine("Numero " + i);
        }

        //forma dos
        Console.WriteLine("\n<<<<<forma dos>>>>>");

        int number = 1;
        while (number <= 100)
        {
            Console.WriteLine("El nunero " + number + "\n");
            number++;
        }

        //forma tres
        Console.WriteLine("<<<<< tercera forma >>>>>");
        int contador = 1; 
        do
        {
            Console.WriteLine("El numero" + contador + "\n");
            contador++;
        } while (contador >= 100);
    }
}
