//class Program
//
// abstract class Motocycle
// {
//     public void StartEngine()
//     { }
//     protected void AddGas(int gallons)
//     { }

//     public virtual int Drive(int miles, int speed)
//     {
//         return 1;
//     }

//     public abstract double GetTopSpeed();
// }

// class TestMotocycle : Motocycle
// {
//     public override double GetTopSpeed()
//     {
//         return 108.4;
//     }

//     static void Main()
//     {
//         TestMotocycle moto = new TestMotocycle();

//         moto.StartEngine();
//         moto.AddGas(56);
//         moto.Drive(5, 20);
//         double speed = moto.GetTopSpeed();
//         double miles = moto.GetTopSpeed();
//         Console.WriteLine($"My top speed is {miles} and {speed}");
//     }
// }

// public void Caller()
// {
//     int numA = 4;
//     int productA = Square(numA);

//     int numB = 32;
//     int productB = Square(numB);

//     int productC = Square(12);

//     productC = Square(productA * 3);
// }

// int Square(int i)
// {
//     int input = i;
//     return input * input;
// }

// static Task Main() => DoSomethingAsync();

// static async Task DoSomethingAsync()
// {
//     Task<int> delayTask = DelayAsync();
//     int result = await delayTask;

//     Console.WriteLine($"Result: {result} ");
// }

// static async Task<int> DelayAsync()
// {
//     await Task.Delay(100);
//     return 5;        
// }
//}



//     

//  static void Main(string[] args)
// {
//     int[,] matrix = new int[2, 2];
//     FillMatrix(matrix);


// }

//  static void FillMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(j); j++)
//         {
//             matrix[i, j] = -1;
//         }
//     }
// }

// class Program
// {
//     public static void Main(string[] args)
//     {
//         var queryIdc =
//         from student in students
//         where student.Id > 111
//         select student.LastName;

//         foreach (string str in queryIdc)
//         {

//         }
//     }
// }

// 

// class Program
// {
//     public static void Main(string[] args)
//     {
//         DisplayWeatherReport(15.0);
//         DisplayWeatherReport(24.0);

//         void DisplayWeatherReport(double tempInCelsius)
//         {
//             if (tempInCelsius < 20.0)
//             {
//                 Console.WriteLine("Is Cold");
//             }
//             else
//             {
//                 Console.WriteLine("Perfect!");
//             }
//         }
//     }
// }

class Program
{
    public class MyClass : IMyClass
    {
        public int Id { set; get; }

        public string? Name { set; get; }

        public string? Apellido { set; get; }

        public void Encender()
        {
            Console.WriteLine("yo tengo el carrp encendido");
        }
    }

    interface IMyClass
    {
        void Encender();
    }
    public static void Main(string[] args)
    {
        MyClass humanos = new MyClass()
        {
            Id = 1,
            Name = "Jose lindo y Precioso",
            Apellido = "Perez"
        };

        IMyClass vehiculo = new MyClass()
        {
            Id = 2,
            Name = "Jorge Alberto",
            Apellido = "Mercadillo flores"
        };
        vehiculo.Encender();

        Console.WriteLine($"hola soy el {humanos.Id} \ndonde mi nombre es {humanos.Name}y \nmi apelliso es {humanos.Apellido}.");

        Console.WriteLine("yo solo quiero que mi carro funcione con las minimas condiciones" );
    }
}



       

