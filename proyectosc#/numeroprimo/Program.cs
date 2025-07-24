
class Program
{
    static void Main()
    {
        //Console.WriteLine("Ingrese un numero");
        //int numero  = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 100; i ++)
        {
            
            
        string resultado = (i / 1 == 0) && (i/ i == 0 ) ? "primo" : "No primo";

        Console.WriteLine($"Es numero {i} es un numero {resultado}\n");
            
        }
    }
}
