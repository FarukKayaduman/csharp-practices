using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the odd numbers up to the input
            Console.Write("Enter a number: ");
            int count = int.Parse(Console.ReadLine());

            for(int i = 0; i <= count; i++)
            {
                if (i % 2 == 1)
                    Console.WriteLine(i);
            }

            Console.WriteLine("\n");

            // Print the sum of even numbers and sum of odd numbers from 1 to 1000
            int oddSum = 0;
            int evenSum = 0;

            for(int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 1)
                    oddSum += i;
                else
                    evenSum += i;
            }

            Console.WriteLine("Sum of odd numbers: " + oddSum);
            Console.WriteLine("Sum of even numbers: " + evenSum);
            
            Console.WriteLine("\n");
            
            // break, continue
            for(int i = 1; i < 5; i++)
            {
                if (i == 4)
                    break;
                Console.WriteLine(i);
            }
            for (int i = 5; i < 10; i++)
            {
                if (i == 7)
                    continue;
                Console.WriteLine(i);
            }
        }
    }
}
