using System.Globalization;

namespace DrawPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            // 문자열 보간 -> $기호 사용
            // 보간 문자열은 서식항목과 동일한 방법으로, {}안에 표현식 입력 가능
            Console.WriteLine("{0}, {1}", 123, "가나다");
            Console.WriteLine($"{123}, {"가나다"}");  // $

            Console.WriteLine("{0,-9:F5}", 123);
            Console.WriteLine($"{123,-9:F5}");      // 맞춤, 서식문자열 사용

            // 변수 입력
            int n = 123;
            string s = "가나다";

            Console.WriteLine("{0}, {1} ", n, s);
            Console.WriteLine($"{n}, {s}");         // 변수명 입력

            Console.WriteLine("{0}", n > 100 ? "크다" : "작다");
            // 조건연산자 - ()괄호로 감싸야 함.
            Console.WriteLine($"{(n > 100 ? "크다" : "작다")}");    
        }
    }
}