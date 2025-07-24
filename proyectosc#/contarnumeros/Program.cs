
using System.ComponentModel;
using System.Diagnostics.Contracts;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("<<<<<Una forma>>>>>");

        for (int i = 0; i <= 100; i++)
        {
            Console.WriteLine("Numero " + i);
        }

        Console.WriteLine("\n<<<<<forma dos>>>>>");

        int number = 1;
        while (number <= 100)
        {
            Console.WriteLine("El nunero " + number + "\n");
            number++;
        }
    }
}
