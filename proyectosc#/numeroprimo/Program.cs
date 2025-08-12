
using System.Diagnostics;

//comprobar si un numero es natural

int number = int.Parse(Console.ReadLine());

bool isPrime = true;
if (number <= 1)
{
    isPrime = false;
}
if (number == 2)
{
    isPrime = true;
}
else if (number > 2)
{
    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0)
        {
            isPrime = false;
            break;
        }
    }
}

if (isPrime)
{
    Console.WriteLine("el numero " + number + " es primo");
}
else
{
    Console.WriteLine("el numero " + number + " no es primo");
}

         
        