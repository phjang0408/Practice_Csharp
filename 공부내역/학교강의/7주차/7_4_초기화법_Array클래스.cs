using System;

namespace TupleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = new string[3] { "안녕", "Hello", "Halo" };
            string[] array2 = new string[] { "안녕", "Hello", "Halo" };
            string[] array3 = { "안녕", "Hello", "Halo" };

            int[] array = new int[] { 10, 30, 20, 7, 1 };
            Console.WriteLine($"Type of array: {array.GetType()}");
            Console.WriteLine($"Base type of array: {array.GetType().BaseType}");
        }
    }
}