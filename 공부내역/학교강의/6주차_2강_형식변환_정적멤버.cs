using System;

namespace SchoolLecture
{
    public class Currency
    {
        private readonly decimal money;

        public decimal Money => money;

        public Currency(decimal money)
        {
            this.money = money;
        }
    }

    public class Won : Currency
    {
        public Won(decimal money) : base(money) { }

        public override string ToString()
        {
            return Money + "Won";
        }
    }

    public class Yen : Currency
    {
        public Yen(decimal money) : base(money) { }

        public override string ToString()
        {
            return Money + "Yen";
        }

        public static implicit operator Won(Yen yen)
        {
            return new Won(yen.Money * 9m);
        }

        public static explicit operator Yen(Won won)
        {
            return new Yen(won.Money / 9m);
        }
    }

    public partial class PartialSample
    {
        public void Part1()
        {
            Console.WriteLine("Part1");
        }
    }

    public partial class PartialSample
    {
        public void Part2()
        {
            Console.WriteLine("Part2");
        }
    }

    public static class StringExtensions
    {
        public static bool IsUpperOnly(this string text)
        {
            foreach (char c in text)
            {
                if (char.IsLetter(c) && !char.IsUpper(c))
                {
                    return false;
                }
            }

            return true;
        }
    }

    public struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Yen yen = new Yen(100);
            Won won1 = yen;
            Yen yen2 = (Yen)won1;

            Console.WriteLine($"{won1}, {yen2}");

            PartialSample sample = new PartialSample();
            sample.Part1();
            sample.Part2();

            Console.WriteLine("HELLO".IsUpperOnly());

            Point point = new Point(3, 4);
            Console.WriteLine($"{point.X}, {point.Y}");
        }
    }
}
