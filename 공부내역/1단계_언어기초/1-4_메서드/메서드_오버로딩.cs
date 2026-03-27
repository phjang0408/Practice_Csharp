// 메서드 오버로딩 (Overloading)
// 같은 이름, 다른 매개변수(수 또는 타입)로 여러 메서드를 정의
// 컴파일러가 호출 시 매개변수를 보고 어떤 버전인지 판단
namespace DrawPaper
{
    class Program
    {
        // 매개변수 수가 다름
        static int Plus(int a, int b)
        {
            return a + b;
        }

        static int Plus(int a, int b, int c)
        {
            return a + b + c;
        }

        // 매개변수 타입이 다름
        static double Plus(double a, double b)
        {
            return a + b;
        }

        static string Plus(string a, string b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Plus(1, 2));          // 3       (int, int)
            Console.WriteLine(Plus(1, 2, 3));       // 6       (int, int, int)
            Console.WriteLine(Plus(1.5, 2.5));      // 4.0     (double, double)
            Console.WriteLine(Plus("Hello", " C#"));// Hello C# (string, string)

            // Console.WriteLine()도 오버로딩 — 18개 버전이 존재
        }
    }
}
