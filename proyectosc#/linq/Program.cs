using System;
using System.Collections.Generic;
using System.Linq;

class Alumno
{
    public int Id { get; set; }

    public string Nombre { get; set; }

    public string Apellido { get; set; }
    
    public int Edad { get; set; }
    }
class Program
{
    public static void Main()
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


        List<Alumno> alumnos = new List<Alumno>()
        {
            new Alumno(Id=1, Nombre = "Ana", Apellido = "González", 9.5),
            new Alumno(Id=2, Nombre = "Luis", Apellido = "Martínez", 7.0),
            new Alumno(Id=3, Nombre = "Carla", Apellido = "Rodríguez", 8.2),
            new Alumno(Id=4, Nombre = "Pedro",  Apellido ="Ramírez", 9.0),
            new Alumno(Id=5, Nombre = "Valentina",  Apellido ="Torres", 6.0),
            new Alumno(Id=6, Nombre = "Diego",Apellido = "Fernández", 9.0),
            new Alumno(Id=7, Nombre = "Lucía", Apellido = "Herrera", 5.5),
            new Alumno(Id=8, Nombre = "Tomás", Apellido = "Morales", 7.8),
            new Alumno(Id=9, Nombre = "Camila", Apellido = "Jiménez", 8.7),
            new Alumno(Id=10, Nombre = "Sebastián", Apellido = "Castro", 6.5)
        };
    }
}
