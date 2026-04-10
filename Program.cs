using System.Globalization;

namespace DrawPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Goodss Morning";

            // 1. Substring : (시작, 끝) or (시작)
            Console.WriteLine(greeting.Substring(0, 5));    
            Console.WriteLine(greeting.Substring(5));

            // 2. string[] Split()
            string[] arr = greeting.Split(" ");
            Console.WriteLine($"단어의 개수 : {arr.Length}");

            foreach(string x in arr)
            {
                Console.WriteLine(x);
            }
        }
    }
}