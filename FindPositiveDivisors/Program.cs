using System;

namespace FindPositiveDivisors
{
    class Program
    {
        private static void Main(string[] args)
        {
            int number; // The number to calculate divisors of.

            Console.Write("Enter a number to calculate divisors: ");
            number = Convert.ToInt32(Console.ReadLine()); // Get a number from user and assign to 'number' variable.

            Console.Write("Divisors of " + number + ": 1 "); // '1' is a divisors for all numbers.

            for(int i = 2; i <= number / 2; i++) // There is not any diviser between 'number/2' and 'number'. So no need to check all of them.
            {
                if (number % i == 0) // If the remainder of dividing the number by 'i' is equal to 0, means its a divisor.
                    Console.Write( i + " " );
            }

            Console.WriteLine(number); // The number is a divisor of itself.
        }
    }
}