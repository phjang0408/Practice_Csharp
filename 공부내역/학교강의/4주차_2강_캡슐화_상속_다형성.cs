using System;

namespace SchoolLecture
{
    class Circle
    {
        private double pi = 3.14;

        public double Pi
        {
            get { return pi; }
            set
            {
                if (value <= 3 || value >= 3.15)
                {
                    Console.WriteLine("문제 발생");
                    return;
                }

                pi = value;
            }
        }
    }

    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("멍멍");
        }
    }

    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("냥냥");
        }
    }

    class Computer
    {
        protected bool powerOn;

        public void Boot()
        {
            powerOn = true;
        }
    }

    class Notebook : Computer
    {
        public void CloseLid()
        {
            if (powerOn)
            {
                Console.WriteLine("shutdown");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.Pi = 3.14159;
            circle.Pi = 3.5;

            Animal[] animals = { new Dog(), new Cat(), new Animal() };
            foreach (var animal in animals)
            {
                animal.Speak();
            }

            Notebook notebook = new Notebook();
            notebook.Boot();
            notebook.CloseLid();
        }
    }
}
