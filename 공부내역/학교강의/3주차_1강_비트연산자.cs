using System;

namespace SchoolLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 9;
            int b = 10;

            Console.WriteLine($"a << 1 : {a << 1}");
            Console.WriteLine($"b >> 2 : {b >> 2}");
            Console.WriteLine($"a & b : {a & b}");
            Console.WriteLine($"a | b : {a | b}");
            Console.WriteLine($"a ^ b : {a ^ b}");
            Console.WriteLine($"~a : {~a}");

            byte value = 240;
            Console.WriteLine(value << 2);
            Console.WriteLine(value >> 2);
        }
    }
}
