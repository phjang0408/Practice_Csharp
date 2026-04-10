using System;

namespace SchoolLecture
{
    class Counter
    {
        public int Value;

        public Counter(int value)
        {
            this.Value = value;
        }

        public Counter(Counter other) : this(other.Value)
        {
        }

        public static void Divide(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Counter.Divide(20, 3, out int q, out int r);
            Console.WriteLine($"20 / 3 = {q}, remainder = {r}");

            Counter a = new Counter(10);
            Counter b = new Counter(a);
            Console.WriteLine($"{a.Value}, {b.Value}");
        }
    }
}
