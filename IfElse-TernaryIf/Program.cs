using System;

namespace IfElse_TernaryIf
{
    class Program
    {
        static void Main(string[] args)
        {

            int time = DateTime.Now.Hour;

            if(time >= 6 && time < 11)
                Console.WriteLine("Good morning!");
            else if (time >= 11 && time <= 18)
                Console.WriteLine("Have a nice day!");
            else
                Console.WriteLine("Good nights!");

            // Ternary If

            string message = time <= 18 ? "Have a nice day!" : "Good nights!";
            message = time >= 6 && time < 11 ? "Good morning!" : time <= 18 ? "Have a nice day!" : "Good nights!";
            Console.WriteLine(message);
        }
    }
}
