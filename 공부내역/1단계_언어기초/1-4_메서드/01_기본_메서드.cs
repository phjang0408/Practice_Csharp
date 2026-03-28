// 메서드 기본 - 매개변수, 반환값, void
namespace DrawPaper
{
    class Program
    {
        // 1. 반환값이 있는 메서드
        static int Add(int a, int b)
        {
            return a + b;
        }

        // 2. 반환값이 없는 메서드 (void)
        static void PrintMessage(string msg)
        {
            Console.WriteLine(msg);
        }

        // 3. 매개변수가 없는 메서드
        static void SayHello()
        {
            Console.WriteLine("안녕하세요!");
        }

        // 4. 여러 값을 계산하는 메서드
        static double GetAverage(int a, int b, int c)
        {
            return (a + b + c) / 3.0;
        }

        static void Main(string[] args)
        {
            // 메서드 호출
            int result = Add(3, 5);
            Console.WriteLine(result);          // 8

            PrintMessage("Hello, C#!");         // Hello, C#!

            SayHello();                         // 안녕하세요!

            double avg = GetAverage(80, 90, 70);
            Console.WriteLine($"평균: {avg}");  // 평균: 80
        }
    }
}
