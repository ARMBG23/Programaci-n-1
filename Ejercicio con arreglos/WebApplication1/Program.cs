using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
        int mayor = int.MinValue, posMayor = -1;
        int mayorPar = int.MinValue, posMayorPar = -1;
        int mayorPrimo = int.MinValue, posMayorPrimo = -1;
        int contadorPrimoInicio = 0;
        int maxDigitosPares = -1, posPrimoMaxPares = -1;

        Console.WriteLine("Ingrese 10 números enteros:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Número {i + 1}: ");
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int numero))
            {
                numeros[i] = numero;

                // Ejercicio 1: Mayor número
                if (numeros[i] > mayor)
                {
                    mayor = numeros[i];
                    posMayor = i;
                }

                // Ejercicio 2: Mayor número par
                if (numeros[i] % 2 == 0 && numeros[i] > mayorPar)
                {
                    mayorPar = numeros[i];
                    posMayorPar = i;
                }

                // Ejercicio 3: Mayor número primo
                if (EsPrimo(numeros[i]) && numeros[i] > mayorPrimo)
                {
                    mayorPrimo = numeros[i];
                    posMayorPrimo = i;
                }

                // Ejercicio 4: Números que comienzan con dígito primo
                int primerDigito = ObtenerPrimerDigito(numeros[i]);
                if (EsPrimo(primerDigito))
                {
                    contadorPrimoInicio++;
                }

                // Ejercicio 5: Número primo con más dígitos pares
                if (EsPrimo(numeros[i]))
                {
                    int cantidadPares = ContarDigitosPares(numeros[i]);
                    if (cantidadPares > maxDigitosPares)
                    {
                        maxDigitosPares = cantidadPares;
                        posPrimoMaxPares = i;
                    }
                }
            }
            else
            {
                Console.WriteLine("Error: Entrada no válida. Introduce un número entero.");
                i--; // Repetir la iteración para este índice
            }
        }

        // Mostrar resultados
        Console.WriteLine("\nResultados:");
        Console.WriteLine($"1. El mayor número es {mayor} y está en la posición {posMayor}.");
        Console.WriteLine($"2. El mayor número par es {mayorPar} y está en la posición {posMayorPar}.");
        Console.WriteLine($"3. El mayor número primo es {mayorPrimo} y está en la posición {posMayorPrimo}.");
        Console.WriteLine($"4. {contadorPrimoInicio} números comienzan con un dígito primo.");
        if (posPrimoMaxPares != -1)
            Console.WriteLine($"5. El número primo con más dígitos pares es {numeros[posPrimoMaxPares]} y está en la posición {posPrimoMaxPares}.");
        else
            Console.WriteLine("5. No se encontraron números primos.");
    }

    // Función para verificar si un número es primo
    static bool EsPrimo(int num)
    {
        if (num < 2) return false;
        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }

    // Función para obtener el primer dígito de un número
    static int ObtenerPrimerDigito(int num)
    {
        num = Math.Abs(num); // Para manejar números negativos
        while (num >= 10)
        {
            num /= 10;
        }
        return num;
    }

    // Función para contar dígitos pares en un número
    static int ContarDigitosPares(int num)
    {
        int contador = 0;
        num = Math.Abs(num); // Para manejar números negativos
        while (num != 0)
        {
            int digito = num % 10;
            if (digito % 2 == 0)
            {
                contador++;
            }
            num /= 10;
        }
        return contador;
    }
}