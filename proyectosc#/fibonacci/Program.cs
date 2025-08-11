Console.WriteLine("HELLO, SEQUENCE");

Console.WriteLine("Hasta que numero quiere generar la sucesion de fibonacci?");

int number = int.Parse(Console.ReadLine());

//definition of variables 

long number1 = 0;
long number2 = 1;

for (int i = 0; i < number; i++)
{
    long temp = number1;
    number1 = number2;
    number2 = temp + number2;
    Console.WriteLine(number2);
}