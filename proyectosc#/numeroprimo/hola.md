bool isPrime = true;
if (number <= 1)
{
    isPrime = false;
}
if(number > 2)
{
    for (int i = 2; i < Math.Sqrt(number); i++)
    {
        if (number % i == 0)
        {
            isPrime = true;
            break;
        }
    }

    if (isPrime)
    {
        Console.WriteLine($"El numero {number} es un numero es primo");
    }
    else
    {
        Console.WriteLine($"El numero {number} no es un numero es primo");
    }
}