using System;

namespace SchoolLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "C# Programming";
            string formatted = string.Format("Name: {0}", name);
            string interpolated = $"Name: {name}";

            Console.WriteLine(formatted);
            Console.WriteLine(interpolated);
            Console.WriteLine(string.Format("{0,-10}{1,5}", "Hello", 123));

            string text = "  apple,banana,carrot  ";
            Console.WriteLine(text.Trim());
            Console.WriteLine(text.Replace("banana", "orange"));

            string[] parts = text.Trim().Split(',');
            Console.WriteLine(string.Join(" | ", parts));

            Console.WriteLine(text.Contains("banana"));
            Console.WriteLine(text.IndexOf("carrot"));
        }
    }
}
