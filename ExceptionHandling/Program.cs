using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Entered number: " + num);
            }
            catch(Exception exception)
            {
                Console.WriteLine("Exception: " + exception.Message.ToString());
            }
            finally  // Optional
            {
                Console.WriteLine("Process Completed!");
            }

            Console.WriteLine("\n");
            
            try
            {
                int a = int.Parse(null);
            }
            catch(ArgumentNullException exception)
            {
                Console.WriteLine("Entered a null value.");
                Console.WriteLine(exception);
            }

            Console.WriteLine("\n");

            try
            {
                int b = int.Parse("text");
            }
            catch (FormatException exception)
            {
                Console.WriteLine("Input was not in a correct format.");
                Console.WriteLine(exception);
            }

            Console.WriteLine("\n");

            try
            {
                int c = int.Parse("-20000000000");
            }
            catch (OverflowException exception)
            {
                Console.WriteLine("Value was eiter too large or too small.");
                Console.WriteLine(exception);
            }
        }
    }
}
