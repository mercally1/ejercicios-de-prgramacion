
class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("contar palabras");

        string palabra = Console.ReadLine();

        string[] countpalabra = palabra.Split();

        Console.WriteLine(countpalabra.Length);
        Console.ReadKey();
    }
}
