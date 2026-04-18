using System;

namespace MySpace
{
    class Program
    {
        static void Main(string[] args)
        {
            // 문자열 <-> 숫자 : 명시적 변환은 에러 발생
            // 1. 숫자 -> 문자 : ToString()
            int a = 123;
            string b = a.ToString();    
            Console.WriteLine($"{b} is {b.GetType()}");

            float c = 3.14f;
            string d = c.ToString();
            Console.WriteLine($"{d} is {d.GetType()}");

            // 2. 문자열 -> 숫자 : Parse()
            string e = "123";
            int i = int.Parse(e);
            Console.WriteLine($"{i} is {i.GetType()}");

            string f = "3.14";
            float g = float.Parse(f);
            Console.WriteLine($"{g} is {g.GetType()}");
        }
    }
}
