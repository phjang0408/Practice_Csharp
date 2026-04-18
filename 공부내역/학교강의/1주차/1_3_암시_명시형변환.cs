using System;

namespace MySpace
{
    class Program
    {
        static void Main(string[] args)
        {   
            // 1. 암시적 형 변환, 작은 타입 -> 큰 타입
            byte b = 250;
            int a = b;          // 암시!
            Console.WriteLine($"a : {a}");

            // 2. 명시적 형 변환
            // 개발자가 의도한 형 변환
            ushort u = 65;
            char c = (char)u;   // 명시!
            Console.WriteLine($"c : {c}");
        }
    }
}
