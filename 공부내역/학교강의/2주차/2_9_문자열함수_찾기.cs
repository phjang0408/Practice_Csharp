using System.Globalization;

namespace DrawPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Good Morning";

            // 1. IndexOf, LastIndexOf
            Console.WriteLine("Index Of 'Good' : {0}", greeting.IndexOf("Good"));
            Console.WriteLine("Index Of 'o' : {0}",greeting.IndexOf('o'));

            Console.WriteLine("Last Index Of : 'Good' : {0}",greeting.LastIndexOf("Good"));
            Console.WriteLine("Last Index Of : 'o' : {0}", greeting.LastIndexOf('o'));

            // 2. StartsWith, EndsWith
            Console.WriteLine("StartsWith 'Good' : {0}", greeting.StartsWith("Good"));
            Console.WriteLine("EndsWith 'Morning' : {0}", greeting.EndsWith("Morning"));

            // 3. Contains
            Console.WriteLine("Contains 'Morning' : {0}", greeting.Contains("Morning"));

            // 4. Replace
            Console.WriteLine("Replace to 'Evening' : {0}", greeting.Replace("Morning", "Evening"));
        }
    }
}