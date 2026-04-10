using System;

namespace SchoolLecture
{
    class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("냠냠 먹습니다.");
        }

        public virtual void Sleep()
        {
            Console.WriteLine("쿨쿨 잠을 잡니다.");
        }
    }

    class Dog : Animal
    {
        public string Color { get; set; } = "Brown";

        public void Bark()
        {
            Console.WriteLine("멍멍 짓습니다.");
        }

        public override void Eat()
        {
            Console.WriteLine("강아지가 냠냠 먹습니다.");
        }
    }

    class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("냥냥 웁니다.");
        }

        public override void Eat()
        {
            Console.WriteLine("고양이가 냠냠 먹습니다.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = { new Dog(), new Cat(), new Dog(), new Cat() };

            foreach (Animal item in animals)
            {
                item.Eat();

                if (item is Dog dog)
                {
                    dog.Bark();
                }
                else if (item is Cat cat)
                {
                    cat.Meow();
                }
            }
        }
    }
}
