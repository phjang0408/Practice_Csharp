using System;

namespace SchoolLecture
{
    class Cat
    {
        public string Name;
        public string Color;

        public Cat()
        {
            Name = "Nabi";
            Color = "Black";
        }

        public Cat(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public void Meow()
        {
            Console.WriteLine($"{Name} ({Color}) : 야옹");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat();
            Cat cat2 = new Cat("Choco", "Brown");

            cat1.Meow();
            cat2.Meow();
        }
    }
}
