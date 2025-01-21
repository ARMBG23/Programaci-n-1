using System;

namespace ConsoleAppExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1: Sum of digits of a two-digit number
            Console.Write("Enter a two-digit number: ");
            int num1 = int.Parse(Console.ReadLine());
            int sumDigits = (num1 / 10) + (num1 % 10);
            Console.WriteLine($"Sum of digits: {sumDigits}\n");

            // Exercise 2: Check if two-digit number is prime and negative
            Console.Write("Enter a two-digit number: ");
            int num2 = int.Parse(Console.ReadLine());
            bool isNegative = num2 < 0;
            bool isPrime = IsPrime(Math.Abs(num2));
            Console.WriteLine($"Is negative: {isNegative}, Is prime: {isPrime}\n");

            // Exercise 3: Check if both digits of a two-digit number are prime
            Console.Write("Enter a two-digit number: ");
            int num3 = int.Parse(Console.ReadLine());
            int digit1 = num3 / 10;
            int digit2 = num3 % 10;
            bool bothDigitsPrime = IsPrime(digit1) && IsPrime(digit2);
            Console.WriteLine($"Both digits are prime: {bothDigitsPrime}\n");

            // Exercise 4: Check if sum of two two-digit numbers is even
            Console.Write("Enter first two-digit number: ");
            int num4a = int.Parse(Console.ReadLine());
            Console.Write("Enter second two-digit number: ");
            int num4b = int.Parse(Console.ReadLine());
            bool isSumEven = ((num4a + num4b) % 2 == 0);
            Console.WriteLine($"Sum is even: {isSumEven}\n");

            // Exercise 5: Find position of largest digit in a three-digit number
            Console.Write("Enter a three-digit number: ");
            int num5 = int.Parse(Console.ReadLine());
            int d1 = num5 / 100, d2 = (num5 / 10) % 10, d3 = num5 % 10;
            int maxDigit = Math.Max(d1, Math.Max(d2, d3));
            string position = maxDigit == d1 ? "first" : maxDigit == d2 ? "second" : "third";
            Console.WriteLine($"The largest digit is in the {position} position\n");

            // Exercise 6: Check if a digit in a three-digit number is a multiple of others
            Console.Write("Enter a three-digit number: ");
            int num6 = int.Parse(Console.ReadLine());
            int a6 = num6 / 100, b6 = (num6 / 10) % 10, c6 = num6 % 10;
            bool hasMultiple = (a6 % b6 == 0 && a6 != b6) || (b6 % c6 == 0 && b6 != c6) || (c6 % a6 == 0 && c6 != a6);
            Console.WriteLine($"A digit is a multiple of another: {hasMultiple}\n");

            // Exercise 7: Find largest of three numbers using only two variables
            Console.Write("Enter three numbers separated by spaces: ");
            string[] inputs7 = Console.ReadLine().Split();
            int a7 = int.Parse(inputs7[0]), b7 = int.Parse(inputs7[1]), max7 = int.Parse(inputs7[2]);
            max7 = Math.Max(max7, Math.Max(a7, b7));
            Console.WriteLine($"The largest number is: {max7}\n");

            // Exercise 8: Check if a five-digit number is a palindrome
            Console.Write("Enter a five-digit number: ");
            string num8 = Console.ReadLine();
            bool isPalindrome = num8 == new string(num8.Reverse().ToArray());
            Console.WriteLine($"Is palindrome: {isPalindrome}\n");

            // Exercise 9: Check if second digit of four-digit number equals the penultimate digit
            Console.Write("Enter a four-digit number: ");
            string num9 = Console.ReadLine();
            bool secondEqualsPenultimate = num9[1] == num9[2];
            Console.WriteLine($"Second digit equals penultimate: {secondEqualsPenultimate}\n");

            // Exercise 10: Display numbers between two integers if their difference is 10 or less
            Console.Write("Enter two integers: ");
            string[] inputs10 = Console.ReadLine().Split();
            int n10a = int.Parse(inputs10[0]), n10b = int.Parse(inputs10[1]);
            if (Math.Abs(n10a - n10b) <= 10)
            {
                int min = Math.Min(n10a, n10b), max = Math.Max(n10a, n10b);
                for (int i = min; i <= max; i++)
                {
                    Console.Write(i + " ");
                }
            }
        }

        static bool IsPrime(int num)
        {
            if (num <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
    }
}

