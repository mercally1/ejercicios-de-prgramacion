using System.Security.Cryptography;

namespace funcion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i < 3; i++)
            {
                Console.WriteLine("Ingrese su nombre");
                string nombre = Console.ReadLine().ToUpper();
                Saludar(nombre);
            }

            // MostrarClave();
            // GetClave();
        }
        public static void Saludar(string name)
        {
            Console.WriteLine("Hola " + name);
            MostrarClave();
        }

        public static void GetClave()
        {
            Console.WriteLine("Tu como te encuentras? Por favor ingresa tu clave:");
        }

        public static void MostrarClave()
        {
            int clave = 45862;
            Console.WriteLine("tu clave es:" + clave);
        } 
    }
}
