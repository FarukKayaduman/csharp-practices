using System;
using System.Globalization;

namespace TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Conversion
            Console.WriteLine("***** Implicit Conversion *****");

            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine("d: " + d);

            long h = d;
            Console.WriteLine("h: " + h);

            float i = h;
            Console.WriteLine("i: " + i);

            string e = "Hello";
            char f = 'N';
            object g = e + f + d;
            Console.WriteLine("g: " + g);

            // Explicit Conversion
            Console.WriteLine("\n***** Explicit Conversion *****");

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y: " + y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t: " + t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v: " + v);

            // ToString() Method
            Console.WriteLine("\n*** ToString() Method ***");

            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy: " + yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz: " + zz);

            // System.Convert Class
            Console.WriteLine("\n*** System.Convert Class *** ");

            string s1 = "10", s2 = "20";
            int num1, num2;
            int sum;

            num1 = Convert.ToInt32(s1);
            num2 = Convert.ToInt32(s2);

            sum = num1 + num2;
            Console.WriteLine("sum: " + sum);

            // Parse Method
            Console.WriteLine("\n*** Parse Method ***");

            ParseMethod();


        }

        public static void ParseMethod()
        {
            string text1 = "10";
            string text2 = "10.25";
            int number1;
            double double1;

            number1 = Int32.Parse(text1);
            double1 = Double.Parse(text2, CultureInfo.InvariantCulture);

            Console.WriteLine("number1: " + number1);
            Console.WriteLine("double1: " + double1);
        }
    }
}
