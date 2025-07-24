class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Calcula el area de un triangulo");

        Console.WriteLine("Introduce la base de triangulo");
        decimal areabase = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Introduce la altura del triangulo");
        decimal altura = decimal.Parse(Console.ReadLine());

        decimal resultado = Math.Round((areabase * altura / 2), 2);

        Console.WriteLine($"la area del triangulo es {resultado}");
    }
}
