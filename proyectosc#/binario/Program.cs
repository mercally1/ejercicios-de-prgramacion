
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("BIENVENIDO AL PROGRAMA DECINARIO");

        int numerodecimal = int.Parse(Console.ReadLine());
        string binario = Convert.ToString(numerodecimal, 2);

            Console.WriteLine($" El numero decimal de {numerodecimal}.\n Numero binario {binario}.");
    }
}
