using System.Data.Common;
using System.Linq;

class Program
{
    public class Alumnos
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Apellido { get; set; }

        public int Edad { get; set; }
    }


    public static void Main(string[] args)
    {
        List<Alumnos> estudiantes = new List<Alumnos>()
        {
            new Alumnos{Id =1, Name="Jorge", Apellido = "Mercadillo", Edad=37},
            new Alumnos { Id = 2, Name = "Ana", Apellido = "Pérez", Edad = 20 },
            new Alumnos { Id = 3, Name = "Luis", Apellido = "Gómez", Edad = 22 },
            new Alumnos { Id = 4, Name = "María", Apellido = "López", Edad = 21 },
            new Alumnos { Id = 5, Name = "Carlos", Apellido = "Hernández", Edad = 23 },
            new Alumnos { Id = 6, Name = "Lucía", Apellido = "Martínez", Edad = 19 },
            new Alumnos { Id = 7, Name = "Pedro", Apellido = "Ramírez", Edad = 25 },
            new Alumnos { Id = 8, Name = "Sofía", Apellido = "Flores", Edad = 24 },
            new Alumnos { Id = 9, Name = "Miguel", Apellido = "Reyes", Edad = 26 },
            new Alumnos { Id = 10, Name = "Valeria", Apellido = "Torres", Edad = 18 },
            new Alumnos { Id = 11, Name = "Andrés", Apellido = "Vargas", Edad = 27 },
            new Alumnos { Id = 12, Name = "Gabriela", Apellido = "Castro", Edad = 23 },
            new Alumnos { Id = 13, Name = "Fernando", Apellido = "Guzmán", Edad = 28 },
            new Alumnos { Id = 14, Name = "Claudia", Apellido = "Mendoza", Edad = 22 },
            new Alumnos { Id = 15, Name = "Oscar", Apellido = "Chávez", Edad = 30 },
            new Alumnos { Id = 16, Name = "Paola", Apellido = "Pineda", Edad = 21 },
            new Alumnos { Id = 17, Name = "Raúl", Apellido = "Suárez", Edad = 24 },
            new Alumnos { Id = 18, Name = "Isabel", Apellido = "Herrera", Edad = 20 },
            new Alumnos { Id = 19, Name = "Diego", Apellido = "Ortega", Edad = 25 },
            new Alumnos { Id = 20, Name = "Elena", Apellido = "Silva", Edad = 19 },
            new Alumnos { Id = 21, Name = "Ricardo", Apellido = "Peralta", Edad = 26 },
            new Alumnos { Id = 22, Name = "Mónica", Apellido = "Rosales", Edad = 27 },
            new Alumnos { Id = 23, Name = "Armando", Apellido = "Mejía", Edad = 23 },
            new Alumnos { Id = 24, Name = "Patricia", Apellido = "Aguilar", Edad = 21 },
            new Alumnos { Id = 25, Name = "Roberto", Apellido = "Santos", Edad = 28 },
            new Alumnos { Id = 26, Name = "Cecilia", Apellido = "Morales", Edad = 20 },
            new Alumnos { Id = 27, Name = "Alberto", Apellido = "Navarro", Edad = 24 },
            new Alumnos { Id = 28, Name = "Diana", Apellido = "Peña", Edad = 22 },
            new Alumnos { Id = 29, Name = "Héctor", Apellido = "Escobar", Edad = 29 },
            new Alumnos { Id = 30, Name = "Laura", Apellido = "Rojas", Edad = 19 },
            new Alumnos { Id = 31, Name = "Javier", Apellido = "Montoya", Edad = 25 },
            new Alumnos { Id = 32, Name = "Karina", Apellido = "Rivas", Edad = 18 },
            new Alumnos { Id = 33, Name = "Manuel", Apellido = "Cortez", Edad = 27 },
            new Alumnos { Id = 34, Name = "Vanessa", Apellido = "Luna", Edad = 23 },
            new Alumnos { Id = 35, Name = "Ernesto", Apellido = "Campos", Edad = 24 },
            new Alumnos { Id = 36, Name = "Yolanda", Apellido = "Salazar", Edad = 22 },
            new Alumnos { Id = 37, Name = "Francisco", Apellido = "Delgado", Edad = 28 },
            new Alumnos { Id = 38, Name = "Roxana", Apellido = "Acosta", Edad = 20 },
            new Alumnos { Id = 39, Name = "Víctor", Apellido = "Ramos", Edad = 26 },
            new Alumnos { Id = 40, Name = "Alejandra", Apellido = "Bautista", Edad = 21 },
            new Alumnos { Id = 41, Name = "Guillermo", Apellido = "Romero", Edad = 23 },
            new Alumnos { Id = 42, Name = "Natalia", Apellido = "Fuentes", Edad = 19 },
            new Alumnos { Id = 43, Name = "Salvador", Apellido = "Padilla", Edad = 25 },
            new Alumnos { Id = 44, Name = "Sandra", Apellido = "Juárez", Edad = 18 },
            new Alumnos { Id = 45, Name = "Benjamin", Apellido = "Carrillo", Edad = 24 },
            new Alumnos { Id = 46, Name = "Lorena", Apellido = "Gallegos", Edad = 22 },
            new Alumnos { Id = 47, Name = "Tomás", Apellido = "Guerrero", Edad = 29 },
            new Alumnos { Id = 48, Name = "Patricio", Apellido = "Vega", Edad = 27 },
            new Alumnos { Id = 49, Name = "Andrea", Apellido = "Palacios", Edad = 20 },
            new Alumnos { Id = 50, Name = "Marcos", Apellido = "Villanueva", Edad = 23 }
        };

            var estudiantesFiltrados = estudiantes.Where(al => al.Edad <= 20).ToList();
        Console.WriteLine("Estos son todos los alumnos\n");
        foreach (Alumnos alumno in estudiantesFiltrados)
        {
            Console.WriteLine($"Id:{alumno.Id}\n Nombre: {alumno.Name}\n Apellido: {alumno.Apellido}\n Edad: {alumno.Edad}\n");
        }
    }
}
