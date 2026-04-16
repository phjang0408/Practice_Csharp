
namespace DrawPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            Console.WriteLine($"a += 90 : {a += 90}");
            Console.WriteLine($"a -= 80 : {a -= 80}");
            Console.WriteLine($"a *= 70 : {a *= 70}");
            Console.WriteLine($"a /= 60 : {a /= 60}");
            Console.WriteLine($"a %= 50 : {a %= 50}");
            Console.WriteLine($"a &= 40 : {a &= 40}");
            Console.WriteLine($"a |= 30 : {a |= 30}");
            Console.WriteLine($"a ^= 20 : {a ^= 20}");
            Console.WriteLine($"a <<= 10 : {a <<= 10}");
            Console.WriteLine($"a >>= 10 : {a >>= 1}");
        }
    }
}