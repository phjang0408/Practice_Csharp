using System;

namespace SchoolLecture
{
    enum CurrencyKind
    {
        Won,
        Yen,
        Dollar
    }

    class Program
    {
        static void Main(string[] args)
        {
            byte a = 255;
            sbyte b = (sbyte)a;

            uint maxU = uint.MaxValue;
            int maxI = int.MaxValue;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(maxU);
            Console.WriteLine(maxI);

            if (int.TryParse("123", out int parsed))
            {
                Console.WriteLine(parsed);
            }

            int? maybe = null;
            Console.WriteLine(maybe ?? 0);
            Console.WriteLine(CurrencyKind.Won);
        }
    }
}
