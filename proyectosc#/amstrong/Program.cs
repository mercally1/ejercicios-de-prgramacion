
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Introduce un numero");
        int numero = int.Parse(Console.ReadLine());
        int suma = 0;
        int temp = numero;
        int digitos = numero.ToString().Length;

        while (temp > 0)
        {
            int digito = temp % 10;
            suma += (int)Math.Pow(digito, digitos);
            numero /= 10;
        }

        if (suma == numero)
        {
            Console.WriteLine($"el numero {numero} es un numero amstrong");
        }
        else
        {
            Console.WriteLine($"el numero {numero} NO es un numero amstrong");
        }
    }
}
