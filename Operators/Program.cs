using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assignment Operators
            int x = 3;
            Console.WriteLine("x: " + x);

            int y = 3;
            Console.WriteLine("y: " + y);
            
            y = y + 2;
            Console.WriteLine("y: " + y);
            
            y += 2;
            Console.WriteLine("y: " + y);
            
            y /= 1;
            Console.WriteLine("y: " + y);

            x *= 2;
            Console.WriteLine("x: " + x);

            // Logical Operators
            // ||, &&, !

            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted)
                Console.WriteLine("Perfect!");

            if (isSuccess || isCompleted)
                Console.WriteLine("Great!");

            if (isSuccess && !isCompleted)
                Console.WriteLine("Fine!");

            // Relational Operators
            // <, >, <=, >=, ==, !=

            Console.WriteLine("\nRelational Operators");

            int a = 3;
            int b = 4;
            
            bool result = a < b;
            Console.WriteLine(result);

            result = a > b;
            Console.WriteLine(result);

            result = a >= b;
            Console.WriteLine(result);

            result = a <= b;
            Console.WriteLine(result);

            result = a == b;
            Console.WriteLine(result);

            result = a != b;
            Console.WriteLine(result);

            // Aritmetic Operators
            // /, *, +, -

            Console.WriteLine("\nAritmetic Operators");
            
            int num1 = 8;
            int num2 = 2;

            int sum = num1 / num2;
            Console.WriteLine(sum);

            sum = num1 * num2;
            Console.WriteLine(sum);
            
            sum = num1 + num2;
            Console.WriteLine(sum);
            
            sum = num1 - num2;
            Console.WriteLine(sum);

            sum = num1++; // num1++ = num1 + 1
            Console.WriteLine(sum);

            // % : Mod Operator
            
            num2 = 3;
            sum = num1 % num2;
            Console.WriteLine("num1 % num2 = " + sum);
        }
    }
}
