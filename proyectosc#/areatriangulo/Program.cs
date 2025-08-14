class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Introduce los valores de tringulo");

        Console.WriteLine("valor1");
        int valor1 = int.Parse(Console.ReadLine());

        Console.WriteLine("valor2");
        int valor2 = int.Parse(Console.ReadLine());

        Console.WriteLine("AREA DEL TRIANGULO");
        Triangulo(valor1, valor2);

        Console.WriteLine("AREA DEL CUADRADO");
        Cuadrado(valor1, valor2);

        Console.WriteLine("AREA DEL RECTANGULO");
        Rectangulo(valor1, valor2);
    }

    public static void Triangulo(int tr1, int tr2)
    {
        int resultado = ((tr1 * tr2) / 2);
        Console.WriteLine("El area del triangulo es " + resultado);
    }

    public static void Cuadrado(int tr1, int tr2)
    {
        int resultado = (int)Math.Pow((tr1 * tr2), 2);
        Console.WriteLine("El area del cuadrado es " + resultado);
    }
    
    public static void Rectangulo(int tr1, int tr2)
    {
        int resultado = (tr1 * tr2);
        Console.WriteLine("El area del triangulo es " + resultado);
    }
       

    }
    

