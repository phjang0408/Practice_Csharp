using System;

namespace SchoolLecture
{
    enum Grade
    {
        A,
        B,
        C
    }

    class Program
    {
        static void Main(string[] args)
        {
            int age = 25;
            double score = 93.5;
            bool isActive = true;
            char grade = 'A';
            string name = "홍길동";
            object box = age;
            Grade schoolGrade = Grade.A;
            int? nullableNumber = null;

            const double pi = 3.141592;
            var message = $"{name} / {age} / {score} / {grade} / {isActive}";

            Console.WriteLine(message);
            Console.WriteLine($"object: {box}");
            Console.WriteLine($"enum: {schoolGrade}");
            Console.WriteLine($"nullable: {nullableNumber is null}");
            Console.WriteLine($"const pi: {pi}");
        }
    }
}
