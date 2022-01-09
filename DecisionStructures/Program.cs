using System;

namespace DecisionStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            // If Else
            if (time >= 6 && time < 11)
                Console.WriteLine("Good morning!");
            else if (time >= 11 && time <= 18)
                Console.WriteLine("Have a nice day!");
            else
                Console.WriteLine("Good nights!");

            // Ternary If
            string message = time <= 18 ? "Have a nice day!" : "Good nights!";
            message = time >= 6 && time < 11 ? "Good morning!" : time <= 18 ? "Have a nice day!" : "Good nights!";
            Console.WriteLine(message);

            // Switch Case
            int month = DateTime.Now.Month;

            switch(month) // Expression
            {
                case 1:
                    Console.WriteLine("You are in January");
                    break;
                case 2:
                    Console.WriteLine("You are in January");
                    break;
                case 3:
                    Console.WriteLine("You are in March");
                    break;
                case 4:
                    Console.WriteLine("You are in April");
                    break;
                case 5:
                    Console.WriteLine("You are in May");
                    break;
                case 6:
                    Console.WriteLine("You are in June");
                    break;
                case 7:
                    Console.WriteLine("You are in July");
                    break;
                case 8:
                    Console.WriteLine("You are in August");
                    break;
                case 9:
                    Console.WriteLine("You are in September");
                    break;
                case 10:
                    Console.WriteLine("You are in October");
                    break;
                case 11:
                    Console.WriteLine("You are in November");
                    break;
                case 12:
                    Console.WriteLine("You are in December");
                    break;
                default:
                    Console.WriteLine("Wrong Data!");
                    break;
            }

            switch(month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("You are in winter");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("You are in spring");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("You are in summer");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("You are in fall/autumn");
                    break;
            }
        }
    }
}
