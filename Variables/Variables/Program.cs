using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            byte b = 5;             // 1 byte
            sbyte c = 5;            // 1 byte

            short s = 5;            // 2 bytes
            ushort us = 5;          // 2 bytes

            Int16 i16 = 2;          // 2 bytes
            int i = 2;              // 4 bytes
            Int32 i32 = 2;          // 4 bytes
            Int64 i64 = 2;          // 8 bytes

            uint ui = 2;            // 4 bytes
            long l = 4;             // 8 bytes
            ulong ul = 4;           // 8 bytes

            float f = 5.0f;         // 4 bytes
            double d = 5;           // 8 bytes
            decimal de = 5;         // 16 bytes

            char ch = '2';          // 2 bytes
            string str = "Hello!";

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;

            Console.WriteLine(str + "\n" + dt);

            object o1 = "x";
            object o2 = 3.2;
        }
    }
}
