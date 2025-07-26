using System.Data;

class Program
{
    public static void Main(string[] args)
    {
        // List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        // List<int> countnumber = numbers.Where(n => n % 2 == 0).ToList();

        // foreach (int number in countnumber)
        // {
        //     Console.WriteLine(number);
        // }

        // List<int> numbers = new List<int> { 20, 45, 58, 65, 56, 62, 1225, 36, };
        // List<int> orderNumber = numbers.OrderBy(n => n).ToList();

        // foreach (int number in orderNumber)
        // {
        //     Console.WriteLine(number);
        // }
        
        List<Alumno> alumnos = new List<Alumno>
        {
            new Alumno(1, "Ana", "González", 9.5, true, ""),
            new Alumno(2, "Luis", "Martínez", 7.0, true, ""),
            new Alumno(3, "Carla", "Rodríguez", 8.2, false, ""),
            new Alumno(4, "Pedro", "Ramírez", null, true, ""),
            new Alumno(5, "Valentina", "Torres", 6.0, false, ""),
            new Alumno(6, "Diego", "Fernández", 9.0, true, ""),
            new Alumno(7, "Lucía", "Herrera", 5.5, true, ""),
            new Alumno(8, "Tomás", "Morales", 7.8, false, ""),
            new Alumno(9, "Camila", "Jiménez", 8.7, true, ""),
            new Alumno(10, "Sebastián", "Castro", 6.5, true, "")
        };
    }
}
