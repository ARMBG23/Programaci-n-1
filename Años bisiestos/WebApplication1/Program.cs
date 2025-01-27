using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Introduce un año:");
        int inputYear = int.Parse(Console.ReadLine());

        if ((inputYear % 4 == 0 && inputYear % 100 != 0) || (inputYear % 400 == 0))
        {
            Console.WriteLine("Es un año bisiesto.");
        }
        else
        {
            Console.WriteLine("No es un año bisiesto.");
        }
    }
}

