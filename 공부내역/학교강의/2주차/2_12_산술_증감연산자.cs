using System.Globalization;

namespace DrawPaper
{
    class Program
    {
        enum COLOR { RED, GREEN, BLUE };
        static void Main(string[] args)
        {
            // 1. 산술연산자 +-*/% : 정수, 소수, decimal만 가능
            int a = 111 + 222;
            Console.WriteLine($"a : {a}");

            int b = a - 100;
            Console.WriteLine($"b : {b}");

            Console.WriteLine($"22 / 7 = {22 / 7}({22 % 7})");

            // 2. 증가/감소 연산자 : 모든 수치 데이터 형식과 열거 형식 가능
            int n = 10;
            Console.WriteLine($"n : {n}");
            Console.WriteLine($"n++ : {n++}");  // 후위형 :
            Console.WriteLine($"n : {n}");

            Console.WriteLine($"++n : {++n}");  // 전위형 :
            Console.WriteLine($"n : {n}");

            // 열거형식의 증가/감소 연산자
            COLOR c = COLOR.RED;
            Console.WriteLine($"c : {c}");
            Console.WriteLine($"c++ : {++c}");
            Console.WriteLine($"c : {c}");
        }
    }
}